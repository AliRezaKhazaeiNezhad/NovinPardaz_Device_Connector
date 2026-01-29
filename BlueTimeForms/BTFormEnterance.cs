using System;
using System.Drawing;
using System.Windows.Forms;
using BlueTime.WebEssentials;

namespace FKAttendDllCSSample.BlueTimeForms
{
    public partial class BTFormEnterance : Form
    {
        public BTFormEnterance()
        {
            InitializeComponent();
        }

        private async void BTFormEnterance_Load(object sender, EventArgs e)
        {
            ErrorText(false);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Application.Exit();
        }

        private void BTNReturnWelcome_Click(object sender, EventArgs e)
        {
            ShowChildForm(new BTFormWelcome());
        }



        /// <summary>
        /// بستن پنجره و بازگشت به صفحه قبلی
        /// </summary>
        /// <param name="childForm"></param>
        private void ShowChildForm(Form childForm)
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

        /// <summary>
        /// مدیریت نمایش پیام خطا
        /// </summary>
        /// <param name="show"></param>
        /// <param name="message"></param>
        private void ErrorText(bool show, string message = null)
        {
            if (show)
            {
                lblErrors.Visible = true;
                lblErrors.Text = message;
            }
            else
            {
                lblErrors.Text = "";
                lblErrors.Visible = false;
            }
        }

        /// <summary>
        /// بررسی وضعیت اتصال به اینترنت
        /// </summary>
        private void ConnectionState()
        {
            lblServerConnection.Text = "درحال بررسی ...";
            btnServerConnection.Enabled = false;

            if (DomainHelper.IsConnect())
            {
                lblServerConnection.ForeColor = Color.MediumSeaGreen;
                lblServerConnection.Text = "اتصال برقرار است";
                ErrorText(false);
            }
            else
            {
                lblServerConnection.ForeColor = Color.Crimson;
                lblServerConnection.Text = "اتصال وجود ندارد";
                ErrorText(true, "اتصال سیستم به اینترنت را بررسی و مجدد ' گام اول ' را تکرار نمایید");
            }

            btnServerConnection.Enabled = true;
        }


    

        private void btnServerConnection_Click(object sender, EventArgs e)
        {
            ConnectionState();
        }

        private void lblServerConnection_Click(object sender, EventArgs e)
        {

        }
    }
}
