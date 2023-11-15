using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class MainForm : Form
    {
        
        // =============================================
        // =                   DEBUG                   =
        // =============================================
        
        private const bool DebugMode = false;
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        private static void Log(string msg)
        {
            Console.WriteLine(msg);
        }

        private static void Log(Exception e)
        {
            Console.WriteLine("==== ERROR ====");
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
            Console.WriteLine("===============");
        }
        
        // =============================================
        // =                   SETUP                   =
        // =============================================

        private int prevX, prevY;
        private int brushSizeX, brushSizeY;
        private int selectedCustomColorIndex;
        private bool isResizingCanvas;
        private Bitmap bmpBeforeResize;
        
        private bool _isDrawingShape;
        private Point selectionStart, selectionEnd;
        private string fileName = "";
        private ImageFormat format = ImageFormat.Jpeg;

        private bool _cursorShown = true;

        public bool CursorShown
        {
            get => _cursorShown;
            set
            {
                if (value == _cursorShown)
                {
                    return;
                }

                if (value)
                {
                    Cursor.Show();
                }
                else
                {
                    Cursor.Hide();
                }
                _cursorShown = value;
            }
        }

        private Point GetCursorPosOnCanvas()
        {
            var cursorPos = PointToClient(Cursor.Position);
            return new Point(cursorPos.X, cursorPos.Y - canvas.Location.Y);
        }


        // =============================================
        // =                FORM EVENTS                =
        // =============================================

        public MainForm()
        {
            InitializeComponent();
            CanvasUtil.Init(canvas.Width, canvas.Height);
            canvas.BackgroundImage = CanvasUtil.Bmp;
            
            ToolUtil.Init(ref selectedColorImg, colors_custom1, colors_custom2, colors_custom3, colors_custom4, colors_custom5);
            prevX = -1;
            prevY = -1;
            brushSizeX = brushSizeImg.Location.X;
            brushSizeY = brushSizeImg.Location.Y;
            UpdateToolButtonBorders();

            colors_black.BorderStyle = BorderStyle.Fixed3D;

            selectedCustomColorIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, canvas,
                new object[] { true });
            if (DebugMode)
            {
                AllocConsole();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MinimumSize = canvas.Size + new Size(100, 150);
        }

        public void NewProject(int width, int height)
        {
            canvas.Size = new Size(width, height);
            CanvasUtil.Load(new Bitmap(width, height));
            canvas.BackgroundImage = CanvasUtil.Bmp;
            canvas.Invalidate();
        }
        
        // =============================================
        // =               CANVAS EVENTS               =
        // =============================================

        private void canvas_MouseEnter(object sender, EventArgs e)
        {
            CursorShown = !ToolUtil.IsBrushLikeSelected;
        }

        private void canvas_MouseLeave(object sender, EventArgs e)
        {
            CursorShown = true;
            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            if (!CursorShown && ToolUtil.IsBrushLikeSelected)
            {
                // https://stackoverflow.com/questions/1140076/want-a-drawn-circle-to-follow-my-mouse-in-c-sharp
                var cursorPos = GetCursorPosOnCanvas();
                int r = ToolUtil.BrushSize / 2;
                g.DrawEllipse(Pens.Black, cursorPos.X - r, cursorPos.Y - r, r * 2, r * 2);
            }

            if (CanvasUtil.IsSelectionActive)
            {
                var end = _isDrawingShape ? GetCursorPosOnCanvas() : selectionEnd;
                
                int x = Math.Min(end.X, selectionStart.X);
                int y = Math.Min(end.Y, selectionStart.Y);
                int w = Math.Abs(end.X - selectionStart.X);
                int h = Math.Abs(end.Y - selectionStart.Y);
                
                g.DrawRectangle(CanvasUtil.SelectionPenBlack, x, y, w, h);
                g.DrawRectangle(CanvasUtil.SelectionPenWhite, x, y, w, h);

                if (_isDrawingShape)
                {
                    CanvasUtil.DrawShape(g, x, y, w, h);
                }
            }
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (ToolUtil.SelectedTool != ToolUtil.ToolType.FILL || !CanvasUtil.AllowActions) return;

            CanvasUtil.PushUndo();
            CanvasUtil.Fill(e.X, e.Y);
            canvas.Invalidate();

            if (ToolUtil.SelectedTool == ToolUtil.ToolType.SHAPE)
            {
                CanvasUtil.PushUndo();
                canvas.Invalidate();

            }

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (!CanvasUtil.AllowActions) return;

            prevX = e.X;
            prevY = e.Y;
            if (ToolUtil.IsBrushLikeSelected)
            {
                CanvasUtil.PushUndo();
                CanvasUtil.Paint(e.X, e.Y);
                canvas.Invalidate();
            }
            else if (ToolUtil.SelectedTool == ToolUtil.ToolType.SHAPE)
            {
                CanvasUtil.PushUndo();
                selectionStart = GetCursorPosOnCanvas();
                CanvasUtil.IsSelectionActive = true;
                _isDrawingShape = true;
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!CanvasUtil.AllowActions) return;
            
            if (prevX != -1 && prevY != -1)
            {
                switch (ToolUtil.SelectedTool)
                {
                    case ToolUtil.ToolType.BRUSH:
                    case ToolUtil.ToolType.ERASER:
                        CanvasUtil.Paint(prevX, prevY, e.X, e.Y);
                        CanvasUtil.Paint(e.X, e.Y);
                        prevX = e.X;
                        prevY = e.Y;
                        break;
                    case ToolUtil.ToolType.FILL:
                        break;
                    case ToolUtil.ToolType.SHAPE:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            canvas.Invalidate();
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            canvas.Cursor = Cursors.Default;
            prevX = -1;
            prevY = -1;
            if (_isDrawingShape)
            {
                _isDrawingShape = false;
                CanvasUtil.IsSelectionActive = false;
                selectionEnd = GetCursorPosOnCanvas();
                int x = Math.Min(selectionEnd.X, selectionStart.X);
                int y = Math.Min(selectionEnd.Y, selectionStart.Y);
                int w = Math.Abs(selectionEnd.X - selectionStart.X);
                int h = Math.Abs(selectionEnd.Y - selectionStart.Y);
                CanvasUtil.DrawShape(x, y, w, h);
            }
        }
        
        // =============================================
        // =                MENU EVENTS                =
        // =============================================

        private void fileMenu_New_Click(object sender, EventArgs e)
        {
            var newImgForm = new NewProjectForm();
            newImgForm.SetWidthAndHeight(canvas.Width, canvas.Height);
            newImgForm.ShowDialog();
        }
        private void menuStrip_File_Save_Click(object sender, EventArgs e)
        {
            if (fileName == "") fileMenu_SaveAs_Click(sender, e);
            else
            {
                int w = canvas.Width;
                int h = canvas.Height;

                var bmp = new Bitmap(w, h);
                canvas.DrawToBitmap(bmp, new Rectangle(0, 0, w, h));
                bmp.Save(fileName, format);

                if (File.Exists(fileName))
                {
                    Process.Start(fileName);
                }
            }
        }

        private void fileMenu_SaveAs_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
            if (string.IsNullOrWhiteSpace(saveFileDialog.FileName)) return;

            int w = canvas.Width;
            int h = canvas.Height;

            var bmp = new Bitmap(w, h);
            canvas.DrawToBitmap(bmp, new Rectangle(0, 0, w, h));

            fileName = saveFileDialog.FileName;
            switch (saveFileDialog.FilterIndex)
            {
                case 1: format = ImageFormat.Jpeg; break;
                case 2: format = ImageFormat.Bmp; break;
                case 3: format = ImageFormat.Png; break;
            }
            bmp.Save(fileName, format);
            fileName = saveFileDialog.FileName;

            if (File.Exists(fileName))
            {
                Process.Start(fileName);
            }
        }

        private void fileMenu_Open_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png";
            openFileDialog.Title = "Open an Image File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (openFileDialog.FilterIndex)
                {
                    case 1: format = ImageFormat.Jpeg; break;
                    case 2: format = ImageFormat.Bmp; break;
                    case 3: format = ImageFormat.Png; break;
                }
                fileName = openFileDialog.FileName;
                var bgimage = new Bitmap(openFileDialog.FileName);
                CanvasUtil.Load(bgimage);
                canvas.Size = bgimage.Size;
                canvas.BackgroundImage = CanvasUtil.Bmp;
            }
            openFileDialog.Dispose();
        }

        private void editMenu_Undo_Click(object sender, EventArgs e)
        {
            CanvasUtil.PopUndo();
            canvas.Size = CanvasUtil.Bmp.Size;
            canvas.BackgroundImage = CanvasUtil.Bmp;
            canvas.Invalidate();
        }

        private void editMenu_Redo_Click(object sender, EventArgs e)
        {
            CanvasUtil.PopRedo();
            canvas.Size = CanvasUtil.Bmp.Size;
            canvas.BackgroundImage = CanvasUtil.Bmp;
            canvas.Invalidate();
        }

        // =============================================
        // =                TOOL EVENTS                =
        // =============================================
        private void ShapeSelectorButton_Click(object sender, EventArgs e)
        {
            var shapeForm = new ShapeForm();
            shapeForm.ShowDialog();
            UpdateToolButtonBorders();
            UpdateCursor();
        }

        private void brushSize_ValueChanged(object sender, EventArgs e)
        {
            ToolUtil.BrushSize = brushSizeBar.Value * 2;
            brushSizeLabel.Text = $"{ToolUtil.BrushSize}";
            brushSizeImg.Size = new Size(9 + brushSizeBar.Value, 9 + brushSizeBar.Value);
            int posOffset = (int)Math.Ceiling((brushSizeBar.Maximum - brushSizeBar.Value) / 2F);
            brushSizeImg.Location = new Point(brushSizeX + posOffset, brushSizeY + posOffset);
        }

        private void customColorButton_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.OK) return;

            ToolUtil.SetColor(colorDialog.Color);
            if (selectedCustomColorIndex != -1)
                ToolUtil.SetCustomColor(selectedCustomColorIndex, colorDialog.Color);
        }
        
        private void selectFillButton_Click(object sender, EventArgs e)
        {
            ToolUtil.SelectedTool = ToolUtil.ToolType.FILL;
            ToolUtil.SetColor(selectedColorImg.BackColor);
            UpdateToolButtonBorders();
            UpdateCursor();
        }
        
        private void selectEraserButton_Click(object sender, EventArgs e)
        {
            ToolUtil.SelectedTool = ToolUtil.ToolType.ERASER;
            UpdateToolButtonBorders();
            UpdateCursor();
        }

        private void selectBrushButton_Click(object sender, EventArgs e)
        {
            ToolUtil.SelectedTool = ToolUtil.ToolType.BRUSH;
            ToolUtil.SetColor(selectedColorImg.BackColor);
            UpdateToolButtonBorders();
            UpdateCursor();
        }

        private void selectColor_Click(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            ToolUtil.SetColor(pictureBox.BackColor);
            foreach (Control control in menuPanel.Controls)
            {
                if (control is PictureBox pBox)
                {
                    pBox.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            pictureBox.BorderStyle = BorderStyle.Fixed3D;

            if (!string.IsNullOrWhiteSpace(pictureBox.Text))
            {
                try
                {
                    selectedCustomColorIndex = int.Parse(pictureBox.Text);
                }
                catch (Exception ex)
                {
                    selectedCustomColorIndex = -1;
                    Log(ex);
                }
            }
            else
            {
                selectedCustomColorIndex = -1;
            }
        }

        private void UpdateToolButtonBorders()
        {
            selectBrushButton.FlatAppearance.BorderColor = ToolUtil.SelectedTool == ToolUtil.ToolType.BRUSH ? Color.Lime : Color.Black;
            selectEraserButton.FlatAppearance.BorderColor = ToolUtil.SelectedTool == ToolUtil.ToolType.ERASER ? Color.Lime : Color.Black;
            selectFillButton.FlatAppearance.BorderColor = ToolUtil.SelectedTool == ToolUtil.ToolType.FILL ? Color.Lime : Color.Black;
            selectShapeButton.FlatAppearance.BorderColor = ToolUtil.SelectedTool == ToolUtil.ToolType.SHAPE ? Color.Lime : Color.Black;
        }

        private void UpdateCursor()
        {
            if (ToolUtil.SelectedTool == ToolUtil.ToolType.FILL)
            {
                canvas.Cursor = ToolUtil.FILL_CURSOR;
                return;
            }

            canvas.Cursor = Cursors.Default;
        }

        
        // =============================================
        // =               RESIZE EVENTS               =
        // =============================================

        private void resizeSquare_MouseDown(object sender, MouseEventArgs e)
        {
            if (!CanvasUtil.AllowActions) return;
            
            isResizingCanvas = true;
            bmpBeforeResize = CanvasUtil.CloneBmp();
        }


        private void resizeSquare_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isResizingCanvas) return;
            
            int w = canvas.Width + e.X;
            int h = canvas.Height + e.Y;

            if (w <= 0 || h <= 0) return;
            
            CanvasUtil.Resize(w, h);
            canvas.BackgroundImage = CanvasUtil.Bmp;
            canvas.Size = new Size(w, h);
        }

        private void resizeSquare_MouseUp(object sender, MouseEventArgs e)
        {
            isResizingCanvas = false;
            if (canvas.Size != bmpBeforeResize.Size)
            {
                CanvasUtil.PushUndo(bmpBeforeResize);
            }
            bmpBeforeResize = null;
        }

        public void InvalidateCanvas()
        {
            canvas.Invalidate();
            UpdateCursor();
        }
    }
}
