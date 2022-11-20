using System;
using System.Collections.Generic;

#nullable disable

namespace Financiera.Domain.Views
{
    public partial class ClientsView
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Nacionalidad { get; set; }
        public string Identificación { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NúmeroTelefonico { get; set; }
        public string Domicilio { get; set; }
    }
}
