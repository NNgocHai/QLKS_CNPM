using QLKS__ADO.Net_CNPM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS__ADO.Net_CNPM
{
    static class Program
    {
        public static int doubleclickdgv = 0;
        public static int doubleclickdgv_ThuePhong = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain("User", "0"));//new FrmMain("User","0")
        }
    }
}
