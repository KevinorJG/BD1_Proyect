using Financiera.AppCore.IServices;
using Financiera.AppCore.Services;
using Financiera.Commons.Processes;
using Financiera.Domain.Entities;
using Financiera.Domain.Enums;
using Reports.FormReports;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
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
            if (User.Rol == Roles.Administrador.ToString())
            {
                this.btDeleteCard.Enabled = true;
            }
            else if (User.Rol == Roles.Empleado.ToString())
            {
                this.btDeleteCard.Enabled = false;
            }
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
                        MessageBox.Show($"Nombre: {cl.Names +" "+cl.LastNames}\nCedula: " +
                                        $"{cl.Identification}","Informacion",
                                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show(Domain.ContextDB.Message.Exception, "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }                          
            }
        }

        public void SetServices(ICardServices cardServices)
        {
            this.CardServices = cardServices;
        }

        private async void btAddCard_Click(object sender, EventArgs e)
        {
            if(indeti != string.Empty)
            {
                if(cbTypeCoin.SelectedIndex  == -1)
                {
                    MessageBox.Show("Selecione el tipo de moneda");
                }
                if(cbTypeCard.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione el tipo de cuenta");
                }
                if(cbTypeCard.SelectedIndex != -1)
                {
                    if (cbTypeCoin.SelectedIndex == 0)
                    {
                        if (txtMounOpenD.Texts == string.Empty)
                        {
                            MessageBox.Show("Llene todo los espacios requeridos para registrar la tarjeta", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            decimal monto = decimal.Parse(txtMounOpenD.Texts);
                            var value = txtBaseD.Text.Replace("$", string.Empty);
                            decimal montoBase = decimal.Parse(value);
                            if (monto < montoBase)
                            {
                                MessageBox.Show($"El monto de apertura no debe de ser menor ha {txtBaseD.Text}");
                                return;
                            }
                        }
                    }
                    else if (cbTypeCoin.SelectedIndex == 1)
                    {
                        if (txtMounOpen.Texts == string.Empty)
                        {
                            MessageBox.Show("Llene todo los espacios requeridos para registrar la tarjeta", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            decimal monto = decimal.Parse(txtMounOpen.Texts);
                            var value = txtBaseC.Text.Replace("C$",string.Empty);
                            decimal montoBase = decimal.Parse(value);
                            if (monto < montoBase)
                            {
                                MessageBox.Show($"El monto de apertura no debe de ser menor ha {txtBaseC.Text}");
                                return;
                            }
                        }
                    }
                }
                
                      
            }                     
            if(indeti.Length != 0)
            {
                Object lockRegister = new object();
                Card card = new Card()
                {                  
                    NameCard = txtNameCard.Text,
                    AmounBaseDolar = Convert.ToDecimal(txtBaseD.Text.Replace("$","")),
                    AmountBaseCordoba = Convert.ToDecimal(txtBaseC.Text.Replace("C$", "")),
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
                    card.MaxAmountCordoba = 0;
                }
                else
                {
                    card.MaxAmountCordoba = Convert.ToDecimal(txtMounOpen.Texts.Replace("C$", ""));
                }
                if (txtMounOpenD.Texts == string.Empty)
                {
                    card.MaxAmountDolar = 0;

                }
                else
                {
                    card.MaxAmountDolar = Convert.ToDecimal(txtMounOpenD.Texts.Replace("$", ""));
                }
                var result = CardServices.InsertCard(card,indeti);
                await result;
                lock (lockRegister)
                {
                    if (result.IsCompleted) { GetCards(); CleanInputs(); }
                }
            }
            else
            {
                MessageBox.Show("Debe de aginar la cedula", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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
            SetColumns();
        }

        private void btSearchCard_Click(object sender, EventArgs e)
        {
            var ls = CardServices.GetCardsByDni(txtSearch.Texts);
            if (ls != null)
            {
                dgvCards.DataSource = ls;
                SetColumns();

            }
            else
            {
                MessageBox.Show(Domain.ContextDB.Message.Exception,"Sin coincidencias",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cbTypeCoin_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTypeCoin.SelectedIndex == 0)
            {
                txtMounOpenD.Visible = true;
                txtMounOpen.Visible = false;
            }
            if(cbTypeCoin.SelectedIndex == 1)
            {
                txtMounOpen.Visible = true;
                txtMounOpenD.Visible = false;
            }
        }

        private void dgvCards_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                var identi = int.Parse(Convert.ToString(dgvCards.Rows[e.RowIndex].Cells[0].Value));
                FmCardReport Reporte = new FmCardReport(identi, Connection.StringConnection);
                Thread thread = new Thread(new ThreadStart(Reporte.Show));
                //Reporte.ShowDialog();
                thread.Start();
            }
            catch (Exception ex)
            {

            }
        }
        private void CleanInputs()
        {
            txtBaseD.Clear();
            txtBaseC.Clear();
            txtMounOpen.Texts = string.Empty;
            txtMounOpenD.Texts = string.Empty;
            txtDescription.Clear();
            txtNameCard.Clear();
            txtNCard.Clear();
            txtDniClient.Texts = string.Empty;

            cbTypeCard.SelectedIndex = -1;
            cbTypeCoin.SelectedIndex = -1;
    
            PickerOpenDate.Value = DateTime.Now;         
        }

        private void btDeleteCard_Click(object sender, EventArgs e)
        {
            CleanInputs();
        }
        private void SetColumns()
        {        
            dgvCards.Columns[4].HeaderText = "Fecha Emisión";
            dgvCards.Columns[5].HeaderText = "Fecha Expiración";
            dgvCards.Columns[6].HeaderText = "TMax Córdobas";
            dgvCards.Columns[7].HeaderText = "TMax Dólares";
            dgvCards.Columns[8].HeaderText = "Fecha Corte";
            dgvCards.Columns[9].HeaderText = "Fecha Pago";

        }
    }
   
}
