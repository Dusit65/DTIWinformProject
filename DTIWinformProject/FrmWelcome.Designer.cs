namespace DTIWinformProject
{
    partial class FrmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.TFUsername = new System.Windows.Forms.TextBox();
            this.TextBirthDate = new System.Windows.Forms.Label();
            this.TextUser = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BTAccept = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTMainMenu = new System.Windows.Forms.Button();
            this.radioWomen = new System.Windows.Forms.RadioButton();
            this.radioMen = new System.Windows.Forms.RadioButton();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(59, 10);
            this.HeadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(466, 84);
            this.HeadLabel.TabIndex = 2;
            this.HeadLabel.Text = "Welcome";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TFUsername
            // 
            this.TFUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFUsername.Location = new System.Drawing.Point(169, 120);
            this.TFUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TFUsername.Name = "TFUsername";
            this.TFUsername.Size = new System.Drawing.Size(332, 28);
            this.TFUsername.TabIndex = 7;
            // 
            // TextBirthDate
            // 
            this.TextBirthDate.AutoSize = true;
            this.TextBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBirthDate.Location = new System.Drawing.Point(70, 171);
            this.TextBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextBirthDate.Name = "TextBirthDate";
            this.TextBirthDate.Size = new System.Drawing.Size(91, 24);
            this.TextBirthDate.TabIndex = 6;
            this.TextBirthDate.Text = "ว/ด/ป เกิด :";
            // 
            // TextUser
            // 
            this.TextUser.AutoSize = true;
            this.TextUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUser.Location = new System.Drawing.Point(84, 124);
            this.TextUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(74, 24);
            this.TextUser.TabIndex = 5;
            this.TextUser.Text = "ชื่อ-สกุล :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 171);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(332, 28);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // BTAccept
            // 
            this.BTAccept.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAccept.Image = global::DTIWinformProject.Properties.Resources.ok;
            this.BTAccept.Location = new System.Drawing.Point(594, 310);
            this.BTAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTAccept.Name = "BTAccept";
            this.BTAccept.Size = new System.Drawing.Size(94, 64);
            this.BTAccept.TabIndex = 10;
            this.BTAccept.Text = "ตกลง";
            this.BTAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTAccept.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.button1.Location = new System.Drawing.Point(594, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "ยกเลิก";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BTMainMenu
            // 
            this.BTMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.BTMainMenu.Location = new System.Drawing.Point(578, 10);
            this.BTMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTMainMenu.Name = "BTMainMenu";
            this.BTMainMenu.Size = new System.Drawing.Size(120, 84);
            this.BTMainMenu.TabIndex = 3;
            this.BTMainMenu.Text = "หน้าจอหลัก";
            this.BTMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTMainMenu.UseVisualStyleBackColor = false;
            // 
            // radioWomen
            // 
            this.radioWomen.AutoSize = true;
            this.radioWomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWomen.Location = new System.Drawing.Point(358, 234);
            this.radioWomen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioWomen.Name = "radioWomen";
            this.radioWomen.Size = new System.Drawing.Size(52, 22);
            this.radioWomen.TabIndex = 12;
            this.radioWomen.Text = "หญิง";
            this.radioWomen.UseVisualStyleBackColor = true;
            // 
            // radioMen
            // 
            this.radioMen.AutoSize = true;
            this.radioMen.Checked = true;
            this.radioMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMen.Location = new System.Drawing.Point(233, 234);
            this.radioMen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioMen.Name = "radioMen";
            this.radioMen.Size = new System.Drawing.Size(48, 22);
            this.radioMen.TabIndex = 11;
            this.radioMen.TabStop = true;
            this.radioMen.Text = "ชาย";
            this.radioMen.UseVisualStyleBackColor = true;
            // 
            // BottomLabel
            // 
            this.BottomLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLabel.ForeColor = System.Drawing.Color.Blue;
            this.BottomLabel.Location = new System.Drawing.Point(55, 310);
            this.BottomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(470, 143);
            this.BottomLabel.TabIndex = 13;
            this.BottomLabel.Text = "?????";
            this.BottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
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
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 529);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BottomLabel);
            this.Controls.Add(this.radioWomen);
            this.Controls.Add(this.radioMen);
            this.Controls.Add(this.BTAccept);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TFUsername);
            this.Controls.Add(this.TextBirthDate);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.BTMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอWelcome - DTI Soft V.1.0";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button BTMainMenu;
        private System.Windows.Forms.TextBox TFUsername;
        private System.Windows.Forms.Label TextBirthDate;
        private System.Windows.Forms.Label TextUser;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTAccept;
        private System.Windows.Forms.RadioButton radioWomen;
        private System.Windows.Forms.RadioButton radioMen;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}