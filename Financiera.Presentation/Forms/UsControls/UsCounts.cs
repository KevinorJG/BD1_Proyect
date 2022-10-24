using Financiera.AppCore.IServices;
using Financiera.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiera.Presentation.Forms.UsControls
{
    public partial class UsCounts : UserControl
    {
        protected IAccountServices AccountServices;
        public UsCounts()
        {
            InitializeComponent();
        }

        private void UsCounts_Load(object sender, EventArgs e)
        {
            cbTypeCoin.DataSource = Enum.GetValues(typeof(TypeCoin));
            cbTyCount.DataSource = Enum.GetValues(typeof(TypeCounts));
        }

        private void txtDniClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                MessageBox.Show("xd");
            }
        }
        public void SetServices(IAccountServices accountServices )
        {
            this.AccountServices = accountServices;
        }
    }
}
