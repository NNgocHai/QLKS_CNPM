
namespace QLKS__ADO.Net_CNPM.Forms
{
    partial class FrmDoanhThu
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
            this.viewDOANHTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSDL_KHACHSANDataSet = new QLKS__ADO.Net_CNPM.CSDL_KHACHSANDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewDOANHTHUTableAdapter = new QLKS__ADO.Net_CNPM.CSDL_KHACHSANDataSetTableAdapters.viewDOANHTHUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewDOANHTHUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_KHACHSANDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // viewDOANHTHUBindingSource
            // 
            this.viewDOANHTHUBindingSource.DataMember = "viewDOANHTHU";
            this.viewDOANHTHUBindingSource.DataSource = this.cSDL_KHACHSANDataSet;
            // 
            // cSDL_KHACHSANDataSet
            // 
            this.cSDL_KHACHSANDataSet.DataSetName = "CSDL_KHACHSANDataSet";
            this.cSDL_KHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.LemonChiffon;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewDOANHTHUBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKS__ADO.Net_CNPM.ReportDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1443, 664);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewDOANHTHUTableAdapter
            // 
            this.viewDOANHTHUTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1443, 664);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.FrmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewDOANHTHUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDL_KHACHSANDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CSDL_KHACHSANDataSet cSDL_KHACHSANDataSet;
        private System.Windows.Forms.BindingSource viewDOANHTHUBindingSource;
        private CSDL_KHACHSANDataSetTableAdapters.viewDOANHTHUTableAdapter viewDOANHTHUTableAdapter;
    }
}