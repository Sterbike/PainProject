using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp9.FloodFill;

namespace WindowsFormsApp9
{
    public static class CanvasUtil
    {
        private const float _selectionAnimSpeed = 0.4f;
        private static int _animLength;
        
        private static Bitmap _bmp;
        private static Stack<Bitmap> _undoBmpStack, _redoBmpStack;

        private static AbstractFloodFiller _floodFiller;

        private static Timer _canvasTimer;
        private static bool _isSelectionActive;
        private static Pen _selectionPenWhite, _selectionPenBlack;

        public static Bitmap Bmp => _bmp;

        public static bool AllowActions { get; private set; }
        
        public static bool IsSelectionActive
        {
            get => _isSelectionActive;
            set => _isSelectionActive = value;
        }

        public static Pen SelectionPenBlack => _selectionPenBlack;
        public static Pen SelectionPenWhite => _selectionPenWhite;

        public static void Init(int width, int height)
        {
            _bmp = new Bitmap(width, height);
            using (var g = Graphics.FromImage(_bmp))
            {
                g.FillRectangle(Brushes.White, 0, 0, width, height);
            }
            _undoBmpStack = new Stack<Bitmap>();
            _redoBmpStack = new Stack<Bitmap>();
            _floodFiller = new FloodFiller();
            _floodFiller.FillStyle = FloodFillStyle.Linear;
            AllowActions = true;

            _canvasTimer = new Timer();
            _canvasTimer.Interval = 100;
            _canvasTimer.Tick += OnCanvasTick;
            _canvasTimer.Enabled = true;

            _selectionPenBlack = new Pen(Color.Black, 1);
            _selectionPenBlack.DashPattern = new float[] { 6, 4 };
            _selectionPenWhite = new Pen(Color.White, 1);
            _selectionPenWhite.DashPattern = _selectionPenBlack.DashPattern.Reverse().ToArray();
            _selectionPenWhite.DashOffset = _selectionPenBlack.DashPattern[0];
            _animLength = (int)_selectionPenBlack.DashPattern.Sum();
            
            _floodFiller.FillFinished += OnFillFinished;
        }
        
        public static void Paint(int x, int y)
        {
            using (var g = Graphics.FromImage(_bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                float r = ToolUtil.BrushSize * 0.5F;
                g.FillEllipse(ToolUtil.Brush, x - r, y - r, r*2, r*2);
                g.Dispose();
            }
        }


        public static void Paint(int x0, int y0, int x1, int y1)
        {
            using (var g = Graphics.FromImage(_bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawLine(ToolUtil.Pen, new Point(x0, y0), new Point(x1, y1));
                g.Dispose();
            }
        }

        public static void Fill(int x, int y)
        {
            AllowActions = false;
            _floodFiller.FillColor = ToolUtil.Pen.Color;
            _floodFiller.FloodFill(_bmp, x, y);
        }

        public static void DrawShape(int x, int y, int w, int h)
        {
            using (var g = Graphics.FromImage(_bmp))
            {
                DrawShape(g, x, y, w, h);
                g.Dispose();
            }
        }

        public static void DrawShape(Graphics g, int x, int y, int w, int h)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            switch (ToolUtil.SelectedShape)
            {
                case ToolUtil.ShapeType.Ellipse:
                    g.DrawEllipse(ToolUtil.Pen, new Rectangle(x, y, w, h));
                    break;
                case ToolUtil.ShapeType.Rectangle:
                    g.DrawRectangle(ToolUtil.Pen, x, y, w, h);
                    break;
                case ToolUtil.ShapeType.Triangle:
                    var bottomLeft = new Point(x, y + h);
                    var bottomRight = new Point(x + w, y + h);
                    var topMiddle = new Point(x + w / 2, y);
                    g.DrawLines(ToolUtil.Pen, new []{ bottomLeft, bottomRight, topMiddle, bottomLeft, bottomRight });
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static void OnFillFinished(object sender, FillFinishedEventArgs e)
        {
            AllowActions = true;
        }

        private static void OnCanvasTick(object sender, EventArgs e)
        {
            if (!AllowActions) return;
            _selectionPenWhite.DashOffset = (_selectionPenWhite.DashOffset + _selectionAnimSpeed) % _animLength;
            _selectionPenBlack.DashOffset = (_selectionPenBlack.DashOffset + _selectionAnimSpeed) % _animLength;
            InvalidateCanvas();
        }

        public static void Resize(int newWidth, int newHeight)
        {
            var bmp = new Bitmap(newWidth, newHeight);
            using (var g = Graphics.FromImage(bmp))
            {
                g.DrawImage(_bmp, 0, 0);
                g.FillRectangle(Brushes.White, _bmp.Width, 0, newWidth, newHeight);
                g.FillRectangle(Brushes.White, 0, _bmp.Height, newWidth, newHeight);
            }
            _bmp = bmp;
        }

        public static void Load(Bitmap newBitmap)
        {
            _undoBmpStack.Clear();
            _redoBmpStack.Clear();
            _bmp = newBitmap;
        }

        public static void PushUndo(Bitmap bmp)
        {
            _undoBmpStack.Push(bmp);
            _redoBmpStack.Clear();
        }

        public static void PushUndo()
        {
            _undoBmpStack.Push(CloneBmp());
            _redoBmpStack.Clear();
        }

        public static void PopUndo()
        {
            if (_undoBmpStack.Count == 0) return;
            
            _redoBmpStack.Push(CloneBmp());
            _bmp = _undoBmpStack.Pop();
        }

        public static void PopRedo()
        {
            if (_redoBmpStack.Count == 0) return;
            
            _undoBmpStack.Push(CloneBmp());
            _bmp = _redoBmpStack.Pop();
        }

        public static Bitmap CloneBmp()
        {
            var clone = _bmp.Clone() as Bitmap;
            var data = clone.LockBits(new Rectangle(0, 0, clone.Width, clone.Height), ImageLockMode.ReadWrite,
                clone.PixelFormat);
            clone.UnlockBits(data);
            return clone;
        }
        
        private static void InvalidateCanvas()
        {
            if (Application.OpenForms["MainForm"] != null)
            {
                var form = Application.OpenForms["MainForm"] as MainForm;
                form.InvalidateCanvas();
            }
        }
    }
}