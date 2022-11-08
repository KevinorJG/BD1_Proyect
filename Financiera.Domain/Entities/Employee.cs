using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            AccountDetails = new HashSet<AccountDetail>();
            CardDetails = new HashSet<CardDetail>();
        }

        public int IdEmployee { get; set; }
        public string Dni { get; set; }
        public string Names { get; set; }
        public string Roll { get; set; }
        public string Status { get; set; }
        public string Surnames { get; set; }

        public virtual ICollection<AccountDetail> AccountDetails { get; set; }
        public virtual ICollection<CardDetail> CardDetails { get; set; }
    }
}
