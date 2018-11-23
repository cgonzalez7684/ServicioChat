using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ServicioChat
{
    public class Mensaje
    {
        public String Tipo { get; set; }//posibles valores I = Interno, E = Externo
        public String TextoMensaje { get; set; }
        public String linkMsj { get; set; }
        public int Leido { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class ListaMensaje
    {
        public string TextoMensaje { get; set; }
        public string Nombre { get; set; }
    }

}
