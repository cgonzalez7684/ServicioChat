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
using System.Net;
using System.IO;
using System.Runtime.InteropServices;



namespace App
{
    public partial class frmChat : Form
    {
        int tipoF = 0;
        string detalleT = "Chat ";
        static DateTime? fechaIni;
        static DateTime? fechaFin;
        static DateTime? fechaAte;
        public static int idEmpleado;
        public static int idChat;
        int CalifiacionChat;
        public static string MsjUsuCierreChat; //Mensaje dejado al cerrar el chat por Cliente
        string MsjUsuSalidaExterno; //Mensaje dejado al cerrar el chat el Agente
        string pUCierra; //Identifica quien cierra el chat Agente (I) , Cliente (E)
        ServicioChat.ListaCliente infoCLiente;
        public static string remoteUri = "http://172.16.7.4/wcfChat/Files/";
        public string ArchivoDescarga = "";
        bool blinking; //Boton del aplicativo estando anclado en la barra de tareas parpadea si es que llega un mensaje
        [DllImport("user32.dll")]
        public static extern int FlashWindow(IntPtr Hwnd, bool Revert);


        #region Medotos internos


   

        private void inicializarVariables()
        {
            idChat = 0;
            fechaIni = null;
            fechaFin = null;
            fechaAte = null;
            CalifiacionChat = 0;
            MsjUsuCierreChat = string.Empty;
            MsjUsuSalidaExterno = string.Empty;
            pUCierra = string.Empty;
        }

        private void HabilitarControlesChat(Boolean Habilitar)
        {
            if (Habilitar)
            {
                txtVchat.Enabled = true;
                TxtEscribeMensaje.Enabled = true;
                BtnEnviarMensaje.Enabled = true;

                TxtNombreCliente.Enabled = true;
                TxtTelefonoCliente.Enabled = true;
                TxtCorreoCliente.Enabled = true;
                TxtIngresoCliente.Enabled = true;
                TxtMinutosCliente.Enabled = true;
                TxtEnviadoUsuario.Enabled = true;
                TxtRecibidoCliente.Enabled = true;
                TxtDirIP.Enabled = true;
                txtVchat.Enabled = true;
                TxtEscribeMensaje.Enabled = true;
                return;
            }

            txtVchat.Enabled = false;
            TxtEscribeMensaje.Enabled = false;
            BtnEnviarMensaje.Enabled = false;

            TxtNombreCliente.Enabled = false;
            TxtTelefonoCliente.Enabled = false;
            TxtCorreoCliente.Enabled = false;
            TxtIngresoCliente.Enabled = false;
            TxtMinutosCliente.Enabled = false;
            TxtEnviadoUsuario.Enabled = false;
            TxtRecibidoCliente.Enabled = false;
            TxtDirIP.Enabled = false;
            txtVchat.Enabled = false;
            TxtEscribeMensaje.Enabled = false;


        }

        private void LimpiarControles()
        {
            TxtNombreCliente.Text = string.Empty;
            TxtTelefonoCliente.Text = string.Empty;
            TxtCorreoCliente.Text = string.Empty;
            TxtIngresoCliente.Text = string.Empty;
            TxtMinutosCliente.Text = string.Empty;
            TxtEnviadoUsuario.Text = string.Empty;
            TxtRecibidoCliente.Text = string.Empty;
            TxtDirIP.Text = string.Empty;
            txtZona.Text = string.Empty;
            txtVchat.Text = string.Empty;
            TxtEscribeMensaje.Text = string.Empty;
            LblIdChat.Text = "0";



        }

        private void AppendText(RichTextBox box, int posI,int posF,Color color, string text)
        {


            box.SelectionFont = new Font(new FontFamily("Comic Sans MS"), 10, FontStyle.Regular);
            box.AppendText(text);
            box.Select(posI, posF);
            box.SelectionColor = color;         
     
        }

        private void VerificarEstadoExternoChat()
        {
            try
            {
                using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
                {
                    toolLabelUsuario.Text = string.Empty;
                    int estadoChat = 0;

                    estadoChat = context.verificar_chat(idChat, "I","WcfChatCoope");
                    if (estadoChat <= 0)
                    {
                        return;
                        //throw new Exception();
                    }
                    if (estadoChat == 2)
                    {
                        toolLabelUsuario.Text = TxtNombreCliente.Text.Trim() + " escribiendo ....";
                    }
                    if (estadoChat == 1)
                    {
                        toolLabelUsuario.Text = "";
                    }
                    RecibirMensaje();
                }
                
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error verificando estado Chat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        private void CrearMensaje()
        {
            try
            {
                if (TxtEscribeMensaje.Text.Length <= 0)
                {
                    return;
                }


                using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
                {

                    String encabezado = String.Format("[{0:hh}:{0:mm}:{0:ss}] /", DateTime.Now) + " [" + FrmMain.cNombreCom.ToUpper() + "] : ";
                    String dato = encabezado + TxtEscribeMensaje.Text + Environment.NewLine;
                    int result = 0;
                    result = context.CrearMensaje(idChat, "E", TxtEscribeMensaje.Text.Trim(),"WcfChatCoope");

                    if (result == 0)
                    {
                        throw new Exception();
                    }

                    if (txtVchat.TextLength <= 0)
                    {
                        int posF = encabezado.LastIndexOf(':');
                        AppendText(txtVchat, 0, posF, Color.DarkBlue, dato);
                    }
                    else
                    {
                        int posF = encabezado.LastIndexOf(':') + txtVchat.TextLength;
                        AppendText(txtVchat, txtVchat.TextLength, encabezado.LastIndexOf(':'), Color.DarkBlue, dato);
                    }
                    TxtEscribeMensaje.Text = String.Empty;


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error registrando mensaje Chat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecibirMensaje()
        {
            try
            {
                
                ArchivoDescarga = "";
                using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
                {

                
                    
                    List<ServicioChat.ListaMensaje> LstMensajesChat = new List<ServicioChat.ListaMensaje>();
                    LstMensajesChat = null;
                    LstMensajesChat = context.RecibirMensajes(idChat, "I", "WcfChatCoope").ToList<ServicioChat.ListaMensaje>();
                    if (LstMensajesChat == null)
                    {

                        //throw new Exception();
                        return;
                    }

                    

                    foreach (var item in LstMensajesChat)
                    {
                        String encabezado = String.Format("[{0:hh}:{0:mm}:{0:ss}] /", DateTime.Now) + " [" + item.Nombre.ToUpper() + "] : ";
                        String dato = "";
                        if (item.linkMsj.Length > 0)
                        {
                            ArchivoDescarga = item.linkMsj;
                            dato = encabezado + remoteUri + "/" + item.linkMsj + Environment.NewLine; ;
                        }
                        else
                        {
                            dato = encabezado + item.TextoMensaje + Environment.NewLine;
                            if ((this.WindowState == FormWindowState.Minimized) && (item.TextoMensaje.Length > 0))
                            {
                                TmBlinking.Start();
                            }


                        }
                        if (txtVchat.TextLength <= 0)
                        {
                            int posF = encabezado.LastIndexOf(':');
                            AppendText(txtVchat, 0, posF, Color.CornflowerBlue, dato);
                        }
                        else
                        {
                            int posF = encabezado.LastIndexOf(':') + txtVchat.TextLength;
                            AppendText(txtVchat, txtVchat.TextLength, encabezado.LastIndexOf(':'), Color.CornflowerBlue, dato);
                        }

                    }

               
               

                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error recibiendo mensaje Chat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



     
        private void CountMinutos()
        {
            try
            {
                if (idChat <= 0)
                {
                    return;
                }

                //TimeSpan Ts = DateTime.Now -  fechaIni;
                TxtMinutosCliente.Text = String.Format("{0:hh}:{0:mm}:{0:ss}.000", DateTime.Now - fechaIni);
                


            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error conteo de minutos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Este metodo esta refrescando por segundo los datos de ultimo momento
        //de envio y recibido de mensajes entre cliente y agente.
        private void CargaDatosVivosChat()
        {
            try
            {
                if (idChat <= 0)
                {
                    return;
                }
                CargarInfoCliente(2);
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        private void CargarInfoCliente(int Tipo)
        {
            try
            {   
                using (ServicioChat.WebChatClient chatContext = new ServicioChat.WebChatClient())
                {
                    
                    
                    infoCLiente = new ServicioChat.ListaCliente();
                    infoCLiente = chatContext.ObtenerInfoCliente(idChat, "WcfChatCoope");
                    if (infoCLiente == null)
                    {
                        return;
                    }

                    if (Tipo == 1)
                    {
                        TxtNombreCliente.Text = infoCLiente.NombreCliente;
                        TxtTelefonoCliente.Text = infoCLiente.TelCliente;
                        TxtCorreoCliente.Text = infoCLiente.EmailCliente;
                        fechaIni = infoCLiente.FechaIngreso;
                        TxtIngresoCliente.Text = infoCLiente.FechaIngreso.ToString();
                        TxtEnviadoUsuario.Text = infoCLiente.UltimoMensajeI.ToString();
                        TxtRecibidoCliente.Text = infoCLiente.UltimoMensajeE.ToString();
                        TxtDirIP.Text = infoCLiente.dirIp;
                        txtZona.Text = infoCLiente.zona;
                        fechaAte = DateTime.Now; //Momento en el que se atendio el chat por parte del agente
                    }
                    else
                    {
                        TxtEnviadoUsuario.Text = infoCLiente.UltimoMensajeI.ToString();
                        TxtRecibidoCliente.Text = infoCLiente.UltimoMensajeE.ToString();
                    }

                    int estado = chatContext.ObtenerEstadoChat(idChat, "WcfChatCoope");

                    if (estado == -1)
                    {
                        TimerMinutosChat.Stop();
                        TimerRecibirMensajes.Stop();
                        //MessageBox.Show("El cliente finalizó el chat, el mismo será guardado y se buscará un nuevo cliente por atender", "Finalización de chat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MessageBox.Show(this, "El cliente finalizó el chat, el mismo será guardado y se buscará un nuevo cliente por atender", "Finalización de chat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                        BtnCerrarChat.PerformClick();
                    }
                    


                    
                    
                    

                }
            }
            catch (Exception e)
            {
                
               MessageBox.Show("Error cargando la información del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private bool EstablecerChat()
        {
            try
            {
                if (idChat != 0){
                    return true;
                }
                using (ServicioChat.WebChatClient chatContext = new ServicioChat.WebChatClient())
                {
                    idChat = chatContext.ObtenerIdChatAtender("WcfChatCoope");

                    if (idChat == 0)
                    {
                        return false;
                    }

                    if (chatContext.AsignarChat(idChat, idEmpleado, "WcfChatCoope") <= 0)
                    {
                        return false;
                    }
                    chatContext.cambiarEstado(idEmpleado, 1, "WcfChatCoope");
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error estableciendo la vinculación con el Chat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }





        #endregion


        public frmChat()
        {
            InitializeComponent();
            idChat = 0;
            CalifiacionChat = 0;
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

       

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (splitContainer1.SplitterDistance == (splitContainer1.Width / 2))
            {
                splitContainer1.SplitterDistance = 0;
                BtnExpandir.Image = App.Properties.Resources.FlechaDerecha;
                return;
            }
            splitContainer1.SplitterDistance = (splitContainer1.Width / 2);
            BtnExpandir.Image = App.Properties.Resources.FlechaIzquierda;
                
            

            
        }

        private void frmChat_Load(object sender, EventArgs e)
        {
            

            splitContainer1.SplitterDistance = 0;
            BtnExpandir.Image = App.Properties.Resources.FlechaDerecha;
            idEmpleado = FrmMain.idUsuario;
            blinking = false;
            inicializarVariables();

            LimpiarControles();

            HabilitarControlesChat(false);

            splitContainer1.SplitterDistance = (splitContainer1.Width / 2);
            BtnExpandir.Image = App.Properties.Resources.FlechaIzquierda;
            BtnHabilitarChat.Focus();
            TimerMinutosChat.Start();
            
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void BtnExpandir_MouseHover(object sender, EventArgs e)
        {
            if (splitContainer1.SplitterDistance == (splitContainer1.Width / 2))
            {
                BtnExpandir.Image = App.Properties.Resources.FlechaIzquierdaN;
                return;
            }
            BtnExpandir.Image = App.Properties.Resources.FlechaDerechaN;
        }

        private void BtnExpandir_MouseLeave(object sender, EventArgs e)
        {
            if (splitContainer1.SplitterDistance == (splitContainer1.Width / 2))
            {
                BtnExpandir.Image = App.Properties.Resources.FlechaIzquierda;
                return;
            }
            BtnExpandir.Image = App.Properties.Resources.FlechaDerecha;
        }

        private void BtnCerrarChat_MouseHover(object sender, EventArgs e)
        {
            BtnCerrarChat.Image = App.Properties.Resources.ApagarRojo;
        }

        private void BtnCerrarChat_MouseLeave(object sender, EventArgs e)
        {
            BtnCerrarChat.Image = App.Properties.Resources.Apagar;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            BtnHabilitarChat.Image = App.Properties.Resources.ChatBtnOpri;
        }

        private void BtnHabilitarChat_MouseLeave(object sender, EventArgs e)
        {
            BtnHabilitarChat.Image = App.Properties.Resources.ChatBtn;
        }

        private void BtnNoDispo_MouseHover(object sender, EventArgs e)
        {
            BtnNoDispo.Image = App.Properties.Resources.BtnChatNoDisponibleOpri;
        }

        private void BtnNoDispo_MouseLeave(object sender, EventArgs e)
        {
            BtnNoDispo.Image = App.Properties.Resources.BtnChatNoDisponible;
        }

        private void BtnNoDispo_Click(object sender, EventArgs e)
        {
            try
            {
                MsjUsuCierreChat = string.Empty;   //Mensaje del agente
                MsjUsuSalidaExterno = string.Empty; //Mensaje del cliente

                if (idChat <= 0)
                {
                    return;
                }

                //Se determina si el chat esta con estado Atendido lo que implica
                //que el cliente no ha cerrado el chat si es asi, el usuario interno
                //debe justificar porque desea cerrar el chat.
                //Se establecen los comentarios de salida, si el chat lo esta cerrando el agente la variable MsjUsuCierreChat
                //debe quedar establecida, ademas se establece el valor para MsjUsuSalidaExterno con el comentario que el cliente haya dejado en el chat
                using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
                {

                    if ((idChat > 0) && (context.ObtenerEstadoChat(idChat, "WcfChatCoope") == 1))
                    {
                        frmCerrarChat objCerrarChat = new frmCerrarChat(this);
                        objCerrarChat.ShowDialog();
                        context.CerrarChat(idChat, 3, MsjUsuCierreChat, "I", "WcfChatCoope");
                    }

                    if (idChat > 0)
                    {
                        pUCierra = context.ObtenerUsuarioCierraChat(idChat, "WcfChatCoope");
                        MsjUsuSalidaExterno = context.ObtenerMensajaCierreChat(idChat, "WcfChatCoope");
                        CalifiacionChat = context.ObtenerCalificacionChat(idChat, "WcfChatCoope");
                    }

                    context.RegistraSalidaUsuarioWeb(idChat, "WcfChatCoope");
                }


                //Se guarda el chat en base de datos.
                if (idChat > 0)
                {
                    using (chatEntidad ctxChat = new chatEntidad())
                    {
                        ChatEntity.chats objChat = new ChatEntity.chats();
                        objChat.cNomclient = TxtNombreCliente.Text.Trim();
                        objChat.cTelCliente = TxtTelefonoCliente.Text.Trim();
                        objChat.cEmailClien = TxtCorreoCliente.Text.Trim();
                        objChat.dFechaIng = Convert.ToDateTime(TxtIngresoCliente.Text.Trim());
                        objChat.dFechaAte = fechaAte;
                        objChat.dFechaFin = DateTime.Now;
                        objChat.direccionIp = TxtDirIP.Text.Trim();
                        objChat.cZona = txtZona.Text.Trim();
                        objChat.cCodigoUsu = FrmMain.cUsuario;
                        objChat.cComenInt = MsjUsuCierreChat;
                        objChat.cComenExt = MsjUsuSalidaExterno;
                        objChat.UCierra = pUCierra.Length <= 0 ? "I" : pUCierra.Trim();
                        objChat.cTextoChat = txtVchat.Text.Trim();
                        objChat.nCalifica = CalifiacionChat;
                        ctxChat.chats.Add(objChat);
                        ctxChat.SaveChanges();
                    }
                }


                TimerMinutosChat.Stop();
                TimerRecibirMensajes.Stop();

              

                LimpiarControles();
                HabilitarControlesChat(false);


                inicializarVariables();


                BtnHabilitarChat.PerformClick();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cerrando el Chat " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnCerrarChat_Click(object sender, EventArgs e)
        {
            try
            {
                MsjUsuCierreChat = string.Empty;   //Mensaje del agente
                MsjUsuSalidaExterno = string.Empty; //Mensaje del cliente

                if (idChat <= 0)
                {
                     this.Close();
                    return;
                }

                //Se determina si el chat esta con estado Atendido lo que implica
                //que el cliente no ha cerrado el chat si es asi, el usuario interno
                //debe justificar porque desea cerrar el chat.
                //Se establecen los comentarios de salida, si el chat lo esta cerrando el agente la variable MsjUsuCierreChat
                //debe quedar establecida, ademas se establece el valor para MsjUsuSalidaExterno con el comentario que el cliente haya dejado en el chat
                using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
                {

                    if ((idChat > 0) && (context.ObtenerEstadoChat(idChat, "WcfChatCoope") == 1))
                    {
                        frmCerrarChat objCerrarChat = new frmCerrarChat(this);
                        objCerrarChat.ShowDialog(this);
                        context.CerrarChat(idChat, 3, MsjUsuCierreChat, "I", "WcfChatCoope");
                    }

                    if (idChat > 0)
                    {
                        pUCierra = context.ObtenerUsuarioCierraChat(idChat, "WcfChatCoope");
                        MsjUsuSalidaExterno = context.ObtenerMensajaCierreChat(idChat, "WcfChatCoope");
                        CalifiacionChat = context.ObtenerCalificacionChat(idChat, "WcfChatCoope");
                    }

                    context.RegistraSalidaUsuarioWeb(idChat, "WcfChatCoope");
                }


                //Se guarda el chat en base de datos.
                if (idChat > 0)
                {
                    using (chatEntidad ctxChat = new chatEntidad())
                    {
                        ChatEntity.chats objChat = new ChatEntity.chats();
                        objChat.cNomclient = TxtNombreCliente.Text.Trim();
                        objChat.cTelCliente = TxtTelefonoCliente.Text.Trim();
                        objChat.cEmailClien = TxtCorreoCliente.Text.Trim();
                        objChat.dFechaIng = Convert.ToDateTime(TxtIngresoCliente.Text.Trim());
                        objChat.dFechaAte = fechaAte;
                        objChat.dFechaFin = DateTime.Now;
                        objChat.direccionIp = TxtDirIP.Text.Trim();
                        objChat.cZona = txtZona.Text.Trim();
                        objChat.cCodigoUsu = FrmMain.cUsuario;
                        objChat.cComenInt = MsjUsuCierreChat;
                        objChat.cComenExt = MsjUsuSalidaExterno;
                        objChat.UCierra = pUCierra.Length <= 0 ? "I" : pUCierra.Trim();
                        objChat.cTextoChat = txtVchat.Text.Trim();
                        objChat.nCalifica = CalifiacionChat;
                        ctxChat.chats.Add(objChat);
                        ctxChat.SaveChanges();
                    }
                }

                TimerMinutosChat.Stop();
                TimerRecibirMensajes.Stop();

                if (pUCierra == "I")
                {
                    this.Close();
                    return;
                }

                LimpiarControles();
                HabilitarControlesChat(false);
                inicializarVariables();
                BtnHabilitarChat.PerformClick();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error cerrando el Chat " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void BtnHabilitarChat_Click(object sender, EventArgs e)
        {

             if (idChat > 0)
            {
                return;
            }
            inicializarVariables();
            frmPrcBuscaChat obj = new frmPrcBuscaChat(this.Location.X + 60, this.Location.Y + 50);
            obj.ShowDialog(this);

            if (idChat > 0)
            {
                //if (FrmMain.ActiveForm.WindowState == FormWindowState.Minimized)
                //{
                //    FrmMain.ActiveForm.WindowState = FormWindowState.Maximized;
                //}

                //using (ServicioChat.WebChatClient chatContext = new ServicioChat.WebChatClient())
                //{                 
                    //chatContext.AsignarChat(idChat, idEmpleado, "WcfChatCoope");
                   //chatContext.cambiarEstado(idEmpleado, 1, "WcfChatCoope");
                    
                //}
                
                CargarInfoCliente(1);
                HabilitarControlesChat(true);
                LblIdChat.Text = idChat.ToString().Trim();
                TimerRecibirMensajes.Start();
                TimerMinutosChat.Start();
                TxtEscribeMensaje.Focus();
            }
        }

        private void TimerMinutosChat_Tick(object sender, EventArgs e)
        {
            CountMinutos();
            CargaDatosVivosChat();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            CrearMensaje();
        }

        private void txtVchat_TextChanged(object sender, EventArgs e)
        {
            txtVchat.SelectionStart = txtVchat.Text.Length;
            // scroll it automatically
            txtVchat.ScrollToCaret();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecibirMensaje();
        }

        private void TimerRecibirMensajes_Tick(object sender, EventArgs e)
        {
            //Este metodo esta escuchando lo que el usuario atendido esta realizando
            //y trae el mensaje del mismo si es que corresponde.
            VerificarEstadoExternoChat();
        }

        private void TxtEscribeMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (TxtEscribeMensaje.TextLength > 0 && (e.KeyData == (Keys.Shift | Keys.Enter)))
            {
                CrearMensaje();
                SendKeys.Send("{BACKSPACE}");
                BtnEnviarMensaje.Focus();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //string myStringDir = "C:/visual/";
    
            
            
            //txtVchat.Enabled = true;
            //txtVchat.Text = remoteUri;
        }

        private void txtVchat_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            using (WebClient myWebClient = new WebClient())
            {
                //myStringWebResource = remoteUri + fileName;
                //remoteUri = "http://172.16.7.4/wcfChat/Files/";
                remoteUri = e.LinkText;
                string archinombre = Path.GetFileName(remoteUri);
                string rutaDownload = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),"Downloads");
                // Download the Web resource and save it into the current filesystem folder.
                //myWebClient.DownloadFile(remoteUri, @"C:\Users\cgonzalez.COOPECAJA\Desktop\" + archinombre.Trim());

                //if (File.Exists(@"C:\Users\cgonzalez.COOPECAJA\Desktop\" + archinombre.Trim()))
                //{
                //    System.Diagnostics.Process.Start(@"C:\Users\cgonzalez.COOPECAJA\Desktop\" + archinombre.Trim());
                //}

                myWebClient.DownloadFile(remoteUri, rutaDownload+@"\"+ archinombre.Trim());

                if (File.Exists(rutaDownload + @"\" +archinombre.Trim()))
                {
                    System.Diagnostics.Process.Start(rutaDownload + @"\" + archinombre.Trim());
                }

                
            }

        }

        private void TxtEscribeMensaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void TxtEscribeMensaje_Enter(object sender, EventArgs e)
        {


            //if (TxtEscribeMensaje.Text.Length <= 0)
            //{
            //    return;
            //}

            using (ServicioChat.WebChatClient chatContext = new ServicioChat.WebChatClient())
            {
                chatContext.verificarteclado(idChat, "E", 1, "WcfChatCoope");
            }
        }

        private void TxtEscribeMensaje_Leave(object sender, EventArgs e)
        {
            using (ServicioChat.WebChatClient chatContext = new ServicioChat.WebChatClient())
            {
                chatContext.verificarteclado(idChat, "E", 0, "WcfChatCoope");
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void frmChat_Resize(object sender, EventArgs e)
        {
           
        }

        private void frmChat_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {     
            
         
        }

        private void TmBlinking_Tick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (blinking)
                {
                    FlashWindow(this.Handle, true);
                    blinking = false;
                }
                else
                {
                    FlashWindow(this.Handle, false);
                    blinking = true;
                }

            }
            
            
        }

        private void frmChat_Resize_1(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {

                TmBlinking.Stop();
                blinking = false;
            }
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            MessageBox.Show(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"));
            
        }

     
     
    }

  
}
