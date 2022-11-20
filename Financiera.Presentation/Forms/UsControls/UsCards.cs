using Financiera.AppCore.IServices;
using Financiera.Commons.Processes;
using Financiera.Domain.Entities;
using Financiera.Domain.Enums;
using System;
using System.Windows.Forms;

namespace Financiera.Presentation.Forms.UsControls
{
    public partial class UsCards : UserControl
    {
        protected ICardServices CardServices;
        string number = string.Empty;
        string indeti = string.Empty;
        public UsCards()
        {
            InitializeComponent();
        }

        private void UsCards_Load(object sender, EventArgs e)
        {
            GetCards();
            cbTypeCard.DataSource = Enum.GetValues(typeof(TypeCard));
            cbTypeCoin.DataSource = Enum.GetValues(typeof(TypeCoin));
            txtDescription.Enabled = false;         
            cbTypeCard.SelectedIndex = -1;
            txtNCard.Enabled = false;
            cbTypeCoin.SelectedIndex = -1;
            txtDescription.Text = String.Empty;
            txtNCard.Text = String.Empty;
            txtBaseC.Text = String.Empty;
            txtBaseD.Text = String.Empty;
            txtMounOpenD.Visible = false;
            txtMounOpen.Visible = false;
        }

        private void txtDniClient_KeyPress(object sender, KeyPressEventArgs e)
         {
            
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if(txtDniClient.Texts != string.Empty)
                {
                    var cl = CardServices.GetClientByDni(txtDniClient.Texts);
                    if (cl != null)
                    {
                        txtNameCard.Text = cl.Names + " " + cl.LastNames;
                        txtNCard.Text = number = Generator.GeneradorCodigo();
                        indeti = cl.Identification;
                        MessageBox.Show($"Nombre: {cl.Names +" "+cl.LastNames}\nCedula: {cl.Identification}","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Este cliente no existe"); }
                }
               
               
            }
        }
        public void SetServices(ICardServices cardServices)
        {
            this.CardServices = cardServices;
        }

        private async void btAddCard_Click(object sender, EventArgs e)
        {
            if(txtDniClient.Texts == string.Empty)
            {
                MessageBox.Show("Debe de aginar la cedula","Campo requerido",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else if(txtMounOpen.Texts == string.Empty || txtMounOpenD.Texts == string.Empty)
            {
                MessageBox.Show("Llene todo los espacios requeridos para registrar la tarjeta","Ocurrio un error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                Object lockRegister = new object();
                Card card = new Card()
                {
                    Identi = indeti,
                    NameCard = txtNameCard.Text,
                    AmounBaseDolar = decimal.Parse(txtBaseD.Text),
                    AmountBaseCordoba = decimal.Parse(txtBaseC.Text),
                    TypeCard = cbTypeCard.SelectedItem.ToString(),
                    TypeCoin = cbTypeCoin.SelectedItem.ToString(),
                    OpenDate = DateTime.Parse(PickerOpenDate.Text),
                    ExpiredDate = DateTime.Parse(PickerOpenDate.Text).AddYears(5),
                    FechaCorte = DateTime.Parse(PickerOpenDate.Text).AddDays(30),
                    FechaPago = DateTime.Parse(PickerOpenDate.Text).AddDays(50),
                    NumerCard = number,

                };
                if (txtMounOpen.Texts == string.Empty)
                {
                    card.MaxAmountCordoba = decimal.Parse("0");
                }
                if (txtMounOpenD.Texts == string.Empty)
                {
                    card.MaxAmountDolar = decimal.Parse("0");
                }
                var result = CardServices.InsertCard(card);
                await result;
                lock (lockRegister)
                {
                    if (result.IsCompleted) { GetCards(); }
                }
            }           
            
        }

        private void cbTypeCard_OnSelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbTypeCard.SelectedIndex == 0)
            {
                txtDescription.Text = Properties.Resources.Débito;
                txtDescription.TextAlign = HorizontalAlignment.Center;              
                txtBaseD.Text = "$200";
                txtBaseC.Text = "C$7200";
            }
            if(cbTypeCard.SelectedIndex == 1)
            {
                txtDescription.Text = Properties.Resources.Crédito;
                txtDescription.TextAlign = HorizontalAlignment.Center;               
                txtBaseD.Text = "$500";
                txtBaseC.Text = "C$18000";
            }
            
        }
        public void GetCards()
        {
            dgvCards.DataSource = CardServices.GetCards();
        }

        private void btSearchCard_Click(object sender, EventArgs e)
        {

        }

        private void txtMounOpen__TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTypeCoin_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTypeCoin.SelectedIndex == 0)
            {
                txtMounOpenD.Visible = false;
                txtMounOpen.Visible = true;
            }
            if(cbTypeCoin.SelectedIndex == 1)
            {
                txtMounOpen.Visible = false;
                txtMounOpenD.Visible = true;
            }
        }

        private void dgvCards_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var identi = int.Parse(Convert.ToString(dgvCards.Rows[e.RowIndex].Cells[0].Value));
                Reports.FormReports.FmCardReport Reporte = new Reports.FormReports.FmCardReport(identi, Connection.StringConnection);
                Reporte.Show();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
