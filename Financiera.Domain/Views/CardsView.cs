using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Views
{
    public partial class CardsView
    {
        public string Cliente { get; set; }
        public string Identification { get; set; }
        public string Tarjeta { get; set; }
        public DateTime FechaEmisión { get; set; }
        public DateTime FechaExpiración { get; set; }
        public decimal? TmáximaCórdobas { get; set; }
        public decimal? TmáximaDólares { get; set; }
        public DateTime? FechaCorte { get; set; }
        public DateTime? FechaPago { get; set; }
    }
}
