using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Entities
{
    public partial class Hideline
    {
        public Hideline()
        {
            Accounts = new HashSet<Account>();
        }

        public int IdHideline { get; set; }
        public string Identification { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
