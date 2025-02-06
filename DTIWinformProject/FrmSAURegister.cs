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
    public partial class FrmSAURegister : Form
    {
        public FrmSAURegister()
        {
            InitializeComponent();
        }

        private void FrmSAURegister_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer.Start();
            btCancel.PerformClick();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th_TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        

        //bt Function==========================================================================
        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();//ปิดหน้าจอ
        }
        
        private void btCancel_Click(object sender, EventArgs e)
        {
            List<string> subjects = new List<string>
            {
                "ภาษาไทย",
                "ภาษาอังกฤษ",
                "ภาษาญี่ปุ่น",
                "ภาษาจีน",
                "สังคมศึกษา",
                "คณิตศาสตร์",
                "พลศึกษา",
                "ประวัติศาสตร์",
                "คอมพิวเตอร์เบื้องต้น",
                "บัญชีเบื้องต้น",
                "กฎหมายเบื้องต้น",
                "เศรษฐศาสตร์เบื้องต้น",
                "หลักการบริหาร",
                "เคมี",
                "ชีววิทยา"
            };
            mcdRegis.SetDate(DateTime.Now);
            tbNoRegis.Clear();
            tbNameRegis.Clear();
            rdNormalRegis.Checked = true;
            cbbLevelRegis.SelectedIndex = 0;
            cbConfirmRegis.Checked = false;
            pbImageRegis.Image = null;

            lsbSubjectRegis.Items.Clear(); // clear all lsbSubjectRegis
            lsbSubjectSelectedRegis.Items.Clear(); // clear all lsbSubjectSelectedRegis

            lsbSubjectRegis.Items.AddRange(subjects.ToArray());// add all subject to lsbSubjectRegis
            /*
            lsbSubjectSelectedRegis.Items.Clear();
            lsbSubjectRegis.Items.Add("ภาษาไทย");
            lsbSubjectRegis.Items.Add("ภาษาอังกฤษ");
            lsbSubjectRegis.Items.Add("ภาษาญี่ปุ่น");
            lsbSubjectRegis.Items.Add("ภาษาจีน");
            lsbSubjectRegis.Items.Add("สังคมศึกษา");
            lsbSubjectRegis.Items.Add("คณิตศาสตร์");
            lsbSubjectRegis.Items.Add("พลศึกษา");
            lsbSubjectRegis.Items.Add("ประวัติศาสตร์");
            lsbSubjectRegis.Items.Add("คอมพิวเตอร์เบื้องต้น");
            lsbSubjectRegis.Items.Add("บัญชีเบื้องต้น");
            lsbSubjectRegis.Items.Add("กฏหมายเบื้องต้น");
            lsbSubjectRegis.Items.Add("เศรษฐศาสตร์เบื้องต้น");
            lsbSubjectRegis.Items.Add("หลักการบริหาร");
            lsbSubjectRegis.Items.Add("เคมี");
            lsbSubjectRegis.Items.Add("ชีววิทยา");
            */
        }

        private void btSelectImageRegis_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.png) |*.jpg; *.jpeg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImageRegis.Image = new Bitmap(openFileDialog1.FileName);
                //pbImageRegis.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        //bt select subject+++++++++++++++++++++++++++++++++++++++++
        private void btSelectSub_Click(object sender, EventArgs e)
        {
            if ( lsbSubjectRegis.SelectedIndex < 0 ) //Validate subject is selected?
            {
                ShareData.showWarningMSG("กรุณาเลือกวิชาที่ต้องการลงทะเบียน");
            }
            else // selected subject add to lsbSubjectSelected
            {
                lsbSubjectSelectedRegis.Items.Add(lsbSubjectRegis.Items[lsbSubjectRegis.SelectedIndex]);
                lsbSubjectRegis.Items.RemoveAt(lsbSubjectRegis.SelectedIndex);
            }
            
        }
        //bt unselect subject+++++++++++++++++++++++++++++++++++++++++
        private void btUnSelectSub_Click(object sender, EventArgs e)
        {
            if (lsbSubjectSelectedRegis.SelectedIndex < 0) //Validate subject is selected?
            {
                ShareData.showWarningMSG("กรุณาเลือกวิชาที่ไม่ต้องการลงทะเบียน");
            }
            else // ีืselected subject add to lsbSubjectSelected
            {
                lsbSubjectRegis.Items.Add(lsbSubjectSelectedRegis.Items[lsbSubjectSelectedRegis.SelectedIndex]);
                lsbSubjectSelectedRegis.Items.RemoveAt(lsbSubjectSelectedRegis.SelectedIndex);
            }
        }
        //bt select all subject+++++++++++++++++++++++++++++++++++++++++
        private void btSelectAllSub_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีรายการใน lsbSubjectRegis หรือไม่
            if (lsbSubjectRegis.Items.Count > 0)
            {
                // เพิ่มรายการจาก lsbSubjectRegis ไปยัง lsbSubjectSelectedRegis
                lsbSubjectSelectedRegis.Items.AddRange(lsbSubjectRegis.Items);

                // ล้างข้อมูลใน lsbSubjectRegis
                lsbSubjectRegis.Items.Clear();
            }
        }

        private void btUnSelectAllSub_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีรายการใน lsbSubjectSelectedRegis หรือไม่
            if (lsbSubjectSelectedRegis.Items.Count > 0)
            {
                // เพิ่มรายการจาก lsbSubjectSelectedRegis ไปยัง lsbSubjectRegis
                lsbSubjectRegis.Items.AddRange(lsbSubjectSelectedRegis.Items);

                // ล้างข้อมูลใน lsbSubjectSelectedRegis
                lsbSubjectSelectedRegis.Items.Clear();
            }
        }

        private void btRegis_Click(object sender, EventArgs e)
        {
            if (tbNoRegis.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณาป้อนเลขประจำตัวนักเรียน");
            }
            else if (tbNameRegis.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("กรุณาป้อนชื่อ-สกุล");
            }
            else if (openFileDialog1.FileName == "")
            {
                ShareData.showWarningMSG("กรุณาเลือกรูป");
            }
            else if (lsbSubjectSelectedRegis.Items.Count <= 0)
            {
                ShareData.showWarningMSG("กรุณาเลือกรายวิชาที่ต้องการลงทะเบียน");
            }
            else if (lsbSubjectSelectedRegis.Items.Count > 7)
            {
                ShareData.showWarningMSG("เลือกรายวิชาที่ต้องการลงทะเบียนได้สูงสุด 7 วิชาเท่านั้น");
            }

            else if (!cbConfirmRegis.Checked)
            {
                ShareData.showWarningMSG("กรุณายันยันการลงทะเบียน");
            }
            else
            {
                ShareData.noRegis = tbNoRegis.Text.Trim();
                ShareData.nameRegis = tbNameRegis.Text.Trim();
                CultureInfo cultureInfo = new CultureInfo("th-TH");
                ShareData.dateRegis = mcdRegis.SelectionStart.ToString("dd/MM/yyyy", cultureInfo);
                ShareData.typeRegis = rdNormalRegis.Checked ? "ปกติ" : "นักเรียนกองทุน";
                ShareData.levelRegis = cbbLevelRegis.SelectedItem.ToString();
                ShareData.imgRegis = openFileDialog1.FileName;

                //เอาวิชาที่เลือกมาเก็บไว้ใน List
                foreach (var item in lsbSubjectSelectedRegis.Items)
                {
                    ShareData.subjectRegist.Add(item.ToString());
                }

                //แปลง list เป็น string
                ShareData.subjectRegis = string.Join("\n", ShareData.subjectRegist);

                FrmSAURegisterResult frmregisterResult = new FrmSAURegisterResult();
                frmregisterResult.Show();
                Hide();
            }
            /*
            //Validate 
            if(tbNoRegis.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนเลขประจำตัวด้วย");
            }
            else if ( tbNameRegis.Text.Trim().Length == 0) 
            {
                ShareData.showWarningMSG("ป้อนชื่อด้วย");
            }
            else if (lsbSubjectSelectedRegis.Items.Count == 0)
            {
                ShareData.showWarningMSG("เลือกยอย่างน้อย 1 วิชาด้วย");
            }
            else if (lsbSubjectSelectedRegis.Items.Count >7)
            {
                ShareData.showWarningMSG("ห้ามเลือกเกิน 7 วิชาด้วย");
            }
            else if (openFileDialog1.FileName == "")
            {
                ShareData.showWarningMSG("เลือกรูปภาพด้วย");
            }
            else if (cbConfirmRegis.Checked == false)
            {
                ShareData.showWarningMSG("ยืนยันการลงทะเบียนด้วย");
            }
            else
            {

                //Packing data 
                CultureInfo cultureInfo = new CultureInfo("th_TH");
                ShareData.imgRegis = openFileDialog1.FileName;
                ShareData.dateRegis = mcdRegis.SelectionStart.ToString("dd/MM/yyyy", cultureInfo);
                ShareData.noRegis = tbNoRegis.Text.Trim();
                ShareData.nameRegis = tbNameRegis.Text.Trim();
                ShareData.typeRegis = rdNormalRegis.Checked ? "ปกติ" : "เทียบโอน";
                ShareData.levelRegis = cbbLevelRegis.SelectedItem.ToString();
                ShareData.subjectRegist = new List<string>();
                foreach (var item in lsbSubjectSelectedRegis.Items)
                {
                    ShareData.subjectRegist.Add(item.ToString());
                }
                ShareData.subjectRegis = string.Join("\n", ShareData.subjectRegis);

                FrmSAURegisterResult frmSAURegisterResult = new FrmSAURegisterResult();
                frmSAURegisterResult.Show();
                Hide();


            }*/
        }
    }
}
