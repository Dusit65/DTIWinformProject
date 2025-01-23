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
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }
        //CalNumber Method===============
        private void calNumber(string opt)
        {
            //Vlaidate UI
            if (tbNum1.Text.Length == 0 || tbNum2.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อนหมายเลขให้ครบทุกช่องก่อนคำนวณด้วย");
            }
            else
            {
                double num1 = double.Parse(tbNum1.Text);
                double num2 = double.Parse(tbNum2.Text);
                double result;
                if (opt == "+")
                {
                    result = num1 + num2;
                }
                else if (opt == "-")
                {
                    result = num1 - num2;

                }
                else if (opt == "*")
                {
                    result = num1 * num2;

                }
                else if (opt == "/")
                {
                    if (num2 == 0)
                    {
                        ShareData.showWarningMSG("ไม่สามารถหารด้วย 0 ได้");
                        return;
                    }
                    else { result = num1 / num2; }

                }
                else
                {
                    result = Math.Pow(num1, num2);

                }
                if (cbbDecimal.SelectedIndex == 0)
                {
                    lbShowResult.Text = result.ToString("N2");
                }
                else if (cbbDecimal.SelectedIndex == 1)
                {
                    lbShowResult.Text = result.ToString("N4");
                }
                else
                {
                    lbShowResult.Text = result.ToString("N8");
                }
                //===================================
            }
        }
        //Event=========================================================
        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer.Start();
            cbbDecimal.SelectedIndex = 0;
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

        private void cbbDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get the TextBox control
            TextBox textBox = sender as TextBox;

            // Check if the pressed key is not a digit, not a control key (e.g., Backspace), and not a dot
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Prevent the input
                return;
            }

            // Prevent a dot if it is the first character
            if (e.KeyChar == '.' && textBox.Text.Length == 0)
            {
                e.Handled = true; // Prevent the input
                return;
            }

            // Prevent multiple dots
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // Prevent the input
            }
        }

        private void tbNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get the TextBox control
            TextBox textBox = sender as TextBox;

            // Check if the pressed key is not a digit, not a control key (e.g., Backspace), and not a dot
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Prevent the input
                return;
            }

            // Prevent a dot if it is the first character
            if (e.KeyChar == '.' && textBox.Text.Length == 0)
            {
                e.Handled = true; // Prevent the input
                return;
            }

            // Prevent multiple dots
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // Prevent the input
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            calNumber("+");
        }
        private void btMinus_Click(object sender, EventArgs e)
        {
            calNumber("-");
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            calNumber("*");
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            calNumber("/");
        }

        private void btPow_Click(object sender, EventArgs e)
        {
            calNumber("^");
        }
        //Event=========================================================
    }
}
