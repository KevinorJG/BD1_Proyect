using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports.FormReports
{
    public partial class FmClientReport : Form
    {
        private string Identification;
        private string Connection;

        public FmClientReport(string identification, string connection)
        {
            Identification = identification;
            Connection = connection;
            InitializeComponent();
        }

        private void FmClientReport_Load(object sender, EventArgs e)
        {
            //Control de errores
            try
            {   this.sp_BuscarTarjetaTableAdapter.Connection.ConnectionString = Connection;
                this.sp_BuscarClientTableAdapter.Connection.ConnectionString = Connection;
                try
                {
                    this.sp_BuscarClientTableAdapter.Fill(this.dataReportes.sp_BuscarClient, Identification);              
                }
                catch (SqlException ex)
                {
                    if (ex.Message == "Cliente no existe")
                    {
                        this.sp_BuscarClientTableAdapter.Dispose();
                    }
                }
                try
                {
                    this.sp_BuscarTarjetaTableAdapter.Fill(this.dataReportes.sp_BuscarTarjeta, Identification);                  
                }
                catch (SqlException ex)
                {
                    if (ex.Message == "Tarjeta no existe")
                    {
                        this.sp_BuscarTarjetaTableAdapter.Dispose();
                    }
                }             
               
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
               
            }
           
        }
    }
}
