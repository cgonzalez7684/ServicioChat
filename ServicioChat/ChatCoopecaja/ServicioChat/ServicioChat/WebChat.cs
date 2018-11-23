using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Net;

using System.Web.Hosting;


using System.Web;


using System.IO;

namespace ServicioChat
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]  
    public class WebChat : IWebChat
    {
        public static List<Chat> ListaChats = new List<Chat>();
        public static List<Cliente> ListaCliente = new List<Cliente>();
        public static List<Empleado> ListaEmpleado = new List<Empleado>();


        public Chat objChat;
        public Cliente objCliente;
        public Empleado objEmpleado;
        public static int vgIdChat = 0;
        public static int vgIdCliente = 0;
        public static int vgArchivo = 0;




        public WebChat()
        {


        }

        //Este método  retorna un 0 si no hay usuarios internos en el chat y un 1 si existen usuarios internos. En caso de retornar un 0 el sistema
        //debe deshabilitar el chat.
        public int Obtenerservicio()
        {
            int nTotal;
            nTotal = ListaEmpleado.Count();
            return nTotal;
        }

        //Hace el registro del usuario de internet en la lista de usuarios no retorna nada porque es parte de otro método
        public void RegistrarUsuarioWeb(string pNombre, string pTelefono, string pEmail) {

            if ((vgIdCliente + 1) > int.MaxValue)
            {
                vgIdCliente = 0;
            }
            vgIdCliente = vgIdCliente + 1;

            objCliente = new Cliente();
            objCliente.IdCliente = vgIdCliente;
            objCliente.NombreCliente = pNombre;
            objCliente.TelCliente = pTelefono;
            objCliente.EmailCliente = pEmail;
            objCliente.FechaIngreso = DateTime.Now;
            ListaCliente.Add(objCliente);
        }


        //Hace el registro de los usuarios internos en la lista de usuarios internos retorna un 1 si el registro se hizo correctamente y un 0 si ocurrio un error 
        // y no se pudo registrar.
        public int RegistrarUsuarioInterno(int pid, string pNombre)
        {
            Empleado empleadoB ;
            try
            {


                empleadoB = ListaEmpleado.FirstOrDefault(n => n.IdEmpleado == pid);
                if (empleadoB != null)
                {
                    return 1;
                }
                
                objEmpleado = new Empleado();
                objEmpleado.IdEmpleado = pid;
                objEmpleado.NombreEmpleado = pNombre;
                objEmpleado.EstadoAtencion = 0;
                ListaEmpleado.Add(objEmpleado);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        //Este método hace el registro de usuario web, y crea un chat y lo asigna al usuario creado.
        //retorna un 0 si ocurriera un error caso contrario retorna el número de chat creado.
        public int CrearChat(string pNombre, string pTelefono, string pEmail, string pIp)
        {
            try{
                RegistrarUsuarioWeb(pNombre, pTelefono, pEmail);
                objChat = new Chat();

                if ((vgIdChat + 1) > int.MaxValue)
                {
                    vgIdChat = 0;
                }
                vgIdChat = vgIdChat + 1;
                
                
                objChat.pObjCliente = objCliente;
                objChat.IdChat = vgIdChat;
                objChat.estado = 0;
                objChat.EstTecladoI = 0;
                objChat.EstTecladoE = 0;
                objChat.Calificacion = 3;
                objChat.Comentario = "";
                objChat.UltimoMensajeE = DateTime.Now;
                objChat.UltimoMensajeI = DateTime.Now;
                objChat.FechaAtencion = null;
                objChat.FechaFinal = null;
                objChat.dirIp = pIp;
                ListaChats.Add(objChat);
                return vgIdChat;
             }
             catch (Exception ex)
             {
                 return 0;
             } 


        }


        //elimina al usuario de la lista de usuarios y ademas elimina el chat asociado a este usuario, tambien si ese chat tenía asociado
        //un usuario interno lo libera poniendole el estadoatencion en 0. retorna un 0 si ocurrió un error y un 1 si el proceso se ejecutó correctamente.
        public int RegistraSalidaUsuarioWeb(int pidChat)
        {
            Chat ChatB;
            Empleado EmpleadoB;
            int idCliente;
            int idEmpleadoB;

            string FilePath = "";
            try{
                ChatB = ListaChats.FirstOrDefault(n => n.IdChat == pidChat);
                if (ChatB != null){
                    idCliente = ChatB.pObjCliente.IdCliente;

                    if (ChatB.pObjEmpleado != null)
                    {
                        idEmpleadoB = ChatB.pObjEmpleado.IdEmpleado;
                        EmpleadoB = ListaEmpleado.FirstOrDefault(n => n.IdEmpleado == idEmpleadoB);
                        if (EmpleadoB != null)
                        {
                            EmpleadoB.EstadoAtencion = 0;
                        }
                    }

                    foreach (var item in ChatB.ListaMensajes.Where(n => (n.linkMsj != "") && (n.linkMsj != null)))
                    {
                        
                        FilePath = Path.Combine(HostingEnvironment.MapPath("~/Files"), item.linkMsj);
                        if (File.Exists(FilePath))
                        { 
                            File.Delete(FilePath);
                        }
                       
                    }


                    ListaChats.RemoveAll(n => n.IdChat == pidChat);
                    ListaCliente.RemoveAll(n => n.IdCliente == idCliente);
                }
                
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            } 
        }


        //Marca el chat como cerrado(-1) y le asigna la calificación y el comentario,a la espera de que un proceso interno lo elimine
        //un usuario interno lo libera poniendole el estadoatencion en 0. retorna un 0 si ocurrió un error y un 1 si el proceso se ejecutó correctamente.
        public int CerrarChat(int pidChat,int pCalifica, string pComentario)
        {
            Chat ChatB;
            try
            {
                ChatB = ListaChats.FirstOrDefault(n => n.IdChat == pidChat);
                if (ChatB != null)
                {
                        ChatB.estado = -1;
                        ChatB.Calificacion = pCalifica;
                        ChatB.Comentario = pComentario;
                        ChatB.FechaFinal = DateTime.Now;
                }

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        //Elimina de la lista de empleados al usuario y además si este usuario interno estaba en algún chat elimina el id de este usuario del chat .
        //Además actualiza el estado del chat a 0 que es no atendido.
        public int RegistraSalidaUsuarioInterno(int pid)
        {
            Chat ChatB;
            try
            {
                ChatB = ListaChats.FirstOrDefault(n => n.pObjEmpleado.IdEmpleado == pid);
                if (ChatB != null)
                {
                    ChatB.estado = 0;
                    ChatB.pObjEmpleado = null;
                    ChatB.ListaMensajes = null;
                }
                ListaEmpleado.RemoveAll(n => n.IdEmpleado == pid);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            } 
        }


        //Habilita al usuario interno para atender otros chat eliminando la referencia en la listachats y cambiando el estado del chat a 0 y el estadoatencion
        //del empleado a 0. Retorna un 1 si el proceso se ejecutó correctamente y un 0 si existió un error.
        public int HabilitarUsuarioInterno(int pid)
        {
            Chat ChatB;
            Empleado EmpleadoB;
            try
            {
                ChatB = ListaChats.FirstOrDefault(n => n.pObjEmpleado.IdEmpleado == pid);
                EmpleadoB = ListaEmpleado.FirstOrDefault(n => n.IdEmpleado == pid);
                if (ChatB != null)
                {
                    ChatB.estado = 0;
                    ChatB.pObjEmpleado = null;
                    ChatB.ListaMensajes = null;
                }
                EmpleadoB.EstadoAtencion = 0;
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            } 
        }

        //Este método se debe estar corriendo constantemente ya que indica si el chat esta activo (1 = activo no hay señal de teclas, 
        //2 = activo, hay señal de teclado) o si está pendiente de atender(0), si se retorna un -1 quiere decir que el chat no existe o ya fue cerrado y está pendiente su eliminación. 
        //En caso de que el usuario externo esté llamando este método se debe ingresar el pTipo como una I,
        //En caso de que el usuario interno esté llamando este método se debe ingresar el pTipo como una E.
        public int verificar_chat(int idChat, string pTipo)
        {
            Chat ChatB;
            try
            {
                ChatB = ListaChats.FirstOrDefault(n => (n.IdChat == idChat));
                if (ChatB != null)
                {
                    if (ChatB.estado == 0)
                    {
                        return 0;
                    }
                    if (ChatB.estado == -1)
                    {
                        return -1;
                    }

                    if (pTipo == "I")
                    {
                        if (ChatB.EstTecladoI == 1)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }   
                    }
                    else
                    {
                        if (ChatB.EstTecladoE == 1)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
                else
                {
                    return -1;
                }

                
            }
            catch (Exception ex)
            {
                return 0;
            } 
        }

        //Este método me indica si el usuario interno o externo de acuerdo al parámetro ptipo esta escribiendo.
        //En caso de que el usuario externo esté escribiendo se debe ingresar el pTipo como una I,
        //En caso de que el usuario interno esté escribiendo se debe ingresar el pTipo como una E.
        public int verificarteclado(int pidChat, string pTipo, int pestado)
        {
            Chat ChatB;
            try
            {
                ChatB = ListaChats.FirstOrDefault(n => (n.IdChat == pidChat) && (n.estado == 1));
                if (ChatB != null)
                {
                    if (pTipo == "I")
                    {
                        ChatB.EstTecladoI = pestado;
                    }
                    else
                    {
                        ChatB.EstTecladoE = pestado;
                    }
                    return 1;
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception ex)
            {
                return 0;
            } 
        }




        //obtiene un listado de los usuarios web que estan activos dentro del chat y retorna un objeto tipo lista de listacliente.
        public List<ListaCliente> ObtenerListaClientes()
        {
            List<ListaCliente> listaC = new List<ListaCliente>();

            listaC = (from Item1 in ListaChats
                         join Item2 in ListaCliente
                         on Item1.pObjCliente.IdCliente equals Item2.IdCliente
                         select new ListaCliente { IdChat= Item1.IdChat, NombreCliente= Item2.NombreCliente, EmailCliente= Item2.EmailCliente,
                                                   TelCliente= Item2.TelCliente, estado= Item1.estado, FechaIngreso = Item2.FechaIngreso,UltimoMensajeE=Item1.UltimoMensajeE, 
                                                   UltimoMensajeI=Item1.UltimoMensajeI, FechaAtencion = Item1.FechaAtencion, FechaFinal = Item1.FechaFinal, dirIp=Item1.dirIp,Calificacion= Item1.Calificacion}).ToList();
            
            return listaC;
            
        }

        public String ObtenerNombre(int pidChat, string pTipo)
        {
            String nombre = "";
            try
            { 
                var ChatB = ListaChats.FirstOrDefault(n => (n.IdChat == pidChat) && (n.estado == 1));
                if (pTipo == "E")
                {
                    if (ChatB != null) { 
                        if (ChatB.pObjEmpleado != null)
                        {
                            var nomb = (from Item1 in ListaChats
                                        join Item2 in ListaEmpleado
                                        on Item1.pObjEmpleado.IdEmpleado equals Item2.IdEmpleado
                                        where (Item1.IdChat == pidChat)
                                        select new { Item2.NombreEmpleado }).FirstOrDefault();
                            if (nomb != null)
                            {
                                nombre = nomb.NombreEmpleado;
                            }
                        }
                    }
                }
                else
                {
                    if (ChatB != null)
                    {
                        if (ChatB.pObjCliente != null)
                        {
                            var nomb = (from Item1 in ListaChats
                                        join Item2 in ListaCliente
                                        on Item1.pObjCliente.IdCliente equals Item2.IdCliente
                                        where (Item1.IdChat == pidChat)
                                        select new { Item2.NombreCliente }).FirstOrDefault();
                            if (nomb != null)
                            {
                                nombre = nomb.NombreCliente;
                            }
                        }
                    }
                }

                return nombre;
            }
            catch (Exception)
            {
                return "";
            }

        }



        //Este método asigna a un usuario interno un chat.
        //retorna un 0 si ocurrió un error y un numero mayor a 0 correspondiente al chat asignado si el proceso se ejecutó correctamente.
        public int AsignarChat(int pIdChat, int pid) {

            Chat ChatB;
            Empleado EmpleadoB;


            try 
            {
                ChatB = ListaChats.FirstOrDefault(n => n.IdChat == pIdChat);
                EmpleadoB = ListaEmpleado.FirstOrDefault(n => n.IdEmpleado == pid);
            
                if ((ChatB != null) && (ChatB.estado == 0) && (ChatB.pObjEmpleado == null))
                {
                    ChatB.pObjEmpleado = EmpleadoB;
                    ChatB.estado = 1;
                    EmpleadoB.EstadoAtencion = 1;
                    ChatB.UltimoMensajeE = DateTime.Now;
                    ChatB.UltimoMensajeI = DateTime.Now;
                    ChatB.FechaAtencion = DateTime.Now;
                    return pIdChat;
                }
                else
                {
                    return 0;
                } 

                
            }
            catch (Exception ex)
            {
                return 0;
            }


        }



        //obtiene un objeto tipo chat, buscando en la lista de chats por el id que viene por parámetro.
        public Chat ObtenerChat(int pIdChat)
        {
            Chat ChatN;
            ChatN = ListaChats.FirstOrDefault(n => (n.IdChat == pIdChat));

            return ChatN;
        }





        //registra un mensaje enviado. Obtiene el chat, luego registra el mensaje para la persona interna o externa
        //de acuerdo al parámetro pTipo que significa a quien va dirigido el msj. (I = interno, E = Externo). Retorna un 0 si existió un error y un  si fué exitoso el envío.
        //En caso de que el usuario externo esté enviado el msj se debe ingresar el pTipo como una I,
        //En caso de que el usuario interno esté enviado el msj se debe ingresar el pTipo como una E.
        public int CrearMensaje(int pIdChat, string pTipo, String pTextoMensaje)
        {
            Mensaje objMensaje = new Mensaje();

            try
            {
                objMensaje.Tipo = pTipo;
                objMensaje.TextoMensaje = pTextoMensaje;
                objMensaje.linkMsj = "";
                objMensaje.Leido = 0;
                objMensaje.Fecha = DateTime.Now;

                Chat vchat = ObtenerChat(pIdChat);

                if (vchat != null)
                {
                    vchat.CargarMensaje(objMensaje);
                    if (pTipo == "E")
                    {
                        vchat.UltimoMensajeI = DateTime.Now;
                       
                    }else
                    {
                        vchat.UltimoMensajeE = DateTime.Now;
                        
                    }
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        //Retorna una lista ListaMensaje con los mensajes pendientes de leer ya sea internamente o externamente de acuerdo al parámetro pTipo.
        //En caso de que el usuario externo sea el que va recibir el o los msjs se debe ingresar el pTipo como una E,
        //En caso de que el usuario interno sea el que va recibir el o los msjs se debe ingresar el pTipo como una I.
        public List<ListaMensaje> RecibirMensajes(int pIdChat, string pTipo)
        {
            List<ListaMensaje> listaM = new List<ListaMensaje>();

            Chat ChatB;
            string sNombre;
            ChatB = ListaChats.FirstOrDefault(n => n.IdChat == pIdChat);

            if (pTipo == "I")
            {
                sNombre = ChatB.pObjCliente.NombreCliente;
            }
            else
            {
                sNombre = ChatB.pObjEmpleado.NombreEmpleado;
            }

            if (ChatB != null)
            {
                listaM = (from item in ChatB.ListaMensajes
                                   where (item.Tipo == pTipo) && (item.Leido == 0)
                          select new ListaMensaje { TextoMensaje = item.TextoMensaje, Nombre = sNombre }).ToList();
                foreach (var item in ChatB.ListaMensajes.Where(n => (n.Leido == 0) && (n.Tipo == pTipo)))
                {
                    item.Leido = 1;
                }
            }
            return listaM;
        }










        public void UploadFile(Stream stream)
        {

            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            string nombre = null;
            int idChat = 0;

            if (headers["nombre"] != null)
            {
                nombre = headers["nombre"];
            }

            if (headers["idChat"] != null)
            {
                idChat = int.Parse(headers["idChat"]);
            }

            if ((vgArchivo + 1) > int.MaxValue)
            {
                vgArchivo = 0;
            }

            vgArchivo = vgArchivo + 1;

            if (idChat == 0)
            {
                throw new Exception();
            }


            string FilePath = Path.Combine(HostingEnvironment.MapPath("~/Files"), idChat.ToString()+vgArchivo.ToString()+nombre);
            int length = 0;

            Mensaje objMensaje = new Mensaje();
            objMensaje.Tipo = "I";
            objMensaje.TextoMensaje = "";
            objMensaje.linkMsj = FilePath;
            objMensaje.Leido = 0;
            objMensaje.Fecha = DateTime.Now;

            Chat vchat = ObtenerChat(idChat);

            if (vchat != null)
            {

                using (FileStream writer = new FileStream(FilePath, FileMode.Create))
                {
                    int readCount;
                    var buffer = new byte[8192];
                    while ((readCount = stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        writer.Write(buffer, 0, readCount);
                        length += readCount;
                    }
                }
                    
                    
                vchat.CargarMensaje(objMensaje);   
                vchat.UltimoMensajeE = DateTime.Now;
                vchat.ComentarioI = idChat.ToString() + vgArchivo.ToString() + nombre;
                return;
            }
            else
            {
                throw new Exception();
            }
        }


        public string ObtieneRuta(int pIdChat)
        {
            string ruta = "";
            Chat vchat = ObtenerChat(pIdChat);
            if (vchat != null)
            {

                ruta = vchat.ComentarioI;
            }
            return ruta;
        }

        public string ObtieneRutaF()
        {
            string FilePath = Path.Combine(HostingEnvironment.MapPath("~/Files"), "archivo.xlsx");
            using (FileStream writer = new FileStream(FilePath, FileMode.Create))
            {
                
            }

            return HostingEnvironment.MapPath("~/Files");
        }


        
        public List<Empleado> ObtenerListaEmpleados()
        {

            return ListaEmpleado;

        }

        public List<Chat> ObtenerListaChats()
        {

            return ListaChats;

        }


        public int cambiarEstado(int idEmp, int estado) 
        {
            Chat ChatB;
            ChatB = ListaChats.FirstOrDefault(n => n.pObjEmpleado.IdEmpleado == idEmp);
            if (ChatB != null){
                return -1;
            }

            Empleado EmpleadoB = ListaEmpleado.FirstOrDefault(n => n.IdEmpleado == idEmp);

            if ((EmpleadoB != null))
            {
                EmpleadoB.EstadoAtencion = idEmp;
                return idEmp;
            }
            else
            {
                return -1;
            } 
        }

        


      
    

    }
}
