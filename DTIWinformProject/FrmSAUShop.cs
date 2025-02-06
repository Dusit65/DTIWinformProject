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
    public partial class FrmSAUShop : Form
    {
        public FrmSAUShop()
        {
            InitializeComponent();
        }

        private void FrmSAUShop_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer.Start();
            btCancel.PerformClick();
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            cbPen.Checked = false;
            cbPencil.Checked = false;
            cbRubber.Checked = false;
            cbRuler.Checked = false;
            cbBook.Checked = false;
            tbPen.Clear();
            tbPencil.Clear();
            tbRubber.Clear();
            tbRuler.Clear();
            tbBook.Clear();
            tbPen.Enabled = false;
            tbPencil.Enabled = false;
            tbRubber.Enabled = false;
            tbRuler.Enabled = false;
            tbBook.Enabled = false;
            lbPen.Text = "0.00";
            lbPencil.Text = "0.00";
            lbRubber.Text = "0.00";
            lbRuler.Text = "0.00";
            lbBook.Text = "0.00";
            cbbDiscount.SelectedIndex = 0;
            lbTotalPay.Text = "0.00";

        }
        //CheckBox========================================================================================
        private void cbPen_Click(object sender, EventArgs e)
        {
            if (cbPen.Checked) {
                tbPen.Enabled = true;
            }
            else
            {
                tbPen.Clear();
                tbPen.Enabled = false;
                lbPen.Text = "0.00";
            }
        }

        private void cbPencil_Click(object sender, EventArgs e)
        {
            if (cbPencil.Checked)
            {
                tbPencil.Enabled = true;
            }
            else
            {
                tbPencil.Clear();
                tbPencil.Enabled = false;
                lbPencil.Text = "0.00";
            }
        }

        private void cbRubber_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRubber.Checked)
            {
                tbRubber.Enabled = true;
            }
            else
            {
                tbRubber.Clear();
                tbRubber.Enabled = false;
                lbRubber.Text = "0.00";
            }
        }

        private void cbRuler_Click(object sender, EventArgs e)
        {
            if (cbRuler.Checked)
            {
                tbRuler.Enabled = true;
            }
            else
            {
                tbRuler.Clear();
                tbRuler.Enabled = false;
                lbRuler.Text = "0.00";
            }
        }

        private void cbBook_Click(object sender, EventArgs e)
        {
            if (cbBook.Checked)
            {
                tbBook.Enabled = true;
            }
            else
            {
                tbBook.Clear();
                tbBook.Enabled = false;
                lbBook.Text = "0.00";
            }
        }
        //TextBox===========================================================================
        private void tbPen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลข หรือปุ่มควบคุม เช่น Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        private void tbPencil_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลข หรือปุ่มควบคุม เช่น Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        private void tbRubber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลข หรือปุ่มควบคุม เช่น Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        private void tbRuler_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลข หรือปุ่มควบคุม เช่น Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        private void tbBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลข หรือปุ่มควบคุม เช่น Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        //TextBox Keyup===========================================================================
        private void tbPen_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPen.Text.Length > 0)
            {
                int quantity = int.Parse(tbPen.Text);
                double price = 5 * quantity;
                lbPen.Text = price.ToString("0.00");
            } else {
                lbPen.Text = "0.00";
            }
        }

        private void tbPencil_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPencil.Text.Length > 0)
            {
                int quantity = int.Parse(tbPencil.Text);
                double price = 1.50 * quantity;
                lbPencil.Text = price.ToString("0.00");
            }
            else
            {
                lbPencil.Text = "0.00";
            }
        }

        private void tbRubber_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbRubber.Text.Length > 0)
            {
                int quantity = int.Parse(tbRubber.Text);
                double price = 2.50 * quantity;
                lbRubber.Text = price.ToString("0.00");
            }
            else
            {
                lbRubber.Text = "0.00";
            }
        }

        private void tbRuler_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbRuler.Text.Length > 0)
            {
                int quantity = int.Parse(tbRuler.Text);
                double price = 2 * quantity;
                lbRuler.Text = price.ToString("0.00");
            }
            else
            {
                lbRuler.Text = "0.00";
            }
        }

        private void tbBook_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbBook.Text.Length > 0)
            {
                int quantity = int.Parse(tbBook.Text);
                double price = 10.25 * quantity;
                lbBook.Text = price.ToString("0.00");
            }
            else
            {
                lbBook.Text = "0.00";
            }
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            double totalPay = 
                double.Parse(lbPen.Text) + 
                double.Parse(lbPencil.Text) + 
                double.Parse(lbRubber.Text) + 
                double.Parse(lbRuler.Text) + 
                double.Parse(lbBook.Text);
            //Validate
            if (cbbDiscount.SelectedIndex == 0)
            {
                totalPay = totalPay - (totalPay * 5 / 100);
            }
            else if (cbbDiscount.SelectedIndex == 1)
            {
                totalPay =  totalPay - (totalPay * 10 / 100);
            }
            else if (cbbDiscount.SelectedIndex == 2)
            {
                totalPay = totalPay -(totalPay * 15 / 100);
            }
            lbTotalPay.Text = totalPay.ToString("#,###,##0.00");
        }

        private void tbPencil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
