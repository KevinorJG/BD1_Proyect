﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Entities
{
    public partial class Card
    {
        public Card()
        {
            CardDetails = new HashSet<CardDetail>();
        }

        public int IdCard { get; set; }
        public int IdClient { get; set; }
        public string NameCard { get; set; }
        public string TypeCard { get; set; }
        public string TypeCoin { get; set; }
        public string Description { get; set; }
        public decimal MaxAmount { get; set; }
        public decimal MinAmount { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime ExpiredDate { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual ICollection<CardDetail> CardDetails { get; set; }
    }
}
