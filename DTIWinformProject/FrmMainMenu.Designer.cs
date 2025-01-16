namespace DTIWinformProject
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.btLogout = new System.Windows.Forms.Button();
            this.btGoShapeArea = new System.Windows.Forms.Button();
            this.btGoRegister = new System.Windows.Forms.Button();
            this.btGoLotto = new System.Windows.Forms.Button();
            this.btGoDooDuang = new System.Windows.Forms.Button();
            this.btGoSAUShop = new System.Windows.Forms.Button();
            this.btGoCalculator = new System.Windows.Forms.Button();
            this.btGoWelcome = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(12, 9);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(989, 68);
            this.HeadLabel.TabIndex = 1;
            this.HeadLabel.Text = "DTI Soft V.1.0";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.toolStrip1.TabIndex = 10;
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
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Image = global::DTIWinformProject.Properties.Resources.exitapp;
            this.btLogout.Location = new System.Drawing.Point(843, 374);
            this.btLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(160, 172);
            this.btLogout.TabIndex = 9;
            this.btLogout.Text = "ออกจากระบบ";
            this.btLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btGoShapeArea
            // 
            this.btGoShapeArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btGoShapeArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoShapeArea.Image = global::DTIWinformProject.Properties.Resources.menu7;
            this.btGoShapeArea.Location = new System.Drawing.Point(296, 374);
            this.btGoShapeArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGoShapeArea.Name = "btGoShapeArea";
            this.btGoShapeArea.Size = new System.Drawing.Size(160, 172);
            this.btGoShapeArea.TabIndex = 8;
            this.btGoShapeArea.Text = "Go to Shape Area";
            this.btGoShapeArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btGoShapeArea.UseVisualStyleBackColor = false;
            this.btGoShapeArea.Click += new System.EventHandler(this.btGoShapeArea_Click);
            // 
            // btGoRegister
            // 
            this.btGoRegister.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btGoRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoRegister.Image = global::DTIWinformProject.Properties.Resources.menu6;
            this.btGoRegister.Location = new System.Drawing.Point(573, 374);
            this.btGoRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGoRegister.Name = "btGoRegister";
            this.btGoRegister.Size = new System.Drawing.Size(160, 172);
            this.btGoRegister.TabIndex = 7;
            this.btGoRegister.Text = "Go to Register";
            this.btGoRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btGoRegister.UseVisualStyleBackColor = false;
            this.btGoRegister.Click += new System.EventHandler(this.btGoRegister_Click);
            // 
            // btGoLotto
            // 
            this.btGoLotto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btGoLotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoLotto.Image = global::DTIWinformProject.Properties.Resources.menu4;
            this.btGoLotto.Location = new System.Drawing.Point(843, 101);
            this.btGoLotto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGoLotto.Name = "btGoLotto";
            this.btGoLotto.Size = new System.Drawing.Size(160, 172);
            this.btGoLotto.TabIndex = 6;
            this.btGoLotto.Text = "Go to Lotto";
            this.btGoLotto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btGoLotto.UseVisualStyleBackColor = false;
            this.btGoLotto.Click += new System.EventHandler(this.btGoLotto_Click);
            // 
            // btGoDooDuang
            // 
            this.btGoDooDuang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btGoDooDuang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoDooDuang.Image = global::DTIWinformProject.Properties.Resources.menu5;
            this.btGoDooDuang.Location = new System.Drawing.Point(19, 374);
            this.btGoDooDuang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGoDooDuang.Name = "btGoDooDuang";
            this.btGoDooDuang.Size = new System.Drawing.Size(160, 172);
            this.btGoDooDuang.TabIndex = 5;
            this.btGoDooDuang.Text = "Go to Doo Duang";
            this.btGoDooDuang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btGoDooDuang.UseVisualStyleBackColor = false;
            this.btGoDooDuang.Click += new System.EventHandler(this.btGoDooDuang_Click);
            // 
            // btGoSAUShop
            // 
            this.btGoSAUShop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btGoSAUShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoSAUShop.Image = global::DTIWinformProject.Properties.Resources.menu3;
            this.btGoSAUShop.Location = new System.Drawing.Point(573, 101);
            this.btGoSAUShop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGoSAUShop.Name = "btGoSAUShop";
            this.btGoSAUShop.Size = new System.Drawing.Size(160, 172);
            this.btGoSAUShop.TabIndex = 4;
            this.btGoSAUShop.Text = "Go to SAU Shop";
            this.btGoSAUShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btGoSAUShop.UseVisualStyleBackColor = false;
            this.btGoSAUShop.Click += new System.EventHandler(this.btGoSAUShop_Click);
            // 
            // btGoCalculator
            // 
            this.btGoCalculator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btGoCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoCalculator.Image = global::DTIWinformProject.Properties.Resources.menu2;
            this.btGoCalculator.Location = new System.Drawing.Point(296, 101);
            this.btGoCalculator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGoCalculator.Name = "btGoCalculator";
            this.btGoCalculator.Size = new System.Drawing.Size(160, 172);
            this.btGoCalculator.TabIndex = 3;
            this.btGoCalculator.Text = "Go to Calculator";
            this.btGoCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btGoCalculator.UseVisualStyleBackColor = false;
            this.btGoCalculator.Click += new System.EventHandler(this.btGoCalculator_Click);
            // 
            // btGoWelcome
            // 
            this.btGoWelcome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btGoWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoWelcome.Image = global::DTIWinformProject.Properties.Resources.menu1;
            this.btGoWelcome.Location = new System.Drawing.Point(19, 101);
            this.btGoWelcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGoWelcome.Name = "btGoWelcome";
            this.btGoWelcome.Size = new System.Drawing.Size(160, 172);
            this.btGoWelcome.TabIndex = 2;
            this.btGoWelcome.Text = "Go to Welcome";
            this.btGoWelcome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btGoWelcome.UseVisualStyleBackColor = false;
            this.btGoWelcome.Click += new System.EventHandler(this.btGoWelcome_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 651);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btGoShapeArea);
            this.Controls.Add(this.btGoRegister);
            this.Controls.Add(this.btGoLotto);
            this.Controls.Add(this.btGoDooDuang);
            this.Controls.Add(this.btGoSAUShop);
            this.Controls.Add(this.btGoCalculator);
            this.Controls.Add(this.btGoWelcome);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMainMenu";
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
        private System.Windows.Forms.Button btGoWelcome;
        private System.Windows.Forms.Button btGoCalculator;
        private System.Windows.Forms.Button btGoSAUShop;
        private System.Windows.Forms.Button btGoDooDuang;
        private System.Windows.Forms.Button btGoLotto;
        private System.Windows.Forms.Button btGoRegister;
        private System.Windows.Forms.Button btGoShapeArea;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer;
    }
}