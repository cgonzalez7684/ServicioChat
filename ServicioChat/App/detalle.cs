/*****************************************************************************************************************
* PROYECTO WEBCHAT PARA USO INTERNO DE COOPECAJA, AÑO 2016.                                                      *
* ESTE PROYECTO FORMA PARTE DE LA SOLUCIÓN 'ServicioChat' Y TIENE COMO OBJETIVO OFRECER LA INTERFACES DE         *
* USUARIO PARA LA ADMINISTRACIÓN Y GESTIÓN DE LA COMUNICACIÓN TIPO CHAT CON LOS CLIENTES POR PARTE DE LOS        *
* AGENTES DE LA COOPERATIVA.                                                                                     *
* PROYECTO DESARROLLADO POR:                                                                                     *
*                       - ING. CARLOS GONZÁLEZ ROMERO                                                            *
*                       - ING. CARLOS FONSECA QUIROS                                                             *
*                       - ING. MAYRA CHAVES BADILLA                                                              *
*****************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Transactions;
using ChatEntity;

namespace App
{
    public partial class detalle : Form
    {
        int tipoF = 0;
        string detalleT = "Detalle ";
        DateTime fechaIni;
        DateTime fechaFin;
        int idEmpleado;

        int tipoPalabra = 0;
        string palabra = "";

        int calificacion = 0;

        public detalle()
        {
            InitializeComponent();
        }

        public detalle(int tipo, string detalle, DateTime fechai, DateTime fechaf, int id, int tipoP, string ppalabra, int califica)
        {

            tipoPalabra = tipoP;
            palabra = ppalabra;

            calificacion = califica;

            tipoF = tipo;
            detalleT = detalle;
            fechaIni = fechai;
            fechaFin = fechaf;
            idEmpleado = id;
            InitializeComponent();
        }

        public detalle(int tipo, string detalle)
        {
            tipoF = tipo;
            detalleT = detalle;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void detalle_Load(object sender, EventArgs e)
        {
            this.lblDetalle.Text = detalleT;

            List<chat> ChatBase= new List<chat>();
            List<chat> chatServicio = new List<chat>();
            List<chat> chatTot = new List<chat>();


            try { 

                using (chatEntidad context = new chatEntidad())
                {


                    if (tipoF == 1 || tipoF == 4)
                    {

                        ChatBase = (from item in context.chats
                                    join item2 in context.usuarios
                                    on item.cCodigoUsu equals item2.cCodigousu
                                    where DbFunctions.DiffDays(DateTime.Now, item.dFechaFin) == 0 && (tipoPalabra == 1 ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                    select new chat
                                    {
                                        NombreCliente = item.cNomclient,
                                        EmailCliente = item.cEmailClien,
                                        TelCliente = item.cTelCliente,
                                        dFechaIng = item.dFechaIng,
                                        dFechaAte = item.dFechaAte,
                                        dFechaFin = item.dFechaFin,
                                        NomUsuari = item2.cNomUsuari,
                                        nCalifica = item.nCalifica,
                                        cComentExt = item.cComenExt,
                                        cComentInt = item.cComenInt,
                                        direccionIp = item.direccionIp,
                                        cTextoChat = item.cTextoChat,
                                        nIdchat = item.nIdChat,
                                        zona = item.cZona
                                    }).ToList();
                    
                    }
                    if (tipoF == 5)
                    {

                        ChatBase = (from item in context.chats
                                    join item2 in context.usuarios
                                    on item.cCodigoUsu equals item2.cCodigousu
                                    where DbFunctions.DiffDays(DateTime.Now, item.dFechaFin) == 0 && item.nCalifica > 2 && (tipoPalabra == 1 ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                    select new chat
                                    {
                                        NombreCliente = item.cNomclient,
                                        EmailCliente = item.cEmailClien,
                                        TelCliente = item.cTelCliente,
                                        dFechaIng = item.dFechaIng,
                                        dFechaAte = item.dFechaAte,
                                        dFechaFin = item.dFechaFin,
                                        NomUsuari = item2.cNomUsuari,
                                        nCalifica = item.nCalifica,
                                        cComentExt = item.cComenExt,
                                        cComentInt = item.cComenInt,
                                        direccionIp = item.direccionIp,
                                        cTextoChat = item.cTextoChat,
                                        nIdchat = item.nIdChat,
                                        zona = item.cZona
                                    }).ToList();

                    }
                    if (tipoF == 6)
                    {

                        ChatBase = (from item in context.chats
                                    join item2 in context.usuarios
                                    on item.cCodigoUsu equals item2.cCodigousu
                                    where DbFunctions.DiffDays(DateTime.Now, item.dFechaFin) == 0 && item.nCalifica < 3 && (tipoPalabra == 1 ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                    select new chat
                                    {
                                        NombreCliente = item.cNomclient,
                                        EmailCliente = item.cEmailClien,
                                        TelCliente = item.cTelCliente,
                                        dFechaIng = item.dFechaIng,
                                        dFechaAte = item.dFechaAte,
                                        dFechaFin = item.dFechaFin,
                                        NomUsuari = item2.cNomUsuari,
                                        nCalifica = item.nCalifica,
                                        cComentExt = item.cComenExt,
                                        cComentInt = item.cComenInt,
                                        direccionIp = item.direccionIp,
                                        cTextoChat = item.cTextoChat,
                                        nIdchat = item.nIdChat,
                                        zona = item.cZona
                                    }).ToList();

                    }

                    if (tipoF == 7)
                    {

                        if (idEmpleado == 0) { 
                        ChatBase = (from item in context.chats
                                    join item2 in context.usuarios
                                    on item.cCodigoUsu equals item2.cCodigousu
                                    where
                                      (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin) && (tipoPalabra == 1 ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                    select new chat
                                    {
                                        NombreCliente = item.cNomclient,
                                        EmailCliente = item.cEmailClien,
                                        TelCliente = item.cTelCliente,
                                        dFechaIng = item.dFechaIng,
                                        dFechaAte = item.dFechaAte,
                                        dFechaFin = item.dFechaFin,
                                        NomUsuari = item2.cNomUsuari,
                                        nCalifica = item.nCalifica,
                                        cComentExt = item.cComenExt,
                                        cComentInt = item.cComenInt,
                                        direccionIp = item.direccionIp,
                                        cTextoChat = item.cTextoChat,
                                        nIdchat = item.nIdChat,
                                        zona = item.cZona
                                    }).ToList();

                        }
                        else
                        {
                            ChatBase = (from item in context.chats
                                        join item2 in context.usuarios
                                        on item.cCodigoUsu equals item2.cCodigousu
                                        where (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin) && (tipoPalabra == 1 ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                        && item2.nIdUsuario.ToString() == idEmpleado.ToString()
                                        select new chat
                                        {
                                            NombreCliente = item.cNomclient,
                                            EmailCliente = item.cEmailClien,
                                            TelCliente = item.cTelCliente,
                                            dFechaIng = item.dFechaIng,
                                            dFechaAte = item.dFechaAte,
                                            dFechaFin = item.dFechaFin,
                                            NomUsuari = item2.cNomUsuari,
                                            nCalifica = item.nCalifica,
                                            cComentExt = item.cComenExt,
                                            cComentInt = item.cComenInt,
                                            direccionIp = item.direccionIp,
                                            cTextoChat = item.cTextoChat,
                                            nIdchat = item.nIdChat,
                                            zona = item.cZona
                                        }).ToList();
                        }
                    }


                    if (tipoF == 8)
                    {

                        if (idEmpleado == 0)
                        {
                            ChatBase = (from item in context.chats
                                        join item2 in context.usuarios
                                        on item.cCodigoUsu equals item2.cCodigousu
                                        where
                                          (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin) && (tipoPalabra == 1 ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                          && item.nCalifica > 2
                                        select new chat
                                        {
                                            NombreCliente = item.cNomclient,
                                            EmailCliente = item.cEmailClien,
                                            TelCliente = item.cTelCliente,
                                            dFechaIng = item.dFechaIng,
                                            dFechaAte = item.dFechaAte,
                                            dFechaFin = item.dFechaFin,
                                            NomUsuari = item2.cNomUsuari,
                                            nCalifica = item.nCalifica,
                                            cComentExt = item.cComenExt,
                                            cComentInt = item.cComenInt,
                                            direccionIp = item.direccionIp,
                                            cTextoChat = item.cTextoChat,
                                            nIdchat = item.nIdChat,
                                            zona = item.cZona
                                        }).ToList();

                        }
                        else
                        {
                            ChatBase = (from item in context.chats
                                        join item2 in context.usuarios
                                        on item.cCodigoUsu equals item2.cCodigousu
                                        where (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin)
                                        && item2.nIdUsuario.ToString() == idEmpleado.ToString() && item.nCalifica > 2 && (tipoPalabra == 1 ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                        select new chat
                                        {
                                            NombreCliente = item.cNomclient,
                                            EmailCliente = item.cEmailClien,
                                            TelCliente = item.cTelCliente,
                                            dFechaIng = item.dFechaIng,
                                            dFechaAte = item.dFechaAte,
                                            dFechaFin = item.dFechaFin,
                                            NomUsuari = item2.cNomUsuari,
                                            nCalifica = item.nCalifica,
                                            cComentExt = item.cComenExt,
                                            cComentInt = item.cComenInt,
                                            direccionIp = item.direccionIp,
                                            cTextoChat = item.cTextoChat,
                                            nIdchat = item.nIdChat,
                                            zona = item.cZona
                                        }).ToList();
                        }
                    }

                    if (tipoF == 9)
                    {

                        if (idEmpleado == 0)
                        {
                            ChatBase = (from item in context.chats
                                        join item2 in context.usuarios
                                        on item.cCodigoUsu equals item2.cCodigousu
                                        where
                                          (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin) && (tipoPalabra == 1 ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                          && item.nCalifica < 3
                                        select new chat
                                        {
                                            NombreCliente = item.cNomclient,
                                            EmailCliente = item.cEmailClien,
                                            TelCliente = item.cTelCliente,
                                            dFechaIng = item.dFechaIng,
                                            dFechaAte = item.dFechaAte,
                                            dFechaFin = item.dFechaFin,
                                            NomUsuari = item2.cNomUsuari,
                                            nCalifica = item.nCalifica,
                                            cComentExt = item.cComenExt,
                                            cComentInt = item.cComenInt,
                                            direccionIp = item.direccionIp,
                                            cTextoChat = item.cTextoChat,
                                            nIdchat = item.nIdChat,
                                            zona = item.cZona
                                        }).ToList();

                        }
                        else
                        {
                            ChatBase = (from item in context.chats
                                        join item2 in context.usuarios
                                        on item.cCodigoUsu equals item2.cCodigousu
                                        where (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin)
                                        && item2.nIdUsuario.ToString() == idEmpleado.ToString() && item.nCalifica < 3 && (tipoPalabra == 1 ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                        select new chat
                                        {
                                            NombreCliente = item.cNomclient,
                                            EmailCliente = item.cEmailClien,
                                            TelCliente = item.cTelCliente,
                                            dFechaIng = item.dFechaIng,
                                            dFechaAte = item.dFechaAte,
                                            dFechaFin = item.dFechaFin,
                                            NomUsuari = item2.cNomUsuari,
                                            nCalifica = item.nCalifica,
                                            cComentExt = item.cComenExt,
                                            cComentInt = item.cComenInt,
                                            direccionIp = item.direccionIp,
                                            cTextoChat = item.cTextoChat,
                                            nIdchat = item.nIdChat,
                                            zona = item.cZona
                                        }).ToList();
                        }
                    }

                }

                using (ServicioChat.WebChatClient chatContext = new ServicioChat.WebChatClient())
                {

                    if (tipoF == 1) {
                        var totChats = chatContext.ObtenerListaChats("WcfChatCoope");
                        chatServicio = (from item in totChats
                                        where (DateTime.Now - item.pObjCliente.FechaIngreso).Days == 0 && (calificacion != 0 ? item.Calificacion == calificacion : 0 == 0)
                                        select new chat
                                        {
                                            NombreCliente = item.pObjCliente.NombreCliente,
                                            EmailCliente = item.pObjCliente.EmailCliente,
                                            TelCliente = item.pObjCliente.TelCliente,
                                            dFechaIng = item.pObjCliente.FechaIngreso,
                                            dFechaAte = item.FechaAtencion,
                                            dFechaFin = item.FechaFinal,
                                            NomUsuari = (item.pObjEmpleado == null ? "" : item.pObjEmpleado.NombreEmpleado),
                                            nCalifica = item.Calificacion,
                                            cComentExt = item.Comentario,
                                            cComentInt = item.ComentarioI,
                                            direccionIp = item.dirIp,
                                            cTextoChat = (item.ListaMensajes == null ? "" : string.Join("\n",(from itemA in item.ListaMensajes select ((itemA.Tipo == "E" ?
                                                         item.pObjCliente.NombreCliente : (item.pObjEmpleado == null ? "Agente No Identificado" : item.pObjEmpleado.NombreEmpleado)) + " - " + itemA.Fecha + ": " + 
                                                         itemA.TextoMensaje)).ToList())),
                                            nIdchat = item.IdChat,
                                            zona = item.zona
                                        }).ToList();
                     }
                    if (tipoF == 2)
                    {
                        var totChats = chatContext.ObtenerListaChats("WcfChatCoope");
                        chatServicio = (from item in totChats
                                        where (DateTime.Now - item.pObjCliente.FechaIngreso).Days == 0 && item.estado == 1 && (calificacion != 0 ? item.Calificacion == calificacion : 0 == 0)
                                        select new chat
                                        {
                                            NombreCliente = item.pObjCliente.NombreCliente,
                                            EmailCliente = item.pObjCliente.EmailCliente,
                                            TelCliente = item.pObjCliente.TelCliente,
                                            dFechaIng = item.pObjCliente.FechaIngreso,
                                            dFechaAte = item.FechaAtencion,
                                            dFechaFin = item.FechaFinal,
                                            NomUsuari = (item.pObjEmpleado == null ? "" : item.pObjEmpleado.NombreEmpleado),
                                            nCalifica = item.Calificacion,
                                            cComentExt = item.Comentario,
                                            cComentInt = item.ComentarioI,
                                            direccionIp = item.dirIp,
                                            cTextoChat = (item.ListaMensajes == null ? "" : string.Join("\n", (from itemA in item.ListaMensajes
                                                                                                               select ((itemA.Tipo == "E" ?
                                                                                                                   item.pObjCliente.NombreCliente : (item.pObjEmpleado == null ? "Agente No Identificado" : item.pObjEmpleado.NombreEmpleado)) + " - " + itemA.Fecha + ": " +
                                                                                                                   itemA.TextoMensaje)).ToList())),
                                            nIdchat = item.IdChat,
                                            zona = item.zona
                                        }).ToList();
                    }
                    if (tipoF == 3)
                    {
                        var totChats = chatContext.ObtenerListaChats("WcfChatCoope");
                        chatServicio = (from item in totChats
                                        where (DateTime.Now - item.pObjCliente.FechaIngreso).Days == 0 && item.estado == 0 && (calificacion != 0 ? item.Calificacion == calificacion : 0 == 0)
                                        select new chat
                                        {
                                            NombreCliente = item.pObjCliente.NombreCliente,
                                            EmailCliente = item.pObjCliente.EmailCliente,
                                            TelCliente = item.pObjCliente.TelCliente,
                                            dFechaIng = item.pObjCliente.FechaIngreso,
                                            dFechaAte = item.FechaAtencion,
                                            dFechaFin = item.FechaFinal,
                                            NomUsuari = (item.pObjEmpleado == null ? "" : item.pObjEmpleado.NombreEmpleado),
                                            nCalifica = item.Calificacion,
                                            cComentExt = item.Comentario,
                                            cComentInt = item.ComentarioI,
                                            direccionIp = item.dirIp,
                                            cTextoChat = (item.ListaMensajes == null ? "" : string.Join("\n", (from itemA in item.ListaMensajes
                                                                                                               select ((itemA.Tipo == "E" ?
                                                                                                                   item.pObjCliente.NombreCliente : (item.pObjEmpleado == null ? "Agente No Identificado" : item.pObjEmpleado.NombreEmpleado)) + " - " + itemA.Fecha + ": " +
                                                                                                                   itemA.TextoMensaje)).ToList())),
                                            nIdchat = item.IdChat,
                                            zona = item.zona
                                        }).ToList();
                    }
                    if (tipoF == 4)
                    {
                        var totChats = chatContext.ObtenerListaChats("WcfChatCoope");
                        chatServicio = (from item in totChats
                                        where (DateTime.Now - item.pObjCliente.FechaIngreso).Days == 0 && item.estado == -1 && (calificacion != 0 ? item.Calificacion == calificacion : 0 == 0)
                                        select new chat
                                        {
                                            NombreCliente = item.pObjCliente.NombreCliente,
                                            EmailCliente = item.pObjCliente.EmailCliente,
                                            TelCliente = item.pObjCliente.TelCliente,
                                            dFechaIng = item.pObjCliente.FechaIngreso,
                                            dFechaAte = item.FechaAtencion,
                                            dFechaFin = item.FechaFinal,
                                            NomUsuari = (item.pObjEmpleado == null ? "" : item.pObjEmpleado.NombreEmpleado),
                                            nCalifica = item.Calificacion,
                                            cComentExt = item.Comentario,
                                            cComentInt = item.ComentarioI,
                                            direccionIp = item.dirIp,
                                            cTextoChat = (item.ListaMensajes == null ? "" : string.Join("\n", (from itemA in item.ListaMensajes
                                                                                                               select ((itemA.Tipo == "E" ?
                                                                                                                   item.pObjCliente.NombreCliente : (item.pObjEmpleado == null ? "Agente No Identificado" : item.pObjEmpleado.NombreEmpleado)) + " - " + itemA.Fecha + ": " +
                                                                                                                   itemA.TextoMensaje)).ToList())),
                                            nIdchat = item.IdChat,
                                            zona = item.zona
                                        }).ToList();
                    }
                    if (tipoF == 5)
                    {
                        var totChats = chatContext.ObtenerListaChats("WcfChatCoope");
                        chatServicio = (from item in totChats
                                        where (DateTime.Now - item.pObjCliente.FechaIngreso).Days == 0 && item.estado == -1 && item.Calificacion > 2 && (calificacion != 0 ? item.Calificacion == calificacion : 0 == 0)
                                        select new chat
                                        {
                                            NombreCliente = item.pObjCliente.NombreCliente,
                                            EmailCliente = item.pObjCliente.EmailCliente,
                                            TelCliente = item.pObjCliente.TelCliente,
                                            dFechaIng = item.pObjCliente.FechaIngreso,
                                            dFechaAte = item.FechaAtencion,
                                            dFechaFin = item.FechaFinal,
                                            NomUsuari = (item.pObjEmpleado == null ? "" : item.pObjEmpleado.NombreEmpleado),
                                            nCalifica = item.Calificacion,
                                            cComentExt = item.Comentario,
                                            cComentInt = item.ComentarioI,
                                            direccionIp = item.dirIp,
                                            cTextoChat = (item.ListaMensajes == null ? "" : string.Join("\n", (from itemA in item.ListaMensajes
                                                                                                               select ((itemA.Tipo == "E" ?
                                                                                                                   item.pObjCliente.NombreCliente : (item.pObjEmpleado == null ? "Agente No Identificado" : item.pObjEmpleado.NombreEmpleado)) + " - " + itemA.Fecha + ": " +
                                                                                                                   itemA.TextoMensaje)).ToList())),
                                            nIdchat = item.IdChat,
                                            zona = item.zona
                                        }).ToList();
                    }
                    if (tipoF == 6)
                    {
                        var totChats = chatContext.ObtenerListaChats("WcfChatCoope");
                        chatServicio = (from item in totChats
                                        where (DateTime.Now - item.pObjCliente.FechaIngreso).Days == 0 && item.estado == -1 && item.Calificacion < 3 && (calificacion != 0 ? item.Calificacion == calificacion : 0 == 0)
                                        select new chat
                                        {
                                            NombreCliente = item.pObjCliente.NombreCliente,
                                            EmailCliente = item.pObjCliente.EmailCliente,
                                            TelCliente = item.pObjCliente.TelCliente,
                                            dFechaIng = item.pObjCliente.FechaIngreso,
                                            dFechaAte = item.FechaAtencion,
                                            dFechaFin = item.FechaFinal,
                                            NomUsuari = (item.pObjEmpleado == null ? "" : item.pObjEmpleado.NombreEmpleado),
                                            nCalifica = item.Calificacion,
                                            cComentExt = item.Comentario,
                                            cComentInt = item.ComentarioI,
                                            direccionIp = item.dirIp,
                                            cTextoChat = (item.ListaMensajes == null ? "" : string.Join("\n", (from itemA in item.ListaMensajes
                                                                                                               select ((itemA.Tipo == "E" ?
                                                                                                                   item.pObjCliente.NombreCliente : (item.pObjEmpleado == null ? "Agente No Identificado" : item.pObjEmpleado.NombreEmpleado)) + " - " + itemA.Fecha + ": " +
                                                                                                                   itemA.TextoMensaje)).ToList())),
                                            nIdchat = item.IdChat,
                                           zona = item.zona
                                        }).ToList();
                    }
                }


                chatTot = ChatBase.Union(chatServicio).ToList();

                this.dgChat.DataSource = chatTot;


            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgChat_SelectionChanged(object sender, EventArgs e)
        {
            string valorChat = dgChat.CurrentRow.Cells["cTextoChat"].Value.ToString();

            txtVchat.Text = valorChat;
        }
     
    }
}
