using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS__ADO.Net_CNPM.Forms
{
    public partial class FrmDoanhThu : Form
    {
        public FrmDoanhThu()
        {
            InitializeComponent();
        }

        private void FrmDoanhThu_Load(object sender, EventArgs e)
        {
            
            this.viewDOANHTHUTableAdapter.Fill(this.cSDL_KHACHSANDataSet.viewDOANHTHU);
            // TODO: This line of code loads data into the 'doanhThu.viewDOANHTHU1' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
