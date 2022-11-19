namespace Reports.FormReports
{
    partial class FmClientReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataReportes = new Reports.FormReports.DataReportes();
            this.spBuscarClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BuscarClientTableAdapter = new Reports.FormReports.DataReportesTableAdapters.sp_BuscarClientTableAdapter();
            this.spBuscarTarjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BuscarTarjetaTableAdapter = new Reports.FormReports.DataReportesTableAdapters.sp_BuscarTarjetaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarTarjetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataClient";
            reportDataSource1.Value = this.spBuscarClientBindingSource;
            reportDataSource2.Name = "DataCard";
            reportDataSource2.Value = this.spBuscarTarjetaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reports.FormReports.AccountReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataReportes
            // 
            this.dataReportes.DataSetName = "DataReportes";
            this.dataReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spBuscarClientBindingSource
            // 
            this.spBuscarClientBindingSource.DataMember = "sp_BuscarClient";
            this.spBuscarClientBindingSource.DataSource = this.dataReportes;
            // 
            // sp_BuscarClientTableAdapter
            // 
            this.sp_BuscarClientTableAdapter.ClearBeforeFill = true;
            // 
            // spBuscarTarjetaBindingSource
            // 
            this.spBuscarTarjetaBindingSource.DataMember = "sp_BuscarTarjeta";
            this.spBuscarTarjetaBindingSource.DataSource = this.dataReportes;
            // 
            // sp_BuscarTarjetaTableAdapter
            // 
            this.sp_BuscarTarjetaTableAdapter.ClearBeforeFill = true;
            // 
            // FmClientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FmClientReport";
            this.Text = "FmClientReport";
            this.Load += new System.EventHandler(this.FmClientReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarTarjetaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spBuscarClientBindingSource;
        private DataReportes dataReportes;
        private System.Windows.Forms.BindingSource spBuscarTarjetaBindingSource;
        private DataReportesTableAdapters.sp_BuscarClientTableAdapter sp_BuscarClientTableAdapter;
        private DataReportesTableAdapters.sp_BuscarTarjetaTableAdapter sp_BuscarTarjetaTableAdapter;
    }
}