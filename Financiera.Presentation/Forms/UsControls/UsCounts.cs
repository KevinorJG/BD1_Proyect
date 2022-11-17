using Financiera.AppCore.IServices;
using Financiera.Domain.Entities;
using Financiera.Domain.Enums;
using System;
using System.Windows.Forms;

namespace Financiera.Presentation.Forms.UsControls
{
    public partial class UsCounts : UserControl
    {
        protected IAccountServices AccountServices;
        protected string Identi = string.Empty;
        protected string STATUS = string.Empty;
        public UsCounts()
        {
            InitializeComponent();
        }

        private void UsCounts_Load(object sender, EventArgs e)
        {
            cbTypeCoin.DataSource = Enum.GetValues(typeof(TypeCoin));
            cbTyCount.DataSource = Enum.GetValues(typeof(TypeCounts));
            GetAccounts();
        }

        private void txtDniClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtDniClient.Texts != string.Empty)
                {
                    var cl = AccountServices.GetClientByDni(txtDniClient.Texts);
                    if (cl != null)
                    {                       
                        Identi = cl.Identification;
                    }
                    else { MessageBox.Show("Este cliente no existe"); }
                }


            }
        }
        public void SetServices(IAccountServices accountServices)
        {
            this.AccountServices = accountServices;
        }

        private void GetAccounts()
        {
            dgvAccounts.DataSource = AccountServices.GetAccounts();
        }

        private async void btAgg_Click(object sender, EventArgs e)
        {
            Object lockinsert = new object();
            Account account = new Account()
            {
                Identi = Identi,
                Status = STATUS,
                OpenDate = DateTime.Parse(pickerDate.Text),
                TypeAccount = cbTyCount.SelectedItem.ToString(),
                TypeCoin = cbTypeCoin.SelectedItem.ToString(),
                IdHideline =  1
            };
            var result = AccountServices.InsertAccount(account);
            await result;
            lock (lockinsert)
            {
                if (result.IsCompleted) { GetAccounts(); }
            }
        }

        private void TgbtStatus_CheckedChanged(object sender, EventArgs e)
        {
            if(TgbtStatus.CheckState == CheckState.Checked){
                STATUS = "Activo";
            }else if (TgbtStatus.CheckState == CheckState.Unchecked)
            {
                STATUS = "Inactivo";
            }
        }

        private void btUptAcc_Click(object sender, EventArgs e)
        {

        }
    }
}
