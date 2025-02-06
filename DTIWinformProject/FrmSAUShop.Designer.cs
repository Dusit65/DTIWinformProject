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
            this.lbPayBaht = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalPay = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.tbPen = new System.Windows.Forms.TextBox();
            this.lbPen = new System.Windows.Forms.Label();
            this.labelBaht1 = new System.Windows.Forms.Label();
            this.labelBaht3 = new System.Windows.Forms.Label();
            this.lbRubber = new System.Windows.Forms.Label();
            this.tbRubber = new System.Windows.Forms.TextBox();
            this.cbRubber = new System.Windows.Forms.CheckBox();
            this.labelBaht2 = new System.Windows.Forms.Label();
            this.lbPencil = new System.Windows.Forms.Label();
            this.tbPencil = new System.Windows.Forms.TextBox();
            this.cbPencil = new System.Windows.Forms.CheckBox();
            this.labelBaht4 = new System.Windows.Forms.Label();
            this.lbRuler = new System.Windows.Forms.Label();
            this.tbRuler = new System.Windows.Forms.TextBox();
            this.cbRuler = new System.Windows.Forms.CheckBox();
            this.labelBaht5 = new System.Windows.Forms.Label();
            this.lbBook = new System.Windows.Forms.Label();
            this.tbBook = new System.Windows.Forms.TextBox();
            this.cbBook = new System.Windows.Forms.CheckBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.cbbDiscount = new System.Windows.Forms.ComboBox();
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
            this.HeadLabel.Location = new System.Drawing.Point(34, 7);
            this.HeadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(466, 84);
            this.HeadLabel.TabIndex = 0;
            this.HeadLabel.Text = "SAU Shop";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPen
            // 
            this.cbPen.AutoSize = true;
            this.cbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPen.Location = new System.Drawing.Point(46, 157);
            this.cbPen.Margin = new System.Windows.Forms.Padding(2);
            this.cbPen.Name = "cbPen";
            this.cbPen.Size = new System.Drawing.Size(150, 24);
            this.cbPen.TabIndex = 2;
            this.cbPen.TabStop = false;
            this.cbPen.Text = "ปากกา 5 บาท / ด้าม";
            this.cbPen.UseVisualStyleBackColor = true;
            this.cbPen.Click += new System.EventHandler(this.cbPen_Click);
            // 
            // labelProductList
            // 
            this.labelProductList.AutoSize = true;
            this.labelProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductList.Location = new System.Drawing.Point(85, 114);
            this.labelProductList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductList.Name = "labelProductList";
            this.labelProductList.Size = new System.Drawing.Size(97, 20);
            this.labelProductList.TabIndex = 7;
            this.labelProductList.Text = "รายการสินค้า";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.btCancel);
            this.gbResult.Controls.Add(this.btCalculate);
            this.gbResult.Controls.Add(this.lbPayBaht);
            this.gbResult.Controls.Add(this.label1);
            this.gbResult.Controls.Add(this.lbTotalPay);
            this.gbResult.Location = new System.Drawing.Point(46, 401);
            this.gbResult.Margin = new System.Windows.Forms.Padding(2);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(2);
            this.gbResult.Size = new System.Drawing.Size(653, 83);
            this.gbResult.TabIndex = 8;
            this.gbResult.TabStop = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(525, 11);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(94, 64);
            this.btCancel.TabIndex = 8;
            this.btCancel.TabStop = false;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculate.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.btCalculate.Location = new System.Drawing.Point(388, 11);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(94, 64);
            this.btCalculate.TabIndex = 7;
            this.btCalculate.TabStop = false;
            this.btCalculate.Text = "คำนวณ";
            this.btCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCalculate.UseVisualStyleBackColor = false;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lbPayBaht
            // 
            this.lbPayBaht.AutoSize = true;
            this.lbPayBaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayBaht.Location = new System.Drawing.Point(342, 33);
            this.lbPayBaht.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPayBaht.Name = "lbPayBaht";
            this.lbPayBaht.Size = new System.Drawing.Size(38, 20);
            this.lbPayBaht.TabIndex = 32;
            this.lbPayBaht.Text = "บาท";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "รวมเป็นเงินทั้งสิ้น";
            // 
            // lbTotalPay
            // 
            this.lbTotalPay.BackColor = System.Drawing.Color.Yellow;
            this.lbTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPay.ForeColor = System.Drawing.Color.Red;
            this.lbTotalPay.Location = new System.Drawing.Point(147, 15);
            this.lbTotalPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPay.Name = "lbTotalPay";
            this.lbTotalPay.Size = new System.Drawing.Size(177, 53);
            this.lbTotalPay.TabIndex = 32;
            this.lbTotalPay.Text = "0.00";
            this.lbTotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(379, 114);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(81, 20);
            this.labelTotalPrice.TabIndex = 9;
            this.labelTotalPrice.Text = "คิดเป็นเงิน";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(250, 114);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(54, 20);
            this.labelQuantity.TabIndex = 10;
            this.labelQuantity.Text = "จำนวน";
            // 
            // tbPen
            // 
            this.tbPen.Location = new System.Drawing.Point(227, 162);
            this.tbPen.Margin = new System.Windows.Forms.Padding(2);
            this.tbPen.MaxLength = 3;
            this.tbPen.Name = "tbPen";
            this.tbPen.Size = new System.Drawing.Size(97, 20);
            this.tbPen.TabIndex = 1;
            this.tbPen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPen_KeyPress);
            this.tbPen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPen_KeyUp);
            // 
            // lbPen
            // 
            this.lbPen.BackColor = System.Drawing.Color.Yellow;
            this.lbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPen.ForeColor = System.Drawing.Color.Red;
            this.lbPen.Location = new System.Drawing.Point(370, 157);
            this.lbPen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPen.Name = "lbPen";
            this.lbPen.Size = new System.Drawing.Size(94, 25);
            this.lbPen.TabIndex = 12;
            this.lbPen.Text = "0.00";
            this.lbPen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBaht1
            // 
            this.labelBaht1.AutoSize = true;
            this.labelBaht1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht1.Location = new System.Drawing.Point(510, 159);
            this.labelBaht1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaht1.Name = "labelBaht1";
            this.labelBaht1.Size = new System.Drawing.Size(35, 20);
            this.labelBaht1.TabIndex = 13;
            this.labelBaht1.Text = "บาท";
            // 
            // labelBaht3
            // 
            this.labelBaht3.AutoSize = true;
            this.labelBaht3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht3.Location = new System.Drawing.Point(510, 246);
            this.labelBaht3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaht3.Name = "labelBaht3";
            this.labelBaht3.Size = new System.Drawing.Size(35, 20);
            this.labelBaht3.TabIndex = 17;
            this.labelBaht3.Text = "บาท";
            // 
            // lbRubber
            // 
            this.lbRubber.BackColor = System.Drawing.Color.Yellow;
            this.lbRubber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRubber.ForeColor = System.Drawing.Color.Red;
            this.lbRubber.Location = new System.Drawing.Point(370, 244);
            this.lbRubber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRubber.Name = "lbRubber";
            this.lbRubber.Size = new System.Drawing.Size(94, 25);
            this.lbRubber.TabIndex = 16;
            this.lbRubber.Text = "0.00";
            this.lbRubber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRubber
            // 
            this.tbRubber.Location = new System.Drawing.Point(227, 248);
            this.tbRubber.Margin = new System.Windows.Forms.Padding(2);
            this.tbRubber.MaxLength = 3;
            this.tbRubber.Name = "tbRubber";
            this.tbRubber.Size = new System.Drawing.Size(97, 20);
            this.tbRubber.TabIndex = 3;
            this.tbRubber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRubber_KeyPress);
            this.tbRubber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRubber_KeyUp);
            // 
            // cbRubber
            // 
            this.cbRubber.AutoSize = true;
            this.cbRubber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRubber.Location = new System.Drawing.Point(46, 244);
            this.cbRubber.Margin = new System.Windows.Forms.Padding(2);
            this.cbRubber.Name = "cbRubber";
            this.cbRubber.Size = new System.Drawing.Size(170, 24);
            this.cbRubber.TabIndex = 6;
            this.cbRubber.TabStop = false;
            this.cbRubber.Text = "ยางลบ 2.50 บาท / ก้อน";
            this.cbRubber.UseVisualStyleBackColor = true;
            this.cbRubber.CheckedChanged += new System.EventHandler(this.cbRubber_CheckedChanged);
            // 
            // labelBaht2
            // 
            this.labelBaht2.AutoSize = true;
            this.labelBaht2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht2.Location = new System.Drawing.Point(510, 202);
            this.labelBaht2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaht2.Name = "labelBaht2";
            this.labelBaht2.Size = new System.Drawing.Size(35, 20);
            this.labelBaht2.TabIndex = 21;
            this.labelBaht2.Text = "บาท";
            // 
            // lbPencil
            // 
            this.lbPencil.BackColor = System.Drawing.Color.Yellow;
            this.lbPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPencil.ForeColor = System.Drawing.Color.Red;
            this.lbPencil.Location = new System.Drawing.Point(370, 199);
            this.lbPencil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPencil.Name = "lbPencil";
            this.lbPencil.Size = new System.Drawing.Size(94, 25);
            this.lbPencil.TabIndex = 20;
            this.lbPencil.Text = "0.00";
            this.lbPencil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPencil
            // 
            this.tbPencil.Location = new System.Drawing.Point(227, 199);
            this.tbPencil.Margin = new System.Windows.Forms.Padding(2);
            this.tbPencil.MaxLength = 3;
            this.tbPencil.Name = "tbPencil";
            this.tbPencil.Size = new System.Drawing.Size(97, 20);
            this.tbPencil.TabIndex = 2;
            this.tbPencil.TextChanged += new System.EventHandler(this.tbPencil_TextChanged);
            this.tbPencil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPencil_KeyPress);
            this.tbPencil.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPencil_KeyUp);
            // 
            // cbPencil
            // 
            this.cbPencil.AutoSize = true;
            this.cbPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPencil.Location = new System.Drawing.Point(46, 199);
            this.cbPencil.Margin = new System.Windows.Forms.Padding(2);
            this.cbPencil.Name = "cbPencil";
            this.cbPencil.Size = new System.Drawing.Size(165, 24);
            this.cbPencil.TabIndex = 4;
            this.cbPencil.TabStop = false;
            this.cbPencil.Text = "ดินสอ 1.50 บาท / ด้าม";
            this.cbPencil.UseVisualStyleBackColor = true;
            this.cbPencil.Click += new System.EventHandler(this.cbPencil_Click);
            // 
            // labelBaht4
            // 
            this.labelBaht4.AutoSize = true;
            this.labelBaht4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht4.Location = new System.Drawing.Point(510, 288);
            this.labelBaht4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaht4.Name = "labelBaht4";
            this.labelBaht4.Size = new System.Drawing.Size(35, 20);
            this.labelBaht4.TabIndex = 25;
            this.labelBaht4.Text = "บาท";
            // 
            // lbRuler
            // 
            this.lbRuler.BackColor = System.Drawing.Color.Yellow;
            this.lbRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuler.ForeColor = System.Drawing.Color.Red;
            this.lbRuler.Location = new System.Drawing.Point(370, 285);
            this.lbRuler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRuler.Name = "lbRuler";
            this.lbRuler.Size = new System.Drawing.Size(94, 25);
            this.lbRuler.TabIndex = 24;
            this.lbRuler.Text = "0.00";
            this.lbRuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRuler
            // 
            this.tbRuler.Location = new System.Drawing.Point(227, 289);
            this.tbRuler.Margin = new System.Windows.Forms.Padding(2);
            this.tbRuler.MaxLength = 3;
            this.tbRuler.Name = "tbRuler";
            this.tbRuler.Size = new System.Drawing.Size(97, 20);
            this.tbRuler.TabIndex = 4;
            this.tbRuler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRuler_KeyPress);
            this.tbRuler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRuler_KeyUp);
            // 
            // cbRuler
            // 
            this.cbRuler.AutoSize = true;
            this.cbRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRuler.Location = new System.Drawing.Point(46, 285);
            this.cbRuler.Margin = new System.Windows.Forms.Padding(2);
            this.cbRuler.Name = "cbRuler";
            this.cbRuler.Size = new System.Drawing.Size(159, 24);
            this.cbRuler.TabIndex = 8;
            this.cbRuler.TabStop = false;
            this.cbRuler.Text = "ไม้บรรทัด 2 บาท / อัน";
            this.cbRuler.UseVisualStyleBackColor = true;
            this.cbRuler.Click += new System.EventHandler(this.cbRuler_Click);
            // 
            // labelBaht5
            // 
            this.labelBaht5.AutoSize = true;
            this.labelBaht5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht5.Location = new System.Drawing.Point(510, 328);
            this.labelBaht5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaht5.Name = "labelBaht5";
            this.labelBaht5.Size = new System.Drawing.Size(35, 20);
            this.labelBaht5.TabIndex = 29;
            this.labelBaht5.Text = "บาท";
            // 
            // lbBook
            // 
            this.lbBook.BackColor = System.Drawing.Color.Yellow;
            this.lbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBook.ForeColor = System.Drawing.Color.Red;
            this.lbBook.Location = new System.Drawing.Point(370, 329);
            this.lbBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(94, 25);
            this.lbBook.TabIndex = 28;
            this.lbBook.Text = "0.00";
            this.lbBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBook
            // 
            this.tbBook.Location = new System.Drawing.Point(227, 332);
            this.tbBook.Margin = new System.Windows.Forms.Padding(2);
            this.tbBook.MaxLength = 3;
            this.tbBook.Name = "tbBook";
            this.tbBook.Size = new System.Drawing.Size(97, 20);
            this.tbBook.TabIndex = 5;
            this.tbBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBook_KeyPress);
            this.tbBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBook_KeyUp);
            // 
            // cbBook
            // 
            this.cbBook.AutoSize = true;
            this.cbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBook.Location = new System.Drawing.Point(46, 328);
            this.cbBook.Margin = new System.Windows.Forms.Padding(2);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(165, 24);
            this.cbBook.TabIndex = 10;
            this.cbBook.TabStop = false;
            this.cbBook.Text = "สมุด 10.25 บาท / เล่ม";
            this.cbBook.UseVisualStyleBackColor = true;
            this.cbBook.Click += new System.EventHandler(this.cbBook_Click);
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(100, 369);
            this.lbDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(55, 20);
            this.lbDiscount.TabIndex = 30;
            this.lbDiscount.Text = "ส่วนลด";
            // 
            // cbbDiscount
            // 
            this.cbbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiscount.FormattingEnabled = true;
            this.cbbDiscount.Items.AddRange(new object[] {
            "5 %",
            "10 %",
            "15 %"});
            this.cbbDiscount.Location = new System.Drawing.Point(213, 369);
            this.cbbDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDiscount.Name = "cbbDiscount";
            this.cbbDiscount.Size = new System.Drawing.Size(123, 21);
            this.cbbDiscount.TabIndex = 6;
            this.cbbDiscount.TabStop = false;
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(579, 7);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(120, 84);
            this.btMainMenu.TabIndex = 1;
            this.btMainMenu.TabStop = false;
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 504);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(728, 25);
            this.toolStrip1.TabIndex = 32;
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
            // FrmSAUShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 529);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbbDiscount);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.labelBaht5);
            this.Controls.Add(this.lbBook);
            this.Controls.Add(this.tbBook);
            this.Controls.Add(this.cbBook);
            this.Controls.Add(this.labelBaht4);
            this.Controls.Add(this.lbRuler);
            this.Controls.Add(this.tbRuler);
            this.Controls.Add(this.cbRuler);
            this.Controls.Add(this.labelBaht2);
            this.Controls.Add(this.lbPencil);
            this.Controls.Add(this.tbPencil);
            this.Controls.Add(this.cbPencil);
            this.Controls.Add(this.labelBaht3);
            this.Controls.Add(this.lbRubber);
            this.Controls.Add(this.tbRubber);
            this.Controls.Add(this.cbRubber);
            this.Controls.Add(this.labelBaht1);
            this.Controls.Add(this.lbPen);
            this.Controls.Add(this.tbPen);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.labelProductList);
            this.Controls.Add(this.cbPen);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox tbPen;
        private System.Windows.Forms.Label lbPen;
        private System.Windows.Forms.Label labelBaht1;
        private System.Windows.Forms.Label labelBaht3;
        private System.Windows.Forms.Label lbRubber;
        private System.Windows.Forms.TextBox tbRubber;
        private System.Windows.Forms.CheckBox cbRubber;
        private System.Windows.Forms.Label labelBaht2;
        private System.Windows.Forms.Label lbPencil;
        private System.Windows.Forms.TextBox tbPencil;
        private System.Windows.Forms.CheckBox cbPencil;
        private System.Windows.Forms.Label labelBaht4;
        private System.Windows.Forms.Label lbRuler;
        private System.Windows.Forms.TextBox tbRuler;
        private System.Windows.Forms.CheckBox cbRuler;
        private System.Windows.Forms.Label labelBaht5;
        private System.Windows.Forms.Label lbBook;
        private System.Windows.Forms.TextBox tbBook;
        private System.Windows.Forms.CheckBox cbBook;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.ComboBox cbbDiscount;
        private System.Windows.Forms.Label lbTotalPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPayBaht;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer;
    }
}