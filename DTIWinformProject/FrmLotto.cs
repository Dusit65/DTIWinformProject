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
    public partial class FrmLotto : Form
    {
        public FrmLotto()
        {
            InitializeComponent();
        }

        private void FrmLotto_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer.Start();
            rdClose.PerformClick();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();//ปิดหน้าจอ
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th_TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }
        //radio==============================================================================
        private void rdClose_Click(object sender, EventArgs e)
        {
            if (rdClose.Checked == true)
            {
                lbLotto1.Text = "??????";
                lbLotto3Top01.Text = "???";
                lbLotto3Top02.Text = "???";
                lbLotto3Bottom01.Text = "???";
                lbLotto3Bottom02.Text = "???";
                lbLotto2Bottom.Text = "??";

                btLotto1.Enabled = false;
                btLotto3Top.Enabled = false;
                btLotto3Bottom.Enabled = false;
                btLotto2Bottom.Enabled = false;

                dtpLotto.Value = DateTime.Now;


            }
        }

        private void rbOpen_Click(object sender, EventArgs e)
        {
            btLotto1.Enabled = true;
            btLotto3Top.Enabled = true;
            btLotto3Bottom.Enabled = true;
            btLotto2Bottom.Enabled = true;
        }
        //btLotto==========================================================================
        private void btLotto1_Click(object sender, EventArgs e)
        {
            //Validate ว่า เป็นวันที่ 1 หรื้อ 16 หรือไม่
            if (dtpLotto.Value.Day != 1 & dtpLotto.Value.Day != 16)
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที 1 หรือ 16 เท่านั้น");
            }
            else
            {
                //random.Next(1000000) สุ่มเลข 0-1000000
                //ดังนั้นจึงใช้.ToString("000000") เพื่อให้เลขมี 6 หลัก หลักไหนไม่มีใส่ 
                //สุ่มเลข 6 หลัก โดยใช้คลาส Random 
                Random random = new Random();
                String lotto = random.Next(1000000).ToString("000000");
                lbLotto1.Text = lotto;
                btLotto1.Enabled = false;
            }

        }

        private void btLotto3Top_Click(object sender, EventArgs e)
        {
            //Validate ว่า เป็นวันที่ 1 หรื้อ 16 หรือไม่
            if (dtpLotto.Value.Day != 1 & dtpLotto.Value.Day != 16)
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที 1 หรือ 16 เท่านั้น");
            }
            else
            {
                //สุ่มเลข 3 หลัก โดยใช้คลาส Random 
                //random.Next(1000) สุ่มเลข 0-1000
                //ดังนั้นจึงใช้.ToString("000") เพื่อให้เลขมี 3 หลัก หลักไหนไม่มีใส่ 

                Random random = new Random();
                String lotto3Top01 = random.Next(1000).ToString("000");
                String lotto3Top02 = random.Next(1000).ToString("000");
                lbLotto3Top01.Text = lotto3Top01;
                lbLotto3Top02.Text = lotto3Top02;
                btLotto3Top.Enabled = false;
            }
        }

        private void btLotto3Bottom_Click(object sender, EventArgs e)
        {
            //Validate ว่า เป็นวันที่ 1 หรื้อ 16 หรือไม่
            if (dtpLotto.Value.Day != 1 & dtpLotto.Value.Day != 16)
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที 1 หรือ 16 เท่านั้น");
            }
            else
            {
                //สุ่มเลข 3 หลัก โดยใช้คลาส Random 
                //random.Next(1000) สุ่มเลข 0-1000
                //ดังนั้นจึงใช้.ToString("000") เพื่อให้เลขมี 3 หลัก หลักไหนไม่มีใส่ 
                Random random = new Random();
                String lotto3Bottom01 = random.Next(1000).ToString("000");
                String lotto3Bottom02 = random.Next(1000).ToString("000");
                lbLotto3Bottom01.Text = lotto3Bottom01;
                lbLotto3Bottom02.Text = lotto3Bottom02;
                btLotto3Bottom.Enabled = false;
            }
        }

        private void btLotto2Bottom_Click(object sender, EventArgs e)
        {
            //Validate ว่า เป็นวันที่ 1 หรื้อ 16 หรือไม่
            if (dtpLotto.Value.Day != 1 & dtpLotto.Value.Day != 16)
            {
                ShareData.showWarningMSG("วันที่ต้องเป็นวันที 1 หรือ 16 เท่านั้น");
            }
            else
            {
                //random.Next(100) สุ่มเลข 0-100
                //ดังนั้นจึงใช้.ToString("00") เพื่อให้เลขมี 2 หลัก หลักไหนไม่มีใส่ 
                //สุ่มเลข 2 หลัก โดยใช้คลาส Random 
                Random random = new Random();
                String lotto2Bottom = random.Next(100).ToString("00");
                lbLotto2Bottom.Text = lotto2Bottom;
                btLotto2Bottom.Enabled = false;
            }
        }
    }
}
