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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.TFNum1 = new System.Windows.Forms.TextBox();
            this.TextNum1 = new System.Windows.Forms.Label();
            this.TFNum2 = new System.Windows.Forms.TextBox();
            this.TextNum2 = new System.Windows.Forms.Label();
            this.BTplus = new System.Windows.Forms.Button();
            this.BTลบ = new System.Windows.Forms.Button();
            this.BTMultiply = new System.Windows.Forms.Button();
            this.BTdivide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTMainMenu = new System.Windows.Forms.Button();
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
            this.HeadLabel.Click += new System.EventHandler(this.HeadLabel_Click);
            // 
            // TFNum1
            // 
            this.TFNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFNum1.Location = new System.Drawing.Point(235, 144);
            this.TFNum1.Name = "TFNum1";
            this.TFNum1.Size = new System.Drawing.Size(442, 34);
            this.TFNum1.TabIndex = 6;
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
            this.TextNum1.Click += new System.EventHandler(this.TextUser_Click);
            // 
            // TFNum2
            // 
            this.TFNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFNum2.Location = new System.Drawing.Point(235, 226);
            this.TFNum2.Name = "TFNum2";
            this.TFNum2.Size = new System.Drawing.Size(442, 34);
            this.TFNum2.TabIndex = 8;
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
            // BTplus
            // 
            this.BTplus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTplus.ForeColor = System.Drawing.Color.Blue;
            this.BTplus.Location = new System.Drawing.Point(83, 303);
            this.BTplus.Name = "BTplus";
            this.BTplus.Size = new System.Drawing.Size(99, 87);
            this.BTplus.TabIndex = 9;
            this.BTplus.Text = "+";
            this.BTplus.UseVisualStyleBackColor = false;
            // 
            // BTลบ
            // 
            this.BTลบ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTลบ.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTลบ.ForeColor = System.Drawing.Color.Blue;
            this.BTลบ.Location = new System.Drawing.Point(223, 303);
            this.BTลบ.Name = "BTลบ";
            this.BTลบ.Size = new System.Drawing.Size(99, 87);
            this.BTลบ.TabIndex = 10;
            this.BTลบ.Text = "-";
            this.BTลบ.UseVisualStyleBackColor = false;
            // 
            // BTMultiply
            // 
            this.BTMultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMultiply.ForeColor = System.Drawing.Color.Blue;
            this.BTMultiply.Location = new System.Drawing.Point(367, 303);
            this.BTMultiply.Name = "BTMultiply";
            this.BTMultiply.Size = new System.Drawing.Size(99, 87);
            this.BTMultiply.TabIndex = 11;
            this.BTMultiply.Text = "x";
            this.BTMultiply.UseVisualStyleBackColor = false;
            // 
            // BTdivide
            // 
            this.BTdivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTdivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdivide.ForeColor = System.Drawing.Color.Blue;
            this.BTdivide.Location = new System.Drawing.Point(515, 303);
            this.BTdivide.Name = "BTdivide";
            this.BTdivide.Size = new System.Drawing.Size(99, 87);
            this.BTdivide.TabIndex = 12;
            this.BTdivide.Text = "÷";
            this.BTdivide.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(672, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 87);
            this.button1.TabIndex = 13;
            this.button1.Text = "^";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(235, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 103);
            this.label1.TabIndex = 14;
            this.label1.Text = "?????";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 620);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1014, 31);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 28);
            this.toolStripLabel1.Text = "name?";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(76, 28);
            this.toolStripLabel2.Text = "datetime?";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ทศนิยม 2 ตำแหน่ง",
            "ทศนิยม 4 ตำแหน่ง",
            "ทศนิยม 8 ตำแหน่ง"});
            this.comboBox1.Location = new System.Drawing.Point(329, 418);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 39);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BTMainMenu
            // 
            this.BTMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.BTMainMenu.Location = new System.Drawing.Point(784, 9);
            this.BTMainMenu.Name = "BTMainMenu";
            this.BTMainMenu.Size = new System.Drawing.Size(160, 103);
            this.BTMainMenu.TabIndex = 4;
            this.BTMainMenu.Text = "หน้าจอหลัก";
            this.BTMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTMainMenu.UseVisualStyleBackColor = false;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 651);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTdivide);
            this.Controls.Add(this.BTMultiply);
            this.Controls.Add(this.BTลบ);
            this.Controls.Add(this.BTplus);
            this.Controls.Add(this.TFNum2);
            this.Controls.Add(this.TextNum2);
            this.Controls.Add(this.TFNum1);
            this.Controls.Add(this.TextNum1);
            this.Controls.Add(this.BTMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอCalculator - DTI Soft V.1.0";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button BTMainMenu;
        private System.Windows.Forms.TextBox TFNum1;
        private System.Windows.Forms.Label TextNum1;
        private System.Windows.Forms.TextBox TFNum2;
        private System.Windows.Forms.Label TextNum2;
        private System.Windows.Forms.Button BTplus;
        private System.Windows.Forms.Button BTลบ;
        private System.Windows.Forms.Button BTMultiply;
        private System.Windows.Forms.Button BTdivide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}