using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Entities
{
    public partial class CardDetail
    {
        public int IdCardDetails { get; set; }
        public int IdCard { get; set; }
        public decimal Deposito { get; set; }
        public decimal Retiro { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TypeGestion { get; set; }
        public string NombreComercio { get; set; }
        public string DireccionComercio { get; set; }
        public string Telefono { get; set; }
        public string CodigoComercio { get; set; }

        public virtual Card IdCardNavigation { get; set; }
    }
}
