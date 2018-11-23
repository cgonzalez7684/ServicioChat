using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioChat
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public String NombreCliente { get; set; }
        public String EmailCliente { get; set; }
        public String TelCliente { get; set;  }
        public DateTime FechaIngreso { get; set; }
    }

    public class ListaCliente
    {
        public int IdChat { get; set; }
        public String NombreCliente { get; set; }
        public String EmailCliente { get; set; }
        public String TelCliente { get; set; }
        public int estado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaAtencion { get; set;}
        public DateTime? FechaFinal { get; set;}
        public DateTime UltimoMensajeE { get; set; }
        public DateTime UltimoMensajeI { get; set; }
        public string dirIp { get; set; }
        public int Calificacion { get; set; }
    }
}
