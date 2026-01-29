using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FKAttendDllCSSample.BlueTimeForms
{
    public partial class BTFormContactUs : Form
    {
        public BTFormContactUs()
        {
            InitializeComponent();
        }

        private void BTFormContactUs_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void BTNReturnWelcome_Click(object sender, EventArgs e)
        {
            ShowChildForm(new BTFormWelcome());
        }



        public void ShowChildForm(Form childForm)
        {
            if (childForm != null)
            {
                this.Hide();
                childForm.Owner = this;
                childForm.ShowDialog();
                childForm.Dispose();
                this.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Application.Exit();
        }
    }
}
