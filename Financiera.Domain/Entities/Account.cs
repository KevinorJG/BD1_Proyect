using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Entities
{
    public partial class Account
    {
        public Account()
        {
            AccountDetails = new HashSet<AccountDetail>();
        }

        public int IdAccount { get; set; }
        public int? IdClient { get; set; }
        public int? IdHideline { get; set; }
        public string Identi { get; set; }
        public string TypeAccount { get; set; }
        public string TypeCoin { get; set; }
        public string Status { get; set; }
        public decimal MinAmount { get; set; }
        public DateTime OpenDate { get; set; }
        public decimal Saldo { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Hideline IdHidelineNavigation { get; set; }
        public virtual ICollection<AccountDetail> AccountDetails { get; set; }
    }
}
