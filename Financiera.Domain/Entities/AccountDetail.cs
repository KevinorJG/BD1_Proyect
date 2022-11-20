using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Entities
{
    public partial class AccountDetail
    {
        public int IdAccountDetails { get; set; }
        public int IdAccount { get; set; }
        public decimal Deposito { get; set; }
        public decimal Retiro { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TypeMove { get; set; }
        public string TypeGestion { get; set; }
        public string Description { get; set; }

        public virtual Account IdAccountNavigation { get; set; }
    }
}
