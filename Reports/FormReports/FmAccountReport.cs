using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports.FormReports
{
    public partial class FmAccountReport : Form
    {
        public int id { get; set; }
        public string Connection { get; set; }
        private System.Security.PermissionSet Permission;

        public FmAccountReport()
        {
            Permission = new System.Security.PermissionSet(System.Security.Permissions.PermissionState.Unrestricted);
            Permission.Demand();
            InitializeComponent();
        }

        //public FmAccountReport(int id, string connection)
        //{
        //    this.id = id;
        //    Connection = connection;
        //    InitializeComponent();
        //}

        private void FmAccountReport_Load(object sender, EventArgs e)
        {
            try
            {
                this.reporteCuentaTableAdapter.Connection.ConnectionString = Connection;
                this.reporteCuentaTableAdapter.Fill(this.dataReportes.ReporteCuenta, id);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
           
        }
    }
}
