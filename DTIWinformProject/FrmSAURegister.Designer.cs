namespace DTIWinformProject
{
    partial class FrmSAURegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSAURegister));
            this.mcdRegis = new System.Windows.Forms.MonthCalendar();
            this.lsbSubjectRegis = new System.Windows.Forms.ListBox();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.labelRegisDate = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.cbbLevelRegis = new System.Windows.Forms.ComboBox();
            this.btSelectSub = new System.Windows.Forms.Button();
            this.labelSubject = new System.Windows.Forms.Label();
            this.btSelectAllSub = new System.Windows.Forms.Button();
            this.btUnSelectSub = new System.Windows.Forms.Button();
            this.btUnSelectAllSub = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.lsbSubjectSelectedRegis = new System.Windows.Forms.ListBox();
            this.tbNoRegis = new System.Windows.Forms.TextBox();
            this.LabeStuId = new System.Windows.Forms.Label();
            this.tbNameRegis = new System.Windows.Forms.TextBox();
            this.LabelFullname1 = new System.Windows.Forms.Label();
            this.labelStuType = new System.Windows.Forms.Label();
            this.rfFundRegis = new System.Windows.Forms.RadioButton();
            this.rdNormalRegis = new System.Windows.Forms.RadioButton();
            this.btSelectImageRegis = new System.Windows.Forms.Button();
            this.cbConfirmRegis = new System.Windows.Forms.CheckBox();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btRegis = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbImageRegis = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageRegis)).BeginInit();
            this.SuspendLayout();
            // 
            // mcdRegis
            // 
            this.mcdRegis.Location = new System.Drawing.Point(69, 121);
            this.mcdRegis.Name = "mcdRegis";
            this.mcdRegis.TabIndex = 0;
            // 
            // lsbSubjectRegis
            // 
            this.lsbSubjectRegis.FormattingEnabled = true;
            this.lsbSubjectRegis.ItemHeight = 16;
            this.lsbSubjectRegis.Items.AddRange(new object[] {
            "ภาษาไทย",
            "ภาษาอังกฤษ",
            "ภาษาญี่ปุ่น",
            "ภาษาจีน",
            "สังคมศึกษา",
            "คณิตศาสตร์",
            "พลศึกษา",
            "ประวัติศาสตร์",
            "คอมพิวเตอร์เบื้องต้น",
            "บัญชีเบื้องต้น",
            "กฏหมายเบื้องต้น",
            "เศรษฐศาสตร์เบื้องต้น",
            "หลักการบริหาร",
            "เคมี",
            "ชีววิทยา"});
            this.lsbSubjectRegis.Location = new System.Drawing.Point(69, 432);
            this.lsbSubjectRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbSubjectRegis.Name = "lsbSubjectRegis";
            this.lsbSubjectRegis.Size = new System.Drawing.Size(160, 180);
            this.lsbSubjectRegis.TabIndex = 1;
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(63, 11);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(680, 80);
            this.HeadLabel.TabIndex = 35;
            this.HeadLabel.Text = "ลงทะเบียน";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegisDate
            // 
            this.labelRegisDate.AutoSize = true;
            this.labelRegisDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisDate.Location = new System.Drawing.Point(65, 92);
            this.labelRegisDate.Name = "labelRegisDate";
            this.labelRegisDate.Size = new System.Drawing.Size(120, 20);
            this.labelRegisDate.TabIndex = 37;
            this.labelRegisDate.Text = "วันที่ลงทะเบียน";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(65, 329);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(71, 20);
            this.labelSemester.TabIndex = 38;
            this.labelSemester.Text = "ระดับชั้น";
            // 
            // cbbLevelRegis
            // 
            this.cbbLevelRegis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLevelRegis.FormattingEnabled = true;
            this.cbbLevelRegis.Items.AddRange(new object[] {
            "ชั้นมัธยมศึกษาปีที่ 1",
            "ชั้นมัธยมศึกษาปีที่ 2",
            "ชั้นมัธยมศึกษาปีที่ 3",
            "ชั้นมัธยมศึกษาปีที่ 4",
            "ชั้นมัธยมศึกษาปีที่ 5",
            "ชั้นมัธยมศึกษาปีที่ 6"});
            this.cbbLevelRegis.Location = new System.Drawing.Point(69, 352);
            this.cbbLevelRegis.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLevelRegis.Name = "cbbLevelRegis";
            this.cbbLevelRegis.Size = new System.Drawing.Size(160, 24);
            this.cbbLevelRegis.TabIndex = 39;
            // 
            // btSelectSub
            // 
            this.btSelectSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSelectSub.ForeColor = System.Drawing.Color.Lime;
            this.btSelectSub.Location = new System.Drawing.Point(259, 432);
            this.btSelectSub.Margin = new System.Windows.Forms.Padding(4);
            this.btSelectSub.Name = "btSelectSub";
            this.btSelectSub.Size = new System.Drawing.Size(100, 38);
            this.btSelectSub.TabIndex = 40;
            this.btSelectSub.Text = ">";
            this.btSelectSub.UseVisualStyleBackColor = true;
            this.btSelectSub.Click += new System.EventHandler(this.btSelectSub_Click);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(65, 410);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(129, 20);
            this.labelSubject.TabIndex = 41;
            this.labelSubject.Text = "วิชาที่ลงทะเบียน";
            // 
            // btSelectAllSub
            // 
            this.btSelectAllSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSelectAllSub.ForeColor = System.Drawing.Color.Lime;
            this.btSelectAllSub.Location = new System.Drawing.Point(259, 483);
            this.btSelectAllSub.Margin = new System.Windows.Forms.Padding(4);
            this.btSelectAllSub.Name = "btSelectAllSub";
            this.btSelectAllSub.Size = new System.Drawing.Size(100, 38);
            this.btSelectAllSub.TabIndex = 42;
            this.btSelectAllSub.Text = ">>";
            this.btSelectAllSub.UseVisualStyleBackColor = true;
            this.btSelectAllSub.Click += new System.EventHandler(this.btSelectAllSub_Click);
            // 
            // btUnSelectSub
            // 
            this.btUnSelectSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btUnSelectSub.ForeColor = System.Drawing.Color.Red;
            this.btUnSelectSub.Location = new System.Drawing.Point(259, 529);
            this.btUnSelectSub.Margin = new System.Windows.Forms.Padding(4);
            this.btUnSelectSub.Name = "btUnSelectSub";
            this.btUnSelectSub.Size = new System.Drawing.Size(100, 38);
            this.btUnSelectSub.TabIndex = 43;
            this.btUnSelectSub.Text = "<";
            this.btUnSelectSub.UseVisualStyleBackColor = true;
            this.btUnSelectSub.Click += new System.EventHandler(this.btUnSelectSub_Click);
            // 
            // btUnSelectAllSub
            // 
            this.btUnSelectAllSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btUnSelectAllSub.ForeColor = System.Drawing.Color.Red;
            this.btUnSelectAllSub.Location = new System.Drawing.Point(259, 575);
            this.btUnSelectAllSub.Margin = new System.Windows.Forms.Padding(4);
            this.btUnSelectAllSub.Name = "btUnSelectAllSub";
            this.btUnSelectAllSub.Size = new System.Drawing.Size(100, 38);
            this.btUnSelectAllSub.TabIndex = 44;
            this.btUnSelectAllSub.Text = "<<";
            this.btUnSelectAllSub.UseVisualStyleBackColor = true;
            this.btUnSelectAllSub.Click += new System.EventHandler(this.btUnSelectAllSub_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 665);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1108, 25);
            this.toolStrip1.TabIndex = 45;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbUsername
            // 
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(53, 22);
            this.tslbUsername.Text = "name?";
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(76, 22);
            this.tslbDateTime.Text = "datetime?";
            // 
            // lsbSubjectSelectedRegis
            // 
            this.lsbSubjectSelectedRegis.FormattingEnabled = true;
            this.lsbSubjectSelectedRegis.ItemHeight = 16;
            this.lsbSubjectSelectedRegis.Location = new System.Drawing.Point(431, 432);
            this.lsbSubjectSelectedRegis.Margin = new System.Windows.Forms.Padding(4);
            this.lsbSubjectSelectedRegis.Name = "lsbSubjectSelectedRegis";
            this.lsbSubjectSelectedRegis.Size = new System.Drawing.Size(159, 180);
            this.lsbSubjectSelectedRegis.TabIndex = 46;
            // 
            // tbNoRegis
            // 
            this.tbNoRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoRegis.Location = new System.Drawing.Point(375, 144);
            this.tbNoRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoRegis.Name = "tbNoRegis";
            this.tbNoRegis.Size = new System.Drawing.Size(297, 26);
            this.tbNoRegis.TabIndex = 48;
            // 
            // LabeStuId
            // 
            this.LabeStuId.AutoSize = true;
            this.LabeStuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabeStuId.Location = new System.Drawing.Point(371, 105);
            this.LabeStuId.Name = "LabeStuId";
            this.LabeStuId.Size = new System.Drawing.Size(164, 20);
            this.LabeStuId.TabIndex = 47;
            this.LabeStuId.Text = "เลขประจำตัวนักเรียน";
            // 
            // tbNameRegis
            // 
            this.tbNameRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameRegis.Location = new System.Drawing.Point(375, 241);
            this.tbNameRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNameRegis.Name = "tbNameRegis";
            this.tbNameRegis.Size = new System.Drawing.Size(297, 26);
            this.tbNameRegis.TabIndex = 52;
            // 
            // LabelFullname1
            // 
            this.LabelFullname1.AutoSize = true;
            this.LabelFullname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFullname1.Location = new System.Drawing.Point(371, 199);
            this.LabelFullname1.Name = "LabelFullname1";
            this.LabelFullname1.Size = new System.Drawing.Size(74, 20);
            this.LabelFullname1.TabIndex = 51;
            this.LabelFullname1.Text = "ชื่อ-สกุล ";
            // 
            // labelStuType
            // 
            this.labelStuType.AutoSize = true;
            this.labelStuType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStuType.Location = new System.Drawing.Point(371, 284);
            this.labelStuType.Name = "labelStuType";
            this.labelStuType.Size = new System.Drawing.Size(127, 20);
            this.labelStuType.TabIndex = 53;
            this.labelStuType.Text = "ประเภทนักเรียน";
            // 
            // rfFundRegis
            // 
            this.rfFundRegis.AutoSize = true;
            this.rfFundRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfFundRegis.Location = new System.Drawing.Point(551, 331);
            this.rfFundRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rfFundRegis.Name = "rfFundRegis";
            this.rfFundRegis.Size = new System.Drawing.Size(87, 24);
            this.rfFundRegis.TabIndex = 55;
            this.rfFundRegis.Text = "กองทุนฯ";
            this.rfFundRegis.UseVisualStyleBackColor = true;
            // 
            // rdNormalRegis
            // 
            this.rdNormalRegis.AutoSize = true;
            this.rdNormalRegis.Checked = true;
            this.rdNormalRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNormalRegis.Location = new System.Drawing.Point(417, 331);
            this.rdNormalRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNormalRegis.Name = "rdNormalRegis";
            this.rdNormalRegis.Size = new System.Drawing.Size(60, 24);
            this.rdNormalRegis.TabIndex = 54;
            this.rdNormalRegis.TabStop = true;
            this.rdNormalRegis.Text = "ปกติ";
            this.rdNormalRegis.UseVisualStyleBackColor = true;
            // 
            // btSelectImageRegis
            // 
            this.btSelectImageRegis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSelectImageRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btSelectImageRegis.Location = new System.Drawing.Point(1044, 333);
            this.btSelectImageRegis.Margin = new System.Windows.Forms.Padding(4);
            this.btSelectImageRegis.Name = "btSelectImageRegis";
            this.btSelectImageRegis.Size = new System.Drawing.Size(48, 43);
            this.btSelectImageRegis.TabIndex = 57;
            this.btSelectImageRegis.Text = "...";
            this.btSelectImageRegis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSelectImageRegis.UseVisualStyleBackColor = false;
            this.btSelectImageRegis.Click += new System.EventHandler(this.btSelectImageRegis_Click);
            // 
            // cbConfirmRegis
            // 
            this.cbConfirmRegis.AutoSize = true;
            this.cbConfirmRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfirmRegis.Location = new System.Drawing.Point(708, 442);
            this.cbConfirmRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbConfirmRegis.Name = "cbConfirmRegis";
            this.cbConfirmRegis.Size = new System.Drawing.Size(166, 24);
            this.cbConfirmRegis.TabIndex = 58;
            this.cbConfirmRegis.Text = "ยืนยันการลงทะเบียน";
            this.cbConfirmRegis.UseVisualStyleBackColor = true;
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(809, 14);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(160, 80);
            this.btMainMenu.TabIndex = 62;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = false;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Image = global::DTIWinformProject.Properties.Resources.exit3;
            this.btExit.Location = new System.Drawing.Point(708, 575);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(384, 60);
            this.btExit.TabIndex = 61;
            this.btExit.Text = "ปิดโปรแกรม";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(708, 507);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(384, 62);
            this.btCancel.TabIndex = 60;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btRegis
            // 
            this.btRegis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegis.Image = global::DTIWinformProject.Properties.Resources.add1;
            this.btRegis.Location = new System.Drawing.Point(868, 442);
            this.btRegis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegis.Name = "btRegis";
            this.btRegis.Size = new System.Drawing.Size(224, 60);
            this.btRegis.TabIndex = 59;
            this.btRegis.Text = "ลงทะเบียน";
            this.btRegis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRegis.UseVisualStyleBackColor = false;
            this.btRegis.Click += new System.EventHandler(this.btRegis_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbImageRegis
            // 
            this.pbImageRegis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageRegis.Location = new System.Drawing.Point(786, 121);
            this.pbImageRegis.Name = "pbImageRegis";
            this.pbImageRegis.Size = new System.Drawing.Size(197, 249);
            this.pbImageRegis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageRegis.TabIndex = 63;
            this.pbImageRegis.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmSAURegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 690);
            this.Controls.Add(this.pbImageRegis);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btRegis);
            this.Controls.Add(this.cbConfirmRegis);
            this.Controls.Add(this.btSelectImageRegis);
            this.Controls.Add(this.rfFundRegis);
            this.Controls.Add(this.rdNormalRegis);
            this.Controls.Add(this.labelStuType);
            this.Controls.Add(this.tbNameRegis);
            this.Controls.Add(this.LabelFullname1);
            this.Controls.Add(this.tbNoRegis);
            this.Controls.Add(this.LabeStuId);
            this.Controls.Add(this.lsbSubjectSelectedRegis);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btUnSelectAllSub);
            this.Controls.Add(this.btUnSelectSub);
            this.Controls.Add(this.btSelectAllSub);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.btSelectSub);
            this.Controls.Add(this.cbbLevelRegis);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelRegisDate);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.lsbSubjectRegis);
            this.Controls.Add(this.mcdRegis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSAURegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอSAURegister - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmSAURegister_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageRegis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcdRegis;
        private System.Windows.Forms.ListBox lsbSubjectRegis;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Label labelRegisDate;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.ComboBox cbbLevelRegis;
        private System.Windows.Forms.Button btSelectSub;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button btSelectAllSub;
        private System.Windows.Forms.Button btUnSelectSub;
        private System.Windows.Forms.Button btUnSelectAllSub;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.ListBox lsbSubjectSelectedRegis;
        private System.Windows.Forms.TextBox tbNoRegis;
        private System.Windows.Forms.Label LabeStuId;
        private System.Windows.Forms.TextBox tbNameRegis;
        private System.Windows.Forms.Label LabelFullname1;
        private System.Windows.Forms.Label labelStuType;
        private System.Windows.Forms.RadioButton rfFundRegis;
        private System.Windows.Forms.RadioButton rdNormalRegis;
        private System.Windows.Forms.Button btSelectImageRegis;
        private System.Windows.Forms.CheckBox cbConfirmRegis;
        private System.Windows.Forms.Button btRegis;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbImageRegis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}