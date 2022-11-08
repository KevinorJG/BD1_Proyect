using Financiera.AppCore.IServices;
using Financiera.Commons.Processes;
using Financiera.Domain.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Financiera.Presentation.Forms.UsControls
{
    public partial class UsClients : UserControl
    {
        protected IClientServices ClientServices;

        public UsClients()
        {
            InitializeComponent();
        }

        private void pbxPhoto_Click(object sender, EventArgs e)
        {

        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {

        }


        private void UsClients_Load(object sender, EventArgs e)
        {
            //pboxLoad.Visible = false;
        }


        private void timerMenuClose_Tick(object sender, EventArgs e)
        {
        }


        private async void btAgg_Click(object sender, EventArgs e)
        {
            
            Client client = new Client()
            {
                Names = txtNames.Texts,
                LastNames = txtSurnames.Texts,
                Identification = txtDni.Texts,
                Nacionality = txtNationality.Texts,
                BirthDate = DateTime.Parse(pickerDate.Text),
                Phone = txtPhone.Texts.ToString(),
                Direction = txtDirection.Texts.ToString(),
            };

            var result = ClientServices.Save(client);
            await result;
            if (result.IsCompleted)
            {
                MessageBox.Show("Agregado");
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void SetServices(IClientServices clientServices)
        {
            this.ClientServices = clientServices;
        }
    }
}
