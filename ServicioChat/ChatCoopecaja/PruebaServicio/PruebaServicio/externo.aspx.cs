using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace PruebaServicio
{
    public partial class externo : System.Web.UI.Page
    {

        public static int chatId;
        public static int estadochat;
        public static string nombre;
        public static string nombreI;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                nombreI = "";
                using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
                {
                    int estado;
                    estado = context.Obtenerservicio();
                    if (estado == 0)
                    {
                        Response.Write("<script>alert('No existe ningun usuario interno registrado favor refresce la pagina.');</script>");
                        this.ListBox1.Enabled = false;
                        this.TextBox1.Enabled = false;
                        this.Button1.Enabled = false;
                        this.Timer1.Enabled = false;
                        return;
                    }

                    chatId = context.CrearChat("Carlos Fonseca", "88697487", "carfonqu@gmail.com");
                    nombre = "Carlos Fonseca";
                    while (chatId == 0)
                    {
                        chatId = context.CrearChat("Carlos Fonseca", "88697487", "carfonqu@gmail.com");
                    }


                    this.ListBox1.Items.Add("Buenos días, en un momento sera atendido por uno de nuestros agentessssss. Numero de chat: " + chatId.ToString());



                }
            }

            
            
            
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
       

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            string mensaje;

            using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
            {
                estadochat = context.verificar_chat(chatId, "E");
                if (estadochat > 0)
                {
                    if (estadochat == 2)
                    {
                        Label1.Text = nombreI + "Esta escribiendo";
                    }
                    else
                    {
                        Label1.Text = "";
                    }
                    var listaMensaje = context.RecibirMensajes(chatId, "E");

                    foreach (var item in listaMensaje)
                    {
                        //string mensaje = DateTime.Now.ToString() + " - " + item.Nombre + ": " + item.TextoMensaje;
                        nombreI = item.Nombre;

                        mensaje = DateTime.Now.ToString() + " - " + item.Nombre + ": " + item.TextoMensaje; ;
                        ListBox1.Items.Add(mensaje);
                    }

                }
                
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int estadoMsj;
            int resultado;
            using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
            {
                if (TextBox1.Text.Trim() != "")
                {
                    estadochat = context.verificar_chat(chatId, "E");
                    if (estadochat > 0)
                    {
                        estadoMsj = context.CrearMensaje(chatId, "I", TextBox1.Text.Trim());
                        if (estadoMsj == 0)
                        {
                            ListBox1.Items.Add("No se pudo enviar el mensaje: " + TextBox1.Text.Trim() + ". Favor intente nuevamente.");
                        }
                        else
                        {
                            ListBox1.Items.Add(DateTime.Now.ToString() + " - " + nombre + TextBox1.Text.Trim());
                        }
                    }

                }
                resultado = context.verificarteclado(chatId, "I", 0);
            }

            TextBox1.Text = "";

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

            int resultado;
                using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
                {
                    
            
            
                if (TextBox1.Text.Trim() == "")
                {
                    resultado = context.verificarteclado(chatId, "I", 0);
                }
                else
                {
                    resultado = context.verificarteclado(chatId, "I", 1);
                }
            }
        }

     
    }
}