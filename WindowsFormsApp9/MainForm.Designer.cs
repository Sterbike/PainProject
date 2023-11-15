using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.canvas = new System.Windows.Forms.Panel();
            this.resizeSquareImg = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.selectShapeButton = new System.Windows.Forms.Button();
            this.selectBrushButton = new System.Windows.Forms.Button();
            this.selectEraserButton = new System.Windows.Forms.Button();
            this.customColorButton = new System.Windows.Forms.Button();
            this.selectedColorImg = new System.Windows.Forms.PictureBox();
            this.selectFillButton = new System.Windows.Forms.Button();
            this.brushSizeImg = new System.Windows.Forms.PictureBox();
            this.brushSizeLabel = new System.Windows.Forms.Label();
            this.brushSizeBar = new System.Windows.Forms.TrackBar();
            this.colors_custom2 = new System.Windows.Forms.PictureBox();
            this.colors_custom3 = new System.Windows.Forms.PictureBox();
            this.colors_custom4 = new System.Windows.Forms.PictureBox();
            this.colors_custom5 = new System.Windows.Forms.PictureBox();
            this.colors_custom1 = new System.Windows.Forms.PictureBox();
            this.colors_cyan = new System.Windows.Forms.PictureBox();
            this.colors_lime = new System.Windows.Forms.PictureBox();
            this.colors_red = new System.Windows.Forms.PictureBox();
            this.colors_black = new System.Windows.Forms.PictureBox();
            this.colors_white = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Edit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.canvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizeSquareImg)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColorImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_custom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_custom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_custom4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_custom5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_custom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_cyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_lime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_white)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Controls.Add(this.resizeSquareImg);
            this.canvas.Location = new System.Drawing.Point(0, 46);
            this.canvas.Margin = new System.Windows.Forms.Padding(0);
            this.canvas.MinimumSize = new System.Drawing.Size(2, 2);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(585, 251);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseEnter += new System.EventHandler(this.canvas_MouseEnter);
            this.canvas.MouseLeave += new System.EventHandler(this.canvas_MouseLeave);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // resizeSquareImg
            // 
            this.resizeSquareImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeSquareImg.BackColor = System.Drawing.Color.Transparent;
            this.resizeSquareImg.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.resizeSquareImg.Location = new System.Drawing.Point(569, 235);
            this.resizeSquareImg.Margin = new System.Windows.Forms.Padding(2);
            this.resizeSquareImg.Name = "resizeSquareImg";
            this.resizeSquareImg.Size = new System.Drawing.Size(15, 15);
            this.resizeSquareImg.TabIndex = 0;
            this.resizeSquareImg.TabStop = false;
            this.resizeSquareImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeSquare_MouseDown);
            this.resizeSquareImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resizeSquare_MouseMove);
            this.resizeSquareImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeSquare_MouseUp);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.LightGray;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.selectShapeButton);
            this.menuPanel.Controls.Add(this.selectBrushButton);
            this.menuPanel.Controls.Add(this.selectEraserButton);
            this.menuPanel.Controls.Add(this.customColorButton);
            this.menuPanel.Controls.Add(this.selectedColorImg);
            this.menuPanel.Controls.Add(this.selectFillButton);
            this.menuPanel.Controls.Add(this.brushSizeImg);
            this.menuPanel.Controls.Add(this.brushSizeLabel);
            this.menuPanel.Controls.Add(this.brushSizeBar);
            this.menuPanel.Controls.Add(this.colors_custom2);
            this.menuPanel.Controls.Add(this.colors_custom3);
            this.menuPanel.Controls.Add(this.colors_custom4);
            this.menuPanel.Controls.Add(this.colors_custom5);
            this.menuPanel.Controls.Add(this.colors_custom1);
            this.menuPanel.Controls.Add(this.colors_cyan);
            this.menuPanel.Controls.Add(this.colors_lime);
            this.menuPanel.Controls.Add(this.colors_red);
            this.menuPanel.Controls.Add(this.colors_black);
            this.menuPanel.Controls.Add(this.colors_white);
            this.menuPanel.Controls.Add(this.menuStrip);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(826, 46);
            this.menuPanel.TabIndex = 0;
            // 
            // selectShapeButton
            // 
            this.selectShapeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectShapeButton.BackgroundImage")));
            this.selectShapeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectShapeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.selectShapeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.selectShapeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.selectShapeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectShapeButton.Location = new System.Drawing.Point(326, 7);
            this.selectShapeButton.Name = "selectShapeButton";
            this.selectShapeButton.Size = new System.Drawing.Size(25, 25);
            this.selectShapeButton.TabIndex = 20;
            this.selectShapeButton.UseVisualStyleBackColor = true;
            this.selectShapeButton.Click += new System.EventHandler(this.ShapeSelectorButton_Click);
            // 
            // selectBrushButton
            // 
            this.selectBrushButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectBrushButton.BackgroundImage")));
            this.selectBrushButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectBrushButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.selectBrushButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.selectBrushButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.selectBrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBrushButton.Location = new System.Drawing.Point(233, 7);
            this.selectBrushButton.Name = "selectBrushButton";
            this.selectBrushButton.Size = new System.Drawing.Size(25, 25);
            this.selectBrushButton.TabIndex = 19;
            this.selectBrushButton.UseVisualStyleBackColor = true;
            this.selectBrushButton.Click += new System.EventHandler(this.selectBrushButton_Click);
            // 
            // selectEraserButton
            // 
            this.selectEraserButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectEraserButton.BackgroundImage")));
            this.selectEraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectEraserButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.selectEraserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.selectEraserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.selectEraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectEraserButton.Location = new System.Drawing.Point(264, 7);
            this.selectEraserButton.Name = "selectEraserButton";
            this.selectEraserButton.Size = new System.Drawing.Size(25, 25);
            this.selectEraserButton.TabIndex = 18;
            this.selectEraserButton.UseVisualStyleBackColor = true;
            this.selectEraserButton.Click += new System.EventHandler(this.selectEraserButton_Click);
            // 
            // customColorButton
            // 
            this.customColorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customColorButton.BackgroundImage")));
            this.customColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customColorButton.Location = new System.Drawing.Point(564, 1);
            this.customColorButton.Name = "customColorButton";
            this.customColorButton.Size = new System.Drawing.Size(20, 20);
            this.customColorButton.TabIndex = 17;
            this.customColorButton.Text = "...";
            this.customColorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customColorButton.UseVisualStyleBackColor = true;
            this.customColorButton.Click += new System.EventHandler(this.customColorButton_Click);
            // 
            // selectedColorImg
            // 
            this.selectedColorImg.BackColor = System.Drawing.Color.Black;
            this.selectedColorImg.Location = new System.Drawing.Point(590, 7);
            this.selectedColorImg.Name = "selectedColorImg";
            this.selectedColorImg.Size = new System.Drawing.Size(31, 30);
            this.selectedColorImg.TabIndex = 16;
            this.selectedColorImg.TabStop = false;
            // 
            // selectFillButton
            // 
            this.selectFillButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectFillButton.BackgroundImage")));
            this.selectFillButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectFillButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.selectFillButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.selectFillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.selectFillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFillButton.Location = new System.Drawing.Point(295, 7);
            this.selectFillButton.Name = "selectFillButton";
            this.selectFillButton.Size = new System.Drawing.Size(25, 25);
            this.selectFillButton.TabIndex = 15;
            this.selectFillButton.UseVisualStyleBackColor = true;
            this.selectFillButton.Click += new System.EventHandler(this.selectFillButton_Click);
            // 
            // brushSizeImg
            // 
            this.brushSizeImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brushSizeImg.BackgroundImage")));
            this.brushSizeImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brushSizeImg.Location = new System.Drawing.Point(396, 7);
            this.brushSizeImg.Name = "brushSizeImg";
            this.brushSizeImg.Size = new System.Drawing.Size(14, 14);
            this.brushSizeImg.TabIndex = 14;
            this.brushSizeImg.TabStop = false;
            // 
            // brushSizeLabel
            // 
            this.brushSizeLabel.AutoSize = true;
            this.brushSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brushSizeLabel.Location = new System.Drawing.Point(374, 6);
            this.brushSizeLabel.Name = "brushSizeLabel";
            this.brushSizeLabel.Size = new System.Drawing.Size(17, 18);
            this.brushSizeLabel.TabIndex = 13;
            this.brushSizeLabel.Text = "6";
            // 
            // brushSizeBar
            // 
            this.brushSizeBar.Location = new System.Drawing.Point(350, 24);
            this.brushSizeBar.Maximum = 12;
            this.brushSizeBar.Minimum = 1;
            this.brushSizeBar.Name = "brushSizeBar";
            this.brushSizeBar.Size = new System.Drawing.Size(104, 45);
            this.brushSizeBar.TabIndex = 12;
            this.brushSizeBar.Value = 3;
            this.brushSizeBar.ValueChanged += new System.EventHandler(this.brushSize_ValueChanged);
            // 
            // colors_custom2
            // 
            this.colors_custom2.BackColor = System.Drawing.Color.Transparent;
            this.colors_custom2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colors_custom2.Location = new System.Drawing.Point(479, 24);
            this.colors_custom2.Margin = new System.Windows.Forms.Padding(2);
            this.colors_custom2.Name = "colors_custom2";
            this.colors_custom2.Size = new System.Drawing.Size(16, 18);
            this.colors_custom2.TabIndex = 10;
            this.colors_custom2.TabStop = false;
            this.colors_custom2.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // colors_custom3
            // 
            this.colors_custom3.BackColor = System.Drawing.Color.Transparent;
            this.colors_custom3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colors_custom3.Location = new System.Drawing.Point(501, 24);
            this.colors_custom3.Margin = new System.Windows.Forms.Padding(2);
            this.colors_custom3.Name = "colors_custom3";
            this.colors_custom3.Size = new System.Drawing.Size(16, 18);
            this.colors_custom3.TabIndex = 9;
            this.colors_custom3.TabStop = false;
            this.colors_custom3.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // colors_custom4
            // 
            this.colors_custom4.BackColor = System.Drawing.Color.Transparent;
            this.colors_custom4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colors_custom4.Location = new System.Drawing.Point(522, 24);
            this.colors_custom4.Margin = new System.Windows.Forms.Padding(2);
            this.colors_custom4.Name = "colors_custom4";
            this.colors_custom4.Size = new System.Drawing.Size(16, 18);
            this.colors_custom4.TabIndex = 8;
            this.colors_custom4.TabStop = false;
            this.colors_custom4.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // colors_custom5
            // 
            this.colors_custom5.BackColor = System.Drawing.Color.Transparent;
            this.colors_custom5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colors_custom5.Location = new System.Drawing.Point(543, 24);
            this.colors_custom5.Margin = new System.Windows.Forms.Padding(2);
            this.colors_custom5.Name = "colors_custom5";
            this.colors_custom5.Size = new System.Drawing.Size(16, 18);
            this.colors_custom5.TabIndex = 7;
            this.colors_custom5.TabStop = false;
            this.colors_custom5.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // colors_custom1
            // 
            this.colors_custom1.BackColor = System.Drawing.Color.Transparent;
            this.colors_custom1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colors_custom1.Location = new System.Drawing.Point(459, 24);
            this.colors_custom1.Margin = new System.Windows.Forms.Padding(2);
            this.colors_custom1.Name = "colors_custom1";
            this.colors_custom1.Size = new System.Drawing.Size(16, 18);
            this.colors_custom1.TabIndex = 6;
            this.colors_custom1.TabStop = false;
            this.colors_custom1.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // colors_cyan
            // 
            this.colors_cyan.BackColor = System.Drawing.Color.Cyan;
            this.colors_cyan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colors_cyan.Location = new System.Drawing.Point(480, 2);
            this.colors_cyan.Margin = new System.Windows.Forms.Padding(2);
            this.colors_cyan.Name = "colors_cyan";
            this.colors_cyan.Size = new System.Drawing.Size(16, 18);
            this.colors_cyan.TabIndex = 5;
            this.colors_cyan.TabStop = false;
            this.colors_cyan.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // colors_lime
            // 
            this.colors_lime.BackColor = System.Drawing.Color.Lime;
            this.colors_lime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colors_lime.Location = new System.Drawing.Point(501, 2);
            this.colors_lime.Margin = new System.Windows.Forms.Padding(2);
            this.colors_lime.Name = "colors_lime";
            this.colors_lime.Size = new System.Drawing.Size(16, 18);
            this.colors_lime.TabIndex = 4;
            this.colors_lime.TabStop = false;
            this.colors_lime.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // colors_red
            // 
            this.colors_red.BackColor = System.Drawing.Color.Red;
            this.colors_red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colors_red.Location = new System.Drawing.Point(522, 2);
            this.colors_red.Margin = new System.Windows.Forms.Padding(2);
            this.colors_red.Name = "colors_red";
            this.colors_red.Size = new System.Drawing.Size(16, 18);
            this.colors_red.TabIndex = 3;
            this.colors_red.TabStop = false;
            this.colors_red.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // colors_black
            // 
            this.colors_black.BackColor = System.Drawing.Color.Black;
            this.colors_black.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colors_black.Location = new System.Drawing.Point(543, 2);
            this.colors_black.Margin = new System.Windows.Forms.Padding(2);
            this.colors_black.Name = "colors_black";
            this.colors_black.Size = new System.Drawing.Size(16, 18);
            this.colors_black.TabIndex = 2;
            this.colors_black.TabStop = false;
            this.colors_black.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // colors_white
            // 
            this.colors_white.BackColor = System.Drawing.Color.White;
            this.colors_white.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colors_white.Location = new System.Drawing.Point(459, 2);
            this.colors_white.Margin = new System.Windows.Forms.Padding(2);
            this.colors_white.Name = "colors_white";
            this.colors_white.Size = new System.Drawing.Size(16, 18);
            this.colors_white.TabIndex = 1;
            this.colors_white.TabStop = false;
            this.colors_white.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_File,
            this.menuStrip_Edit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(824, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuStrip_File
            // 
            this.menuStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_File_New,
            this.menuStrip_File_Open,
            this.toolStripSeparator,
            this.menuStrip_File_Save,
            this.menuStrip_File_SaveAs,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.menuStrip_File.Name = "menuStrip_File";
            this.menuStrip_File.Size = new System.Drawing.Size(37, 20);
            this.menuStrip_File.Text = "&File";
            // 
            // menuStrip_File_New
            // 
            this.menuStrip_File_New.Image = ((System.Drawing.Image)(resources.GetObject("menuStrip_File_New.Image")));
            this.menuStrip_File_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStrip_File_New.Name = "menuStrip_File_New";
            this.menuStrip_File_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuStrip_File_New.Size = new System.Drawing.Size(146, 22);
            this.menuStrip_File_New.Text = "&New";
            this.menuStrip_File_New.Click += new System.EventHandler(this.fileMenu_New_Click);
            // 
            // menuStrip_File_Open
            // 
            this.menuStrip_File_Open.Image = ((System.Drawing.Image)(resources.GetObject("menuStrip_File_Open.Image")));
            this.menuStrip_File_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStrip_File_Open.Name = "menuStrip_File_Open";
            this.menuStrip_File_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuStrip_File_Open.Size = new System.Drawing.Size(146, 22);
            this.menuStrip_File_Open.Text = "&Open";
            this.menuStrip_File_Open.Click += new System.EventHandler(this.fileMenu_Open_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // menuStrip_File_Save
            // 
            this.menuStrip_File_Save.Image = ((System.Drawing.Image)(resources.GetObject("menuStrip_File_Save.Image")));
            this.menuStrip_File_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStrip_File_Save.Name = "menuStrip_File_Save";
            this.menuStrip_File_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuStrip_File_Save.Size = new System.Drawing.Size(146, 22);
            this.menuStrip_File_Save.Text = "&Save";
            this.menuStrip_File_Save.Click += new System.EventHandler(this.menuStrip_File_Save_Click);
            // 
            // menuStrip_File_SaveAs
            // 
            this.menuStrip_File_SaveAs.Name = "menuStrip_File_SaveAs";
            this.menuStrip_File_SaveAs.Size = new System.Drawing.Size(146, 22);
            this.menuStrip_File_SaveAs.Text = "Save &As";
            this.menuStrip_File_SaveAs.Click += new System.EventHandler(this.fileMenu_SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // menuStrip_Edit
            // 
            this.menuStrip_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Edit_Undo,
            this.menuStrip_Edit_Redo,
            this.toolStripSeparator3,
            this.toolStripSeparator4});
            this.menuStrip_Edit.Name = "menuStrip_Edit";
            this.menuStrip_Edit.Size = new System.Drawing.Size(39, 20);
            this.menuStrip_Edit.Text = "&Edit";
            // 
            // menuStrip_Edit_Undo
            // 
            this.menuStrip_Edit_Undo.Name = "menuStrip_Edit_Undo";
            this.menuStrip_Edit_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuStrip_Edit_Undo.Size = new System.Drawing.Size(144, 22);
            this.menuStrip_Edit_Undo.Text = "&Undo";
            this.menuStrip_Edit_Undo.Click += new System.EventHandler(this.editMenu_Undo_Click);
            // 
            // menuStrip_Edit_Redo
            // 
            this.menuStrip_Edit_Redo.Name = "menuStrip_Edit_Redo";
            this.menuStrip_Edit_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuStrip_Edit_Redo.Size = new System.Drawing.Size(144, 22);
            this.menuStrip_Edit_Redo.Text = "&Redo";
            this.menuStrip_Edit_Redo.Click += new System.EventHandler(this.editMenu_Redo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(826, 524);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.canvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.canvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resizeSquareImg)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColorImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_custom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_custom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_custom4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_custom5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_custom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_cyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_lime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colors_white)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button selectBrushButton;

        #endregion

        private Panel canvas;
        private Panel menuPanel;
        private PictureBox colors_cyan;
        private PictureBox colors_lime;
        private PictureBox colors_red;
        private PictureBox colors_black;
        private PictureBox colors_white;
        private PictureBox colors_custom2;
        private PictureBox colors_custom3;
        private PictureBox colors_custom4;
        private PictureBox colors_custom5;
        private PictureBox colors_custom1;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuStrip_File;
        private ToolStripMenuItem menuStrip_File_New;
        private ToolStripMenuItem menuStrip_File_Open;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem menuStrip_File_Save;
        private ToolStripMenuItem menuStrip_File_SaveAs;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private BackgroundWorker backgroundWorker1;
        private PictureBox resizeSquareImg;
        private TrackBar brushSizeBar;
        private PictureBox brushSizeImg;
        private Label brushSizeLabel;
        private Button selectFillButton;
        private PictureBox selectedColorImg;
        private Button customColorButton;
        private Button selectEraserButton;
        private System.Windows.Forms.Button selectShapeButton;
        private ToolStripMenuItem menuStrip_Edit;
        private ToolStripMenuItem menuStrip_Edit_Undo;
        private ToolStripMenuItem menuStrip_Edit_Redo;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
    }
}

