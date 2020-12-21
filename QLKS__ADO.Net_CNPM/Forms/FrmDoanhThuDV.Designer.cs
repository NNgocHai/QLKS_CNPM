
namespace QLKS__ADO.Net_CNPM.Forms
{
    partial class FrmDoanhThuDV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewDOANHTHUDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSDL_KHACHSANDataSet = new QLKS__ADO.Net_CNPM.CSDL_KHACHSANDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewDOANHTHUDVTableAdapter = new QLKS__ADO.Net_CNPM.CSDL_KHACHSANDataSetTableAdapters.viewDOANHTHUDVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewDOANHTHUDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_KHACHSANDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // viewDOANHTHUDVBindingSource
            // 
            this.viewDOANHTHUDVBindingSource.DataMember = "viewDOANHTHUDV";
            this.viewDOANHTHUDVBindingSource.DataSource = this.cSDL_KHACHSANDataSet;
            // 
            // cSDL_KHACHSANDataSet
            // 
            this.cSDL_KHACHSANDataSet.DataSetName = "CSDL_KHACHSANDataSet";
            this.cSDL_KHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewDOANHTHUDVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKS__ADO.Net_CNPM.ReportDoanhThuDV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1410, 744);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewDOANHTHUDVTableAdapter
            // 
            this.viewDOANHTHUDVTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDoanhThuDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1410, 744);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmDoanhThuDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu Dịch vụ";
            this.Load += new System.EventHandler(this.FrmDoanhThuDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewDOANHTHUDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_KHACHSANDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CSDL_KHACHSANDataSet cSDL_KHACHSANDataSet;
        private System.Windows.Forms.BindingSource viewDOANHTHUDVBindingSource;
        private CSDL_KHACHSANDataSetTableAdapters.viewDOANHTHUDVTableAdapter viewDOANHTHUDVTableAdapter;
    }
}