using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace menudangnhap
{
    class save
    {
        static bool kt = true;
        public static bool KT
        {
            set
            {
                kt = value;
            }
            get { return kt; }
        }
        static SqlConnection con = null;
        public static SqlConnection Con
        {
            set { con = value; }
            get { return con; }
        }
        internal static class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmChinh());
            }
        }
    }
}
