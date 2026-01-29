namespace FKAttendDllCSSample.BlueTimeForms
{
    partial class BTFormWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTFormWelcome));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.BTNEnterance = new System.Windows.Forms.Button();
            this.BTNContactUs = new System.Windows.Forms.Button();
            this.BTNWebsite = new System.Windows.Forms.Button();
            this.BTNFAQ = new System.Windows.Forms.Button();
            this.LabelSlogan = new System.Windows.Forms.Label();
            this.BTNClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            resources.ApplyResources(this.LabelTitle, "LabelTitle");
            this.LabelTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LabelTitle.Name = "LabelTitle";
            // 
            // BTNEnterance
            // 
            this.BTNEnterance.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.BTNEnterance, "BTNEnterance");
            this.BTNEnterance.ForeColor = System.Drawing.Color.White;
            this.BTNEnterance.Name = "BTNEnterance";
            this.BTNEnterance.UseVisualStyleBackColor = false;
            this.BTNEnterance.Click += new System.EventHandler(this.BTNEnterance_Click);
            // 
            // BTNContactUs
            // 
            this.BTNContactUs.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.BTNContactUs, "BTNContactUs");
            this.BTNContactUs.ForeColor = System.Drawing.Color.White;
            this.BTNContactUs.Name = "BTNContactUs";
            this.BTNContactUs.UseVisualStyleBackColor = false;
            this.BTNContactUs.Click += new System.EventHandler(this.BTNContactUs_Click);
            // 
            // BTNWebsite
            // 
            this.BTNWebsite.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.BTNWebsite, "BTNWebsite");
            this.BTNWebsite.ForeColor = System.Drawing.Color.White;
            this.BTNWebsite.Name = "BTNWebsite";
            this.BTNWebsite.UseVisualStyleBackColor = false;
            this.BTNWebsite.Click += new System.EventHandler(this.BTNWebsite_Click);
            // 
            // BTNFAQ
            // 
            this.BTNFAQ.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.BTNFAQ, "BTNFAQ");
            this.BTNFAQ.ForeColor = System.Drawing.Color.White;
            this.BTNFAQ.Name = "BTNFAQ";
            this.BTNFAQ.UseVisualStyleBackColor = false;
            // 
            // LabelSlogan
            // 
            resources.ApplyResources(this.LabelSlogan, "LabelSlogan");
            this.LabelSlogan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LabelSlogan.Name = "LabelSlogan";
            this.LabelSlogan.Click += new System.EventHandler(this.LabelSlogan_Click);
            // 
            // BTNClose
            // 
            this.BTNClose.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.BTNClose, "BTNClose");
            this.BTNClose.ForeColor = System.Drawing.Color.White;
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.UseVisualStyleBackColor = false;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FKAttendDllCSSample.Properties.Resources.bluetime;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BTFormWelcome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.LabelSlogan);
            this.Controls.Add(this.BTNFAQ);
            this.Controls.Add(this.BTNWebsite);
            this.Controls.Add(this.BTNContactUs);
            this.Controls.Add(this.BTNEnterance);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BTFormWelcome";
            this.Load += new System.EventHandler(this.BTFormWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button BTNEnterance;
        private System.Windows.Forms.Button BTNContactUs;
        private System.Windows.Forms.Button BTNWebsite;
        private System.Windows.Forms.Button BTNFAQ;
        private System.Windows.Forms.Label LabelSlogan;
        private System.Windows.Forms.Button BTNClose;
    }
}