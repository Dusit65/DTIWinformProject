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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSAURegister));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBoxSubject = new System.Windows.Forms.ListBox();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.labelRegisDate = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.CBBSemester = new System.Windows.Forms.ComboBox();
            this.BTNext = new System.Windows.Forms.Button();
            this.labelSubject = new System.Windows.Forms.Label();
            this.BTdoubleN = new System.Windows.Forms.Button();
            this.BTBack = new System.Windows.Forms.Button();
            this.BTdoubleback = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.d = new System.Windows.Forms.ListBox();
            this.TFStuId = new System.Windows.Forms.TextBox();
            this.LabeStuId = new System.Windows.Forms.Label();
            this.TFFullname = new System.Windows.Forms.TextBox();
            this.LabelFullname1 = new System.Windows.Forms.Label();
            this.labelStuType = new System.Windows.Forms.Label();
            this.radioSpecial = new System.Windows.Forms.RadioButton();
            this.radioNormal = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAccept = new System.Windows.Forms.CheckBox();
            this.BTMainMenu = new System.Windows.Forms.Button();
            this.BTendProgram = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            this.BTSignin = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(52, 98);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBoxSubject
            // 
            this.listBoxSubject.FormattingEnabled = true;
            this.listBoxSubject.Items.AddRange(new object[] {
            "ภาษาไทย",
            "ภาษาอังกฤษ",
            "ภาษาญี่ปุ่น",
            "ภาษาจีน",
            "สังคมศึกษา",
            "คณิตศาสตร์",
            "พลศึกษา",
            "ประวัติศาสตร์",
            "คอมพิวเตอร์เบื้องต้น",
            "บัญชีเบื้องต้น"});
            this.listBoxSubject.Location = new System.Drawing.Point(52, 351);
            this.listBoxSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSubject.Name = "listBoxSubject";
            this.listBoxSubject.Size = new System.Drawing.Size(121, 147);
            this.listBoxSubject.TabIndex = 1;
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(47, 9);
            this.HeadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(510, 65);
            this.HeadLabel.TabIndex = 35;
            this.HeadLabel.Text = "ลงทะเบียน";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegisDate
            // 
            this.labelRegisDate.AutoSize = true;
            this.labelRegisDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisDate.Location = new System.Drawing.Point(49, 75);
            this.labelRegisDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegisDate.Name = "labelRegisDate";
            this.labelRegisDate.Size = new System.Drawing.Size(88, 16);
            this.labelRegisDate.TabIndex = 37;
            this.labelRegisDate.Text = "วันที่ลงทะเบียน";
            this.labelRegisDate.Click += new System.EventHandler(this.labelRegisDate_Click);
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(49, 267);
            this.labelSemester.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(53, 16);
            this.labelSemester.TabIndex = 38;
            this.labelSemester.Text = "ระดับชั้น";
            // 
            // CBBSemester
            // 
            this.CBBSemester.FormattingEnabled = true;
            this.CBBSemester.Items.AddRange(new object[] {
            "ชั้นมัธยมศึกษาปีที่ 1",
            "ชั้นมัธยมศึกษาปีที่ 2",
            "ชั้นมัธยมศึกษาปีที่ 3",
            "ชั้นมัธยมศึกษาปีที่ 4",
            "ชั้นมัธยมศึกษาปีที่ 5",
            "ชั้นมัธยมศึกษาปีที่ 6"});
            this.CBBSemester.Location = new System.Drawing.Point(52, 286);
            this.CBBSemester.Name = "CBBSemester";
            this.CBBSemester.Size = new System.Drawing.Size(121, 21);
            this.CBBSemester.TabIndex = 39;
            // 
            // BTNext
            // 
            this.BTNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTNext.ForeColor = System.Drawing.Color.Lime;
            this.BTNext.Location = new System.Drawing.Point(194, 351);
            this.BTNext.Name = "BTNext";
            this.BTNext.Size = new System.Drawing.Size(75, 31);
            this.BTNext.TabIndex = 40;
            this.BTNext.Text = ">";
            this.BTNext.UseVisualStyleBackColor = true;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(49, 333);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(94, 16);
            this.labelSubject.TabIndex = 41;
            this.labelSubject.Text = "วิชาที่ลงทะเบียน";
            // 
            // BTdoubleN
            // 
            this.BTdoubleN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTdoubleN.ForeColor = System.Drawing.Color.Lime;
            this.BTdoubleN.Location = new System.Drawing.Point(194, 388);
            this.BTdoubleN.Name = "BTdoubleN";
            this.BTdoubleN.Size = new System.Drawing.Size(75, 31);
            this.BTdoubleN.TabIndex = 42;
            this.BTdoubleN.Text = ">>";
            this.BTdoubleN.UseVisualStyleBackColor = true;
            // 
            // BTBack
            // 
            this.BTBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTBack.ForeColor = System.Drawing.Color.Red;
            this.BTBack.Location = new System.Drawing.Point(194, 425);
            this.BTBack.Name = "BTBack";
            this.BTBack.Size = new System.Drawing.Size(75, 31);
            this.BTBack.TabIndex = 43;
            this.BTBack.Text = "<";
            this.BTBack.UseVisualStyleBackColor = true;
            // 
            // BTdoubleback
            // 
            this.BTdoubleback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BTdoubleback.ForeColor = System.Drawing.Color.Red;
            this.BTdoubleback.Location = new System.Drawing.Point(194, 467);
            this.BTdoubleback.Name = "BTdoubleback";
            this.BTdoubleback.Size = new System.Drawing.Size(75, 31);
            this.BTdoubleback.TabIndex = 44;
            this.BTdoubleback.Text = "<<";
            this.BTdoubleback.UseVisualStyleBackColor = true;
            this.BTdoubleback.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 536);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 25);
            this.toolStrip1.TabIndex = 45;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "name?";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "datetime?";
            // 
            // d
            // 
            this.d.FormattingEnabled = true;
            this.d.Location = new System.Drawing.Point(340, 351);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(120, 147);
            this.d.TabIndex = 46;
            // 
            // TFStuId
            // 
            this.TFStuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFStuId.Location = new System.Drawing.Point(281, 117);
            this.TFStuId.Margin = new System.Windows.Forms.Padding(2);
            this.TFStuId.Name = "TFStuId";
            this.TFStuId.Size = new System.Drawing.Size(224, 22);
            this.TFStuId.TabIndex = 48;
            this.TFStuId.TextChanged += new System.EventHandler(this.TFUsername_TextChanged);
            // 
            // LabeStuId
            // 
            this.LabeStuId.AutoSize = true;
            this.LabeStuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabeStuId.Location = new System.Drawing.Point(278, 85);
            this.LabeStuId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabeStuId.Name = "LabeStuId";
            this.LabeStuId.Size = new System.Drawing.Size(117, 16);
            this.LabeStuId.TabIndex = 47;
            this.LabeStuId.Text = "เลขประจำตัวนักเรียน";
            this.LabeStuId.Click += new System.EventHandler(this.LabelFullname1_Click);
            // 
            // TFFullname
            // 
            this.TFFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFFullname.Location = new System.Drawing.Point(281, 196);
            this.TFFullname.Margin = new System.Windows.Forms.Padding(2);
            this.TFFullname.Name = "TFFullname";
            this.TFFullname.Size = new System.Drawing.Size(224, 22);
            this.TFFullname.TabIndex = 52;
            // 
            // LabelFullname1
            // 
            this.LabelFullname1.AutoSize = true;
            this.LabelFullname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFullname1.Location = new System.Drawing.Point(278, 162);
            this.LabelFullname1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFullname1.Name = "LabelFullname1";
            this.LabelFullname1.Size = new System.Drawing.Size(53, 16);
            this.LabelFullname1.TabIndex = 51;
            this.LabelFullname1.Text = "ชื่อ-สกุล ";
            // 
            // labelStuType
            // 
            this.labelStuType.AutoSize = true;
            this.labelStuType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStuType.Location = new System.Drawing.Point(278, 231);
            this.labelStuType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStuType.Name = "labelStuType";
            this.labelStuType.Size = new System.Drawing.Size(91, 16);
            this.labelStuType.TabIndex = 53;
            this.labelStuType.Text = "ประเภทนักเรียน";
            // 
            // radioSpecial
            // 
            this.radioSpecial.AutoSize = true;
            this.radioSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSpecial.Location = new System.Drawing.Point(410, 269);
            this.radioSpecial.Margin = new System.Windows.Forms.Padding(2);
            this.radioSpecial.Name = "radioSpecial";
            this.radioSpecial.Size = new System.Drawing.Size(64, 20);
            this.radioSpecial.TabIndex = 55;
            this.radioSpecial.Text = "กองทุนฯ";
            this.radioSpecial.UseVisualStyleBackColor = true;
            // 
            // radioNormal
            // 
            this.radioNormal.AutoSize = true;
            this.radioNormal.Checked = true;
            this.radioNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNormal.Location = new System.Drawing.Point(313, 269);
            this.radioNormal.Margin = new System.Windows.Forms.Padding(2);
            this.radioNormal.Name = "radioNormal";
            this.radioNormal.Size = new System.Drawing.Size(45, 20);
            this.radioNormal.TabIndex = 54;
            this.radioNormal.TabStop = true;
            this.radioNormal.Text = "ปกติ";
            this.radioNormal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(531, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 243);
            this.panel1.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(783, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 57;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // checkBoxAccept
            // 
            this.checkBoxAccept.AutoSize = true;
            this.checkBoxAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAccept.Location = new System.Drawing.Point(531, 359);
            this.checkBoxAccept.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAccept.Name = "checkBoxAccept";
            this.checkBoxAccept.Size = new System.Drawing.Size(118, 20);
            this.checkBoxAccept.TabIndex = 58;
            this.checkBoxAccept.Text = "ยืนยันการลงทะเบียน";
            this.checkBoxAccept.UseVisualStyleBackColor = true;
            // 
            // BTMainMenu
            // 
            this.BTMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.BTMainMenu.Location = new System.Drawing.Point(607, 11);
            this.BTMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BTMainMenu.Name = "BTMainMenu";
            this.BTMainMenu.Size = new System.Drawing.Size(120, 65);
            this.BTMainMenu.TabIndex = 62;
            this.BTMainMenu.Text = "หน้าจอหลัก";
            this.BTMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTMainMenu.UseVisualStyleBackColor = false;
            // 
            // BTendProgram
            // 
            this.BTendProgram.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTendProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTendProgram.Image = global::DTIWinformProject.Properties.Resources.exit3;
            this.BTendProgram.Location = new System.Drawing.Point(531, 467);
            this.BTendProgram.Margin = new System.Windows.Forms.Padding(2);
            this.BTendProgram.Name = "BTendProgram";
            this.BTendProgram.Size = new System.Drawing.Size(288, 49);
            this.BTendProgram.TabIndex = 61;
            this.BTendProgram.Text = "ปิดโปรแกรม";
            this.BTendProgram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTendProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTendProgram.UseVisualStyleBackColor = false;
            // 
            // BTCancel
            // 
            this.BTCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.BTCancel.Location = new System.Drawing.Point(531, 412);
            this.BTCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(288, 50);
            this.BTCancel.TabIndex = 60;
            this.BTCancel.Text = "ยกเลิก";
            this.BTCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTCancel.UseVisualStyleBackColor = false;
            // 
            // BTSignin
            // 
            this.BTSignin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSignin.Image = global::DTIWinformProject.Properties.Resources.add1;
            this.BTSignin.Location = new System.Drawing.Point(651, 359);
            this.BTSignin.Margin = new System.Windows.Forms.Padding(2);
            this.BTSignin.Name = "BTSignin";
            this.BTSignin.Size = new System.Drawing.Size(168, 49);
            this.BTSignin.TabIndex = 59;
            this.BTSignin.Text = "ลงทะเบียน";
            this.BTSignin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTSignin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTSignin.UseVisualStyleBackColor = false;
            // 
            // FrmSAURegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 561);
            this.Controls.Add(this.BTMainMenu);
            this.Controls.Add(this.BTendProgram);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.BTSignin);
            this.Controls.Add(this.checkBoxAccept);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioSpecial);
            this.Controls.Add(this.radioNormal);
            this.Controls.Add(this.labelStuType);
            this.Controls.Add(this.TFFullname);
            this.Controls.Add(this.LabelFullname1);
            this.Controls.Add(this.TFStuId);
            this.Controls.Add(this.LabeStuId);
            this.Controls.Add(this.d);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BTdoubleback);
            this.Controls.Add(this.BTBack);
            this.Controls.Add(this.BTdoubleN);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.BTNext);
            this.Controls.Add(this.CBBSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelRegisDate);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.listBoxSubject);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSAURegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอSAURegister - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmSAURegister_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBoxSubject;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Label labelRegisDate;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.ComboBox CBBSemester;
        private System.Windows.Forms.Button BTNext;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button BTdoubleN;
        private System.Windows.Forms.Button BTBack;
        private System.Windows.Forms.Button BTdoubleback;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ListBox d;
        private System.Windows.Forms.TextBox TFStuId;
        private System.Windows.Forms.Label LabeStuId;
        private System.Windows.Forms.TextBox TFFullname;
        private System.Windows.Forms.Label LabelFullname1;
        private System.Windows.Forms.Label labelStuType;
        private System.Windows.Forms.RadioButton radioSpecial;
        private System.Windows.Forms.RadioButton radioNormal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAccept;
        private System.Windows.Forms.Button BTSignin;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.Button BTendProgram;
        private System.Windows.Forms.Button BTMainMenu;
    }
}