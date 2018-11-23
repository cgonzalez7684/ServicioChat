using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

using System.IO;

namespace ServicioChat
{
    [ServiceContract]
    public interface IWebChat
    {
       // UriTemplate ="Obtenerservicio"

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int Obtenerservicio(string pass);


        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string pruebaarchivo(string pass);


        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void RegistrarUsuarioWeb(string pNombre, string pTelefono, string pEmail, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int RegistrarUsuarioInterno(int pid, string pNombre, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int CrearChat(string pNombre, string pTelefono, string pEmail, string pIp, string pass);





        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int CrearChat2(string pNombre, string pTelefono, string pEmail, string pIp, string pass);




        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int CrearMensaje(int pIdChat, string pTipo, String pTextoMensaje, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ListaMensaje> RecibirMensajes(int pIdChat, string pTipo, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Chat ObtenerChat(int pIdChat);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int RegistraSalidaUsuarioWeb(int pidChat, string pass);
        

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int CerrarChat(int pidChat, int pCalifica, string pComentario, string pUCierra, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int RegistraSalidaUsuarioInterno(int pid, string pComentario, string pUCierra, string pass);


        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int HabilitarUsuarioInterno(int pid, int pestado, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int ObtenerIdChatAtender(string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ListaCliente> ObtenerListaClientes(string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int verificar_chat(int idChat, string pTipo, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string ObtenerNombre(int pidChat, string pTipo, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int verificarteclado(int pidChat, string pTipo, int pestado, string pass);


        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int AsignarChat(int pIdChat, int pid, string pass);


        [OperationContract]
        //[WebInvoke(Method = "POST", UriTemplate = "/UploadFile?msj={msj}")]
        [WebInvoke(Method = "POST")]
        void UploadFile(Stream stream);


        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string ObtieneRuta(int pIdChat, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string ObtieneRutaF(string pass);

        [OperationContract]
        List<Empleado> ObtenerListaEmpleados(string pass);

        [OperationContract]
        List<Chat> ObtenerListaChats(string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int cambiarEstado(int idEmp, int estado, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ListaCliente ObtenerInfoCliente(int pidChat, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int ObtenerEstadoChat(int pidChat, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string ObtenerMensajaCierreChat(int pidChat, string pass);


        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string ObtenerUsuarioCierraChat(int pidChat, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int ObtenerCalificacionChat(int pidChat, string pass);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int RegistraComentarioSalidaAgente(int pIdChat, string pComentario, string pass);

    }
}
