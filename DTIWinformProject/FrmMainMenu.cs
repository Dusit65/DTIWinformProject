using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DTIWinformProject
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }
        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer.Start();
        }

        private void btGoWelcome_Click(object sender, EventArgs e)
        {
            FrmWelcome frmWelcome = new FrmWelcome();
            frmWelcome.Show();
            Hide();
        }

        private void btGoCalculator_Click(object sender, EventArgs e)
        {
            FrmCalculator frmCalculator = new FrmCalculator();
            frmCalculator.Show();
            Hide();
        }

        private void btGoSAUShop_Click(object sender, EventArgs e)
        {
            FrmSAUShop frmSAUShop = new FrmSAUShop();
            frmSAUShop.Show();
            Hide();
        }

        private void btGoLotto_Click(object sender, EventArgs e)
        {
            FrmLotto frmLotto = new FrmLotto();
            frmLotto.Show();
            Hide();
        }

        private void btGoDooDuang_Click(object sender, EventArgs e)
        {
            FrmDooDuang frmDooDuang = new FrmDooDuang();
            frmDooDuang.Show();
            Hide();
        }

        private void btGoShapeArea_Click(object sender, EventArgs e)
        {
            FrmShapeArea frmShapeArea = new FrmShapeArea();
            frmShapeArea.Show();
            Hide();
        }

        private void btGoRegister_Click(object sender, EventArgs e)
        {
            FrmSAURegister frmSAURegister = new FrmSAURegister();
            frmSAURegister.Show();
            Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th_TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo );
        }
    }
}
