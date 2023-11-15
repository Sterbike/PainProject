using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class ShapeForm : Form
    {
        public ShapeForm()
        {
            InitializeComponent();

            // =============================================
            // =             BUTTON GENERATION             =
            // =============================================
            
            var shapes = Enum.GetValues(typeof(ToolUtil.ShapeType))
                .Cast<ToolUtil.ShapeType>().ToArray();
            int x = -64;
            int y = 10;
            Console.WriteLine(Size.Width - 20);
            foreach (var shape in shapes)
            {
                x += 64 + 10;
                if (x + 64 > Size.Width - 20)
                {
                    x = 10;
                    y += 64 + 10;
                }
                
                Button btn = new Button();
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Location = new Point(x, y);
                btn.Name = $"{(int)shape}";
                btn.Size = new Size(64, 64);
                btn.UseVisualStyleBackColor = true;
                btn.Click += shapeButton_Click;

                Bitmap bmp = (Bitmap)Image.FromFile($"shapes/{shape}.png");
                btn.BackgroundImage = bmp;
                Controls.Add(btn);
            }

            void shapeButton_Click(object sender, EventArgs e)
            {
                Button btn = sender as Button;
                ToolUtil.SelectedShape = (ToolUtil.ShapeType) int.Parse(btn.Name);
                ToolUtil.SelectedTool = ToolUtil.ToolType.SHAPE;
                Close();
            }
        }
    }
}

        

  


