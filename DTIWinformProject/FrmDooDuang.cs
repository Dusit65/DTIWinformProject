using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmDooDuang : Form
    {
        public FrmDooDuang()
        {
            InitializeComponent();
        }
        private void FrmDooDuang_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer.Start();
            btNew.PerformClick();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th_TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();//ปิดหน้าจอ
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            mtbIDcard.Clear();
            tbFullname.Clear();
            dtpBirthDate.Value = DateTime.Now;
            nudHeight.Value = 0;
            nudWeight.Value = 0;

            lbIDcard.Text = "XXXXXXXXXX";
            lbFullname.Text = "XXXXXXXXXX";
            lbBirthDate.Text = "XXXXXXXXXX";
            lbAge.Text = "XXXXXXXXXX";
            lbWeight.Text = "XXXXXXXXXX";
            lbHeight.Text = "XXXXXXXXXX";
            lbBMI.Text = "XXXXXXXXXX";

            lbShowResult.Text = "ผลดวง";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();//ปิดหน้าจอ
        }
        private void mtbIDcard_Click(object sender, EventArgs e)
        {
            mtbIDcard.SelectionStart = 0;
        }
        private void btDooDeung_Click(object sender, EventArgs e)
        {
            //Validate
            if (mtbIDcard.MaskCompleted == false)
            {
                ShareData.showWarningMSG("ป้อนเลขประจำตัวประชาชนด้วย");
            } else if (tbFullname.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนชื่อ-สกุลด้วย");
            }
            else if (dtpBirthDate.Value.Year >= DateTime.Now.Year)
            {
                ShareData.showWarningMSG("ป้อนวันเกิดด้วย");
            }
            else if (nudWeight.Value == 0)
            {
                ShareData.showWarningMSG("ป้อนน้ำหนักด้วย");
            }
            else if (nudWeight.Value == 0)
            {
                ShareData.showWarningMSG("ป้อนส่วนสูงด้วย");
            } else
            {
                lbIDcard.Text = mtbIDcard.Text;
                lbFullname.Text = tbFullname.Text.Trim();

                CultureInfo cultureInfo = new CultureInfo("th-TH");
                lbBirthDate.Text = dtpBirthDate.Value.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy", cultureInfo);

                int age = DateTime.Now.Year - dtpBirthDate.Value.Year;
                lbAge.Text = age.ToString();

                lbWeight.Text = nudWeight.Value.ToString();
                lbHeight.Text = nudHeight.Value.ToString();

                double height = (double)nudHeight.Value / 100;
                double bmi = (double)nudWeight.Value / Math.Pow(height, 2);
                lbBMI.Text = bmi.ToString("0.00");

                //ผลด่วงดูจากเดือน
                int month = dtpBirthDate.Value.Month;
                switch (month) {
                    case 1: lbShowResult.Text = "มีโชคดีมาก111"; break;
                    case 2: lbShowResult.Text = "มีโชคดีมาก222"; break;
                    case 3: lbShowResult.Text = "มีโชคดีมาก333"; break;
                    case 4: lbShowResult.Text = "มีโชคดีมาก444"; break;
                    case 5: lbShowResult.Text = "มีโชคดีมาก555"; break;
                    case 6: lbShowResult.Text = "มีโชคดีมาก666"; break;
                    case 7: lbShowResult.Text = "มีโชคดีมาก777"; break;
                    case 8: lbShowResult.Text = "มีโชคดีมาก888"; break;
                    case 9: lbShowResult.Text = "มีโชคดีมาก999"; break;
                    case 10: lbShowResult.Text = "มีโชคดีมาก101010"; break;
                    case 11: lbShowResult.Text = "มีโชคดีมาก111111"; break;
                    case 12: lbShowResult.Text = "มีโชคดีมาก121212"; break;


                }

            }
        }

        private void tbFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            // อนุญาตเฉพาะตัวอักษร (A-Z, a-z), ปุ่มควบคุม (เช่น Backspace) และ Space เท่านั้น
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // ป้องกันไม่ให้พิมพ์ตัวเลขหรืออักขระพิเศษ
            }
        }
    }
}
