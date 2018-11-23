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
using System.Data.Entity;

//Estados del empleado 
//0 activo pendiente de atender
//1 atendiendo
//2 inactivo

//Estados del chat
//0 sin atender
//1 esta siendo atendido
//-1 finalizado

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

        public string archivo = Path.Combine(HostingEnvironment.MapPath("~/"), "wcfpChat.txt");
        



        public WebChat()
        {


        }

        //Este método  retorna un 0 si no hay usuarios internos en el chat y un 1 si existen usuarios internos. En caso de retornar un 0 el sistema
        //debe deshabilitar el chat.
        public int Obtenerservicio(string pass)
        {
            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            pass = pass != null ? pass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                    {
                        return 0;
                    } 
                }
                else
                {
                    return 0;
                }
            }


            int nTotal;
            nTotal = ListaEmpleado.Count();
            return nTotal <= 0 ? nTotal : 1;
        }



        public string pruebaarchivo(string pass)
        {
            encript enc = new encript();
            return enc.Encrypt("WcfChatCoope", "coopec@j@1");
        }

   


        //Hace el registro de los usuarios internos en la lista de usuarios internos retorna un 1 si el registro se hizo correctamente y un 0 si ocurrio un error 
        // y no se pudo registrar.
        public int RegistrarUsuarioInterno(int pid, string pNombre, string pass)
        {



            Empleado empleadoB ;
            try
            {

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }



                empleadoB = ListaEmpleado.FirstOrDefault(n => n.IdEmpleado == pid);
                if (empleadoB != null)
                {
                    return 1;
                }
                
                objEmpleado = new Empleado();
                objEmpleado.IdEmpleado = pid;
                objEmpleado.NombreEmpleado = pNombre;
                objEmpleado.EstadoAtencion = 2;  
                ListaEmpleado.Add(objEmpleado);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        //Hace el registro del usuario de internet en la lista de usuarios no retorna nada porque es parte de otro método
        public void RegistrarUsuarioWeb(string pNombre, string pTelefono, string pEmail, string pass)
        {
            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            pass = pass != null ? pass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                    {
                        return ;
                    }
                }
                else
                {
                    return ;
                }
            }

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

        //Este método hace el registro de usuario web, y crea un chat y lo asigna al usuario creado.
        //retorna un 0 si ocurriera un error caso contrario retorna el número de chat creado.
        public int CrearChat(string pNombre, string pTelefono, string pEmail, string pIp,string zona, string pass)
        {
            try{

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }

                RegistrarUsuarioWeb(pNombre, pTelefono, pEmail, pass);
                objChat = new Chat();

                if ((vgIdChat + 1) > int.MaxValue)
                {
                    vgIdChat = 0;
                }
                vgIdChat = vgIdChat + 1;
                
                
                objChat.pObjCliente = objCliente;
                objChat.pObjEmpleado = null;
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
                objChat.zona = zona;
                ListaChats.Add(objChat);
                return vgIdChat;
             }
             catch (Exception ex)
             {
                 return 0;
             } 


        }




        public int CrearChat2(string pNombre, string pTelefono, string pEmail, string pIp, string zona, string pass)
        {
            try
            {

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }

                RegistrarUsuarioWeb(pNombre, pTelefono, pEmail, pass);
                objChat = new Chat();

                if ((vgIdChat + 1) > int.MaxValue)
                {
                    vgIdChat = 0;
                }
                vgIdChat = vgIdChat + 1;


                objChat.pObjCliente = objCliente;
                objChat.pObjEmpleado = null;
                objChat.IdChat = vgIdChat;
                objChat.estado = -1;
                objChat.EstTecladoI = 0;
                objChat.EstTecladoE = 0;
                objChat.Calificacion = 3;
                objChat.Comentario = "";
                objChat.UltimoMensajeE = DateTime.Now;
                objChat.UltimoMensajeI = DateTime.Now;
                objChat.FechaAtencion = null;
                objChat.FechaFinal = null;
                objChat.dirIp = pIp;
                objChat.zona = zona;
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
        public int RegistraSalidaUsuarioWeb(int pidChat, string pass)
        {
            Chat ChatB;
            Empleado EmpleadoB;
            int idCliente;
            int idEmpleadoB;

            string FilePath = "";
            try{

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }


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

        //Este metodo permite saber que estado tiene el chat
        public int ObtenerEstadoChat(int pidChat, string pass)
        {
            Chat ChatB;
            try
            {

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }



                int estado = 0;
                ChatB = ListaChats.FirstOrDefault(n => n.IdChat == pidChat);
                if (ChatB != null)
                {
                    estado = ChatB.estado;                    
                }

                return estado;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        //Marca el chat como cerrado(-1) y le asigna la calificación y el comentario,a la espera de que un proceso interno lo elimine
        //un usuario interno lo libera poniendole el estadoatencion en 0. retorna un 0 si ocurrió un error y un 1 si el proceso se ejecutó correctamente.
        //El parametro pUCierra es para saber quien cerro el chat (I = usuario coopecaja / E = usuario externo)
        public int CerrarChat(int pidChat, int pCalifica, string pComentario, string pUCierra, string pass)
        {
            Chat ChatB;
            try
            {

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }



                ChatB = ListaChats.FirstOrDefault(n => n.IdChat == pidChat);
                if (ChatB != null)
                {
                        ChatB.estado = -1;
                        ChatB.Calificacion = pCalifica;
                        ChatB.Comentario = pComentario;
                        ChatB.FechaFinal = DateTime.Now;
                        ChatB.UCierra = pUCierra;
                }

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }



        //Este metodo se utiliza para que el agente registre un comentario del cierre del chat
        //se utiliza siempre y cuando quien cierre la ventana chat sea el agente.
        public int RegistraComentarioSalidaAgente(int pIdChat, string pComentario, string pass)
        {
            Chat ChatB;
            try
            {

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }


                ChatB = ListaChats.FirstOrDefault(n => (n.IdChat == pIdChat));
                if (ChatB != null)
                {
                    ChatB.UCierra = "I";
                    ChatB.Comentario = pComentario;
                }

                return 1;

            }
            catch (Exception)
            {

                return 0;
            }
        }

        //Elimina de la lista de empleados al usuario y además si este usuario interno estaba en algún chat elimina el id de este usuario del chat .
        //Además actualiza el estado del chat a 0 que es no atendido.
        //El parametro pUCierra es para saber quien cerro el chat (I = usuario coopecaja / E = usuario externo)
        //El parametro pComentario es ya que este es el metodo que registra la salida del agente, para que el mismo justifique porque esta
        //cerrando el chat.
        public int RegistraSalidaUsuarioInterno(int pid, string pComentario, string pUCierra, string pass)
        {
            Chat ChatB;
            List<Chat> listCA;


            try
            {


                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }

                ChatB = ListaChats.FirstOrDefault(n => n.pObjEmpleado != null && n.pObjEmpleado.IdEmpleado == pid);
                if (ChatB != null)
                {
                    ChatB.estado = 0;
                    ChatB.Comentario = pComentario; //Aqui quedaria registrado el comentario del agente del porque cerror el chat
                    ChatB.UCierra = pUCierra; // Se registra en el chat que fue el agente el que lo cerro.
                    ChatB.pObjEmpleado = null;
                    //ChatB.ListaMensajes = null;
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
        //del empleado a 2. Retorna un 1 si el proceso se ejecutó correctamente y un 0 si existió un error.
        //0 activo pendiente de atender
        //1 atendiendo
        //2 inactivo
        public int HabilitarUsuarioInterno(int pid, int pestado, string pass)
        {
            Chat ChatB;
            Empleado EmpleadoB;
            try
            {
                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }


                ChatB = ListaChats.FirstOrDefault(n => n.pObjEmpleado != null && n.pObjEmpleado.IdEmpleado == pid);
                EmpleadoB = ListaEmpleado.FirstOrDefault(n => n.IdEmpleado == pid);
                if (ChatB != null)
                {
                    ChatB.estado = 0;
                    ChatB.pObjEmpleado = null;
                    //ChatB.ListaMensajes = null;
                }
                EmpleadoB.EstadoAtencion = pestado;
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
        public int verificar_chat(int idChat, string pTipo, string pass)
        {
            Chat ChatB;
            try
            {

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }


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
        public int verificarteclado(int pidChat, string pTipo, int pestado, string pass)
        {
            Chat ChatB;
            try
            {

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }

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



        //Teniendo la Lista de ListaCliente se ordena de tal forma que el primero en la lista
        //sea el chat con mas tiempo de estar en la lista, esto en función de FechaIngreso
        //se retorna el ID chat primero en la lista. (Solo chats donde el estado sea cero.
        public int ObtenerIdChatAtender(string pass)
        {

            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            pass = pass != null ? pass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }


            ListaCliente firstChat = ObtenerListaClientes(pass).Where(n => n.estado == 0).OrderBy(n => n.FechaIngreso).FirstOrDefault();
            if (firstChat == null)
            {
                return 0;
            }


            return firstChat.IdChat;   
        
        }


        //Este metodo devuelve la información especifica del chat solicitado.
        public ListaCliente ObtenerInfoCliente(int pidChat, string pass)
        {

            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            pass = pass != null ? pass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }

            if ((ListaCliente.Count <= 0) || (ListaChats.Count <= 0))
            {
                return null;
            }
            
            List<ListaCliente> listaC = new List<ListaCliente>();

            listaC = (from Item1 in ListaChats
                      join Item2 in ListaCliente
                      on Item1.pObjCliente.IdCliente equals Item2.IdCliente
                      where Item1.IdChat == pidChat
                      select new ListaCliente
                      {
                          IdChat = Item1.IdChat,
                          NombreCliente = Item2.NombreCliente,
                          EmailCliente = Item2.EmailCliente,
                          TelCliente = Item2.TelCliente,
                          estado = Item1.estado,
                          FechaIngreso = Item2.FechaIngreso,
                          UltimoMensajeE = Item1.UltimoMensajeE,
                          UltimoMensajeI = Item1.UltimoMensajeI,
                          FechaAtencion = Item1.FechaAtencion,
                          FechaFinal = Item1.FechaFinal,
                          dirIp = Item1.dirIp,                          
                          Calificacion = Item1.Calificacion,
                          zona = Item1.zona
                      }).ToList();

            ListaCliente infoCliente = new ListaCliente();
            foreach (ListaCliente item in listaC)
            {
                          infoCliente.IdChat = item.IdChat;
                          infoCliente.NombreCliente = item.NombreCliente;
                          infoCliente.EmailCliente = item.EmailCliente;
                          infoCliente.TelCliente = item.TelCliente;
                          infoCliente.estado = item.estado;
                          infoCliente.FechaIngreso = item.FechaIngreso;
                          infoCliente.UltimoMensajeE = item.UltimoMensajeE;
                          infoCliente.UltimoMensajeI = item.UltimoMensajeI;
                          infoCliente.FechaAtencion = item.FechaAtencion;
                          infoCliente.FechaFinal = item.FechaFinal;
                          infoCliente.dirIp = item.dirIp;
                          infoCliente.Calificacion = item.Calificacion;
                          infoCliente.zona = item.zona;
                
            }

            return infoCliente;

        }

        //obtiene un listado de los usuarios web que estan activos dentro del chat y retorna un objeto tipo lista de listacliente.
        public List<ListaCliente> ObtenerListaClientes(string pass)
        {

            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            pass = pass != null ? pass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }


            List<ListaCliente> listaC = new List<ListaCliente>();

            listaC = (from Item1 in ListaChats
                         join Item2 in ListaCliente
                         on Item1.pObjCliente.IdCliente equals Item2.IdCliente
                         select new ListaCliente { IdChat= Item1.IdChat, NombreCliente= Item2.NombreCliente, EmailCliente= Item2.EmailCliente,
                                                   TelCliente= Item2.TelCliente, estado= Item1.estado, FechaIngreso = Item2.FechaIngreso,UltimoMensajeE=Item1.UltimoMensajeE, 
                                                   UltimoMensajeI=Item1.UltimoMensajeI, FechaAtencion = Item1.FechaAtencion, FechaFinal = Item1.FechaFinal, dirIp=Item1.dirIp,Calificacion= Item1.Calificacion,zona = Item1.zona}).ToList();
            
            return listaC;
            
        }

        public String ObtenerNombre(int pidChat, string pTipo, string pass)
        {
            String nombre = "";
            try
            {

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return "Agente Coopecaja";
                        }
                    }
                    else
                    {
                        return "Agente Coopecaja";
                    }
                }

                var ChatB = ListaChats.FirstOrDefault(n => (n.IdChat == pidChat) && (n.estado == 1));
                if (pTipo == "E")
                {
                    if (ChatB != null) {
                        if (ChatB.pObjEmpleado != null)
                        {

                            List<Chat> chatE = new List<Chat>();
                            chatE = (from Item1 in ListaChats
                                     where (Item1.pObjEmpleado != null)
                                     select Item1).ToList();

                            var nomb = (from Item1 in chatE
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
            catch (Exception ex)
            {
                return "Agente Coopecaja";
            }

        }



        //Este método asigna a un usuario interno un chat.
        //retorna un 0 si ocurrió un error y un numero mayor a 0 correspondiente al chat asignado si el proceso se ejecutó correctamente.
        public int AsignarChat(int pIdChat, int pid, string pass)
        {

            Chat ChatB;
            Empleado EmpleadoB;


            try 
            {

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }


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
        public int CrearMensaje(int pIdChat, string pTipo, String pTextoMensaje, string pass)
        {
            Mensaje objMensaje = new Mensaje();

            try
            {

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }

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
        public List<ListaMensaje> RecibirMensajes(int pIdChat, string pTipo, string pass)
        {
            List<ListaMensaje> listaM = new List<ListaMensaje>();


            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            pass = pass != null ? pass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }



            Chat ChatB;
            string sNombre;


            try
            {

                ChatB = ListaChats.FirstOrDefault(n => n.IdChat == pIdChat);



                if (ChatB != null)
                {
                    if (pTipo == "I")
                    {
                        sNombre = ChatB.pObjCliente.NombreCliente;
                    }
                    else
                    {
                        sNombre = ChatB.pObjEmpleado.NombreEmpleado;
                    }
                    listaM = (from item in ChatB.ListaMensajes
                              where (item.Tipo == pTipo) && (item.Leido == 0)
                              select new ListaMensaje { TextoMensaje = item.TextoMensaje, Nombre = sNombre, linkMsj = item.linkMsj }).ToList();
                    foreach (var item in ChatB.ListaMensajes.Where(n => (n.Leido == 0) && (n.Tipo == pTipo)))
                    {
                        item.Leido = 1;
                    }
                }
                return listaM;

            }
            catch (Exception ex)
            {
                return null;
            }
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
            objMensaje.linkMsj = idChat.ToString() + vgArchivo.ToString() + nombre;
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


        public string ObtieneRuta(int pIdChat, string pass)
        {

            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            pass = pass != null ? pass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                    {
                        return "";
                    }
                }
                else
                {
                    return "";
                }
            }

            string ruta = "";
            Chat vchat = ObtenerChat(pIdChat);
            if (vchat != null)
            {

                ruta = vchat.ComentarioI;
            }
            return ruta;
        }

        public string ObtieneRutaF(string pass)
        {

            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            pass = pass != null ? pass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                    {
                        return "";
                    }
                }
                else
                {
                    return "";
                }
            }

            string FilePath = Path.Combine(HostingEnvironment.MapPath("~/Files"), "archivo.xlsx");
            using (FileStream writer = new FileStream(FilePath, FileMode.Create))
            {
                
            }

            return HostingEnvironment.MapPath("~/Files");
        }



        public List<Empleado> ObtenerListaEmpleados(string pass)
        {
            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            pass = pass != null ? pass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            return ListaEmpleado;

        }

        public List<Chat> ObtenerListaChats(string pass)
        {
            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            pass = pass != null ? pass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }

            return ListaChats;

        }


        public int cambiarEstado(int idEmp, int estado, string pass) 
        {

            encript enc = new encript();
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            pass = pass != null ? pass : "";
            if (headers["web"] == null)
            {
                if (File.Exists(archivo))
                {
                    string password = File.ReadLines(archivo).First();
                    if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }

            Chat ChatB;
            ChatB = ListaChats.FirstOrDefault(n => n.pObjEmpleado != null && n.pObjEmpleado.IdEmpleado == idEmp);
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


        //Este metodo se utiliza para que el aplicativo del agente recupere el mensaje dejado por el cliente sobre
        //el cierre del chat
        public string ObtenerMensajaCierreChat(int pidChat, string pass)
        {

            try
            {

                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return "";
                        }
                    }
                    else
                    {
                        return "";
                    }
                }

                Chat ChatB;
                string mensaje = string.Empty;
                ChatB = ListaChats.FirstOrDefault(n => (n.IdChat == pidChat));
                mensaje = ((ChatB != null) || (ChatB.Comentario.Length <= 0)) ? string.Empty : ChatB.Comentario;

                return mensaje;

            }
            catch (Exception)
            {

                return "";
            }

        }


        //Obtiene quien esta cerrando el chat Agente (I) , Cliente (E)
        public string ObtenerUsuarioCierraChat(int pidChat, string pass)
        {

            try
            {
                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return "";
                        }
                    }
                    else
                    {
                        return "";
                    }
                }

                Chat ChatB;
                string UCierra = string.Empty;
                ChatB = ListaChats.FirstOrDefault(n => (n.IdChat == pidChat));
                UCierra = ((ChatB == null) || (ChatB.UCierra.Length <= 0)) ? string.Empty : ChatB.UCierra;
                return UCierra;

            }
            catch (Exception)
            {

                return "";
            }

        }


        //Obtine la calificación dada al chat
        public int ObtenerCalificacionChat(int pidChat, string pass)
        {

            try
            {
                encript enc = new encript();
                IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
                WebHeaderCollection headers = request.Headers;
                pass = pass != null ? pass : "";
                if (headers["web"] == null)
                {
                    if (File.Exists(archivo))
                    {
                        string password = File.ReadLines(archivo).First();
                        if (password.Trim() != enc.Encrypt(pass.Trim(), "coopec@j@1"))
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }

                Chat ChatB;
                int calificacion;
                ChatB = ListaChats.FirstOrDefault(n => (n.IdChat == pidChat));
                calificacion = ((ChatB != null) ? ChatB.Calificacion : 0);
                return calificacion;

            }
            catch (Exception)
            {

                return 0;
            }

        }


        //Este método borrar los chats que ya están cerrados y que no tengan empleado asignado y tengan mas de 2 minutos.
        public string LimpiarChats(string pass)
        {
            try
            {
                //ListaChats.RemoveAll(x => x.estado == -1 && x.pObjEmpleado == null && DbFunctions.DiffMinutes(x.FechaFinal,DateTime.Now) > 2);
                ListaChats.RemoveAll(x => x.estado == -1 && x.pObjEmpleado == null && ((TimeSpan) (DateTime.Now - x.FechaFinal)).Minutes > 2);
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



    }
}
