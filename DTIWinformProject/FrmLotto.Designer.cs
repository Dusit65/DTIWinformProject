namespace DTIWinformProject
{
    partial class FrmLotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLotto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.labelLottoDate = new System.Windows.Forms.Label();
            this.dtpLotto = new System.Windows.Forms.DateTimePicker();
            this.gbLotto1 = new System.Windows.Forms.GroupBox();
            this.btLotto1 = new System.Windows.Forms.Button();
            this.lbLotto1 = new System.Windows.Forms.Label();
            this.gbLotto3Top = new System.Windows.Forms.GroupBox();
            this.lbLotto3Top02 = new System.Windows.Forms.Label();
            this.btLotto3Top = new System.Windows.Forms.Button();
            this.lbLotto3Top01 = new System.Windows.Forms.Label();
            this.gb3Bottom = new System.Windows.Forms.GroupBox();
            this.lbLotto3Bottom02 = new System.Windows.Forms.Label();
            this.btLotto3Bottom = new System.Windows.Forms.Button();
            this.lbLotto3Bottom01 = new System.Windows.Forms.Label();
            this.gbLotto2Bottom = new System.Windows.Forms.GroupBox();
            this.btLotto2Bottom = new System.Windows.Forms.Button();
            this.lbLotto2Bottom = new System.Windows.Forms.Label();
            this.rbOpen = new System.Windows.Forms.RadioButton();
            this.rdClose = new System.Windows.Forms.RadioButton();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.gbLotto1.SuspendLayout();
            this.gbLotto3Top.SuspendLayout();
            this.gb3Bottom.SuspendLayout();
            this.gbLotto2Bottom.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 33;
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
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(46, 7);
            this.HeadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(466, 65);
            this.HeadLabel.TabIndex = 34;
            this.HeadLabel.Text = "LOTTO หวยออนไลน์";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLottoDate
            // 
            this.labelLottoDate.AutoSize = true;
            this.labelLottoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLottoDate.Location = new System.Drawing.Point(65, 98);
            this.labelLottoDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLottoDate.Name = "labelLottoDate";
            this.labelLottoDate.Size = new System.Drawing.Size(107, 20);
            this.labelLottoDate.TabIndex = 36;
            this.labelLottoDate.Text = "ประจำงวดวันที่";
            // 
            // dtpLotto
            // 
            this.dtpLotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLotto.Location = new System.Drawing.Point(179, 94);
            this.dtpLotto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpLotto.Name = "dtpLotto";
            this.dtpLotto.Size = new System.Drawing.Size(332, 26);
            this.dtpLotto.TabIndex = 37;
            // 
            // gbLotto1
            // 
            this.gbLotto1.Controls.Add(this.btLotto1);
            this.gbLotto1.Controls.Add(this.lbLotto1);
            this.gbLotto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLotto1.Location = new System.Drawing.Point(70, 145);
            this.gbLotto1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLotto1.Name = "gbLotto1";
            this.gbLotto1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLotto1.Size = new System.Drawing.Size(448, 88);
            this.gbLotto1.TabIndex = 38;
            this.gbLotto1.TabStop = false;
            this.gbLotto1.Text = "รางวัลที่1";
            // 
            // btLotto1
            // 
            this.btLotto1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btLotto1.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btLotto1.Location = new System.Drawing.Point(382, 31);
            this.btLotto1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLotto1.Name = "btLotto1";
            this.btLotto1.Size = new System.Drawing.Size(38, 38);
            this.btLotto1.TabIndex = 39;
            this.btLotto1.UseVisualStyleBackColor = false;
            this.btLotto1.Click += new System.EventHandler(this.btLotto1_Click);
            // 
            // lbLotto1
            // 
            this.lbLotto1.AutoSize = true;
            this.lbLotto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto1.ForeColor = System.Drawing.Color.Red;
            this.lbLotto1.Location = new System.Drawing.Point(158, 32);
            this.lbLotto1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLotto1.Name = "lbLotto1";
            this.lbLotto1.Size = new System.Drawing.Size(91, 29);
            this.lbLotto1.TabIndex = 39;
            this.lbLotto1.Text = "??????";
            // 
            // gbLotto3Top
            // 
            this.gbLotto3Top.Controls.Add(this.lbLotto3Top02);
            this.gbLotto3Top.Controls.Add(this.btLotto3Top);
            this.gbLotto3Top.Controls.Add(this.lbLotto3Top01);
            this.gbLotto3Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLotto3Top.Location = new System.Drawing.Point(70, 250);
            this.gbLotto3Top.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLotto3Top.Name = "gbLotto3Top";
            this.gbLotto3Top.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLotto3Top.Size = new System.Drawing.Size(208, 112);
            this.gbLotto3Top.TabIndex = 40;
            this.gbLotto3Top.TabStop = false;
            this.gbLotto3Top.Text = "รางวัล 3 ตัวบน";
            // 
            // lbLotto3Top02
            // 
            this.lbLotto3Top02.AutoSize = true;
            this.lbLotto3Top02.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Top02.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Top02.Location = new System.Drawing.Point(63, 76);
            this.lbLotto3Top02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLotto3Top02.Name = "lbLotto3Top02";
            this.lbLotto3Top02.Size = new System.Drawing.Size(52, 29);
            this.lbLotto3Top02.TabIndex = 40;
            this.lbLotto3Top02.Text = "???";
            // 
            // btLotto3Top
            // 
            this.btLotto3Top.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btLotto3Top.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btLotto3Top.Location = new System.Drawing.Point(153, 46);
            this.btLotto3Top.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLotto3Top.Name = "btLotto3Top";
            this.btLotto3Top.Size = new System.Drawing.Size(38, 38);
            this.btLotto3Top.TabIndex = 39;
            this.btLotto3Top.UseVisualStyleBackColor = false;
            this.btLotto3Top.Click += new System.EventHandler(this.btLotto3Top_Click);
            // 
            // lbLotto3Top01
            // 
            this.lbLotto3Top01.AutoSize = true;
            this.lbLotto3Top01.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Top01.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Top01.Location = new System.Drawing.Point(63, 32);
            this.lbLotto3Top01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLotto3Top01.Name = "lbLotto3Top01";
            this.lbLotto3Top01.Size = new System.Drawing.Size(52, 29);
            this.lbLotto3Top01.TabIndex = 39;
            this.lbLotto3Top01.Text = "???";
            // 
            // gb3Bottom
            // 
            this.gb3Bottom.Controls.Add(this.lbLotto3Bottom02);
            this.gb3Bottom.Controls.Add(this.btLotto3Bottom);
            this.gb3Bottom.Controls.Add(this.lbLotto3Bottom01);
            this.gb3Bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb3Bottom.Location = new System.Drawing.Point(309, 250);
            this.gb3Bottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb3Bottom.Name = "gb3Bottom";
            this.gb3Bottom.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb3Bottom.Size = new System.Drawing.Size(208, 112);
            this.gb3Bottom.TabIndex = 42;
            this.gb3Bottom.TabStop = false;
            this.gb3Bottom.Text = "รางวัล 3 ตัวล่าง";
            // 
            // lbLotto3Bottom02
            // 
            this.lbLotto3Bottom02.AutoSize = true;
            this.lbLotto3Bottom02.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Bottom02.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Bottom02.Location = new System.Drawing.Point(63, 76);
            this.lbLotto3Bottom02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLotto3Bottom02.Name = "lbLotto3Bottom02";
            this.lbLotto3Bottom02.Size = new System.Drawing.Size(52, 29);
            this.lbLotto3Bottom02.TabIndex = 40;
            this.lbLotto3Bottom02.Text = "???";
            // 
            // btLotto3Bottom
            // 
            this.btLotto3Bottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btLotto3Bottom.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btLotto3Bottom.Location = new System.Drawing.Point(153, 46);
            this.btLotto3Bottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLotto3Bottom.Name = "btLotto3Bottom";
            this.btLotto3Bottom.Size = new System.Drawing.Size(38, 38);
            this.btLotto3Bottom.TabIndex = 39;
            this.btLotto3Bottom.UseVisualStyleBackColor = false;
            this.btLotto3Bottom.Click += new System.EventHandler(this.btLotto3Bottom_Click);
            // 
            // lbLotto3Bottom01
            // 
            this.lbLotto3Bottom01.AutoSize = true;
            this.lbLotto3Bottom01.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto3Bottom01.ForeColor = System.Drawing.Color.Red;
            this.lbLotto3Bottom01.Location = new System.Drawing.Point(63, 32);
            this.lbLotto3Bottom01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLotto3Bottom01.Name = "lbLotto3Bottom01";
            this.lbLotto3Bottom01.Size = new System.Drawing.Size(52, 29);
            this.lbLotto3Bottom01.TabIndex = 39;
            this.lbLotto3Bottom01.Text = "???";
            // 
            // gbLotto2Bottom
            // 
            this.gbLotto2Bottom.Controls.Add(this.btLotto2Bottom);
            this.gbLotto2Bottom.Controls.Add(this.lbLotto2Bottom);
            this.gbLotto2Bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLotto2Bottom.Location = new System.Drawing.Point(70, 384);
            this.gbLotto2Bottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLotto2Bottom.Name = "gbLotto2Bottom";
            this.gbLotto2Bottom.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLotto2Bottom.Size = new System.Drawing.Size(208, 112);
            this.gbLotto2Bottom.TabIndex = 41;
            this.gbLotto2Bottom.TabStop = false;
            this.gbLotto2Bottom.Text = "รางวัลเลขท้าย 2 ตัวล่าง";
            // 
            // btLotto2Bottom
            // 
            this.btLotto2Bottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btLotto2Bottom.Image = global::DTIWinformProject.Properties.Resources.start2;
            this.btLotto2Bottom.Location = new System.Drawing.Point(153, 46);
            this.btLotto2Bottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLotto2Bottom.Name = "btLotto2Bottom";
            this.btLotto2Bottom.Size = new System.Drawing.Size(38, 38);
            this.btLotto2Bottom.TabIndex = 39;
            this.btLotto2Bottom.UseVisualStyleBackColor = false;
            this.btLotto2Bottom.Click += new System.EventHandler(this.btLotto2Bottom_Click);
            // 
            // lbLotto2Bottom
            // 
            this.lbLotto2Bottom.AutoSize = true;
            this.lbLotto2Bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLotto2Bottom.ForeColor = System.Drawing.Color.Red;
            this.lbLotto2Bottom.Location = new System.Drawing.Point(56, 47);
            this.lbLotto2Bottom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLotto2Bottom.Name = "lbLotto2Bottom";
            this.lbLotto2Bottom.Size = new System.Drawing.Size(39, 29);
            this.lbLotto2Bottom.TabIndex = 39;
            this.lbLotto2Bottom.Text = "??";
            // 
            // rbOpen
            // 
            this.rbOpen.AutoSize = true;
            this.rbOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpen.Location = new System.Drawing.Point(365, 404);
            this.rbOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbOpen.Name = "rbOpen";
            this.rbOpen.Size = new System.Drawing.Size(125, 22);
            this.rbOpen.TabIndex = 44;
            this.rbOpen.Text = "เปิดการออกรางวัล";
            this.rbOpen.UseVisualStyleBackColor = true;
            this.rbOpen.Click += new System.EventHandler(this.rbOpen_Click);
            // 
            // rdClose
            // 
            this.rdClose.AutoSize = true;
            this.rdClose.Checked = true;
            this.rdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdClose.Location = new System.Drawing.Point(365, 446);
            this.rdClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdClose.Name = "rdClose";
            this.rdClose.Size = new System.Drawing.Size(121, 22);
            this.rdClose.TabIndex = 43;
            this.rdClose.TabStop = true;
            this.rdClose.Text = "ปิดการออกรางวัล";
            this.rdClose.UseVisualStyleBackColor = true;
            this.rdClose.Click += new System.EventHandler(this.rdClose_Click);
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(598, 7);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(120, 84);
            this.btMainMenu.TabIndex = 35;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = false;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 529);
            this.Controls.Add(this.rbOpen);
            this.Controls.Add(this.rdClose);
            this.Controls.Add(this.gbLotto2Bottom);
            this.Controls.Add(this.gb3Bottom);
            this.Controls.Add(this.gbLotto3Top);
            this.Controls.Add(this.gbLotto1);
            this.Controls.Add(this.dtpLotto);
            this.Controls.Add(this.labelLottoDate);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmLotto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอLotto- DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmLotto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbLotto1.ResumeLayout(false);
            this.gbLotto1.PerformLayout();
            this.gbLotto3Top.ResumeLayout(false);
            this.gbLotto3Top.PerformLayout();
            this.gb3Bottom.ResumeLayout(false);
            this.gb3Bottom.PerformLayout();
            this.gbLotto2Bottom.ResumeLayout(false);
            this.gbLotto2Bottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Label labelLottoDate;
        private System.Windows.Forms.DateTimePicker dtpLotto;
        private System.Windows.Forms.GroupBox gbLotto1;
        private System.Windows.Forms.Label lbLotto1;
        private System.Windows.Forms.Button btLotto1;
        private System.Windows.Forms.GroupBox gbLotto3Top;
        private System.Windows.Forms.Button btLotto3Top;
        private System.Windows.Forms.Label lbLotto3Top01;
        private System.Windows.Forms.Label lbLotto3Top02;
        private System.Windows.Forms.GroupBox gb3Bottom;
        private System.Windows.Forms.Label lbLotto3Bottom02;
        private System.Windows.Forms.Button btLotto3Bottom;
        private System.Windows.Forms.Label lbLotto3Bottom01;
        private System.Windows.Forms.GroupBox gbLotto2Bottom;
        private System.Windows.Forms.Button btLotto2Bottom;
        private System.Windows.Forms.Label lbLotto2Bottom;
        private System.Windows.Forms.RadioButton rbOpen;
        private System.Windows.Forms.RadioButton rdClose;
        private System.Windows.Forms.Timer timer;
    }
}