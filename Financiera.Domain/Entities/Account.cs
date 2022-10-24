using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Entities
{
    public partial class Account
    {
        public int IdAccount { get; set; }
        public int IdClient { get; set; }
        public string TypeAccount { get; set; }
        public string TypeCoin { get; set; }
        public string Description { get; set; }
        public decimal MinAmount { get; set; }
        public DateTime OpenDate { get; set; }
        public string Status { get; set; }

        public virtual Client IdClientNavigation { get; set; }
    }
}
