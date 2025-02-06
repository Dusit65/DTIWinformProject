using System;

using System.Drawing;

using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmSAURegisterResult : Form
    {
        
        public FrmSAURegisterResult()
        {
            InitializeComponent();
        }
        private void FrmSAURegisterResult_Load(object sender, EventArgs e)
        {
            lbDateShow.Text = ShareData.dateRegis;
            pbImageRegisShow.Image = new Bitmap(ShareData.imgRegis);
            lbNoShow.Text = ShareData.noRegis;
            lbNameShow.Text = ShareData.nameRegis;
            lbTypeShow.Text = ShareData.typeRegis;
            lbLevelShow.Text = ShareData.levelRegis;
            lbSubjectShow.Text = ShareData.subjectRegis;

        }
    }
}
