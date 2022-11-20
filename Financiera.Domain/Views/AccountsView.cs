using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Views
{
    public partial class AccountsView
    {
        public int Id_Account { get; set; }
        public string Cliente { get; set; }
        public string IdentificaciónCliente { get; set; }
        public string Titular { get; set; }
        public string IdentificaciónTitular { get; set; }
        public string TipoDeCuenta { get; set; }
        public string TipoDeMoneda { get; set; }
        public string EstadoDeLaCuenta { get; set; }
        public DateTime FechaDeApertura { get; set; }
    }
}
