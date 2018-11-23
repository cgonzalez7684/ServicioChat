using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class chat
    {
        public string NombreCliente { get; set; }
        public string EmailCliente { get; set; }
        public string TelCliente { get; set; }
        public DateTime? dFechaIng { get; set; }
        public DateTime? dFechaAte { get; set; }
        public DateTime? dFechaFin { get; set; }
        public string NomUsuari { get; set; }
        public int nCalifica { get; set; }
        public string cComentExt { get; set; }
        public string cComentInt { get; set; }
        public string direccionIp { get; set; }
        public string zona { get; set; }
        public string cTextoChat { get; set; }
        public Int64 nIdchat { get; set; }


    }
}
