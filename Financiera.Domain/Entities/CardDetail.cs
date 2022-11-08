using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Entities
{
    public partial class CardDetail
    {
        public int IdCardDetails { get; set; }
        public int IdCard { get; set; }
        public int IdEmployee { get; set; }
        public decimal Deposito { get; set; }
        public decimal Retiro { get; set; }
        public DateTime TransactionDate { get; set; }

        public virtual Card IdCardNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
