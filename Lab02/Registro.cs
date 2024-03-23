using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Registro
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Placa { get; set; }
        public string Turno { get; set; }
        public string NombreConductor { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaHora { get; set; }
        public double PesoIngreso { get; set; }
    }

}
