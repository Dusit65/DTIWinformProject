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
    public partial class FrmShapeArea : Form
    {
        public FrmShapeArea()
        {
            InitializeComponent();
        }
        private void FrmShapeArea_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer.Start();
        }
        private void keyNumberAndDotOnly(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            // ตรวจสอบว่าคีย์ที่ป้อนเป็นตัวเลขหรือจุด 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // ไม่อนุญาตให้ป้อนคีย์นี้ 
            }
            // ตรวจสอบว่ามีจุดอยู่แล้วในข้อความหรือไม่ 
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // ไม่อนุญาตให้ป้อนจุดอีก 
            }
        }
        //KeyPress=============================================================================
        private void tbRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbRectHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbTriHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbSideAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
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
        //Circle Tab ========================================================================
        private void btCircleCal_Click(object sender, EventArgs e)
        {
            //Validate
            if (tbRadius.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อนรัศมี");
            }
            else
            {
                double r = double.Parse(tbRadius.Text);
                double result;
                if (rdCircleArea.Checked == true)
                {
                    result = Math.PI * Math.Pow(r, 2);
                }
                else
                {
                    result = 2 * Math.PI * r;
                }
                lbCircleShow.Text = result.ToString("0.00");
            }
        }
        private void btCircleCancel_Click(object sender, EventArgs e)
        {
            tbRadius.Clear();
            rdCircleArea.Checked = true;
            lbCircleShow.Text = "0.00";
        }
        //Rectangle Tab ================================================================

        private void btRectCal_Click(object sender, EventArgs e)
        {
            //Validate
            if (tbWidth.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อนกว้าง");

            } else if (tbRectHeight.Text.Length == 0) 
            {
                ShareData.showWarningMSG("ป้อนสูง");
            }
            else
            {
                double width = double.Parse(tbWidth.Text);
                double height = double.Parse(tbRectHeight.Text);
                double result;
                if (rdRectArea.Checked == true)
                {
                    result = width * height;
                }
                else
                {
                    result = 2 * (width + height);
                }
                lbRectShow.Text = result.ToString("0.00");
            }
        }
        private void btRectCancel_Click(object sender, EventArgs e)
        {
            tbWidth.Clear();
            tbRectHeight.Clear();
            rdRectArea.Checked = true;  
            lbRectShow.Text = "0.00";
        }
        //Triangle Tab ========================================================================
        private void btTriCal_Click(object sender, EventArgs e)
        {
            //Validate
            if (tbBase.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อนฐาน");
            }
            else if (tbTriHeight.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อนสูง");
            }
            else if (tbSideAngle.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อนด้านตรง");
            }
            else
            {
                double Tribase = double.Parse(tbBase.Text);
                double triheight = double.Parse(tbTriHeight.Text);
                double sideAngle = double.Parse(tbSideAngle.Text);
                double result;
                if (rdTriArea.Checked == true)
                {
                    result = 0.5 * Tribase * triheight;
                }
                else
                {
                    result = Tribase + triheight + sideAngle;
                }
                lbTriShow.Text = result.ToString("0.00");
            }
        }
        private void btTriCancel_Click(object sender, EventArgs e)
        {
            tbBase.Clear();
            tbTriHeight.Clear();
            tbSideAngle.Clear();
            rdTriArea.Checked = true;
            lbTriShow.Text = "0.00";
        }

    }
}
