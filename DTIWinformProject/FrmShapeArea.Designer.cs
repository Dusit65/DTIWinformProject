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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelCircleResult = new System.Windows.Forms.Label();
            this.BTCancel = new System.Windows.Forms.Button();
            this.BTCal = new System.Windows.Forms.Button();
            this.radioCircleLength = new System.Windows.Forms.RadioButton();
            this.radioArea = new System.Windows.Forms.RadioButton();
            this.TFStuId = new System.Windows.Forms.TextBox();
            this.LabeStuId = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTCancel2 = new System.Windows.Forms.Button();
            this.BTCal2 = new System.Windows.Forms.Button();
            this.radioSquareLength = new System.Windows.Forms.RadioButton();
            this.radioSquareArea = new System.Windows.Forms.RadioButton();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxOpppsite = new System.Windows.Forms.TextBox();
            this.labelOpppsite = new System.Windows.Forms.Label();
            this.textBoxHeight2 = new System.Windows.Forms.TextBox();
            this.labelHeight2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTCancel3 = new System.Windows.Forms.Button();
            this.BTCal3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.labelBase = new System.Windows.Forms.Label();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.BTMainMenu = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
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
            this.tabControl1.Location = new System.Drawing.Point(84, 138);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelResult);
            this.tabPage1.Controls.Add(this.labelCircleResult);
            this.tabPage1.Controls.Add(this.BTCancel);
            this.tabPage1.Controls.Add(this.BTCal);
            this.tabPage1.Controls.Add(this.radioCircleLength);
            this.tabPage1.Controls.Add(this.radioArea);
            this.tabPage1.Controls.Add(this.TFStuId);
            this.tabPage1.Controls.Add(this.LabeStuId);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(912, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วงกลม";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(67, 287);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(68, 25);
            this.labelResult.TabIndex = 61;
            this.labelResult.Text = "ผลลัพธ์";
            // 
            // labelCircleResult
            // 
            this.labelCircleResult.BackColor = System.Drawing.Color.Yellow;
            this.labelCircleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCircleResult.ForeColor = System.Drawing.Color.Red;
            this.labelCircleResult.Location = new System.Drawing.Point(65, 347);
            this.labelCircleResult.Name = "labelCircleResult";
            this.labelCircleResult.Size = new System.Drawing.Size(363, 65);
            this.labelCircleResult.TabIndex = 60;
            this.labelCircleResult.Text = "0.00";
            this.labelCircleResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTCancel
            // 
            this.BTCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.BTCancel.Location = new System.Drawing.Point(637, 287);
            this.BTCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(125, 79);
            this.BTCancel.TabIndex = 57;
            this.BTCancel.Text = "ยกเลิก";
            this.BTCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTCancel.UseVisualStyleBackColor = false;
            // 
            // BTCal
            // 
            this.BTCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCal.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.BTCal.Location = new System.Drawing.Point(637, 193);
            this.BTCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTCal.Name = "BTCal";
            this.BTCal.Size = new System.Drawing.Size(125, 79);
            this.BTCal.TabIndex = 59;
            this.BTCal.Text = "คำนวณ";
            this.BTCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTCal.UseVisualStyleBackColor = false;
            // 
            // radioCircleLength
            // 
            this.radioCircleLength.AutoSize = true;
            this.radioCircleLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCircleLength.Location = new System.Drawing.Point(52, 219);
            this.radioCircleLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioCircleLength.Name = "radioCircleLength";
            this.radioCircleLength.Size = new System.Drawing.Size(101, 28);
            this.radioCircleLength.TabIndex = 56;
            this.radioCircleLength.Text = "เส้นรอบวง";
            this.radioCircleLength.UseVisualStyleBackColor = true;
            // 
            // radioArea
            // 
            this.radioArea.AutoSize = true;
            this.radioArea.Checked = true;
            this.radioArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioArea.Location = new System.Drawing.Point(52, 156);
            this.radioArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioArea.Name = "radioArea";
            this.radioArea.Size = new System.Drawing.Size(113, 28);
            this.radioArea.TabIndex = 55;
            this.radioArea.TabStop = true;
            this.radioArea.Text = "พื้นที่วงกลม";
            this.radioArea.UseVisualStyleBackColor = true;
            // 
            // TFStuId
            // 
            this.TFStuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFStuId.Location = new System.Drawing.Point(52, 71);
            this.TFStuId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TFStuId.Name = "TFStuId";
            this.TFStuId.Size = new System.Drawing.Size(297, 26);
            this.TFStuId.TabIndex = 50;
            // 
            // LabeStuId
            // 
            this.LabeStuId.AutoSize = true;
            this.LabeStuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabeStuId.Location = new System.Drawing.Point(48, 32);
            this.LabeStuId.Name = "LabeStuId";
            this.LabeStuId.Size = new System.Drawing.Size(73, 20);
            this.LabeStuId.TabIndex = 49;
            this.LabeStuId.Text = "ป้อนรัศมี";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxHeight);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.BTCancel2);
            this.tabPage2.Controls.Add(this.BTCal2);
            this.tabPage2.Controls.Add(this.radioSquareLength);
            this.tabPage2.Controls.Add(this.radioSquareArea);
            this.tabPage2.Controls.Add(this.textBoxWidth);
            this.tabPage2.Controls.Add(this.labelWidth);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(912, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "สี่เหลี่ยม";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(348, 73);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(193, 26);
            this.textBoxHeight.TabIndex = 71;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "ป้อนสูง";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "ผลลัพธ์";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(115, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 65);
            this.label2.TabIndex = 68;
            this.label2.Text = "0.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTCancel2
            // 
            this.BTCancel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTCancel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancel2.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.BTCancel2.Location = new System.Drawing.Point(687, 289);
            this.BTCancel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTCancel2.Name = "BTCancel2";
            this.BTCancel2.Size = new System.Drawing.Size(125, 79);
            this.BTCancel2.TabIndex = 66;
            this.BTCancel2.Text = "ยกเลิก";
            this.BTCancel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTCancel2.UseVisualStyleBackColor = false;
            // 
            // BTCal2
            // 
            this.BTCal2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTCal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCal2.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.BTCal2.Location = new System.Drawing.Point(687, 196);
            this.BTCal2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTCal2.Name = "BTCal2";
            this.BTCal2.Size = new System.Drawing.Size(125, 79);
            this.BTCal2.TabIndex = 67;
            this.BTCal2.Text = "คำนวณ";
            this.BTCal2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTCal2.UseVisualStyleBackColor = false;
            // 
            // radioSquareLength
            // 
            this.radioSquareLength.AutoSize = true;
            this.radioSquareLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSquareLength.Location = new System.Drawing.Point(101, 222);
            this.radioSquareLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSquareLength.Name = "radioSquareLength";
            this.radioSquareLength.Size = new System.Drawing.Size(142, 28);
            this.radioSquareLength.TabIndex = 65;
            this.radioSquareLength.Text = "เส้นรอบสี่เหลี่ยม";
            this.radioSquareLength.UseVisualStyleBackColor = true;
            // 
            // radioSquareArea
            // 
            this.radioSquareArea.AutoSize = true;
            this.radioSquareArea.Checked = true;
            this.radioSquareArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSquareArea.Location = new System.Drawing.Point(101, 159);
            this.radioSquareArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSquareArea.Name = "radioSquareArea";
            this.radioSquareArea.Size = new System.Drawing.Size(124, 28);
            this.radioSquareArea.TabIndex = 64;
            this.radioSquareArea.TabStop = true;
            this.radioSquareArea.Text = "พื้นที่สี่เหลี่ยม";
            this.radioSquareArea.UseVisualStyleBackColor = true;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWidth.Location = new System.Drawing.Point(101, 73);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(193, 26);
            this.textBoxWidth.TabIndex = 63;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(97, 34);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(79, 20);
            this.labelWidth.TabIndex = 62;
            this.labelWidth.Text = "ป้อนกว้าง";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxOpppsite);
            this.tabPage3.Controls.Add(this.labelOpppsite);
            this.tabPage3.Controls.Add(this.textBoxHeight2);
            this.tabPage3.Controls.Add(this.labelHeight2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.BTCancel3);
            this.tabPage3.Controls.Add(this.BTCal3);
            this.tabPage3.Controls.Add(this.radioButton1);
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.textBoxBase);
            this.tabPage3.Controls.Add(this.labelBase);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(912, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "สามเหลี่ยมมุมฉาก";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxOpppsite
            // 
            this.textBoxOpppsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOpppsite.Location = new System.Drawing.Point(605, 73);
            this.textBoxOpppsite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOpppsite.Name = "textBoxOpppsite";
            this.textBoxOpppsite.Size = new System.Drawing.Size(193, 26);
            this.textBoxOpppsite.TabIndex = 83;
            // 
            // labelOpppsite
            // 
            this.labelOpppsite.AutoSize = true;
            this.labelOpppsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpppsite.Location = new System.Drawing.Point(601, 34);
            this.labelOpppsite.Name = "labelOpppsite";
            this.labelOpppsite.Size = new System.Drawing.Size(189, 20);
            this.labelOpppsite.TabIndex = 82;
            this.labelOpppsite.Text = "ป้อนด้านตรงข้่ามมุมฉาก";
            // 
            // textBoxHeight2
            // 
            this.textBoxHeight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight2.Location = new System.Drawing.Point(348, 73);
            this.textBoxHeight2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHeight2.Name = "textBoxHeight2";
            this.textBoxHeight2.Size = new System.Drawing.Size(193, 26);
            this.textBoxHeight2.TabIndex = 81;
            // 
            // labelHeight2
            // 
            this.labelHeight2.AutoSize = true;
            this.labelHeight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight2.Location = new System.Drawing.Point(344, 34);
            this.labelHeight2.Name = "labelHeight2";
            this.labelHeight2.Size = new System.Drawing.Size(60, 20);
            this.labelHeight2.TabIndex = 80;
            this.labelHeight2.Text = "ป้อนสูง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 79;
            this.label5.Text = "ผลลัพธ์";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(115, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 65);
            this.label6.TabIndex = 78;
            this.label6.Text = "0.00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTCancel3
            // 
            this.BTCancel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTCancel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancel3.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.BTCancel3.Location = new System.Drawing.Point(687, 289);
            this.BTCancel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTCancel3.Name = "BTCancel3";
            this.BTCancel3.Size = new System.Drawing.Size(125, 79);
            this.BTCancel3.TabIndex = 76;
            this.BTCancel3.Text = "ยกเลิก";
            this.BTCancel3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTCancel3.UseVisualStyleBackColor = false;
            // 
            // BTCal3
            // 
            this.BTCal3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTCal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCal3.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.BTCal3.Location = new System.Drawing.Point(687, 196);
            this.BTCal3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTCal3.Name = "BTCal3";
            this.BTCal3.Size = new System.Drawing.Size(125, 79);
            this.BTCal3.TabIndex = 77;
            this.BTCal3.Text = "คำนวณ";
            this.BTCal3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTCal3.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(101, 222);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(161, 28);
            this.radioButton1.TabIndex = 75;
            this.radioButton1.Text = "เส้นรอบสามเหลี่ยม";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(101, 159);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(143, 28);
            this.radioButton2.TabIndex = 74;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "พื้นที่สามเหลี่ยม";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxBase
            // 
            this.textBoxBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBase.Location = new System.Drawing.Point(101, 73);
            this.textBoxBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(193, 26);
            this.textBoxBase.TabIndex = 73;
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBase.Location = new System.Drawing.Point(97, 34);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(71, 20);
            this.labelBase.TabIndex = 72;
            this.labelBase.Text = "ป้อนฐาน";
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(87, 34);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(680, 54);
            this.HeadLabel.TabIndex = 36;
            this.HeadLabel.Text = "คำนวณรูปทรง";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTMainMenu
            // 
            this.BTMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.BTMainMenu.Location = new System.Drawing.Point(819, 34);
            this.BTMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTMainMenu.Name = "BTMainMenu";
            this.BTMainMenu.Size = new System.Drawing.Size(160, 78);
            this.BTMainMenu.TabIndex = 63;
            this.BTMainMenu.Text = "หน้าจอหลัก";
            this.BTMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTMainMenu.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 681);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1151, 25);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "name?";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel2.Text = "datetime?";
            // 
            // FrmShapeArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 706);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BTMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmShapeArea";
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
        private System.Windows.Forms.Button BTMainMenu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox TFStuId;
        private System.Windows.Forms.Label LabeStuId;
        private System.Windows.Forms.RadioButton radioCircleLength;
        private System.Windows.Forms.RadioButton radioArea;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.Button BTCal;
        private System.Windows.Forms.Label labelCircleResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTCancel2;
        private System.Windows.Forms.Button BTCal2;
        private System.Windows.Forms.RadioButton radioSquareLength;
        private System.Windows.Forms.RadioButton radioSquareArea;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOpppsite;
        private System.Windows.Forms.Label labelOpppsite;
        private System.Windows.Forms.TextBox textBoxHeight2;
        private System.Windows.Forms.Label labelHeight2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTCancel3;
        private System.Windows.Forms.Button BTCal3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}