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
    public partial class FmCardReport : Form
    {
        public int id { get; set; }
        public string Connection { get; set; }
        private System.Security.PermissionSet Permission;
        public FmCardReport()
        {
            Permission = new System.Security.PermissionSet(System.Security.Permissions.PermissionState.Unrestricted);
            Permission.Demand();
            InitializeComponent();
        }

        //public FmCardReport(int id, string connection)
        //{
        //    this.id = id;
        //    Connection = connection;
        //    InitializeComponent();
        //}

        private void FmCardReport_Load(object sender, EventArgs e)
        {
            try
            {
                this.reporteTarjetaTableAdapter.Connection.ConnectionString = Connection;
                this.reporteTarjetaTableAdapter.Fill(this.dataReportes.ReporteTarjeta, id);
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                
            }
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
