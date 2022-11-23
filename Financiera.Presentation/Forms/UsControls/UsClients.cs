using Financiera.AppCore.IServices;
using Financiera.Commons.Processes;
using Financiera.Domain.Entities;
using Financiera.Domain.Enums;
using RJCodeAdvance.RJControls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Financiera.Presentation.Forms.UsControls
{
    public partial class UsClients : UserControl
    {
        protected IClientServices ClientServices;
        int id = 0;
        public UsClients()
        {
            InitializeComponent();
        }

        private void UsClients_Load(object sender, EventArgs e)
        {
            GetClients();
            if (User.Rol == Roles.Administrador.ToString())
            {
                this.btDeleteClient.Enabled = true;
            }
            else if (User.Rol == Roles.Empleado.ToString())
            {
                this.btDeleteClient.Enabled = false;
            }
        }

        public void SetServices(IClientServices clientServices)
        {
            this.ClientServices = clientServices;
        }

        private async void btAgg_Click(object sender, EventArgs e)
        {

            if (txtNames.Text == string.Empty || txtSurnames.Text == string.Empty || txtNationality.Text == string.Empty || txtPhone.Text == string.Empty || txtDirection.Text == string.Empty)
            {
                MessageBox.Show("Asegurese de llenar todos los campos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Client client = new Client()
                {
                    Names = txtNames.Text,
                    LastNames = txtSurnames.Text,
                    Identification = txtDni.Text,
                    Nacionality = txtNationality.Text,
                    BirthDate = DateTime.Parse(pickerDate.Text),
                    Phone = txtPhone.Text.ToString(),
                    Direction = txtDirection.Text.ToString(),
                };

                var result = ClientServices.Save(client);
                await result;
                if (result.Result == 0)
                {
                    MessageBox.Show(Domain.ContextDB.Message.Exception, "Cliente existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Agregado");
                    GetClients();
                    return;
                }
            }

        }

        private void btSearchClient_Click(object sender, EventArgs e)
        {

            var cl = ClientServices.GetClientByDni(txtSearch.Texts);
            if (cl != null)
            {
                id = cl.IdClient;
                txtNames.Text = cl.Names;
                txtSurnames.Text = cl.LastNames;
                txtDni.Text = cl.Identification;
                txtPhone.Text = cl.Phone;
                txtDirection.Text = cl.Direction;
                txtNationality.Text = cl.Nacionality;
                pickerDate.Text = cl.BirthDate.ToString();
                OnClick(sender, e);
            }
            else
            {
                MessageBox.Show(Domain.ContextDB.Message.Exception, "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetClients()
        {
            dvgClients.DataSource = ClientServices.GetClients();
        }

        private void OnClick(object sender, EventArgs e)
        {
            var bt = (RJButton)sender;
            switch (bt.Name)
            {
                case "btSearchClient":
                    this.txtNames.Enabled = false;
                    this.txtSurnames.Enabled = false;
                    this.btAgg.Enabled = false;
                    break;

                case "btUpdate":
                    this.txtNames.Enabled = true;
                    this.txtSurnames.Enabled = true;
                    this.btAgg.Enabled = true;
                    break;
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            OnClick(sender, e);
            Client client = new Client()
            {
                Identification = txtDni.Text,
                Nacionality = txtNationality.Text,
                Phone = txtPhone.Text.ToString(),
                Direction = txtDirection.Text.ToString(),
                BirthDate = DateTime.Parse(pickerDate.Text)
            };
            ClientServices.UpdateClient(client, id);
            GetClients();
        }

        private void dvgClients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var identi = Convert.ToString(dvgClients.Rows[e.RowIndex].Cells[4].Value);
                var cl = ClientServices.GetClientByDni(identi);
                if (cl != null)
                {
                    id = cl.IdClient;
                    txtNames.Text = cl.Names;
                    txtSurnames.Text = cl.LastNames;
                    txtDni.Text = cl.Identification;
                    txtPhone.Text = cl.Phone;
                    txtDirection.Text = cl.Direction;
                    txtNationality.Text = cl.Nacionality;
                    pickerDate.Text = cl.BirthDate.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
