using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Entities
{
    public partial class AccountDetail
    {
        public int IdAccountDetails { get; set; }
        public int IdAccount { get; set; }
        public int IdEmployee { get; set; }
        public decimal Deposito { get; set; }
        public decimal Retiro { get; set; }
        public DateTime TransactionDate { get; set; }

        public virtual Account IdAccountNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
