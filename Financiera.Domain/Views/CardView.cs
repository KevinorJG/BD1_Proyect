using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Views
{
    struct CardView
    {
        public string Cliente { get; set; }
        public string Identification { get; set; }
        public string Tarjeta { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public double MaxCordobas { get; set; }
    }
}
