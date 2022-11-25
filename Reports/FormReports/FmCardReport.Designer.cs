namespace Reports.FormReports
{
    partial class FmCardReport
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
            this.reporteTarjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataReportes = new Reports.FormReports.DataReportes();
            this.reporteTarjetaTableAdapter = new Reports.FormReports.DataReportesTableAdapters.ReporteTarjetaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteTarjetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataReporteTarjeta";
            reportDataSource1.Value = this.reporteTarjetaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reports.FormReports.CardReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(876, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reporteTarjetaBindingSource
            // 
            this.reporteTarjetaBindingSource.DataMember = "ReporteTarjeta";
            this.reporteTarjetaBindingSource.DataSource = this.dataReportes;
            // 
            // dataReportes
            // 
            this.dataReportes.DataSetName = "DataReportes";
            this.dataReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteTarjetaTableAdapter
            // 
            this.reporteTarjetaTableAdapter.ClearBeforeFill = true;
            // 
            // FmCardReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FmCardReport";
            this.Text = "FmCardReport";
            this.Load += new System.EventHandler(this.FmCardReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteTarjetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteTarjetaBindingSource;
        private DataReportes dataReportes;
        private DataReportesTableAdapters.ReporteTarjetaTableAdapter reporteTarjetaTableAdapter;
    }
}