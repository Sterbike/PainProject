using System;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class NewProjectForm : Form
    {
        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MainForm"] != null)
            {
                var form = Application.OpenForms["MainForm"] as MainForm;
                form.NewProject((int)widthNum.Value, (int)heightNum.Value);
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetWidthAndHeight(int width, int height)
        {
            widthNum.Value = width;
            heightNum.Value = height;
        }
    }
}
