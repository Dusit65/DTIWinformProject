namespace DTIWinformProject
{
    partial class FrmShapeArea
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelResult = new System.Windows.Forms.Label();
            this.lbCircleShow = new System.Windows.Forms.Label();
            this.btCircleCancel = new System.Windows.Forms.Button();
            this.btCircleCal = new System.Windows.Forms.Button();
            this.rdCircleRound = new System.Windows.Forms.RadioButton();
            this.rdCircleArea = new System.Windows.Forms.RadioButton();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.LabeStuId = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbRectHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRectShow = new System.Windows.Forms.Label();
            this.btRectCancel = new System.Windows.Forms.Button();
            this.btRectCal = new System.Windows.Forms.Button();
            this.rdRectRound = new System.Windows.Forms.RadioButton();
            this.rdRectArea = new System.Windows.Forms.RadioButton();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbSideAngle = new System.Windows.Forms.TextBox();
            this.labelOpppsite = new System.Windows.Forms.Label();
            this.tbTriHeight = new System.Windows.Forms.TextBox();
            this.labelHeight2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTriShow = new System.Windows.Forms.Label();
            this.btTriCancel = new System.Windows.Forms.Button();
            this.btTriCal = new System.Windows.Forms.Button();
            this.rdTriRound = new System.Windows.Forms.RadioButton();
            this.rdTriArea = new System.Windows.Forms.RadioButton();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.labelBase = new System.Windows.Forms.Label();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(63, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelResult);
            this.tabPage1.Controls.Add(this.lbCircleShow);
            this.tabPage1.Controls.Add(this.btCircleCancel);
            this.tabPage1.Controls.Add(this.btCircleCal);
            this.tabPage1.Controls.Add(this.rdCircleRound);
            this.tabPage1.Controls.Add(this.rdCircleArea);
            this.tabPage1.Controls.Add(this.tbRadius);
            this.tabPage1.Controls.Add(this.LabeStuId);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วงกลม";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(50, 233);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(57, 20);
            this.labelResult.TabIndex = 61;
            this.labelResult.Text = "ผลลัพธ์";
            // 
            // lbCircleShow
            // 
            this.lbCircleShow.BackColor = System.Drawing.Color.Yellow;
            this.lbCircleShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCircleShow.ForeColor = System.Drawing.Color.Red;
            this.lbCircleShow.Location = new System.Drawing.Point(34, 282);
            this.lbCircleShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCircleShow.Name = "lbCircleShow";
            this.lbCircleShow.Size = new System.Drawing.Size(272, 53);
            this.lbCircleShow.TabIndex = 60;
            this.lbCircleShow.Text = "0.00";
            this.lbCircleShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCircleCancel
            // 
            this.btCircleCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCircleCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCircleCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btCircleCancel.Location = new System.Drawing.Point(478, 233);
            this.btCircleCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCircleCancel.Name = "btCircleCancel";
            this.btCircleCancel.Size = new System.Drawing.Size(94, 64);
            this.btCircleCancel.TabIndex = 57;
            this.btCircleCancel.Text = "ยกเลิก";
            this.btCircleCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCircleCancel.UseVisualStyleBackColor = false;
            this.btCircleCancel.Click += new System.EventHandler(this.btCircleCancel_Click);
            // 
            // btCircleCal
            // 
            this.btCircleCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCircleCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCircleCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btCircleCal.Location = new System.Drawing.Point(478, 157);
            this.btCircleCal.Margin = new System.Windows.Forms.Padding(2);
            this.btCircleCal.Name = "btCircleCal";
            this.btCircleCal.Size = new System.Drawing.Size(94, 64);
            this.btCircleCal.TabIndex = 59;
            this.btCircleCal.Text = "คำนวณ";
            this.btCircleCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCircleCal.UseVisualStyleBackColor = false;
            this.btCircleCal.Click += new System.EventHandler(this.btCircleCal_Click);
            // 
            // rdCircleRound
            // 
            this.rdCircleRound.AutoSize = true;
            this.rdCircleRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCircleRound.Location = new System.Drawing.Point(39, 178);
            this.rdCircleRound.Margin = new System.Windows.Forms.Padding(2);
            this.rdCircleRound.Name = "rdCircleRound";
            this.rdCircleRound.Size = new System.Drawing.Size(84, 22);
            this.rdCircleRound.TabIndex = 56;
            this.rdCircleRound.Text = "เส้นรอบวง";
            this.rdCircleRound.UseVisualStyleBackColor = true;
            // 
            // rdCircleArea
            // 
            this.rdCircleArea.AutoSize = true;
            this.rdCircleArea.Checked = true;
            this.rdCircleArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCircleArea.Location = new System.Drawing.Point(39, 127);
            this.rdCircleArea.Margin = new System.Windows.Forms.Padding(2);
            this.rdCircleArea.Name = "rdCircleArea";
            this.rdCircleArea.Size = new System.Drawing.Size(91, 22);
            this.rdCircleArea.TabIndex = 55;
            this.rdCircleArea.TabStop = true;
            this.rdCircleArea.Text = "พื้นที่วงกลม";
            this.rdCircleArea.UseVisualStyleBackColor = true;
            // 
            // tbRadius
            // 
            this.tbRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRadius.Location = new System.Drawing.Point(39, 58);
            this.tbRadius.Margin = new System.Windows.Forms.Padding(2);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(224, 22);
            this.tbRadius.TabIndex = 50;
            this.tbRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRadius_KeyPress);
            // 
            // LabeStuId
            // 
            this.LabeStuId.AutoSize = true;
            this.LabeStuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabeStuId.Location = new System.Drawing.Point(36, 26);
            this.LabeStuId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabeStuId.Name = "LabeStuId";
            this.LabeStuId.Size = new System.Drawing.Size(53, 16);
            this.LabeStuId.TabIndex = 49;
            this.LabeStuId.Text = "ป้อนรัศมี";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbRectHeight);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lbRectShow);
            this.tabPage2.Controls.Add(this.btRectCancel);
            this.tabPage2.Controls.Add(this.btRectCal);
            this.tabPage2.Controls.Add(this.rdRectRound);
            this.tabPage2.Controls.Add(this.rdRectArea);
            this.tabPage2.Controls.Add(this.tbWidth);
            this.tabPage2.Controls.Add(this.labelWidth);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "สี่เหลี่ยม";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbRectHeight
            // 
            this.tbRectHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRectHeight.Location = new System.Drawing.Point(261, 59);
            this.tbRectHeight.Margin = new System.Windows.Forms.Padding(2);
            this.tbRectHeight.Name = "tbRectHeight";
            this.tbRectHeight.Size = new System.Drawing.Size(146, 22);
            this.tbRectHeight.TabIndex = 71;
            this.tbRectHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRectHeight_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "ป้อนสูง";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "ผลลัพธ์";
            // 
            // lbRectShow
            // 
            this.lbRectShow.BackColor = System.Drawing.Color.Yellow;
            this.lbRectShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRectShow.ForeColor = System.Drawing.Color.Red;
            this.lbRectShow.Location = new System.Drawing.Point(86, 284);
            this.lbRectShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRectShow.Name = "lbRectShow";
            this.lbRectShow.Size = new System.Drawing.Size(272, 53);
            this.lbRectShow.TabIndex = 68;
            this.lbRectShow.Text = "0.00";
            this.lbRectShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRectCancel
            // 
            this.btRectCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btRectCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRectCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btRectCancel.Location = new System.Drawing.Point(515, 235);
            this.btRectCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btRectCancel.Name = "btRectCancel";
            this.btRectCancel.Size = new System.Drawing.Size(94, 64);
            this.btRectCancel.TabIndex = 66;
            this.btRectCancel.Text = "ยกเลิก";
            this.btRectCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRectCancel.UseVisualStyleBackColor = false;
            this.btRectCancel.Click += new System.EventHandler(this.btRectCancel_Click);
            // 
            // btRectCal
            // 
            this.btRectCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btRectCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRectCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btRectCal.Location = new System.Drawing.Point(515, 159);
            this.btRectCal.Margin = new System.Windows.Forms.Padding(2);
            this.btRectCal.Name = "btRectCal";
            this.btRectCal.Size = new System.Drawing.Size(94, 64);
            this.btRectCal.TabIndex = 67;
            this.btRectCal.Text = "คำนวณ";
            this.btRectCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRectCal.UseVisualStyleBackColor = false;
            this.btRectCal.Click += new System.EventHandler(this.btRectCal_Click);
            // 
            // rdRectRound
            // 
            this.rdRectRound.AutoSize = true;
            this.rdRectRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRectRound.Location = new System.Drawing.Point(76, 180);
            this.rdRectRound.Margin = new System.Windows.Forms.Padding(2);
            this.rdRectRound.Name = "rdRectRound";
            this.rdRectRound.Size = new System.Drawing.Size(116, 22);
            this.rdRectRound.TabIndex = 65;
            this.rdRectRound.Text = "เส้นรอบสี่เหลี่ยม";
            this.rdRectRound.UseVisualStyleBackColor = true;
            // 
            // rdRectArea
            // 
            this.rdRectArea.AutoSize = true;
            this.rdRectArea.Checked = true;
            this.rdRectArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRectArea.Location = new System.Drawing.Point(76, 129);
            this.rdRectArea.Margin = new System.Windows.Forms.Padding(2);
            this.rdRectArea.Name = "rdRectArea";
            this.rdRectArea.Size = new System.Drawing.Size(99, 22);
            this.rdRectArea.TabIndex = 64;
            this.rdRectArea.TabStop = true;
            this.rdRectArea.Text = "พื้นที่สี่เหลี่ยม";
            this.rdRectArea.UseVisualStyleBackColor = true;
            // 
            // tbWidth
            // 
            this.tbWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWidth.Location = new System.Drawing.Point(76, 59);
            this.tbWidth.Margin = new System.Windows.Forms.Padding(2);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(146, 22);
            this.tbWidth.TabIndex = 63;
            this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidth_KeyPress);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(73, 28);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(57, 16);
            this.labelWidth.TabIndex = 62;
            this.labelWidth.Text = "ป้อนกว้าง";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbSideAngle);
            this.tabPage3.Controls.Add(this.labelOpppsite);
            this.tabPage3.Controls.Add(this.tbTriHeight);
            this.tabPage3.Controls.Add(this.labelHeight2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.lbTriShow);
            this.tabPage3.Controls.Add(this.btTriCancel);
            this.tabPage3.Controls.Add(this.btTriCal);
            this.tabPage3.Controls.Add(this.rdTriRound);
            this.tabPage3.Controls.Add(this.rdTriArea);
            this.tabPage3.Controls.Add(this.tbBase);
            this.tabPage3.Controls.Add(this.labelBase);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(682, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "สามเหลี่ยมมุมฉาก";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbSideAngle
            // 
            this.tbSideAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSideAngle.Location = new System.Drawing.Point(454, 59);
            this.tbSideAngle.Margin = new System.Windows.Forms.Padding(2);
            this.tbSideAngle.Name = "tbSideAngle";
            this.tbSideAngle.Size = new System.Drawing.Size(146, 22);
            this.tbSideAngle.TabIndex = 83;
            this.tbSideAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSideAngle_KeyPress);
            // 
            // labelOpppsite
            // 
            this.labelOpppsite.AutoSize = true;
            this.labelOpppsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpppsite.Location = new System.Drawing.Point(451, 28);
            this.labelOpppsite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpppsite.Name = "labelOpppsite";
            this.labelOpppsite.Size = new System.Drawing.Size(134, 16);
            this.labelOpppsite.TabIndex = 82;
            this.labelOpppsite.Text = "ป้อนด้านตรงข้่ามมุมฉาก";
            // 
            // tbTriHeight
            // 
            this.tbTriHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTriHeight.Location = new System.Drawing.Point(261, 59);
            this.tbTriHeight.Margin = new System.Windows.Forms.Padding(2);
            this.tbTriHeight.Name = "tbTriHeight";
            this.tbTriHeight.Size = new System.Drawing.Size(146, 22);
            this.tbTriHeight.TabIndex = 81;
            this.tbTriHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTriHeight_KeyPress);
            // 
            // labelHeight2
            // 
            this.labelHeight2.AutoSize = true;
            this.labelHeight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight2.Location = new System.Drawing.Point(258, 28);
            this.labelHeight2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeight2.Name = "labelHeight2";
            this.labelHeight2.Size = new System.Drawing.Size(45, 16);
            this.labelHeight2.TabIndex = 80;
            this.labelHeight2.Text = "ป้อนสูง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "ผลลัพธ์";
            // 
            // lbTriShow
            // 
            this.lbTriShow.BackColor = System.Drawing.Color.Yellow;
            this.lbTriShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTriShow.ForeColor = System.Drawing.Color.Red;
            this.lbTriShow.Location = new System.Drawing.Point(86, 284);
            this.lbTriShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTriShow.Name = "lbTriShow";
            this.lbTriShow.Size = new System.Drawing.Size(272, 53);
            this.lbTriShow.TabIndex = 78;
            this.lbTriShow.Text = "0.00";
            this.lbTriShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTriCancel
            // 
            this.btTriCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btTriCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTriCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btTriCancel.Location = new System.Drawing.Point(515, 235);
            this.btTriCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btTriCancel.Name = "btTriCancel";
            this.btTriCancel.Size = new System.Drawing.Size(94, 64);
            this.btTriCancel.TabIndex = 76;
            this.btTriCancel.Text = "ยกเลิก";
            this.btTriCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTriCancel.UseVisualStyleBackColor = false;
            this.btTriCancel.Click += new System.EventHandler(this.btTriCancel_Click);
            // 
            // btTriCal
            // 
            this.btTriCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btTriCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTriCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btTriCal.Location = new System.Drawing.Point(515, 159);
            this.btTriCal.Margin = new System.Windows.Forms.Padding(2);
            this.btTriCal.Name = "btTriCal";
            this.btTriCal.Size = new System.Drawing.Size(94, 64);
            this.btTriCal.TabIndex = 77;
            this.btTriCal.Text = "คำนวณ";
            this.btTriCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTriCal.UseVisualStyleBackColor = false;
            this.btTriCal.Click += new System.EventHandler(this.btTriCal_Click);
            // 
            // rdTriRound
            // 
            this.rdTriRound.AutoSize = true;
            this.rdTriRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTriRound.Location = new System.Drawing.Point(76, 180);
            this.rdTriRound.Margin = new System.Windows.Forms.Padding(2);
            this.rdTriRound.Name = "rdTriRound";
            this.rdTriRound.Size = new System.Drawing.Size(131, 22);
            this.rdTriRound.TabIndex = 75;
            this.rdTriRound.Text = "เส้นรอบสามเหลี่ยม";
            this.rdTriRound.UseVisualStyleBackColor = true;
            // 
            // rdTriArea
            // 
            this.rdTriArea.AutoSize = true;
            this.rdTriArea.Checked = true;
            this.rdTriArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTriArea.Location = new System.Drawing.Point(76, 129);
            this.rdTriArea.Margin = new System.Windows.Forms.Padding(2);
            this.rdTriArea.Name = "rdTriArea";
            this.rdTriArea.Size = new System.Drawing.Size(114, 22);
            this.rdTriArea.TabIndex = 74;
            this.rdTriArea.TabStop = true;
            this.rdTriArea.Text = "พื้นที่สามเหลี่ยม";
            this.rdTriArea.UseVisualStyleBackColor = true;
            // 
            // tbBase
            // 
            this.tbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBase.Location = new System.Drawing.Point(76, 59);
            this.tbBase.Margin = new System.Windows.Forms.Padding(2);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(146, 22);
            this.tbBase.TabIndex = 73;
            this.tbBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBase_KeyPress);
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBase.Location = new System.Drawing.Point(73, 28);
            this.labelBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(51, 16);
            this.labelBase.TabIndex = 72;
            this.labelBase.Text = "ป้อนฐาน";
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(65, 28);
            this.HeadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(510, 44);
            this.HeadLabel.TabIndex = 36;
            this.HeadLabel.Text = "คำนวณรูปทรง";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(614, 28);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(120, 63);
            this.btMainMenu.TabIndex = 63;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = false;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 549);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 25);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbUsername
            // 
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(42, 22);
            this.tslbUsername.Text = "name?";
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(59, 22);
            this.tslbDateTime.Text = "datetime?";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmShapeArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 574);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmShapeArea";
            this.Load += new System.EventHandler(this.FrmShapeArea_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.Label LabeStuId;
        private System.Windows.Forms.RadioButton rdCircleRound;
        private System.Windows.Forms.RadioButton rdCircleArea;
        private System.Windows.Forms.Button btCircleCancel;
        private System.Windows.Forms.Button btCircleCal;
        private System.Windows.Forms.Label lbCircleShow;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRectShow;
        private System.Windows.Forms.Button btRectCancel;
        private System.Windows.Forms.Button btRectCal;
        private System.Windows.Forms.RadioButton rdRectRound;
        private System.Windows.Forms.RadioButton rdRectArea;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox tbRectHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSideAngle;
        private System.Windows.Forms.Label labelOpppsite;
        private System.Windows.Forms.TextBox tbTriHeight;
        private System.Windows.Forms.Label labelHeight2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTriShow;
        private System.Windows.Forms.Button btTriCancel;
        private System.Windows.Forms.Button btTriCal;
        private System.Windows.Forms.RadioButton rdTriRound;
        private System.Windows.Forms.RadioButton rdTriArea;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer;
    }
}