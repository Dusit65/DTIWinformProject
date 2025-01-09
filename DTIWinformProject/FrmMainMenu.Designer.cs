namespace DTIWinformProject
{
    partial class หน้าจอหลัก
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(หน้าจอหลัก));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.BTLogout = new System.Windows.Forms.Button();
            this.BTgoShapeArea = new System.Windows.Forms.Button();
            this.BTgoRegister = new System.Windows.Forms.Button();
            this.BTGoLotto = new System.Windows.Forms.Button();
            this.BTgoDooDuang = new System.Windows.Forms.Button();
            this.BTgoSAUShop = new System.Windows.Forms.Button();
            this.BTgoCalculator = new System.Windows.Forms.Button();
            this.BTgoWelcome = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(9, 7);
            this.HeadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(742, 55);
            this.HeadLabel.TabIndex = 1;
            this.HeadLabel.Text = "DTI Soft V.1.0";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 504);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // BTLogout
            // 
            this.BTLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLogout.Image = global::DTIWinformProject.Properties.Resources.exitapp;
            this.BTLogout.Location = new System.Drawing.Point(632, 304);
            this.BTLogout.Margin = new System.Windows.Forms.Padding(2);
            this.BTLogout.Name = "BTLogout";
            this.BTLogout.Size = new System.Drawing.Size(120, 140);
            this.BTLogout.TabIndex = 9;
            this.BTLogout.Text = "ออกจากระบบ";
            this.BTLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTLogout.UseVisualStyleBackColor = false;
            // 
            // BTgoShapeArea
            // 
            this.BTgoShapeArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTgoShapeArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTgoShapeArea.Image = global::DTIWinformProject.Properties.Resources.menu7;
            this.BTgoShapeArea.Location = new System.Drawing.Point(222, 304);
            this.BTgoShapeArea.Margin = new System.Windows.Forms.Padding(2);
            this.BTgoShapeArea.Name = "BTgoShapeArea";
            this.BTgoShapeArea.Size = new System.Drawing.Size(120, 140);
            this.BTgoShapeArea.TabIndex = 8;
            this.BTgoShapeArea.Text = "Go to Shape Area";
            this.BTgoShapeArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTgoShapeArea.UseVisualStyleBackColor = false;
            // 
            // BTgoRegister
            // 
            this.BTgoRegister.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTgoRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTgoRegister.Image = global::DTIWinformProject.Properties.Resources.menu6;
            this.BTgoRegister.Location = new System.Drawing.Point(430, 304);
            this.BTgoRegister.Margin = new System.Windows.Forms.Padding(2);
            this.BTgoRegister.Name = "BTgoRegister";
            this.BTgoRegister.Size = new System.Drawing.Size(120, 140);
            this.BTgoRegister.TabIndex = 7;
            this.BTgoRegister.Text = "Go to Register";
            this.BTgoRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTgoRegister.UseVisualStyleBackColor = false;
            // 
            // BTGoLotto
            // 
            this.BTGoLotto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTGoLotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGoLotto.Image = global::DTIWinformProject.Properties.Resources.menu4;
            this.BTGoLotto.Location = new System.Drawing.Point(632, 82);
            this.BTGoLotto.Margin = new System.Windows.Forms.Padding(2);
            this.BTGoLotto.Name = "BTGoLotto";
            this.BTGoLotto.Size = new System.Drawing.Size(120, 140);
            this.BTGoLotto.TabIndex = 6;
            this.BTGoLotto.Text = "Go to Lotto";
            this.BTGoLotto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTGoLotto.UseVisualStyleBackColor = false;
            // 
            // BTgoDooDuang
            // 
            this.BTgoDooDuang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTgoDooDuang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTgoDooDuang.Image = global::DTIWinformProject.Properties.Resources.menu5;
            this.BTgoDooDuang.Location = new System.Drawing.Point(14, 304);
            this.BTgoDooDuang.Margin = new System.Windows.Forms.Padding(2);
            this.BTgoDooDuang.Name = "BTgoDooDuang";
            this.BTgoDooDuang.Size = new System.Drawing.Size(120, 140);
            this.BTgoDooDuang.TabIndex = 5;
            this.BTgoDooDuang.Text = "Go to Doo Duang";
            this.BTgoDooDuang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTgoDooDuang.UseVisualStyleBackColor = false;
            // 
            // BTgoSAUShop
            // 
            this.BTgoSAUShop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTgoSAUShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTgoSAUShop.Image = global::DTIWinformProject.Properties.Resources.menu3;
            this.BTgoSAUShop.Location = new System.Drawing.Point(430, 82);
            this.BTgoSAUShop.Margin = new System.Windows.Forms.Padding(2);
            this.BTgoSAUShop.Name = "BTgoSAUShop";
            this.BTgoSAUShop.Size = new System.Drawing.Size(120, 140);
            this.BTgoSAUShop.TabIndex = 4;
            this.BTgoSAUShop.Text = "Go to SAU Shop";
            this.BTgoSAUShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTgoSAUShop.UseVisualStyleBackColor = false;
            // 
            // BTgoCalculator
            // 
            this.BTgoCalculator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTgoCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTgoCalculator.Image = global::DTIWinformProject.Properties.Resources.menu2;
            this.BTgoCalculator.Location = new System.Drawing.Point(222, 82);
            this.BTgoCalculator.Margin = new System.Windows.Forms.Padding(2);
            this.BTgoCalculator.Name = "BTgoCalculator";
            this.BTgoCalculator.Size = new System.Drawing.Size(120, 140);
            this.BTgoCalculator.TabIndex = 3;
            this.BTgoCalculator.Text = "Go to Calculator";
            this.BTgoCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTgoCalculator.UseVisualStyleBackColor = false;
            // 
            // BTgoWelcome
            // 
            this.BTgoWelcome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTgoWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTgoWelcome.Image = global::DTIWinformProject.Properties.Resources.menu1;
            this.BTgoWelcome.Location = new System.Drawing.Point(14, 82);
            this.BTgoWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.BTgoWelcome.Name = "BTgoWelcome";
            this.BTgoWelcome.Size = new System.Drawing.Size(120, 140);
            this.BTgoWelcome.TabIndex = 2;
            this.BTgoWelcome.Text = "Go to Welcome";
            this.BTgoWelcome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTgoWelcome.UseVisualStyleBackColor = false;
            // 
            // หน้าจอหลัก
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 529);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BTLogout);
            this.Controls.Add(this.BTgoShapeArea);
            this.Controls.Add(this.BTgoRegister);
            this.Controls.Add(this.BTGoLotto);
            this.Controls.Add(this.BTgoDooDuang);
            this.Controls.Add(this.BTgoSAUShop);
            this.Controls.Add(this.BTgoCalculator);
            this.Controls.Add(this.BTgoWelcome);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "หน้าจอหลัก";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอหลัก - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button BTgoWelcome;
        private System.Windows.Forms.Button BTgoCalculator;
        private System.Windows.Forms.Button BTgoSAUShop;
        private System.Windows.Forms.Button BTgoDooDuang;
        private System.Windows.Forms.Button BTGoLotto;
        private System.Windows.Forms.Button BTgoRegister;
        private System.Windows.Forms.Button BTgoShapeArea;
        private System.Windows.Forms.Button BTLogout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}