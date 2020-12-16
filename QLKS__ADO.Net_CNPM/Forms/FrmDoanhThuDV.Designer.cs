
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewDOANHTHUDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doanhThu = new QLKS__ADO.Net_CNPM.DoanhThu();
            this.viewDOANHTHUDVTableAdapter = new QLKS__ADO.Net_CNPM.DoanhThuTableAdapters.viewDOANHTHUDVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewDOANHTHUDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewDOANHTHUDVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKS__ADO.Net_CNPM.ReportDV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(27, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1371, 693);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewDOANHTHUDVBindingSource
            // 
            this.viewDOANHTHUDVBindingSource.DataMember = "viewDOANHTHUDV";
            this.viewDOANHTHUDVBindingSource.DataSource = this.doanhThu;
            // 
            // doanhThu
            // 
            this.doanhThu.DataSetName = "DoanhThu";
            this.doanhThu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Text = "FrmDoanhThuDV";
            this.Load += new System.EventHandler(this.FrmDoanhThuDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewDOANHTHUDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DoanhThu doanhThu;
        private System.Windows.Forms.BindingSource viewDOANHTHUDVBindingSource;
        private DoanhThuTableAdapters.viewDOANHTHUDVTableAdapter viewDOANHTHUDVTableAdapter;
    }
}