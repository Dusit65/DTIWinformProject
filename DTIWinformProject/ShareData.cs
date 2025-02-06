using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    internal class ShareData
    {
        public static String loginName;
        public static String loginType;

        public static String noRegis;
        public static String nameRegis;
        public static String typeRegis;
        public static String dateRegis;
        public static String imgRegis;
        public static String levelRegis;
        public static String subjectRegisItems;
        public static List<string> subjectRegisItemsShow = new List<string>();

        //Method show warning======================================
        public static void showWarningMSG(String msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //=========================================================
    }
}
