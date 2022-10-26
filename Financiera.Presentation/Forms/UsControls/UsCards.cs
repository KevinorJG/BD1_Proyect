using Financiera.AppCore.IServices;
using Financiera.Domain.Enums;
using System;
using System.Windows.Forms;

namespace Financiera.Presentation.Forms.UsControls
{
    public partial class UsCards : UserControl
    {
        protected ICardServices CardServices;
        public UsCards()
        {
            InitializeComponent();
        }

        private void UsCards_Load(object sender, EventArgs e)
        {
            cbTypeCard.DataSource = Enum.GetValues(typeof(TypeCard));
            cbTypeCoin.DataSource = Enum.GetValues(typeof(TypeCoin));
        }

        private void txtDniClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                MessageBox.Show("xd");
            }
        }
        public void SetServices(ICardServices cardServices)
        {
            this.CardServices = cardServices;
        }
    }
}
