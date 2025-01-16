using System;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmLogin : Form
    {
        //Method show warning======================================
        private void showWarningMSG(String msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //=========================================================

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ต้องการออกจากโปรแกรมใช่มั้ย", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิกใช่มั้ย", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbUsername.Clear();
                tbUsername.Focus();
                tbPassword.Clear();
                rdStudent.Checked = true;
            }
        }

        
        private void btLogin_Click(object sender, EventArgs e)
        {
            //Validate UI
            if (tbUsername.Text.Trim().Length == 0)
            {
                //MessageBox.Show("ป้อนชื่อผู้ใช้งานด้วย", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWarningMSG("ป้อนชื่อผู้ใช้งานด้วย");
            }
            else if (tbPassword.Text.Trim().Length == 0)
            {
                //MessageBox.Show("ป้อนรหัสผ่านด้วย", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWarningMSG("ป้อนรหัสผ่านด้วย");
            }
            else if (tbPassword.Text.Trim().Length < 6)
            {
                //MessageBox.Show("รหัสผ่านต้อง 6 ตัวขึ้นไป", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWarningMSG("รหัสผ่านต้อง 6 ตัวขึ้นไป");
            }
            else {
                //Validate User and Pass (sau/123456789 and dti/987654321) for go to FrmMainMenu
                if ((tbUsername.Text.Trim().ToLower() != "sau" || tbPassword.Text.Trim().ToLower() != "123456789") && 
                    (tbUsername.Text.Trim().ToLower() != "dti" || tbPassword.Text.Trim().ToLower() != "987654321"))
                {
                    showWarningMSG("ชื่อผู้ใช้และรหัสผ่านไม่ถูกต้อง");
                }
                else
                {
                    // If Username and Password correct then open to FrmMainMenu and display Username
                    ShareData.loginName = tbUsername.Text.Trim();
                    if (rdStudent.Checked == true)
                    {
                        ShareData.loginType = "student";
                    }
                    else
                    {
                        ShareData.loginType = "Teacher";
                    }
                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    frmMainMenu.Show();
                    Hide();//ปิดหน้าจอ

                }
            }
        }
    }
}
