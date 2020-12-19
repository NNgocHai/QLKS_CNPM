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
    public partial class FrmDoanhThuDV : Form
    {
        public FrmDoanhThuDV()
        {
            InitializeComponent();
        }

        private void FrmDoanhThuDV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSDL_KHACHSANDataSet.viewDOANHTHUDV' table. You can move, or remove it, as needed.
            this.viewDOANHTHUDVTableAdapter.Fill(this.cSDL_KHACHSANDataSet.viewDOANHTHUDV);
            // TODO: This line of code loads data into the 'doanhThu.viewDOANHTHUDV' table. You can move, or remove it, as needed.
            //this.viewDOANHTHUDVTableAdapter.Fill(this.doanhThu.viewDOANHTHUDV);
            // TODO: This line of code loads data into the 'doanhThu.viewDOANHTHUDV' table. You can move, or remove it, as needed.
            //this.viewDOANHTHUDVTableAdapter.Fill(this.doanhThu.viewDOANHTHUDV);
            // TODO: This line of code loads data into the 'doanhThu.viewDOANHTHUDV' table. You can move, or remove it, as needed.
            //this.viewDOANHTHUDVTableAdapter.Fill(this.doanhThu.viewDOANHTHUDV);
            // TODO: This line of code loads data into the 'doanhThu.viewDOANHTHUDV' table. You can move, or remove it, as needed.
            //this.viewDOANHTHUDVTableAdapter.Fill(this.doanhThu.viewDOANHTHUDV);
            // TODO: This line of code loads data into the 'doanhThu.viewDOANHTHU1' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'doanhThu.viewDOANHTHUDV' table. You can move, or remove it, as needed.



            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
