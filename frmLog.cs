using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace FKAttendDllCSSample
{
  /// <summary>
  /// Form5 ��ժҪ˵����
  /// </summary>
  public class frmLog : System.Windows.Forms.Form
  {
    public System.Windows.Forms.CheckBox chkSave;
    public System.Windows.Forms.Button cmdUsbGlog;
    public System.Windows.Forms.Button cmdUsbSLog;
    internal System.Windows.Forms.ListView gridLogView;
    internal System.Windows.Forms.OpenFileDialog dlgOpen;
    public System.Windows.Forms.CheckBox chkReadMark;
    public System.Windows.Forms.Button cmdEmptyGLogData;
    public System.Windows.Forms.Button cmdEmptySLogData;
    public System.Windows.Forms.Button cmdGlogData;
    public System.Windows.Forms.Button cmdSLogData;
    public System.Windows.Forms.Label lblEnrollData;
    public System.Windows.Forms.Label lblTotal;
    public System.Windows.Forms.Label lblMessage;
    private AxAXIMAGELib.AxAxImage axAxImage1;
    /// <summary>
    /// ����������������
    /// </summary>
    private System.ComponentModel.Container components = null;

    public frmLog()
    {
      //
      // Windows ���������֧���������
      //
      InitializeComponent();

      //
      // TODO: �� InitializeComponent ���ú�����κι��캯������
      //
    }

    /// <summary>
    /// ������������ʹ�õ���Դ��
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }


    const long DEF_MAX_LOGCOUNT = 200000;    // max log data count to support by device.
    const long DEF_MAX_DISPCOUNT = 30000;     // max count to show on a grid.
    const short DEF_MUL_TWIPS = 15;

    private int mnGridHeight;
    private int mngrdIndex;
    private ListView[] mgrdLogView;

    #region Windows ������������ɵĴ���
    /// <summary>
    /// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
    /// �˷��������ݡ�
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))));
      System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))));
      System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))));
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
      this.chkSave = new System.Windows.Forms.CheckBox();
      this.cmdUsbGlog = new System.Windows.Forms.Button();
      this.cmdUsbSLog = new System.Windows.Forms.Button();
      this.gridLogView = new System.Windows.Forms.ListView();
      this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
      this.chkReadMark = new System.Windows.Forms.CheckBox();
      this.cmdEmptyGLogData = new System.Windows.Forms.Button();
      this.cmdEmptySLogData = new System.Windows.Forms.Button();
      this.cmdGlogData = new System.Windows.Forms.Button();
      this.cmdSLogData = new System.Windows.Forms.Button();
      this.lblEnrollData = new System.Windows.Forms.Label();
      this.lblTotal = new System.Windows.Forms.Label();
      this.lblMessage = new System.Windows.Forms.Label();
      this.axAxImage1 = new AxAXIMAGELib.AxAxImage();
      ((System.ComponentModel.ISupportInitialize)(this.axAxImage1)).BeginInit();
      this.SuspendLayout();
      // 
      // chkSave
      // 
      this.chkSave.BackColor = System.Drawing.SystemColors.Control;
      this.chkSave.Cursor = System.Windows.Forms.Cursors.Default;
      this.chkSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkSave.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkSave.Location = new System.Drawing.Point(526, 74);
      this.chkSave.Name = "chkSave";
      this.chkSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.chkSave.Size = new System.Drawing.Size(124, 22);
      this.chkSave.TabIndex = 33;
      this.chkSave.Text = "Save to file";
      this.chkSave.UseVisualStyleBackColor = false;
      // 
      // cmdUsbGlog
      // 
      this.cmdUsbGlog.BackColor = System.Drawing.SystemColors.Control;
      this.cmdUsbGlog.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdUsbGlog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdUsbGlog.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdUsbGlog.Location = new System.Drawing.Point(659, 463);
      this.cmdUsbGlog.Name = "cmdUsbGlog";
      this.cmdUsbGlog.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdUsbGlog.Size = new System.Drawing.Size(127, 60);
      this.cmdUsbGlog.TabIndex = 27;
      this.cmdUsbGlog.Text = "Read USB GLogData";
      this.cmdUsbGlog.UseVisualStyleBackColor = false;
      this.cmdUsbGlog.Click += new System.EventHandler(this.cmdUsbGlog_Click);
      // 
      // cmdUsbSLog
      // 
      this.cmdUsbSLog.BackColor = System.Drawing.SystemColors.Control;
      this.cmdUsbSLog.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdUsbSLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdUsbSLog.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdUsbSLog.Location = new System.Drawing.Point(275, 463);
      this.cmdUsbSLog.Name = "cmdUsbSLog";
      this.cmdUsbSLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdUsbSLog.Size = new System.Drawing.Size(126, 60);
      this.cmdUsbSLog.TabIndex = 24;
      this.cmdUsbSLog.Text = "Read USB SLogData";
      this.cmdUsbSLog.UseVisualStyleBackColor = false;
      this.cmdUsbSLog.Click += new System.EventHandler(this.cmdUsbSLog_Click);
      // 
      // gridLogView
      // 
      this.gridLogView.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gridLogView.FullRowSelect = true;
      this.gridLogView.GridLines = true;
      this.gridLogView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
      this.gridLogView.Location = new System.Drawing.Point(17, 101);
      this.gridLogView.MultiSelect = false;
      this.gridLogView.Name = "gridLogView";
      this.gridLogView.Size = new System.Drawing.Size(773, 353);
      this.gridLogView.TabIndex = 32;
      this.gridLogView.UseCompatibleStateImageBehavior = false;
      this.gridLogView.View = System.Windows.Forms.View.Details;
      this.gridLogView.DoubleClick += new System.EventHandler(this.gridLogView_DoubleClick);
      // 
      // chkReadMark
      // 
      this.chkReadMark.BackColor = System.Drawing.SystemColors.Control;
      this.chkReadMark.Cursor = System.Windows.Forms.Cursors.Default;
      this.chkReadMark.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkReadMark.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkReadMark.Location = new System.Drawing.Point(668, 74);
      this.chkReadMark.Name = "chkReadMark";
      this.chkReadMark.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.chkReadMark.Size = new System.Drawing.Size(116, 22);
      this.chkReadMark.TabIndex = 28;
      this.chkReadMark.Text = "ReadMark";
      this.chkReadMark.UseVisualStyleBackColor = false;
      // 
      // cmdEmptyGLogData
      // 
      this.cmdEmptyGLogData.BackColor = System.Drawing.SystemColors.Control;
      this.cmdEmptyGLogData.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdEmptyGLogData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdEmptyGLogData.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEmptyGLogData.Location = new System.Drawing.Point(530, 463);
      this.cmdEmptyGLogData.Name = "cmdEmptyGLogData";
      this.cmdEmptyGLogData.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdEmptyGLogData.Size = new System.Drawing.Size(128, 60);
      this.cmdEmptyGLogData.TabIndex = 26;
      this.cmdEmptyGLogData.Text = "Empty GLogData";
      this.cmdEmptyGLogData.UseVisualStyleBackColor = false;
      this.cmdEmptyGLogData.Click += new System.EventHandler(this.cmdEmptyGLogData_Click);
      // 
      // cmdEmptySLogData
      // 
      this.cmdEmptySLogData.BackColor = System.Drawing.SystemColors.Control;
      this.cmdEmptySLogData.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdEmptySLogData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdEmptySLogData.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEmptySLogData.Location = new System.Drawing.Point(145, 463);
      this.cmdEmptySLogData.Name = "cmdEmptySLogData";
      this.cmdEmptySLogData.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdEmptySLogData.Size = new System.Drawing.Size(129, 60);
      this.cmdEmptySLogData.TabIndex = 23;
      this.cmdEmptySLogData.Text = "Empty SLogData";
      this.cmdEmptySLogData.UseVisualStyleBackColor = false;
      this.cmdEmptySLogData.Click += new System.EventHandler(this.cmdEmptySLogData_Click);
      // 
      // cmdGlogData
      // 
      this.cmdGlogData.BackColor = System.Drawing.SystemColors.Control;
      this.cmdGlogData.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdGlogData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdGlogData.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdGlogData.Location = new System.Drawing.Point(402, 463);
      this.cmdGlogData.Name = "cmdGlogData";
      this.cmdGlogData.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdGlogData.Size = new System.Drawing.Size(127, 60);
      this.cmdGlogData.TabIndex = 25;
      this.cmdGlogData.Text = "Read GLogData";
      this.cmdGlogData.UseVisualStyleBackColor = false;
      this.cmdGlogData.Click += new System.EventHandler(this.cmdGlogData_Click);
      // 
      // cmdSLogData
      // 
      this.cmdSLogData.BackColor = System.Drawing.SystemColors.Control;
      this.cmdSLogData.Cursor = System.Windows.Forms.Cursors.Default;
      this.cmdSLogData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdSLogData.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSLogData.Location = new System.Drawing.Point(17, 463);
      this.cmdSLogData.Name = "cmdSLogData";
      this.cmdSLogData.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cmdSLogData.Size = new System.Drawing.Size(127, 60);
      this.cmdSLogData.TabIndex = 22;
      this.cmdSLogData.Text = "Read SLogData";
      this.cmdSLogData.UseVisualStyleBackColor = false;
      this.cmdSLogData.Click += new System.EventHandler(this.cmdSLogData_Click);
      // 
      // lblEnrollData
      // 
      this.lblEnrollData.AutoSize = true;
      this.lblEnrollData.BackColor = System.Drawing.SystemColors.Control;
      this.lblEnrollData.Cursor = System.Windows.Forms.Cursors.Default;
      this.lblEnrollData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEnrollData.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblEnrollData.Location = new System.Drawing.Point(17, 75);
      this.lblEnrollData.Name = "lblEnrollData";
      this.lblEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lblEnrollData.Size = new System.Drawing.Size(73, 19);
      this.lblEnrollData.TabIndex = 31;
      this.lblEnrollData.Text = "Log Data :";
      // 
      // lblTotal
      // 
      this.lblTotal.AutoSize = true;
      this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
      this.lblTotal.Cursor = System.Windows.Forms.Cursors.Default;
      this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTotal.Location = new System.Drawing.Point(149, 75);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lblTotal.Size = new System.Drawing.Size(46, 19);
      this.lblTotal.TabIndex = 30;
      this.lblTotal.Text = "Total :";
      // 
      // lblMessage
      // 
      this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
      this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
      this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblMessage.Location = new System.Drawing.Point(17, 23);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lblMessage.Size = new System.Drawing.Size(1056, 30);
      this.lblMessage.TabIndex = 29;
      this.lblMessage.Text = "Message";
      this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // axAxImage1
      // 
      this.axAxImage1.Enabled = true;
      this.axAxImage1.Location = new System.Drawing.Point(798, 101);
      this.axAxImage1.Name = "axAxImage1";
      this.axAxImage1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxImage1.OcxState")));
      this.axAxImage1.Size = new System.Drawing.Size(240, 320);
      this.axAxImage1.TabIndex = 35;
      // 
      // frmLog
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
      this.ClientSize = new System.Drawing.Size(1089, 547);
      this.Controls.Add(this.axAxImage1);
      this.Controls.Add(this.chkSave);
      this.Controls.Add(this.cmdUsbGlog);
      this.Controls.Add(this.cmdUsbSLog);
      this.Controls.Add(this.gridLogView);
      this.Controls.Add(this.chkReadMark);
      this.Controls.Add(this.cmdEmptyGLogData);
      this.Controls.Add(this.cmdEmptySLogData);
      this.Controls.Add(this.cmdGlogData);
      this.Controls.Add(this.cmdSLogData);
      this.Controls.Add(this.lblEnrollData);
      this.Controls.Add(this.lblTotal);
      this.Controls.Add(this.lblMessage);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmLog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Empty GLogData";
      this.Closed += new System.EventHandler(this.frmLog_Closed);
      this.Load += new System.EventHandler(this.frmLog_Load);
      ((System.ComponentModel.ISupportInitialize)(this.axAxImage1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion

    private void frmLog_Load(object sender, System.EventArgs e)
    {
      int vnii;
      long vngrdNumber;

      chkReadMark.CheckState = CheckState.Checked;
      chkSave.CheckState = CheckState.Unchecked;
      mnGridHeight = gridLogView.Height;
      vngrdNumber = DEF_MAX_LOGCOUNT / DEF_MAX_DISPCOUNT;
      if (vngrdNumber * DEF_MAX_DISPCOUNT < DEF_MAX_LOGCOUNT) vngrdNumber = vngrdNumber + 1;
      if (vngrdNumber < 0) vngrdNumber = 0;

      frmLog_Closed(sender, e);
      mgrdLogView = new ListView[vngrdNumber];
      mgrdLogView[0] = gridLogView;
      if (vngrdNumber > 0)
      {
        for (vnii = 1; vnii < vngrdNumber; vnii++)
        {
          mgrdLogView[vnii] = new ListView();
          mgrdLogView[vnii].Name = "gridListView" + vnii;
          mgrdLogView[vnii].Left = gridLogView.Left;
          mgrdLogView[vnii].Top = gridLogView.Top;
          mgrdLogView[vnii].Width = gridLogView.Width;
          mgrdLogView[vnii].Height = 0;
          mgrdLogView[vnii].HeaderStyle = ColumnHeaderStyle.None;
          mgrdLogView[vnii].View = gridLogView.View;
          mgrdLogView[vnii].GridLines = gridLogView.GridLines;
          mgrdLogView[vnii].Visible = false;
          Controls.Add(mgrdLogView[vnii]);
        }
      }
      OwnerEnableButtons(true);
    }


    private void frmLog_Closed(object sender, System.EventArgs e)
    {
      if (mgrdLogView == null) return;
      if (mgrdLogView.GetUpperBound(0) <= 0) return;
      foreach (ListView vtObject in mgrdLogView)
      {
        if (vtObject != null)
        {
          if (vtObject.Name != gridLogView.Name)
          {
            Controls.Remove(vtObject);
            vtObject.Dispose();
          }
        }
      }
    }
    private void cmdSLogData_Click(object sender, System.EventArgs e)
    {
      OwnerEnableButtons(false);
      funcGetSuperLogData(false);
      OwnerEnableButtons(true);
    }

    private void cmdEmptySLogData_Click(object sender, System.EventArgs e)
    {
      int vnResultCode;

      cmdEmptySLogData.Enabled = false;
      lblMessage.Text = "Working...";
      Application.DoEvents();

      vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdEmptySLogData.Enabled = true;
        return;
      }
      vnResultCode = FKAttendDLL.FK_EmptySuperLogData(FKAttendDLL.nCommHandleIndex);
      lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdEmptySLogData.Enabled = true;
    }

    private void cmdUsbSLog_Click(object sender, System.EventArgs e)
    {
      OwnerEnableButtons(false);
      funcGetSuperLogData(true);
      OwnerEnableButtons(true);
    }

    private void cmdGlogData_Click(object sender, System.EventArgs e)
    {
      OwnerEnableButtons(false);
      funcGetGeneralLogData(false);
      OwnerEnableButtons(true);
    }

    private void cmdEmptyGLogData_Click(object sender, System.EventArgs e)
    {
      int vnResultCode;
      cmdEmptyGLogData.Enabled = false;
      lblMessage.Text = "Working...";
      Application.DoEvents();

      vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        cmdEmptyGLogData.Enabled = true;
        return;
      }

      vnResultCode = FKAttendDLL.FK_EmptyGeneralLogData(FKAttendDLL.nCommHandleIndex);
      lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
      cmdEmptyGLogData.Enabled = true;
    }

    private void cmdUsbGlog_Click(object sender, System.EventArgs e)
    {
      OwnerEnableButtons(false);
      funcGetGeneralLogData(true);
      OwnerEnableButtons(true);

      // int vIoMode = 0, vDoorMode = 0;
      //   FKAttendDLL.GetIoModeAndDoorMode(0x00000001, ref vIoMode, ref vDoorMode);

    }
    private void funcGetSuperLogData(bool abUSBFlag)
    {
      int vSEnrollNumber = 0;
      int vGEnrollNumber = 0;
      int vManipulation = 0;
      int vBackupNumber = 0;
      DateTime vdwDate = DateTime.Now;
      int vnii;

      string[] vstrLogItem;
      string vstrFileName;
      int vnReadMark;
      int vnResultCode;
      string vstrTmp;
      ListViewItem vtItem;

      vstrFileName = "";
      vstrTmp = "";
      lblMessage.Text = "Waiting...";
      lblTotal.Text = "Total : 0";
      Application.DoEvents();

      vstrLogItem = new string[] { "", "SEnrollNo", "GEnrollNo", "Manipulation", "BackupNo", "DateTime" };

      mgrdLogView[0].Height = mnGridHeight;
      mgrdLogView[0].Items.Clear();
      mgrdLogView[0].Columns.Clear();

      foreach (string vstrTmp2 in vstrLogItem)
      {
        mgrdLogView[0].Columns.Add(vstrTmp2, 80, HorizontalAlignment.Center);
      }
      mgrdLogView[0].Columns[0].Width = 48;
      mgrdLogView[0].Columns[0].TextAlign = HorizontalAlignment.Right;
      mgrdLogView[0].Columns[3].Width = 140;
      mgrdLogView[0].Columns[3].TextAlign = HorizontalAlignment.Left;
      mgrdLogView[0].Columns[5].Width = 140;
      Application.DoEvents();


      for (vnii = 1; vnii < mgrdLogView.GetUpperBound(0); vnii++)
      {
        if (mgrdLogView[vnii] != null)
        {
          mgrdLogView[vnii].Visible = false;
          mgrdLogView[vnii].Height = 0;
          mgrdLogView[vnii].Items.Clear();
          mgrdLogView[vnii].Columns.Clear();
          foreach (ColumnHeader vtColumnHeader in mgrdLogView[0].Columns)
          {
            mgrdLogView[vnii].Columns.Add("", vtColumnHeader.Width, vtColumnHeader.TextAlign);
          }
        }
      }

      if (abUSBFlag == true)
      {
        dlgOpen.InitialDirectory = Directory.GetCurrentDirectory();
        dlgOpen.Filter = "SLog Files (*.txt)|*.txt|All Files (*.*)|*.*";
        dlgOpen.FilterIndex = 1;
        if (dlgOpen.ShowDialog() != DialogResult.OK)
          return;
        vstrFileName = dlgOpen.FileName;
        dlgOpen.FileName = "";
        if (vstrFileName == "") return;
      }
      else
      {
        vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
        if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
        {
          lblMessage.Text = FKAttendDLL.msErrorNoDevice;
          return;
        }
      }

      Cursor = Cursors.WaitCursor;
      Application.DoEvents();
      if (abUSBFlag == true)
        vnResultCode = FKAttendDLL.FK_USBLoadSuperLogDataFromFile(FKAttendDLL.nCommHandleIndex, vstrFileName);
      else
      {
        if (chkReadMark.CheckState == CheckState.Checked)
          vnReadMark = 1;
        else
          vnReadMark = 0;

        vnResultCode = FKAttendDLL.FK_LoadSuperLogData(FKAttendDLL.nCommHandleIndex, vnReadMark);
      }

      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
        lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
      else
      {
        lblMessage.Text = "Getting...";
        Application.DoEvents();
        vnii = 1;
        do
        {
          vnResultCode = FKAttendDLL.FK_GetSuperLogData(FKAttendDLL.nCommHandleIndex, ref vSEnrollNumber,
  ref vGEnrollNumber, ref vManipulation, ref vBackupNumber, ref vdwDate);
          if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
          {
            if (vnResultCode == (int)enumErrorCode.RUNERR_DATAARRAY_END)
              vnResultCode = (int)enumErrorCode.RUN_SUCCESS;
            break;
          }
          vtItem = new ListViewItem();
          vtItem.Text = (Convert.ToString(vnii)).Trim();
          vtItem.SubItems.Add(vSEnrollNumber.ToString().Trim());
          vtItem.SubItems.Add(vGEnrollNumber.ToString().Trim());
          switch (vManipulation)
          {
            case (int)enumSuperLogInfo.LOG_ENROLL_USER:
              vstrTmp = "Enroll User"; break;
            case (int)enumSuperLogInfo.LOG_ENROLL_MANAGER:
              vstrTmp = "Enroll Manager"; break;
            case (int)enumSuperLogInfo.LOG_ENROLL_DELFP:
              vstrTmp = "Delete Fp Data"; break;
            case (int)enumSuperLogInfo.LOG_ENROLL_DELPASS:
              vstrTmp = "Delete Password"; break;
            case (int)enumSuperLogInfo.LOG_ENROLL_DELCARD:
              vstrTmp = "Delete Card Data"; break;
            case (int)enumSuperLogInfo.LOG_LOG_ALLDEL:
              vstrTmp = "Delete All LogData"; break;
            case (int)enumSuperLogInfo.LOG_SETUP_SYS:
              vstrTmp = "Modify System Info"; break;
            case (int)enumSuperLogInfo.LOG_SETUP_TIME:
              vstrTmp = "Modify System Time"; break;
            case (int)enumSuperLogInfo.LOG_SETUP_LOG:
              vstrTmp = "Modify Log Setting"; break;
            case (int)enumSuperLogInfo.LOG_SETUP_COMM:
              vstrTmp = "Modify Comm Setting"; break;
            case (int)enumSuperLogInfo.LOG_PASSTIME:
              vstrTmp = "Pass Time Set"; break;
            case (int)enumSuperLogInfo.LOG_SETUP_DOOR:
              vstrTmp = "Door Set Log"; break;
            default:
              vstrTmp = "--"; break;
          }
          vtItem.SubItems.Add(vstrTmp);

          if (vBackupNumber == (int)enumBackupNumberType.BACKUP_PSW)
            vstrTmp = "Password";
          else if (vBackupNumber == (int)enumBackupNumberType.BACKUP_CARD)
            vstrTmp = "Card";
          else if (vBackupNumber < (int)enumBackupNumberType.BACKUP_PSW)
            vstrTmp = "Fp-" + vBackupNumber.ToString().Trim();
          else
            vstrTmp = "--";

          vtItem.SubItems.Add(vstrTmp);

          vstrTmp = vdwDate.Year + vdwDate.Month.ToString("/0#") + vdwDate.Day.ToString("/0#") +
            vdwDate.Hour.ToString(" 0#") + vdwDate.Minute.ToString(":0#") + vdwDate.Second.ToString(":0#");

          vtItem.SubItems.Add(vstrTmp);
          mgrdLogView[0].Items.Add(vtItem);
          vtItem = null;
          lblTotal.Text = "Total : " + vnii;
          Application.DoEvents();
          vnii = vnii + 1;
        } while (true);

        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          if (abUSBFlag == true)
            lblMessage.Text = "USBReadSuperLogDataFromFile OK";
          else
            lblMessage.Text = "ReadAllSuperLogData OK";
        }
        else
          lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
      }

      Cursor = Cursors.Default;
      if (abUSBFlag == false)
        FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);

    }

    private void funcGeneralLogDataGridFormat()
    {
      int vnii;
      string[] vstrLogItem;

      vstrLogItem = new string[] { "", "EnrollNo", "VerifyMode", "InOutMode", "DateTime", "WorkCode" };

      mgrdLogView[0].Height = mnGridHeight;
      mgrdLogView[0].Items.Clear();
      mgrdLogView[0].Columns.Clear();
      foreach (string vstrTmp in vstrLogItem) mgrdLogView[0].Columns.Add(vstrTmp, 80, HorizontalAlignment.Center);

      mgrdLogView[0].Columns[0].Width = 48;
      mgrdLogView[0].Columns[0].TextAlign = HorizontalAlignment.Right;
      mgrdLogView[0].Columns[2].Width = 140;
      mgrdLogView[0].Columns[4].Width = 140;
      Application.DoEvents();


      for (vnii = 1; vnii < mgrdLogView.GetUpperBound(0); vnii++)
      {
        if (mgrdLogView[vnii] != null)
        {
          mgrdLogView[vnii].Visible = false;
          mgrdLogView[vnii].Left = mgrdLogView[0].Left;
          mgrdLogView[vnii].Top = mgrdLogView[0].Top;
          mgrdLogView[vnii].Width = mgrdLogView[0].Width;
          mgrdLogView[vnii].Height = 0;
          mgrdLogView[vnii].Items.Clear();
          mgrdLogView[vnii].Columns.Clear();
          foreach (ColumnHeader vtColumnHeader in mgrdLogView[0].Columns)
          {
            mgrdLogView[vnii].Columns.Add("", vtColumnHeader.Width, vtColumnHeader.TextAlign);
          }

        }
      }
      Application.DoEvents();

    }

    private string getVerifymodeToString(int anVerifyMode)
    {
      string vstrTmp;

      switch (anVerifyMode)
      {
        case (int)enumGLogVerifyMode.LOG_FPVERIFY:          //1
          vstrTmp = "Fp"; break;
        case (int)enumGLogVerifyMode.LOG_PASSVERIFY:        //2
          vstrTmp = "Password"; break;
        case (int)enumGLogVerifyMode.LOG_CARDVERIFY:        //3
          vstrTmp = "Card"; break;
        case (int)enumGLogVerifyMode.LOG_FPPASS_VERIFY:     //4
          vstrTmp = "Fp+Password"; break;
        case (int)enumGLogVerifyMode.LOG_FPCARD_VERIFY:     //5
          vstrTmp = "Fp+Card"; break;
        case (int)enumGLogVerifyMode.LOG_PASSFP_VERIFY:     //6
          vstrTmp = "Password+Fp"; break;
        case (int)enumGLogVerifyMode.LOG_CARDFP_VERIFY:     //7
          vstrTmp = "Card+Fp"; break;
        case (int)enumGLogVerifyMode.LOG_FACEVERIFY:        //20
          vstrTmp = "Face"; break;
        case (int)enumGLogVerifyMode.LOG_FACECARDVERIFY:    //21
          vstrTmp = "Face+Card"; break;
        case (int)enumGLogVerifyMode.LOG_FACEPASSVERIFY:    //22
          vstrTmp = "Face+Pass"; break;
        case (int)enumGLogVerifyMode.LOG_PASSFACEVERIFY:    //21
          vstrTmp = "Pass+Face"; break;
        case (int)enumGLogVerifyMode.LOG_CARDFACEVERIFY:    //22
          vstrTmp = "Card+Face"; break;
        default:
          vstrTmp = FKAttendDLL.GetStringVerifyMode(anVerifyMode); break;

      }
      return vstrTmp;
    }

    private string getIOmodeToString(int anInOutMode)
    {
      string vstrTmp;
      int vIoMode = 0;
      int vDoorMode = 0;
      FKAttendDLL.GetIoModeAndDoorMode(anInOutMode, ref vIoMode, ref vDoorMode);

      if (vDoorMode == 0)
        vstrTmp = "( " + vIoMode + " )";
      else
        vstrTmp = "( " + vIoMode + " ) &    ";
      switch (vDoorMode)
      {
        case (int)enumGLogDoorMode.LOG_CLOSE_DOOR:
          vstrTmp += "Close Door"; break;
        case (int)enumGLogDoorMode.LOG_OPEN_HAND:
          vstrTmp += "Hand Open"; break;
        case (int)enumGLogDoorMode.LOG_PROG_OPEN:
          vstrTmp += "Prog Open"; break;
        case (int)enumGLogDoorMode.LOG_PROG_CLOSE:
          vstrTmp += "Prog Close"; break;
        case (int)enumGLogDoorMode.LOG_OPEN_IREGAL:
          vstrTmp += "Illegal Open"; break;
        case (int)enumGLogDoorMode.LOG_CLOSE_IREGAL:
          vstrTmp += "Illegal Close"; break;
        case (int)enumGLogDoorMode.LOG_OPEN_COVER:
          vstrTmp += "Cover Open"; break;
        case (int)enumGLogDoorMode.LOG_CLOSE_COVER:
          vstrTmp += "Cover Close"; break;
        case (int)enumGLogDoorMode.LOG_OPEN_DOOR:
          vstrTmp += "Open door"; break;
        case (int)enumGLogDoorMode.LOG_OPEN_DOOR_THREAT:
          vstrTmp += "Open Door as Threat"; break;
        case (int)enumGLogDoorMode.LOG_FORCE_OPEN_DOOR:
          vstrTmp += "Force Open"; break;
        case (int)enumGLogDoorMode.LOG_FORCE_CLOSE_DOOR_:
          vstrTmp += "Force Close"; break;

        //vstrTmp = "--"; break;
      }
      if (vstrTmp == "") vstrTmp = "--";
      return vstrTmp;
    }

    private bool funcShowGeneralLogDataToGrid(int anCount, string aStrEnrollNumber, UInt32 aSEnrollNumber, int aVerifyMode, int aInOutMode, DateTime adwDate)
    {
        return funcShowGeneralLogDataToGrid(anCount, aStrEnrollNumber, aSEnrollNumber, aVerifyMode, aInOutMode, adwDate, 0);
    }

    private bool funcShowGeneralLogDataToGrid(int anCount, string aStrEnrollNumber, UInt32 aSEnrollNumber, int aVerifyMode, int aInOutMode, DateTime adwDate, int aWorkCode)
    {
        int vnkk;
        int vnTop, vnAllHeight;
        string vstrTmp;
        ListViewItem vtItem;
        bool vRet = true;

        if (anCount <= 1)
            mngrdIndex = 0;
        else
        {
            if ((mngrdIndex + 1) * DEF_MAX_DISPCOUNT < anCount)
            {
                mngrdIndex = mngrdIndex + 1;
                if (mngrdIndex > mgrdLogView.GetUpperBound(0))
                {
                    vRet = false;
                    return vRet;
                }
                vnAllHeight = mnGridHeight;
                vnTop = mgrdLogView[0].Top;
                for (vnkk = 0; vnkk < mngrdIndex; vnkk++)
                {
                    mgrdLogView[vnkk].Top = vnTop + (vnkk - 1) * (vnAllHeight / mngrdIndex);
                    mgrdLogView[vnkk].Height = vnAllHeight / mngrdIndex;
                }
                mgrdLogView[mngrdIndex].Visible = true;
            }
        }

        vtItem = new ListViewItem();
        vtItem.Text = anCount.ToString().Trim();
        if (aStrEnrollNumber.Length == 0)
            vtItem.SubItems.Add(aSEnrollNumber.ToString().Trim());
        else
            vtItem.SubItems.Add(aStrEnrollNumber.Trim());




        vtItem.SubItems.Add(getVerifymodeToString(aVerifyMode));



        vtItem.SubItems.Add(getIOmodeToString(aInOutMode));

        vstrTmp = adwDate.Year + adwDate.Month.ToString("/0#") + adwDate.Day.ToString("/0#") +
          adwDate.Hour.ToString(" 0#") + adwDate.Minute.ToString(":0#") + adwDate.Second.ToString(":0#");

        vtItem.SubItems.Add(vstrTmp);

        vtItem.SubItems.Add(aWorkCode.ToString());

        mgrdLogView[mngrdIndex].Items.Add(vtItem);
        vtItem = null;
        lblTotal.Text = "Total : " + anCount;

        Application.DoEvents();
        return vRet;
    }


    private void funcGetGeneralLogData(bool abUSBFlag)
    {
      UInt32 vSEnrollNumber = 0;
      string vStrEnrollNumber;
      int vVerifyMode = 0;
      int vInOutMode = 0;
      int vWorkCode = 0;
      DateTime vdwDate = DateTime.MinValue;
      int vnCount;
      int vnResultCode = 0;
      string vstrFileName;
      string vstrFileData;
      int vnReadMark;

      vstrFileName = "";
      lblMessage.Text = "Waiting...";
      lblTotal.Text = "Total : 0";
      Application.DoEvents();
      funcGeneralLogDataGridFormat();

      if (abUSBFlag == true)
      {
        dlgOpen.InitialDirectory = Directory.GetCurrentDirectory();
        dlgOpen.Filter = "GLog Files (*.txt)|*.txt|All Files (*.*)|*.*";
        dlgOpen.FilterIndex = 1;
        if (dlgOpen.ShowDialog() != DialogResult.OK)
          return;
        vstrFileName = dlgOpen.FileName;
        dlgOpen.FileName = "";
      }
      else
      {
        vnResultCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
        if (vnResultCode == 0)
        {
          lblMessage.Text = FKAttendDLL.msErrorNoDevice;
          return;
        }
      }

      Cursor = Cursors.WaitCursor;
      Application.DoEvents();
      if (abUSBFlag == true)
        vnResultCode = FKAttendDLL.FK_USBLoadGeneralLogDataFromFile(FKAttendDLL.nCommHandleIndex, vstrFileName);
      else
      {
        if (chkReadMark.CheckState == CheckState.Checked)
          vnReadMark = 1;
        else
          vnReadMark = 0;

        //open file for save
        if (chkSave.CheckState == CheckState.Checked)
        {
          if (vnReadMark == 0)
            vstrFileName = Directory.GetCurrentDirectory() + "\\AllLog.txt";
          else
            vstrFileName = Directory.GetCurrentDirectory() + "\\Log.txt";

          if (Directory.Exists(vstrFileName) == true) File.Delete(vstrFileName);
          vstrFileData = "No." + Convert.ToChar(9) + "EnrNo" + Convert.ToChar(9) + "Verify"
            + Convert.ToChar(9) + "InOut" + Convert.ToChar(9) + "DateTime" + Convert.ToChar(13) + Convert.ToChar(10);

          using (FileStream fs = File.Create(vstrFileName)) { };
          // Open the stream and read it back.
          using (FileStream fs = File.OpenWrite(vstrFileName))
          {
            byte[] newBytes = new ASCIIEncoding().GetBytes(vstrFileData.ToCharArray());
            fs.Write(newBytes, 0, vstrFileData.Length);
          }
        }
        vnResultCode = FKAttendDLL.FK_LoadGeneralLogData(FKAttendDLL.nCommHandleIndex, vnReadMark);

      }
      if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
        lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);
      else
      {
        lblMessage.Text = "Getting...";
        Application.DoEvents();

        vnCount = 1;

        int vnResultSupportStringID = FKAttendDLL.FK_GetIsSupportStringID(FKAttendDLL.nCommHandleIndex);
        if (vnResultSupportStringID >= (int)enumErrorCode.RUN_SUCCESS)
        {
          do
          {
            if (vnResultSupportStringID == FKAttendDLL.USER_ID_LENGTH13_1)
              vStrEnrollNumber = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH13_1);
            else
              vStrEnrollNumber = new string((char)0x20, FKAttendDLL.USER_ID_LENGTH);
            //vnResultCode = FKAttendDLL.FK_GetGeneralLogData_StringID(FKAttendDLL.nCommHandleIndex, ref vStrEnrollNumber, ref vVerifyMode, ref vInOutMode, ref vdwDate);
            vnResultCode = FKAttendDLL.FK_GetGeneralLogData_StringID_Workcode(FKAttendDLL.nCommHandleIndex, ref vStrEnrollNumber, ref vVerifyMode, ref vInOutMode, ref vdwDate, ref vWorkCode);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
              if (vnResultCode == (int)enumErrorCode.RUNERR_DATAARRAY_END)
              {
                vnResultCode = (int)enumErrorCode.RUN_SUCCESS;
              }
              break;
            }
            vStrEnrollNumber = vStrEnrollNumber.Trim();
            if (abUSBFlag == false && chkSave.CheckState == CheckState.Checked)
            {
              vstrFileData = funcMakeGeneralLogFileData(vnCount, vStrEnrollNumber, vSEnrollNumber, vVerifyMode, vInOutMode, vdwDate);

              using (FileStream fs = File.OpenWrite(vstrFileName))
              {
                byte[] newBytes = new ASCIIEncoding().GetBytes(vstrFileData.ToCharArray());

                fs.Seek(0, SeekOrigin.End);
                fs.Write(newBytes, 0, vstrFileData.Length);
              }
            }

            if (funcShowGeneralLogDataToGrid(vnCount, vStrEnrollNumber, vSEnrollNumber, vVerifyMode, vInOutMode, vdwDate, vWorkCode) == false) break;
            vnCount = vnCount + 1;
            vStrEnrollNumber = null;
          } while (true);
        }
        else
        {

          do
          {
            vnResultCode = FKAttendDLL.FK_GetGeneralLogData(FKAttendDLL.nCommHandleIndex, ref vSEnrollNumber, ref vVerifyMode, ref vInOutMode, ref vdwDate);
            if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
            {
              if (vnResultCode == (int)enumErrorCode.RUNERR_DATAARRAY_END)
              {
                vnResultCode = (int)enumErrorCode.RUN_SUCCESS;
              }
              break;
            }
            if (abUSBFlag == false && chkSave.CheckState == CheckState.Checked)
            {
              vstrFileData = funcMakeGeneralLogFileData(vnCount, "", vSEnrollNumber, vVerifyMode, vInOutMode, vdwDate);

              using (FileStream fs = File.OpenWrite(vstrFileName))
              {
                byte[] newBytes = new ASCIIEncoding().GetBytes(vstrFileData.ToCharArray());

                fs.Seek(0, SeekOrigin.End);
                fs.Write(newBytes, 0, vstrFileData.Length);
              }
            }

            if (funcShowGeneralLogDataToGrid(vnCount, "", vSEnrollNumber, vVerifyMode, vInOutMode, vdwDate) == false) break;
            vnCount = vnCount + 1;
          } while (true);
        }
        if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
        {
          if (abUSBFlag == true)
            lblMessage.Text = "USBReadGeneralLogDataFromFile OK";
          else
            lblMessage.Text = "ReadGeneralLogData OK";
        }
        else
          lblMessage.Text = FKAttendDLL.ReturnResultPrint(vnResultCode);

      }

      Cursor = Cursors.Default;
      if (abUSBFlag == false)
        FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);

    }
    private void OwnerEnableButtons(bool abEnableFlag)
    {
      bool vbFrmOpenFlag;

      vbFrmOpenFlag = frmMain.gfrmMain.OpenFlag;
      cmdSLogData.Enabled = vbFrmOpenFlag && abEnableFlag;
      cmdEmptySLogData.Enabled = vbFrmOpenFlag && abEnableFlag;
      cmdUsbSLog.Enabled = abEnableFlag;
      cmdGlogData.Enabled = vbFrmOpenFlag && abEnableFlag;
      cmdEmptyGLogData.Enabled = vbFrmOpenFlag && abEnableFlag;
      cmdUsbGlog.Enabled = abEnableFlag;
      Application.DoEvents();
    }

    private string funcMakeGeneralLogFileData(long anCount, string aStrEnrollNumber,
      long aSEnrollNumber, long aVerifyMode, long aInOutMode, DateTime adwDate)
    {
      string vstrData;
      string vstrDTime;

      string vStrEnrollNumber;

      vStrEnrollNumber = (aStrEnrollNumber.Length == 0) ? aSEnrollNumber.ToString() : aStrEnrollNumber;
      vstrData = anCount.ToString() + Convert.ToChar(9) + vStrEnrollNumber
  + Convert.ToChar(9) + getVerifymodeToString((int)aVerifyMode) + Convert.ToChar(9) + getIOmodeToString((int)aInOutMode) + Convert.ToChar(9);

      vstrDTime = adwDate.Year + adwDate.Month.ToString("/0#") + adwDate.Day.ToString("/0#") +
        adwDate.Hour.ToString(" 0#") + adwDate.Minute.ToString(":0#") + adwDate.Second.ToString(":0#");

      return (vstrData + vstrDTime + Convert.ToChar(13) + Convert.ToChar(10));
    }

    private void gridLogView_DoubleClick(object sender, EventArgs e)
    {
      UInt32 nEnrollNumber;
      int nYear;
      int nMonth;
      int nDay;
      int nHour;
      int nMinute;
      int nSecond;

      int nPhotoLen;
      int nFKRetCode;

      DateTime dtLog;
      object varImg;
      byte[] bytPhotoImage;

      if (mngrdIndex < 0)
        return;

      ListViewItem item = mgrdLogView[mngrdIndex].SelectedItems[0];
      nEnrollNumber = FKAttendDLL.GetInt(item.SubItems[1].Text);
      dtLog = Convert.ToDateTime(item.SubItems[4].Text);

      nYear = dtLog.Year;
      nMonth = dtLog.Month;
      nDay = dtLog.Day;
      nHour = dtLog.Hour;
      nMinute = dtLog.Minute;
      nSecond = dtLog.Second;

      lblMessage.Text = "Getting log photo ...";
      Application.DoEvents();

      nFKRetCode = FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 0);
      if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.msErrorNoDevice;
        return;
      }



      bytPhotoImage = new byte[0];
      nPhotoLen = 0;
      nFKRetCode = FKAttendDLL.FK_GetLogPhoto(
          FKAttendDLL.nCommHandleIndex,
          nEnrollNumber,
          nYear, nMonth, nDay,
          nHour, nMinute, nSecond, bytPhotoImage, ref nPhotoLen);
      if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);

        FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
        return;
      }

      bytPhotoImage = new byte[nPhotoLen];
      nFKRetCode = FKAttendDLL.FK_GetLogPhoto(
          FKAttendDLL.nCommHandleIndex,
          nEnrollNumber,
          nYear, nMonth, nDay,
          nHour, nMinute, nSecond, bytPhotoImage, ref nPhotoLen);
      if (nFKRetCode != (int)enumErrorCode.RUN_SUCCESS)
      {
        lblMessage.Text = FKAttendDLL.ReturnResultPrint(nFKRetCode);
      }
      else
      {
        lblMessage.Text = "GetLogPhoto OK";
        varImg = new System.Runtime.InteropServices.VariantWrapper(bytPhotoImage);
        axAxImage1.SetJpgImage(ref varImg);
      }

      FKAttendDLL.FK_EnableDevice(FKAttendDLL.nCommHandleIndex, 1);
    }
  }
}
