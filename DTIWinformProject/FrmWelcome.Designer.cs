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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.TextBirthDate = new System.Windows.Forms.Label();
            this.TextUser = new System.Windows.Forms.Label();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btAccept = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.rdWomen = new System.Windows.Forms.RadioButton();
            this.rdMen = new System.Windows.Forms.RadioButton();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(79, 12);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(621, 103);
            this.HeadLabel.TabIndex = 2;
            this.HeadLabel.Text = "Welcome";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(225, 148);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(441, 34);
            this.tbUsername.TabIndex = 7;
            // 
            // TextBirthDate
            // 
            this.TextBirthDate.AutoSize = true;
            this.TextBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBirthDate.Location = new System.Drawing.Point(93, 210);
            this.TextBirthDate.Name = "TextBirthDate";
            this.TextBirthDate.Size = new System.Drawing.Size(119, 29);
            this.TextBirthDate.TabIndex = 6;
            this.TextBirthDate.Text = "ว/ด/ป เกิด :";
            // 
            // TextUser
            // 
            this.TextUser.AutoSize = true;
            this.TextUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUser.Location = new System.Drawing.Point(112, 153);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(97, 29);
            this.TextUser.TabIndex = 5;
            this.TextUser.Text = "ชื่อ-สกุล :";
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateTimePicker.Location = new System.Drawing.Point(225, 210);
            this.birthDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(441, 34);
            this.birthDateTimePicker.TabIndex = 8;
            // 
            // btAccept
            // 
            this.btAccept.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccept.Image = global::DTIWinformProject.Properties.Resources.ok;
            this.btAccept.Location = new System.Drawing.Point(792, 382);
            this.btAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(125, 79);
            this.btAccept.TabIndex = 10;
            this.btAccept.Text = "ตกลง";
            this.btAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAccept.UseVisualStyleBackColor = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(792, 479);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 79);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(771, 12);
            this.btMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(160, 103);
            this.btMainMenu.TabIndex = 3;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = false;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // rdWomen
            // 
            this.rdWomen.AutoSize = true;
            this.rdWomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdWomen.Location = new System.Drawing.Point(477, 288);
            this.rdWomen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdWomen.Name = "rdWomen";
            this.rdWomen.Size = new System.Drawing.Size(63, 26);
            this.rdWomen.TabIndex = 12;
            this.rdWomen.Text = "หญิง";
            this.rdWomen.UseVisualStyleBackColor = true;
            // 
            // rdMen
            // 
            this.rdMen.AutoSize = true;
            this.rdMen.Checked = true;
            this.rdMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMen.Location = new System.Drawing.Point(314, 288);
            this.rdMen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdMen.Name = "rdMen";
            this.rdMen.Size = new System.Drawing.Size(58, 26);
            this.rdMen.TabIndex = 11;
            this.rdMen.TabStop = true;
            this.rdMen.Text = "ชาย";
            this.rdMen.UseVisualStyleBackColor = true;
            // 
            // BottomLabel
            // 
            this.BottomLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLabel.ForeColor = System.Drawing.Color.Blue;
            this.BottomLabel.Location = new System.Drawing.Point(73, 382);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(627, 176);
            this.BottomLabel.TabIndex = 13;
            this.BottomLabel.Text = "?????";
            this.BottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 651);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BottomLabel);
            this.Controls.Add(this.rdWomen);
            this.Controls.Add(this.rdMen);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.TextBirthDate);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอWelcome - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmWelcome_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label TextBirthDate;
        private System.Windows.Forms.Label TextUser;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.RadioButton rdWomen;
        private System.Windows.Forms.RadioButton rdMen;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer;
    }
}