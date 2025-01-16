namespace DTIWinformProject
{
    partial class FrmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.TextNum1 = new System.Windows.Forms.Label();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.TextNum2 = new System.Windows.Forms.Label();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btSquared = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.cbb = new System.Windows.Forms.ComboBox();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(58, 9);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(621, 103);
            this.HeadLabel.TabIndex = 3;
            this.HeadLabel.Text = "Calculator";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNum1
            // 
            this.tbNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum1.Location = new System.Drawing.Point(235, 144);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(442, 34);
            this.tbNum1.TabIndex = 6;
            // 
            // TextNum1
            // 
            this.TextNum1.AutoSize = true;
            this.TextNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNum1.Location = new System.Drawing.Point(110, 149);
            this.TextNum1.Name = "TextNum1";
            this.TextNum1.Size = new System.Drawing.Size(127, 29);
            this.TextNum1.TabIndex = 5;
            this.TextNum1.Text = "ป้อนตัวเลข :";
            this.TextNum1.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // tbNum2
            // 
            this.tbNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum2.Location = new System.Drawing.Point(235, 226);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(442, 34);
            this.tbNum2.TabIndex = 8;
            // 
            // TextNum2
            // 
            this.TextNum2.AutoSize = true;
            this.TextNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNum2.Location = new System.Drawing.Point(110, 229);
            this.TextNum2.Name = "TextNum2";
            this.TextNum2.Size = new System.Drawing.Size(127, 29);
            this.TextNum2.TabIndex = 7;
            this.TextNum2.Text = "ป้อนตัวเลข :";
            // 
            // btPlus
            // 
            this.btPlus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlus.ForeColor = System.Drawing.Color.Blue;
            this.btPlus.Location = new System.Drawing.Point(83, 303);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(99, 87);
            this.btPlus.TabIndex = 9;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = false;
            // 
            // btMinus
            // 
            this.btMinus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinus.ForeColor = System.Drawing.Color.Blue;
            this.btMinus.Location = new System.Drawing.Point(223, 303);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(99, 87);
            this.btMinus.TabIndex = 10;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = false;
            // 
            // btMultiply
            // 
            this.btMultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiply.ForeColor = System.Drawing.Color.Blue;
            this.btMultiply.Location = new System.Drawing.Point(367, 303);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(99, 87);
            this.btMultiply.TabIndex = 11;
            this.btMultiply.Text = "x";
            this.btMultiply.UseVisualStyleBackColor = false;
            // 
            // btDivide
            // 
            this.btDivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivide.ForeColor = System.Drawing.Color.Blue;
            this.btDivide.Location = new System.Drawing.Point(515, 303);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(99, 87);
            this.btDivide.TabIndex = 12;
            this.btDivide.Text = "÷";
            this.btDivide.UseVisualStyleBackColor = false;
            // 
            // btSquared
            // 
            this.btSquared.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSquared.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSquared.ForeColor = System.Drawing.Color.Blue;
            this.btSquared.Location = new System.Drawing.Point(672, 303);
            this.btSquared.Name = "btSquared";
            this.btSquared.Size = new System.Drawing.Size(99, 87);
            this.btSquared.TabIndex = 13;
            this.btSquared.Text = "^";
            this.btSquared.UseVisualStyleBackColor = false;
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.Yellow;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(235, 483);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(458, 103);
            this.lbResult.TabIndex = 14;
            this.lbResult.Text = "?????";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResult.Location = new System.Drawing.Point(72, 516);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(106, 36);
            this.LabelResult.TabIndex = 15;
            this.LabelResult.Text = "ผลลัพธ์";
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
            this.toolStrip1.Size = new System.Drawing.Size(1014, 25);
            this.toolStrip1.TabIndex = 16;
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
            // cbb
            // 
            this.cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb.FormattingEnabled = true;
            this.cbb.Items.AddRange(new object[] {
            "ทศนิยม 2 ตำแหน่ง",
            "ทศนิยม 4 ตำแหน่ง",
            "ทศนิยม 8 ตำแหน่ง"});
            this.cbb.Location = new System.Drawing.Point(329, 418);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(213, 39);
            this.cbb.TabIndex = 17;
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(784, 9);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(160, 103);
            this.btMainMenu.TabIndex = 4;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = false;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 651);
            this.Controls.Add(this.cbb);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btSquared);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.TextNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.TextNum1);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "))";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Label TextNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label TextNum2;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btSquared;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.ComboBox cbb;
        private System.Windows.Forms.Timer timer;
    }
}