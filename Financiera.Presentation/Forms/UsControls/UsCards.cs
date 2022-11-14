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
        }

        private void txtDniClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if(txtSearch.Texts != string.Empty)
                {
                    var cl = CardServices.GetClientByDni(txtDniClient.Texts);
                    if (cl != null)
                    {
                        txtNameCard.Text = cl.Names + " " + cl.LastNames;
                        txtNCard.Text = number = Generator.GeneradorCodigo();
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
            Object lockRegister = new object();
            Card card = new Card()
            {
                identi = txtDniClient.Texts,
                NameCard = txtNameCard.Text,
                MaxAmountCordoba =decimal.Parse(txtMounOpen.Texts),
                MaxAmountDolar = decimal.Parse(txtMounOpen.Texts),
                TypeCard = cbTypeCard.SelectedItem.ToString(),
                TypeCoin = cbTypeCoin.SelectedItem.ToString(),
                OpenDate = DateTime.Parse(PickerOpenDate.Text),
                ExpiredDate = DateTime.Parse(PickerOpenDate.Text).AddYears(5),
                FechaCorte = DateTime.Parse(PickerOpenDate.Text).AddDays(30),
                FechaPago = DateTime.Parse(PickerOpenDate.Text).AddDays(50),
                NumerCard = number,
                
            };

            var result = CardServices.Save(card);
            await result;
            lock (lockRegister)
            {
                if (result.IsCompleted) { GetCards(); }                
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
    }
}
