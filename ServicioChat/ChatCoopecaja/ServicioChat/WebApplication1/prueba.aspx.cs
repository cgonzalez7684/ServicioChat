using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioChat;

namespace WebApplication1
{
    public partial class prueba : System.Web.UI.Page
    {
        public static List<Chat> Listachats = new List<Chat>();
        public static List<Empleado> ListaEmpleado = new List<Empleado>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string valor;
            var chatb = new Chat();
            chatb.IdChat = 1;
            chatb.estado = 0;
            chatb.EstTecladoE = 0;
            chatb.EstTecladoI = 0;
            //chatb.pObjCliente = null;
            //chatb.pObjEmpleado = null;

            var nomb = (from Item1 in Listachats
                        join Item2 in ListaEmpleado
                        on Item1.pObjEmpleado.IdEmpleado equals Item2.IdEmpleado
                        where (Item1.IdChat == 1)
                        select new { Item2.NombreEmpleado }).FirstOrDefault();
            valor = nomb.NombreEmpleado;

            //chatb = ListaEmpleado.FirstOrDefault(n => n.IdChat == 1);
            //if (object.ReferenceEquals(null, chatb.pObjEmpleado) )
            //{
                
            //}

            //int a = 1;
        }
    }
}