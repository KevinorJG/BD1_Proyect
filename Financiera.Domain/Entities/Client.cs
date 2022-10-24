using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Entities
{
    public partial class Client
    {
        public Client()
        {
            Accounts = new HashSet<Account>();
            Cards = new HashSet<Card>();
        }

        public int IdClient { get; set; }
        public string Names { get; set; }
        public string LastNames { get; set; }
        public string Direction { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Identification { get; set; }
        public byte[] Photo { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
    }
}
