using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FKAttendDllCSSample
{
    public partial class LegoTimeFormMain : Form
    {
        public LegoTimeFormMain()
        {
            InitializeComponent();
        }

        private void LegoTimeFormMain_Load(object sender, EventArgs e)
        {
            FKAttendDLL.nCommHandleIndex = FKAttendDLL.FK_ConnectNet(1, "192.168.1.224", 5005, 5000, 0, 0, 1261);

            if (FKAttendDLL.nCommHandleIndex > 0)
            {
                lblDescription.Text = "Success";
            }

        }
    }
}
