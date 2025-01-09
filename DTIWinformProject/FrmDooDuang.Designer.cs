namespace DTIWinformProject
{
    partial class FrmDooDuang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDooDuang));
            this.groupPrivateInfo = new System.Windows.Forms.GroupBox();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.LabelidCard = new System.Windows.Forms.Label();
            this.maskedID = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LabelBirthDate = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelheight = new System.Windows.Forms.Label();
            this.numericUpDownW = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            this.labelWu = new System.Windows.Forms.Label();
            this.labelHu = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTendProgram = new System.Windows.Forms.Button();
            this.BTFind = new System.Windows.Forms.Button();
            this.BTNew = new System.Windows.Forms.Button();
            this.BTMainMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.labelH2 = new System.Windows.Forms.Label();
            this.LabelBirthDate2 = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelid2 = new System.Windows.Forms.Label();
            this.labelW2 = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelResultDuang = new System.Windows.Forms.Label();
            this.labelRid = new System.Windows.Forms.Label();
            this.labelRFullname = new System.Windows.Forms.Label();
            this.labelRBirthDate = new System.Windows.Forms.Label();
            this.labelRAge = new System.Windows.Forms.Label();
            this.labelRWeight = new System.Windows.Forms.Label();
            this.labelRHeight = new System.Windows.Forms.Label();
            this.LabelFullname1 = new System.Windows.Forms.Label();
            this.TFUsername = new System.Windows.Forms.TextBox();
            this.groupPrivateInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPrivateInfo
            // 
            this.groupPrivateInfo.Controls.Add(this.labelHu);
            this.groupPrivateInfo.Controls.Add(this.labelWu);
            this.groupPrivateInfo.Controls.Add(this.numericUpDownH);
            this.groupPrivateInfo.Controls.Add(this.numericUpDownW);
            this.groupPrivateInfo.Controls.Add(this.labelheight);
            this.groupPrivateInfo.Controls.Add(this.labelWeight);
            this.groupPrivateInfo.Controls.Add(this.dateTimePicker1);
            this.groupPrivateInfo.Controls.Add(this.LabelBirthDate);
            this.groupPrivateInfo.Controls.Add(this.TFUsername);
            this.groupPrivateInfo.Controls.Add(this.LabelFullname1);
            this.groupPrivateInfo.Controls.Add(this.maskedID);
            this.groupPrivateInfo.Controls.Add(this.LabelidCard);
            this.groupPrivateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPrivateInfo.Location = new System.Drawing.Point(78, 78);
            this.groupPrivateInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupPrivateInfo.Name = "groupPrivateInfo";
            this.groupPrivateInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupPrivateInfo.Size = new System.Drawing.Size(426, 255);
            this.groupPrivateInfo.TabIndex = 39;
            this.groupPrivateInfo.TabStop = false;
            this.groupPrivateInfo.Text = "ข้อมูลส่วนตัว";
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(73, 9);
            this.HeadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(466, 55);
            this.HeadLabel.TabIndex = 40;
            this.HeadLabel.Text = "ดูดวงแม่นๆ";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelidCard
            // 
            this.LabelidCard.AutoSize = true;
            this.LabelidCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelidCard.Location = new System.Drawing.Point(17, 37);
            this.LabelidCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelidCard.Name = "LabelidCard";
            this.LabelidCard.Size = new System.Drawing.Size(59, 16);
            this.LabelidCard.TabIndex = 16;
            this.LabelidCard.Text = "ID Card";
            // 
            // maskedID
            // 
            this.maskedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedID.Location = new System.Drawing.Point(103, 33);
            this.maskedID.Mask = "_-____-_____-__-_";
            this.maskedID.Name = "maskedID";
            this.maskedID.Size = new System.Drawing.Size(224, 22);
            this.maskedID.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 117);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // LabelBirthDate
            // 
            this.LabelBirthDate.AutoSize = true;
            this.LabelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBirthDate.Location = new System.Drawing.Point(16, 117);
            this.LabelBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBirthDate.Name = "LabelBirthDate";
            this.LabelBirthDate.Size = new System.Drawing.Size(67, 16);
            this.LabelBirthDate.TabIndex = 20;
            this.LabelBirthDate.Text = "ว/ด/ป เกิด ";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(16, 169);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(45, 16);
            this.labelWeight.TabIndex = 22;
            this.labelWeight.Text = "น้ำหนัก";
            // 
            // labelheight
            // 
            this.labelheight.AutoSize = true;
            this.labelheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheight.Location = new System.Drawing.Point(17, 203);
            this.labelheight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelheight.Name = "labelheight";
            this.labelheight.Size = new System.Drawing.Size(45, 16);
            this.labelheight.TabIndex = 23;
            this.labelheight.Text = "ส่วนสูง";
            // 
            // numericUpDownW
            // 
            this.numericUpDownW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownW.Location = new System.Drawing.Point(103, 169);
            this.numericUpDownW.Name = "numericUpDownW";
            this.numericUpDownW.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownW.TabIndex = 24;
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownH.Location = new System.Drawing.Point(103, 203);
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownH.TabIndex = 25;
            // 
            // labelWu
            // 
            this.labelWu.AutoSize = true;
            this.labelWu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWu.Location = new System.Drawing.Point(254, 175);
            this.labelWu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWu.Name = "labelWu";
            this.labelWu.Size = new System.Drawing.Size(49, 16);
            this.labelWu.TabIndex = 26;
            this.labelWu.Text = "กิโลกรัม";
            // 
            // labelHu
            // 
            this.labelHu.AutoSize = true;
            this.labelHu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHu.Location = new System.Drawing.Point(254, 209);
            this.labelHu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHu.Name = "labelHu";
            this.labelHu.Size = new System.Drawing.Size(62, 16);
            this.labelHu.TabIndex = 27;
            this.labelHu.Text = "เซนติเมตร";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 521);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(973, 25);
            this.toolStrip1.TabIndex = 44;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(305, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 172);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // BTendProgram
            // 
            this.BTendProgram.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTendProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTendProgram.Image = global::DTIWinformProject.Properties.Resources.exit3;
            this.BTendProgram.Location = new System.Drawing.Point(78, 452);
            this.BTendProgram.Margin = new System.Windows.Forms.Padding(2);
            this.BTendProgram.Name = "BTendProgram";
            this.BTendProgram.Size = new System.Drawing.Size(168, 49);
            this.BTendProgram.TabIndex = 45;
            this.BTendProgram.Text = "จบโปรแกรม";
            this.BTendProgram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTendProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTendProgram.UseVisualStyleBackColor = false;
            // 
            // BTFind
            // 
            this.BTFind.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTFind.Image = global::DTIWinformProject.Properties.Resources.find1;
            this.BTFind.Location = new System.Drawing.Point(78, 399);
            this.BTFind.Margin = new System.Windows.Forms.Padding(2);
            this.BTFind.Name = "BTFind";
            this.BTFind.Size = new System.Drawing.Size(168, 49);
            this.BTFind.TabIndex = 43;
            this.BTFind.Text = "ดูดวง";
            this.BTFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTFind.UseVisualStyleBackColor = false;
            // 
            // BTNew
            // 
            this.BTNew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNew.Image = global::DTIWinformProject.Properties.Resources.new1;
            this.BTNew.Location = new System.Drawing.Point(78, 346);
            this.BTNew.Margin = new System.Windows.Forms.Padding(2);
            this.BTNew.Name = "BTNew";
            this.BTNew.Size = new System.Drawing.Size(168, 49);
            this.BTNew.TabIndex = 42;
            this.BTNew.Text = "ใหม่";
            this.BTNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNew.UseVisualStyleBackColor = false;
            // 
            // BTMainMenu
            // 
            this.BTMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.BTMainMenu.Location = new System.Drawing.Point(607, 9);
            this.BTMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BTMainMenu.Name = "BTMainMenu";
            this.BTMainMenu.Size = new System.Drawing.Size(120, 65);
            this.BTMainMenu.TabIndex = 41;
            this.BTMainMenu.Text = "หน้าจอหลัก";
            this.BTMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTMainMenu.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DTIWinformProject.Properties.Resources.marvel1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(163, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupResult
            // 
            this.groupResult.Controls.Add(this.labelRHeight);
            this.groupResult.Controls.Add(this.labelRWeight);
            this.groupResult.Controls.Add(this.labelRAge);
            this.groupResult.Controls.Add(this.labelRBirthDate);
            this.groupResult.Controls.Add(this.labelRFullname);
            this.groupResult.Controls.Add(this.labelRid);
            this.groupResult.Controls.Add(this.labelResultDuang);
            this.groupResult.Controls.Add(this.labelAge);
            this.groupResult.Controls.Add(this.labelW2);
            this.groupResult.Controls.Add(this.labelH2);
            this.groupResult.Controls.Add(this.LabelBirthDate2);
            this.groupResult.Controls.Add(this.labelFullname);
            this.groupResult.Controls.Add(this.labelid2);
            this.groupResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupResult.Location = new System.Drawing.Point(536, 78);
            this.groupResult.Margin = new System.Windows.Forms.Padding(2);
            this.groupResult.Name = "groupResult";
            this.groupResult.Padding = new System.Windows.Forms.Padding(2);
            this.groupResult.Size = new System.Drawing.Size(426, 440);
            this.groupResult.TabIndex = 40;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "ข้อมูลส่วนตัว";
            // 
            // labelH2
            // 
            this.labelH2.AutoSize = true;
            this.labelH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH2.Location = new System.Drawing.Point(16, 268);
            this.labelH2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelH2.Name = "labelH2";
            this.labelH2.Size = new System.Drawing.Size(45, 16);
            this.labelH2.TabIndex = 23;
            this.labelH2.Text = "ส่วนสูง";
            // 
            // LabelBirthDate2
            // 
            this.LabelBirthDate2.AutoSize = true;
            this.LabelBirthDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBirthDate2.Location = new System.Drawing.Point(16, 123);
            this.LabelBirthDate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBirthDate2.Name = "LabelBirthDate2";
            this.LabelBirthDate2.Size = new System.Drawing.Size(67, 16);
            this.LabelBirthDate2.TabIndex = 20;
            this.LabelBirthDate2.Text = "ว/ด/ป เกิด ";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.Location = new System.Drawing.Point(17, 76);
            this.labelFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(53, 16);
            this.labelFullname.TabIndex = 18;
            this.labelFullname.Text = "ชื่อ-สกุล ";
            // 
            // labelid2
            // 
            this.labelid2.AutoSize = true;
            this.labelid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid2.Location = new System.Drawing.Point(17, 37);
            this.labelid2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelid2.Name = "labelid2";
            this.labelid2.Size = new System.Drawing.Size(59, 16);
            this.labelid2.TabIndex = 16;
            this.labelid2.Text = "ID Card";
            // 
            // labelW2
            // 
            this.labelW2.AutoSize = true;
            this.labelW2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW2.Location = new System.Drawing.Point(16, 221);
            this.labelW2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelW2.Name = "labelW2";
            this.labelW2.Size = new System.Drawing.Size(45, 16);
            this.labelW2.TabIndex = 24;
            this.labelW2.Text = "น้ำหนัก";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(17, 171);
            this.labelAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(27, 16);
            this.labelAge.TabIndex = 25;
            this.labelAge.Text = "อายุ";
            // 
            // labelResultDuang
            // 
            this.labelResultDuang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelResultDuang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultDuang.ForeColor = System.Drawing.Color.MediumOrchid;
            this.labelResultDuang.Location = new System.Drawing.Point(30, 321);
            this.labelResultDuang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultDuang.Name = "labelResultDuang";
            this.labelResultDuang.Size = new System.Drawing.Size(381, 85);
            this.labelResultDuang.TabIndex = 47;
            this.labelResultDuang.Text = "ผลดวง";
            this.labelResultDuang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResultDuang.Click += new System.EventHandler(this.labelResultDuang_Click);
            // 
            // labelRid
            // 
            this.labelRid.AutoSize = true;
            this.labelRid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRid.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelRid.Location = new System.Drawing.Point(132, 39);
            this.labelRid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRid.Name = "labelRid";
            this.labelRid.Size = new System.Drawing.Size(97, 16);
            this.labelRid.TabIndex = 48;
            this.labelRid.Text = "XXXXXXXXXX";
            // 
            // labelRFullname
            // 
            this.labelRFullname.AutoSize = true;
            this.labelRFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRFullname.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelRFullname.Location = new System.Drawing.Point(132, 82);
            this.labelRFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRFullname.Name = "labelRFullname";
            this.labelRFullname.Size = new System.Drawing.Size(97, 16);
            this.labelRFullname.TabIndex = 49;
            this.labelRFullname.Text = "XXXXXXXXXX";
            // 
            // labelRBirthDate
            // 
            this.labelRBirthDate.AutoSize = true;
            this.labelRBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRBirthDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelRBirthDate.Location = new System.Drawing.Point(132, 123);
            this.labelRBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRBirthDate.Name = "labelRBirthDate";
            this.labelRBirthDate.Size = new System.Drawing.Size(97, 16);
            this.labelRBirthDate.TabIndex = 50;
            this.labelRBirthDate.Text = "XXXXXXXXXX";
            // 
            // labelRAge
            // 
            this.labelRAge.AutoSize = true;
            this.labelRAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAge.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelRAge.Location = new System.Drawing.Point(132, 175);
            this.labelRAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRAge.Name = "labelRAge";
            this.labelRAge.Size = new System.Drawing.Size(97, 16);
            this.labelRAge.TabIndex = 51;
            this.labelRAge.Text = "XXXXXXXXXX";
            // 
            // labelRWeight
            // 
            this.labelRWeight.AutoSize = true;
            this.labelRWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRWeight.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelRWeight.Location = new System.Drawing.Point(132, 221);
            this.labelRWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRWeight.Name = "labelRWeight";
            this.labelRWeight.Size = new System.Drawing.Size(97, 16);
            this.labelRWeight.TabIndex = 52;
            this.labelRWeight.Text = "XXXXXXXXXX";
            // 
            // labelRHeight
            // 
            this.labelRHeight.AutoSize = true;
            this.labelRHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRHeight.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelRHeight.Location = new System.Drawing.Point(132, 268);
            this.labelRHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRHeight.Name = "labelRHeight";
            this.labelRHeight.Size = new System.Drawing.Size(97, 16);
            this.labelRHeight.TabIndex = 53;
            this.labelRHeight.Text = "XXXXXXXXXX";
            // 
            // LabelFullname1
            // 
            this.LabelFullname1.AutoSize = true;
            this.LabelFullname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFullname1.Location = new System.Drawing.Point(27, 76);
            this.LabelFullname1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFullname1.Name = "LabelFullname1";
            this.LabelFullname1.Size = new System.Drawing.Size(53, 16);
            this.LabelFullname1.TabIndex = 18;
            this.LabelFullname1.Text = "ชื่อ-สกุล ";
            // 
            // TFUsername
            // 
            this.TFUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFUsername.Location = new System.Drawing.Point(103, 76);
            this.TFUsername.Margin = new System.Windows.Forms.Padding(2);
            this.TFUsername.Name = "TFUsername";
            this.TFUsername.Size = new System.Drawing.Size(224, 22);
            this.TFUsername.TabIndex = 19;
            // 
            // FrmDooDuang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 546);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTendProgram);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BTFind);
            this.Controls.Add(this.BTNew);
            this.Controls.Add(this.BTMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.groupPrivateInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDooDuang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอDooDuang - DTI Soft V.1.0";
            this.groupPrivateInfo.ResumeLayout(false);
            this.groupPrivateInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPrivateInfo;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button BTMainMenu;
        private System.Windows.Forms.MaskedTextBox maskedID;
        private System.Windows.Forms.Label LabelidCard;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LabelBirthDate;
        private System.Windows.Forms.Label labelHu;
        private System.Windows.Forms.Label labelWu;
        private System.Windows.Forms.NumericUpDown numericUpDownH;
        private System.Windows.Forms.NumericUpDown numericUpDownW;
        private System.Windows.Forms.Label labelheight;
        private System.Windows.Forms.Button BTNew;
        private System.Windows.Forms.Button BTFind;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button BTendProgram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelW2;
        private System.Windows.Forms.Label labelH2;
        private System.Windows.Forms.Label LabelBirthDate2;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelid2;
        private System.Windows.Forms.Label labelRHeight;
        private System.Windows.Forms.Label labelRWeight;
        private System.Windows.Forms.Label labelRAge;
        private System.Windows.Forms.Label labelRBirthDate;
        private System.Windows.Forms.Label labelRFullname;
        private System.Windows.Forms.Label labelRid;
        private System.Windows.Forms.Label labelResultDuang;
        private System.Windows.Forms.TextBox TFUsername;
        private System.Windows.Forms.Label LabelFullname1;
    }
}