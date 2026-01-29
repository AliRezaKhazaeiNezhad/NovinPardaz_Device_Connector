using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FKAttendDllCSSample.BlueTimeForms
{
    public partial class BTFormWelcome : Form
    {
        public BTFormWelcome()
        {
            InitializeComponent();
        }

        private void BTFormWelcome_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void LabelSlogan_Click(object sender, EventArgs e)
        {

        }

        private void BTNEnterance_Click(object sender, EventArgs e)
        {
            ShowChildForm(new BTFormEnterance());
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Application.Exit();
        }

        private void BTNWebsite_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bluetime.ir/");
        }

        private void lblDivider_Click(object sender, EventArgs e)
        {
        }

        private void BTNContactUs_Click(object sender, EventArgs e)
        {
            ShowChildForm(new BTFormContactUs());
        }


        public void ShowChildForm(Form childForm)
        {
            if (childForm != null)
            {
                Hide();
                childForm.Owner = this;
                childForm.ShowDialog();
                childForm.Dispose();
                Show();
            }
        }
    }
}
