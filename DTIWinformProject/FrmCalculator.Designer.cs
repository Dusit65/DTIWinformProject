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
            this.btPow = new System.Windows.Forms.Button();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.cbbDecimal = new System.Windows.Forms.ComboBox();
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
            this.tbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum1_KeyPress);
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
            this.tbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum2_KeyPress);
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
            this.btPlus.Location = new System.Drawing.Point(64, 303);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(99, 87);
            this.btPlus.TabIndex = 9;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = false;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinus.ForeColor = System.Drawing.Color.Blue;
            this.btMinus.Location = new System.Drawing.Point(190, 303);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(99, 87);
            this.btMinus.TabIndex = 10;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = false;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiply.ForeColor = System.Drawing.Color.Blue;
            this.btMultiply.Location = new System.Drawing.Point(319, 303);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(99, 87);
            this.btMultiply.TabIndex = 11;
            this.btMultiply.Text = "x";
            this.btMultiply.UseVisualStyleBackColor = false;
            this.btMultiply.Click += new System.EventHandler(this.btMultiply_Click);
            // 
            // btDivide
            // 
            this.btDivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivide.ForeColor = System.Drawing.Color.Blue;
            this.btDivide.Location = new System.Drawing.Point(452, 303);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(99, 87);
            this.btDivide.TabIndex = 12;
            this.btDivide.Text = "÷";
            this.btDivide.UseVisualStyleBackColor = false;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // btPow
            // 
            this.btPow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPow.ForeColor = System.Drawing.Color.Blue;
            this.btPow.Location = new System.Drawing.Point(580, 303);
            this.btPow.Name = "btPow";
            this.btPow.Size = new System.Drawing.Size(99, 87);
            this.btPow.TabIndex = 13;
            this.btPow.Text = "^";
            this.btPow.UseVisualStyleBackColor = false;
            this.btPow.Click += new System.EventHandler(this.btPow_Click);
            // 
            // lbShowResult
            // 
            this.lbShowResult.BackColor = System.Drawing.Color.Yellow;
            this.lbShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowResult.ForeColor = System.Drawing.Color.Red;
            this.lbShowResult.Location = new System.Drawing.Point(221, 483);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(458, 94);
            this.lbShowResult.TabIndex = 14;
            this.lbShowResult.Text = "?????";
            this.lbShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(58, 516);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(106, 36);
            this.lbResult.TabIndex = 15;
            this.lbResult.Text = "ผลลัพธ์";
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
            this.toolStrip1.Size = new System.Drawing.Size(846, 25);
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
            // cbbDecimal
            // 
            this.cbbDecimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDecimal.FormattingEnabled = true;
            this.cbbDecimal.Items.AddRange(new object[] {
            "ทศนิยม 2 ตำแหน่ง",
            "ทศนิยม 4 ตำแหน่ง",
            "ทศนิยม 8 ตำแหน่ง"});
            this.cbbDecimal.Location = new System.Drawing.Point(64, 420);
            this.cbbDecimal.Name = "cbbDecimal";
            this.cbbDecimal.Size = new System.Drawing.Size(613, 39);
            this.cbbDecimal.TabIndex = 17;
            this.cbbDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbDecimal_KeyPress);
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(709, 9);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(108, 103);
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
            this.ClientSize = new System.Drawing.Size(846, 651);
            this.Controls.Add(this.cbbDecimal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbShowResult);
            this.Controls.Add(this.btPow);
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
            this.Text = "หน้าจอCalculator- DTI Soft V.1.0";
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
        private System.Windows.Forms.Button btPow;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.ComboBox cbbDecimal;
        private System.Windows.Forms.Timer timer;
    }
}