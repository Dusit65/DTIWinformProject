using System;
using System.Globalization;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();//ปิดหน้าจอ
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer.Start();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th_TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            //Validate UI
            if (tbFullname.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนชื่อด้วย....");
            }
            else if (dtBirthDate.Value.Year >= DateTime.Now.Year)
            {
                ShareData.showWarningMSG("ปีเกิดต้องน้อยกว่าปีปัจจุบัน....");
            }
            else
            {
                //นำข้อมูลไปแสดงผล โดยต้องคำนวณอายุด้วย แล้ววันเดือนปีเกิดต้องแสดงเป็นวันที่ไทย
                int age = DateTime.Now.Year - dtBirthDate.Value.Year;

                string birthDate = dtBirthDate.Value.ToString("วันที่ d MMMM พ.ศ. yyyy", new CultureInfo("th-TH"));
                /*
                string gender;
                if (rdMale.Checked == true)
                {
                    gender = "ชาย";
                }
                else
                {
                    gender = "หญิง";
                }
                */
                string gender = rdMale.Checked == true ? "ชาย" : "หญิง";

                string dataShow = "ชื่อ : " + tbFullname.Text + "\n" +
                                  "วันเกิด : " + birthDate + "\n" +
                                  "อายุ : " + age + "\n" +
                                   "อายุ : " + gender;
                //show Result
                lbResult.Text = dataShow;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิกใช่มั้ย", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbFullname.Clear();
                tbFullname.Focus();
                dtBirthDate.Value = DateTime.Now;
                rdMale.Checked = true;
                lbResult.Text = "Welcome";
            }
        }
    }
}
