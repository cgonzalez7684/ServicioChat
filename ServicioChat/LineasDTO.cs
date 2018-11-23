using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioChat
{
    public class LineasDTO
    {
        public int nidLineaCr { get; set; }//Id de la linea
        public string cnombreLin { get; set; }//Nombre de la linea
        public decimal ntasainter { get; set; } //tasa de interés
        public int nidmoneda { get; set; }
    }

}
