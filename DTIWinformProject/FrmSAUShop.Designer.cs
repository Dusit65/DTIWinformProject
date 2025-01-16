namespace DTIWinformProject
{
    partial class FrmSAUShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSAUShop));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.cbPen = new System.Windows.Forms.CheckBox();
            this.labelProductList = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbResultBaht = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalResult = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.tbQuanPen = new System.Windows.Forms.TextBox();
            this.lbTotalPen = new System.Windows.Forms.Label();
            this.labelBaht1 = new System.Windows.Forms.Label();
            this.labelBaht3 = new System.Windows.Forms.Label();
            this.lbTotalEraser = new System.Windows.Forms.Label();
            this.tbQuanEraser = new System.Windows.Forms.TextBox();
            this.cbEraser = new System.Windows.Forms.CheckBox();
            this.labelBaht2 = new System.Windows.Forms.Label();
            this.lbTotalPencil = new System.Windows.Forms.Label();
            this.tbQuanPencil = new System.Windows.Forms.TextBox();
            this.cbPencil = new System.Windows.Forms.CheckBox();
            this.labelBaht4 = new System.Windows.Forms.Label();
            this.lbTotalRuler = new System.Windows.Forms.Label();
            this.tbQuanRuler = new System.Windows.Forms.TextBox();
            this.cbRuler = new System.Windows.Forms.CheckBox();
            this.labelBaht5 = new System.Windows.Forms.Label();
            this.lbTotalNbook = new System.Windows.Forms.Label();
            this.tbQuanNotebook = new System.Windows.Forms.TextBox();
            this.cbNotebook = new System.Windows.Forms.CheckBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbResult.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(45, 9);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(621, 103);
            this.HeadLabel.TabIndex = 4;
            this.HeadLabel.Text = "SAU Shop";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPen
            // 
            this.cbPen.AutoSize = true;
            this.cbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPen.Location = new System.Drawing.Point(61, 193);
            this.cbPen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPen.Name = "cbPen";
            this.cbPen.Size = new System.Drawing.Size(179, 29);
            this.cbPen.TabIndex = 6;
            this.cbPen.Text = "ปากกา 5 บาท / ด้าม";
            this.cbPen.UseVisualStyleBackColor = true;
            // 
            // labelProductList
            // 
            this.labelProductList.AutoSize = true;
            this.labelProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductList.Location = new System.Drawing.Point(113, 140);
            this.labelProductList.Name = "labelProductList";
            this.labelProductList.Size = new System.Drawing.Size(115, 25);
            this.labelProductList.TabIndex = 7;
            this.labelProductList.Text = "รายการสินค้า";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.btCancel);
            this.gbResult.Controls.Add(this.btCalculate);
            this.gbResult.Controls.Add(this.lbResultBaht);
            this.gbResult.Controls.Add(this.lbTotal);
            this.gbResult.Controls.Add(this.lbTotalResult);
            this.gbResult.Location = new System.Drawing.Point(107, 494);
            this.gbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbResult.Size = new System.Drawing.Size(804, 102);
            this.gbResult.TabIndex = 8;
            this.gbResult.TabStop = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(597, 15);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 79);
            this.btCancel.TabIndex = 32;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btCalculate
            // 
            this.btCalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculate.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btCalculate.Location = new System.Drawing.Point(435, 15);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(125, 79);
            this.btCalculate.TabIndex = 33;
            this.btCalculate.Text = "คำนวณ";
            this.btCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCalculate.UseVisualStyleBackColor = false;
            // 
            // lbResultBaht
            // 
            this.lbResultBaht.AutoSize = true;
            this.lbResultBaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultBaht.Location = new System.Drawing.Point(371, 41);
            this.lbResultBaht.Name = "lbResultBaht";
            this.lbResultBaht.Size = new System.Drawing.Size(46, 25);
            this.lbResultBaht.TabIndex = 32;
            this.lbResultBaht.Text = "บาท";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(8, 41);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(147, 25);
            this.lbTotal.TabIndex = 32;
            this.lbTotal.Text = "รวมเป็นเงินทั้งสิ้น";
            // 
            // lbTotalResult
            // 
            this.lbTotalResult.BackColor = System.Drawing.Color.Yellow;
            this.lbTotalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalResult.ForeColor = System.Drawing.Color.Red;
            this.lbTotalResult.Location = new System.Drawing.Point(196, 18);
            this.lbTotalResult.Name = "lbTotalResult";
            this.lbTotalResult.Size = new System.Drawing.Size(140, 65);
            this.lbTotalResult.TabIndex = 32;
            this.lbTotalResult.Text = "0.00";
            this.lbTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(505, 140);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(96, 25);
            this.labelTotalPrice.TabIndex = 9;
            this.labelTotalPrice.Text = "คิดเป็นเงิน";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(333, 140);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(68, 25);
            this.labelQuantity.TabIndex = 10;
            this.labelQuantity.Text = "จำนวน";
            // 
            // tbQuanPen
            // 
            this.tbQuanPen.Location = new System.Drawing.Point(303, 199);
            this.tbQuanPen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuanPen.Name = "tbQuanPen";
            this.tbQuanPen.Size = new System.Drawing.Size(128, 22);
            this.tbQuanPen.TabIndex = 11;
            // 
            // lbTotalPen
            // 
            this.lbTotalPen.BackColor = System.Drawing.Color.Yellow;
            this.lbTotalPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPen.ForeColor = System.Drawing.Color.Red;
            this.lbTotalPen.Location = new System.Drawing.Point(493, 193);
            this.lbTotalPen.Name = "lbTotalPen";
            this.lbTotalPen.Size = new System.Drawing.Size(125, 31);
            this.lbTotalPen.TabIndex = 12;
            this.lbTotalPen.Text = "0.00";
            this.lbTotalPen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBaht1
            // 
            this.labelBaht1.AutoSize = true;
            this.labelBaht1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht1.Location = new System.Drawing.Point(680, 196);
            this.labelBaht1.Name = "labelBaht1";
            this.labelBaht1.Size = new System.Drawing.Size(43, 25);
            this.labelBaht1.TabIndex = 13;
            this.labelBaht1.Text = "บาท";
            // 
            // labelBaht3
            // 
            this.labelBaht3.AutoSize = true;
            this.labelBaht3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht3.Location = new System.Drawing.Point(680, 303);
            this.labelBaht3.Name = "labelBaht3";
            this.labelBaht3.Size = new System.Drawing.Size(43, 25);
            this.labelBaht3.TabIndex = 17;
            this.labelBaht3.Text = "บาท";
            // 
            // lbTotalEraser
            // 
            this.lbTotalEraser.BackColor = System.Drawing.Color.Yellow;
            this.lbTotalEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalEraser.ForeColor = System.Drawing.Color.Red;
            this.lbTotalEraser.Location = new System.Drawing.Point(493, 300);
            this.lbTotalEraser.Name = "lbTotalEraser";
            this.lbTotalEraser.Size = new System.Drawing.Size(125, 31);
            this.lbTotalEraser.TabIndex = 16;
            this.lbTotalEraser.Text = "0.00";
            this.lbTotalEraser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbQuanEraser
            // 
            this.tbQuanEraser.Location = new System.Drawing.Point(303, 305);
            this.tbQuanEraser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuanEraser.Name = "tbQuanEraser";
            this.tbQuanEraser.Size = new System.Drawing.Size(128, 22);
            this.tbQuanEraser.TabIndex = 15;
            // 
            // cbEraser
            // 
            this.cbEraser.AutoSize = true;
            this.cbEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEraser.Location = new System.Drawing.Point(61, 300);
            this.cbEraser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEraser.Name = "cbEraser";
            this.cbEraser.Size = new System.Drawing.Size(206, 29);
            this.cbEraser.TabIndex = 14;
            this.cbEraser.Text = "ยางลบ 2.50 บาท / ก้อน";
            this.cbEraser.UseVisualStyleBackColor = true;
            // 
            // labelBaht2
            // 
            this.labelBaht2.AutoSize = true;
            this.labelBaht2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht2.Location = new System.Drawing.Point(680, 249);
            this.labelBaht2.Name = "labelBaht2";
            this.labelBaht2.Size = new System.Drawing.Size(43, 25);
            this.labelBaht2.TabIndex = 21;
            this.labelBaht2.Text = "บาท";
            // 
            // lbTotalPencil
            // 
            this.lbTotalPencil.BackColor = System.Drawing.Color.Yellow;
            this.lbTotalPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPencil.ForeColor = System.Drawing.Color.Red;
            this.lbTotalPencil.Location = new System.Drawing.Point(493, 245);
            this.lbTotalPencil.Name = "lbTotalPencil";
            this.lbTotalPencil.Size = new System.Drawing.Size(125, 31);
            this.lbTotalPencil.TabIndex = 20;
            this.lbTotalPencil.Text = "0.00";
            this.lbTotalPencil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbQuanPencil
            // 
            this.tbQuanPencil.Location = new System.Drawing.Point(303, 254);
            this.tbQuanPencil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuanPencil.Name = "tbQuanPencil";
            this.tbQuanPencil.Size = new System.Drawing.Size(128, 22);
            this.tbQuanPencil.TabIndex = 19;
            // 
            // cbPencil
            // 
            this.cbPencil.AutoSize = true;
            this.cbPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPencil.Location = new System.Drawing.Point(61, 245);
            this.cbPencil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPencil.Name = "cbPencil";
            this.cbPencil.Size = new System.Drawing.Size(201, 29);
            this.cbPencil.TabIndex = 18;
            this.cbPencil.Text = "ดินสอ 1.50 บาท / ด้าม";
            this.cbPencil.UseVisualStyleBackColor = true;
            // 
            // labelBaht4
            // 
            this.labelBaht4.AutoSize = true;
            this.labelBaht4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht4.Location = new System.Drawing.Point(680, 354);
            this.labelBaht4.Name = "labelBaht4";
            this.labelBaht4.Size = new System.Drawing.Size(43, 25);
            this.labelBaht4.TabIndex = 25;
            this.labelBaht4.Text = "บาท";
            // 
            // lbTotalRuler
            // 
            this.lbTotalRuler.BackColor = System.Drawing.Color.Yellow;
            this.lbTotalRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRuler.ForeColor = System.Drawing.Color.Red;
            this.lbTotalRuler.Location = new System.Drawing.Point(493, 351);
            this.lbTotalRuler.Name = "lbTotalRuler";
            this.lbTotalRuler.Size = new System.Drawing.Size(125, 31);
            this.lbTotalRuler.TabIndex = 24;
            this.lbTotalRuler.Text = "0.00";
            this.lbTotalRuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbQuanRuler
            // 
            this.tbQuanRuler.Location = new System.Drawing.Point(303, 356);
            this.tbQuanRuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuanRuler.Name = "tbQuanRuler";
            this.tbQuanRuler.Size = new System.Drawing.Size(128, 22);
            this.tbQuanRuler.TabIndex = 23;
            // 
            // cbRuler
            // 
            this.cbRuler.AutoSize = true;
            this.cbRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRuler.Location = new System.Drawing.Point(61, 351);
            this.cbRuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRuler.Name = "cbRuler";
            this.cbRuler.Size = new System.Drawing.Size(194, 29);
            this.cbRuler.TabIndex = 22;
            this.cbRuler.Text = "ไม้บรรทัด 2 บาท / อัน";
            this.cbRuler.UseVisualStyleBackColor = true;
            // 
            // labelBaht5
            // 
            this.labelBaht5.AutoSize = true;
            this.labelBaht5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht5.Location = new System.Drawing.Point(680, 404);
            this.labelBaht5.Name = "labelBaht5";
            this.labelBaht5.Size = new System.Drawing.Size(43, 25);
            this.labelBaht5.TabIndex = 29;
            this.labelBaht5.Text = "บาท";
            // 
            // lbTotalNbook
            // 
            this.lbTotalNbook.BackColor = System.Drawing.Color.Yellow;
            this.lbTotalNbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalNbook.ForeColor = System.Drawing.Color.Red;
            this.lbTotalNbook.Location = new System.Drawing.Point(493, 405);
            this.lbTotalNbook.Name = "lbTotalNbook";
            this.lbTotalNbook.Size = new System.Drawing.Size(125, 31);
            this.lbTotalNbook.TabIndex = 28;
            this.lbTotalNbook.Text = "0.00";
            this.lbTotalNbook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbQuanNotebook
            // 
            this.tbQuanNotebook.Location = new System.Drawing.Point(303, 409);
            this.tbQuanNotebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuanNotebook.Name = "tbQuanNotebook";
            this.tbQuanNotebook.Size = new System.Drawing.Size(128, 22);
            this.tbQuanNotebook.TabIndex = 27;
            // 
            // cbNotebook
            // 
            this.cbNotebook.AutoSize = true;
            this.cbNotebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotebook.Location = new System.Drawing.Point(61, 404);
            this.cbNotebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNotebook.Name = "cbNotebook";
            this.cbNotebook.Size = new System.Drawing.Size(196, 29);
            this.cbNotebook.TabIndex = 26;
            this.cbNotebook.Text = "สมุด 10.25 บาท / เล่ม";
            this.cbNotebook.UseVisualStyleBackColor = true;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(133, 454);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(67, 25);
            this.lbDiscount.TabIndex = 30;
            this.lbDiscount.Text = "ส่วนลด";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5 %",
            "10 %",
            "15 %"});
            this.comboBox1.Location = new System.Drawing.Point(284, 454);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(772, 9);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(160, 103);
            this.btMainMenu.TabIndex = 5;
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 626);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1013, 25);
            this.toolStrip1.TabIndex = 32;
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
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmSAUShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 651);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.labelBaht5);
            this.Controls.Add(this.lbTotalNbook);
            this.Controls.Add(this.tbQuanNotebook);
            this.Controls.Add(this.cbNotebook);
            this.Controls.Add(this.labelBaht4);
            this.Controls.Add(this.lbTotalRuler);
            this.Controls.Add(this.tbQuanRuler);
            this.Controls.Add(this.cbRuler);
            this.Controls.Add(this.labelBaht2);
            this.Controls.Add(this.lbTotalPencil);
            this.Controls.Add(this.tbQuanPencil);
            this.Controls.Add(this.cbPencil);
            this.Controls.Add(this.labelBaht3);
            this.Controls.Add(this.lbTotalEraser);
            this.Controls.Add(this.tbQuanEraser);
            this.Controls.Add(this.cbEraser);
            this.Controls.Add(this.labelBaht1);
            this.Controls.Add(this.lbTotalPen);
            this.Controls.Add(this.tbQuanPen);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.labelProductList);
            this.Controls.Add(this.cbPen);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSAUShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอSAU Shop- DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmSAUShop_Load);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.CheckBox cbPen;
        private System.Windows.Forms.Label labelProductList;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox tbQuanPen;
        private System.Windows.Forms.Label lbTotalPen;
        private System.Windows.Forms.Label labelBaht1;
        private System.Windows.Forms.Label labelBaht3;
        private System.Windows.Forms.Label lbTotalEraser;
        private System.Windows.Forms.TextBox tbQuanEraser;
        private System.Windows.Forms.CheckBox cbEraser;
        private System.Windows.Forms.Label labelBaht2;
        private System.Windows.Forms.Label lbTotalPencil;
        private System.Windows.Forms.TextBox tbQuanPencil;
        private System.Windows.Forms.CheckBox cbPencil;
        private System.Windows.Forms.Label labelBaht4;
        private System.Windows.Forms.Label lbTotalRuler;
        private System.Windows.Forms.TextBox tbQuanRuler;
        private System.Windows.Forms.CheckBox cbRuler;
        private System.Windows.Forms.Label labelBaht5;
        private System.Windows.Forms.Label lbTotalNbook;
        private System.Windows.Forms.TextBox tbQuanNotebook;
        private System.Windows.Forms.CheckBox cbNotebook;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbTotalResult;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbResultBaht;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer;
    }
}