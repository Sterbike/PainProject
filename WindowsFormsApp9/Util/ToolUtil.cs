using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public static class ToolUtil
    {
        public static readonly Cursor FILL_CURSOR = new Cursor("fill.cur");
        
        public enum ToolType
        {
            BRUSH,
            ERASER,
            FILL,
            SHAPE
        }
        public enum ShapeType
        {
            Ellipse = 1,
            Rectangle = 2,
            Triangle = 3,
        }

        private static int _brushSize;
        private static Pen _pen;
        private static Brush _brush;
        private static Color[] _customColors;
        private static ToolType _selectedTool;
        private static ShapeType _selectedShapeType;

        private static PictureBox _currentColorPictureBox;
        private static PictureBox[] _customColorPictureBoxes;

        public static void Init(ref PictureBox currentColorPB, params PictureBox[] customColorPBs)
        {
            _currentColorPictureBox = currentColorPB;
            _customColorPictureBoxes = customColorPBs;
            _brushSize = 6;
            _pen = new Pen(Color.Black, _brushSize);
            _brush = new SolidBrush(Color.Black);
            _customColors = new Color[customColorPBs.Length];
            for (int i = 0; i < _customColors.Length; i++)
            {
                _customColors[i] = Color.Transparent;
                _customColorPictureBoxes[i].Text = $"{i}";
            }

            _selectedTool = ToolType.BRUSH;
        }

        public static int BrushSize
        {
            get => _brushSize;
            set
            {
                _brushSize = value;
                _pen.Width = value;
            }
        }

        public static Pen Pen => _pen;

        public static Brush Brush => _brush;

        public static ToolType SelectedTool
        {
            get => _selectedTool;
            set
            {
                _selectedTool = value;
                if (value == ToolType.ERASER)
                {
                    _pen = new Pen(Color.White, _brushSize);
                    _brush = new SolidBrush(Color.White);
                }
                else if (value == ToolType.SHAPE)
                {
                    _selectedShapeType = SelectedShape;
                }
            }
        }

        public static bool IsBrushLikeSelected => _selectedTool == ToolType.BRUSH || _selectedTool == ToolType.ERASER;

        public static ShapeType SelectedShape
        {
            get => _selectedShapeType;
            set
            {
                _selectedShapeType = value;
                
            }

        }


        public static void SetColor(Color color)
        {
            if (_selectedTool != ToolType.ERASER || _selectedTool != ToolType.SHAPE)
            {
                _pen = new Pen(color, _brushSize);
                _brush = new SolidBrush(color);
                _currentColorPictureBox.BackColor = color;
            }
        }

        public static void SetCustomColor(int index, Color color)
        {
            _customColors[index] = color;
            _customColorPictureBoxes[index].BackColor = color;
        }
    }
}