using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    partial class NewProjectForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.heightNum = new System.Windows.Forms.NumericUpDown();
            this.widthNum = new System.Windows.Forms.NumericUpDown();
            this.NewProjectHeightLabel = new System.Windows.Forms.Label();
            this.NewProjectWidthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(30, 189);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(55, 24);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(142, 189);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(55, 24);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // heightNum
            // 
            this.heightNum.Location = new System.Drawing.Point(77, 60);
            this.heightNum.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            this.heightNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.heightNum.Name = "heightNum";
            this.heightNum.Size = new System.Drawing.Size(123, 20);
            this.heightNum.TabIndex = 3;
            this.heightNum.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // widthNum
            // 
            this.widthNum.Location = new System.Drawing.Point(77, 14);
            this.widthNum.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            this.widthNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.widthNum.Name = "widthNum";
            this.widthNum.Size = new System.Drawing.Size(120, 20);
            this.widthNum.TabIndex = 2;
            this.widthNum.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // NewProjectHeightLabel
            // 
            this.NewProjectHeightLabel.AutoSize = true;
            this.NewProjectHeightLabel.Location = new System.Drawing.Point(28, 60);
            this.NewProjectHeightLabel.Name = "NewProjectHeightLabel";
            this.NewProjectHeightLabel.Size = new System.Drawing.Size(44, 13);
            this.NewProjectHeightLabel.TabIndex = 1;
            this.NewProjectHeightLabel.Text = "Height: ";
            // 
            // NewProjectWidthLabel
            // 
            this.NewProjectWidthLabel.AutoSize = true;
            this.NewProjectWidthLabel.Location = new System.Drawing.Point(34, 14);
            this.NewProjectWidthLabel.Name = "NewProjectWidthLabel";
            this.NewProjectWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.NewProjectWidthLabel.TabIndex = 0;
            this.NewProjectWidthLabel.Text = "Width:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 225);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.widthNum);
            this.Controls.Add(this.heightNum);
            this.Controls.Add(this.NewProjectWidthLabel);
            this.Controls.Add(this.NewProjectHeightLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewProjectForm";
            this.Text = "New project";
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Button cancelButton;
        private Button okButton;
        private NumericUpDown heightNum;
        private NumericUpDown widthNum;
        private Label NewProjectHeightLabel;
        private Label NewProjectWidthLabel;
    }
}