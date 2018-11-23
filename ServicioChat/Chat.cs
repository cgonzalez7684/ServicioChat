using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioChat
{
    public class Chat
    {
        public int IdChat { get; set; }//ALMACENDA EL ID DEL CHAT
        public Cliente pObjCliente { get; set; }//OBJETO TIPO CLIENTE QUE VA A CONTENER LOS DATOS DEL CLIENTE
        public Empleado pObjEmpleado { get; set; }//OBJETO TIPO EMPLEADO QUE VA A CONTENER LOS DATOS DEL CLIENTE
        public List<Mensaje> ListaMensajes = new List<Mensaje>();//LISTA DE OBJETOS TIPO MENSAJE
        public int EstTecladoI { get; set; }//ESTADO DEL TECLADO INTERNO INDICA SI 0 NO ESTA ESCRIBIENT 1 ESTA ESCRIBIENDO
        public int EstTecladoE { get; set; }//ESTADO DEL TECLADO EXTERNO INDICA SI 0 NO ESTA ESCRIBIENT 1 ESTA ESCRIBIENDO
        public int estado { get; set;  } //ESTADO DEL CHAT
        public DateTime UltimoMensajeE { get; set; }//FECHA DEL ULTIMO MENSAJE ENVIADO POR EL CLIENTE EXTERNO
        public DateTime UltimoMensajeI { get; set; }//FECHA DEL ULTIMO MENSAJE ENVIADO POR EL CLIENTE INTERNO
        public int Calificacion { get; set; }//CALIFICAION DADA AL CHAT POR EL CLIENTE
        public string Comentario { get; set; }//COMENTARIO DEJADO AL CHAT POR EL CLIENTE / USUARIO INTERNO (DEPENDE DE UCierra)
        public string ComentarioI { get; set; }//SE USA PARA GUARDAR LA RUTA Y EL NOMBRE DE UN ARCHIVO ADJUNTO ENVIADO POR USUARIO INTERNO
        public DateTime? FechaAtencion { get; set; }// fecha en que se atendendio el chat.
        public DateTime? FechaFinal { get; set; }//fecha en que se cerró el chat
        public string dirIp { get; set; } //direccion ip del equipo donde se creó el chat
        public string UCierra { get; set; } //Quien cerro el chat? I = usuario coopecaja / E = usuario externo
        public string zona { get; set; }//Zona del usuario del chat pais - provincia.




        public void CargarMensaje(Mensaje pMensaje)
        {
            ListaMensajes.Add(pMensaje);
        }
    }

}
