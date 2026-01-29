namespace FKAttendDllCSSample.BlueTimeForms
{
    partial class BTFormEnterance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTFormEnterance));
            this.BTNClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNReturnWelcome = new System.Windows.Forms.Button();
            this.lblServerConnection = new System.Windows.Forms.Label();
            this.btnServerConnection = new System.Windows.Forms.Button();
            this.lblFirstStep = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNClose
            // 
            this.BTNClose.BackColor = System.Drawing.Color.Red;
            this.BTNClose.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.BTNClose.ForeColor = System.Drawing.Color.White;
            this.BTNClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTNClose.Location = new System.Drawing.Point(13, 633);
            this.BTNClose.Margin = new System.Windows.Forms.Padding(4);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(156, 59);
            this.BTNClose.TabIndex = 23;
            this.BTNClose.Text = "خروج";
            this.BTNClose.UseVisualStyleBackColor = false;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FKAttendDllCSSample.Properties.Resources.bluetime;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // BTNReturnWelcome
            // 
            this.BTNReturnWelcome.BackColor = System.Drawing.Color.SteelBlue;
            this.BTNReturnWelcome.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.BTNReturnWelcome.ForeColor = System.Drawing.Color.White;
            this.BTNReturnWelcome.Location = new System.Drawing.Point(1218, 633);
            this.BTNReturnWelcome.Margin = new System.Windows.Forms.Padding(4);
            this.BTNReturnWelcome.Name = "BTNReturnWelcome";
            this.BTNReturnWelcome.Size = new System.Drawing.Size(152, 59);
            this.BTNReturnWelcome.TabIndex = 21;
            this.BTNReturnWelcome.Text = "بازگشت";
            this.BTNReturnWelcome.UseVisualStyleBackColor = false;
            this.BTNReturnWelcome.Click += new System.EventHandler(this.BTNReturnWelcome_Click);
            // 
            // lblServerConnection
            // 
            this.lblServerConnection.AutoSize = true;
            this.lblServerConnection.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblServerConnection.ForeColor = System.Drawing.Color.Red;
            this.lblServerConnection.Location = new System.Drawing.Point(592, 60);
            this.lblServerConnection.Name = "lblServerConnection";
            this.lblServerConnection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblServerConnection.Size = new System.Drawing.Size(107, 44);
            this.lblServerConnection.TabIndex = 25;
            this.lblServerConnection.Text = "نامشخص";
            this.lblServerConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblServerConnection.Click += new System.EventHandler(this.lblServerConnection_Click);
            // 
            // btnServerConnection
            // 
            this.btnServerConnection.BackColor = System.Drawing.Color.SteelBlue;
            this.btnServerConnection.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.btnServerConnection.ForeColor = System.Drawing.Color.White;
            this.btnServerConnection.Location = new System.Drawing.Point(885, 53);
            this.btnServerConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btnServerConnection.Name = "btnServerConnection";
            this.btnServerConnection.Size = new System.Drawing.Size(340, 59);
            this.btnServerConnection.TabIndex = 26;
            this.btnServerConnection.Text = "بررسی وضعیت اتصال به سرور";
            this.btnServerConnection.UseVisualStyleBackColor = false;
            this.btnServerConnection.Click += new System.EventHandler(this.btnServerConnection_Click);
            // 
            // lblFirstStep
            // 
            this.lblFirstStep.AutoSize = true;
            this.lblFirstStep.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.lblFirstStep.Location = new System.Drawing.Point(1251, 61);
            this.lblFirstStep.Name = "lblFirstStep";
            this.lblFirstStep.Size = new System.Drawing.Size(90, 44);
            this.lblFirstStep.TabIndex = 27;
            this.lblFirstStep.Text = "گام اول";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(20, 555);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(264, 44);
            this.lblErrors.TabIndex = 28;
            this.lblErrors.Text = "محل نمایش پیام های خطا";
            // 
            // BTFormEnterance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1383, 703);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblFirstStep);
            this.Controls.Add(this.btnServerConnection);
            this.Controls.Add(this.lblServerConnection);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNReturnWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "BTFormEnterance";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به مدیریت دستگاه ها";
            this.Load += new System.EventHandler(this.BTFormEnterance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNReturnWelcome;
        private System.Windows.Forms.Label lblServerConnection;
        private System.Windows.Forms.Button btnServerConnection;
        private System.Windows.Forms.Label lblFirstStep;
        private System.Windows.Forms.Label lblErrors;
    }
}