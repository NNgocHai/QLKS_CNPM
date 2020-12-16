
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.doanhThu = new QLKS__ADO.Net_CNPM.DoanhThu();
            this.viewDOANHTHU1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewDOANHTHU1TableAdapter = new QLKS__ADO.Net_CNPM.DoanhThuTableAdapters.viewDOANHTHU1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.doanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDOANHTHU1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewDOANHTHU1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKS__ADO.Net_CNPM.ReportDoanhThurdlc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(41, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1318, 642);
            this.reportViewer1.TabIndex = 0;
            // 
            // doanhThu
            // 
            this.doanhThu.DataSetName = "DoanhThu";
            this.doanhThu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewDOANHTHU1BindingSource
            // 
            this.viewDOANHTHU1BindingSource.DataMember = "viewDOANHTHU1";
            this.viewDOANHTHU1BindingSource.DataSource = this.doanhThu;
            // 
            // viewDOANHTHU1TableAdapter
            // 
            this.viewDOANHTHU1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1450, 731);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmDoanhThu";
            this.Text = "FrmDoanhThu";
            this.Load += new System.EventHandler(this.FrmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDOANHTHU1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DoanhThu doanhThu;
        private System.Windows.Forms.BindingSource viewDOANHTHU1BindingSource;
        private DoanhThuTableAdapters.viewDOANHTHU1TableAdapter viewDOANHTHU1TableAdapter;
    }
}