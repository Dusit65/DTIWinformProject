namespace DTIWinformProject
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.TextUser = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.TFUsername = new System.Windows.Forms.TextBox();
            this.TFPassword = new System.Windows.Forms.TextBox();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.radioTeacher = new System.Windows.Forms.RadioButton();
            this.BTLogout = new System.Windows.Forms.Button();
            this.BTCancel = new System.Windows.Forms.Button();
            this.BTLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(39, 9);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(936, 68);
            this.HeadLabel.TabIndex = 0;
            this.HeadLabel.Text = "DTI Soft V.1.0";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeadLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextUser
            // 
            this.TextUser.AutoSize = true;
            this.TextUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUser.Location = new System.Drawing.Point(299, 160);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(87, 29);
            this.TextUser.TabIndex = 1;
            this.TextUser.Text = "ชื่อผู้ใช้ :";
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.Location = new System.Drawing.Point(281, 245);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(105, 29);
            this.TextPassword.TabIndex = 2;
            this.TextPassword.Text = "รหัสผ่าน :";
            // 
            // TFUsername
            // 
            this.TFUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFUsername.Location = new System.Drawing.Point(413, 155);
            this.TFUsername.Name = "TFUsername";
            this.TFUsername.Size = new System.Drawing.Size(442, 34);
            this.TFUsername.TabIndex = 3;
            // 
            // TFPassword
            // 
            this.TFPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFPassword.Location = new System.Drawing.Point(413, 240);
            this.TFPassword.Name = "TFPassword";
            this.TFPassword.PasswordChar = '*';
            this.TFPassword.Size = new System.Drawing.Size(442, 34);
            this.TFPassword.TabIndex = 4;
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Checked = true;
            this.radioStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStudent.Location = new System.Drawing.Point(480, 317);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(93, 26);
            this.radioStudent.TabIndex = 6;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Student";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // radioTeacher
            // 
            this.radioTeacher.AutoSize = true;
            this.radioTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTeacher.Location = new System.Drawing.Point(647, 317);
            this.radioTeacher.Name = "radioTeacher";
            this.radioTeacher.Size = new System.Drawing.Size(98, 26);
            this.radioTeacher.TabIndex = 7;
            this.radioTeacher.Text = "Teacher";
            this.radioTeacher.UseVisualStyleBackColor = true;
            // 
            // BTLogout
            // 
            this.BTLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLogout.Image = global::DTIWinformProject.Properties.Resources.exit3;
            this.BTLogout.Location = new System.Drawing.Point(413, 495);
            this.BTLogout.Name = "BTLogout";
            this.BTLogout.Size = new System.Drawing.Size(442, 72);
            this.BTLogout.TabIndex = 10;
            this.BTLogout.Text = "ออกจากระบบ";
            this.BTLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTLogout.UseVisualStyleBackColor = false;
            // 
            // BTCancel
            // 
            this.BTCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancel.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.BTCancel.Location = new System.Drawing.Point(647, 400);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(208, 72);
            this.BTCancel.TabIndex = 9;
            this.BTCancel.Text = "ยกเลิก";
            this.BTCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTCancel.UseVisualStyleBackColor = false;
            // 
            // BTLogin
            // 
            this.BTLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLogin.Image = global::DTIWinformProject.Properties.Resources.start;
            this.BTLogin.Location = new System.Drawing.Point(413, 400);
            this.BTLogin.Name = "BTLogin";
            this.BTLogin.Size = new System.Drawing.Size(208, 72);
            this.BTLogin.TabIndex = 8;
            this.BTLogin.Text = "เข้าใช้งานระบบ";
            this.BTLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DTIWinformProject.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(45, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 651);
            this.Controls.Add(this.BTLogout);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.BTLogin);
            this.Controls.Add(this.radioTeacher);
            this.Controls.Add(this.radioStudent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TFPassword);
            this.Controls.Add(this.TFUsername);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login-DTI Soft v.1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Label TextUser;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.TextBox TFUsername;
        private System.Windows.Forms.TextBox TFPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.RadioButton radioTeacher;
        private System.Windows.Forms.Button BTLogin;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button BTLogout;
    }
}

