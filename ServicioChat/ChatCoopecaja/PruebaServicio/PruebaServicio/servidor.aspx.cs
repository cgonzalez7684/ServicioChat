using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaServicio
{
    public partial class servidor : System.Web.UI.Page
    {
        public static int chatId;
        public static int estadochat;
        public static string nombre;
        public static int id;
        public static string nombreE;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Timer1.Enabled = false;
                this.Button2.Enabled = true;
                this.Button3.Enabled = false;
                this.Button4.Enabled = false;
                nombreE = "";
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            string mensaje;
            using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
            {
                estadochat = context.verificar_chat(chatId, "I");
               
                if (estadochat > 0)
                {
                    if (estadochat == 2)
                    {
                        Label1.Text = nombreE + "Esta escribiendo";
                    }
                    else
                    {
                        Label1.Text = "";
                    }

                    var listaMensaje = context.RecibirMensajes(chatId, "I");

                    foreach (var item in listaMensaje)
                    {
                        nombreE = item.Nombre;
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
                    estadochat = context.verificar_chat(chatId, "I");
                    if (estadochat > 0)
                    {
                        estadoMsj = context.CrearMensaje(chatId, "E", TextBox1.Text.Trim());
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
                resultado = context.verificarteclado(chatId, "E", 0);
            }

            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
            {
                int estado;

                if(TextBox2.Text.Trim() == ""){
                    return;
                }
                if (TextBox3.Text.Trim() == "")
                {
                    return;
                }

                estado = context.RegistrarUsuarioInterno(Int16.Parse(TextBox2.Text),TextBox3.Text.Trim());
                if (estado == 0)
                {
                    Response.Write("<script>alert('No existe ningun usuario interno registrado favor refresce la pagina.');</script>");
                    this.ListBox1.Enabled = false;
                    this.TextBox1.Enabled = false;
                    this.Button1.Enabled = false;
                    this.Timer1.Enabled = false;
                    return;
                }


                id = Int16.Parse(TextBox2.Text);
                nombre = TextBox3.Text.Trim();

                ListBox1.Items.Add("se registro el usuario con el id: " + TextBox2.Text);

                this.Button2.Enabled = false;
                this.Button3.Enabled = true;
                this.Button4.Enabled = true;


            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
            {
                chatId = context.AsignarChat(Int16.Parse(TextBox4.Text.Trim()),id);
                if (chatId == 0)
                {
                    this.ListBox1.Items.Add("Error al unirse al chat vuelva a intentarlo" );
                    return;
                }

                Timer1.Enabled = true;
                this.ListBox1.Items.Add("Usted se encuentra actualmente atendiendo el chat: " + chatId.ToString());

                this.Button4.Enabled= false;
                this.Button3.Enabled= true;

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
            {
                int estado;

                if (TextBox2.Text.Trim() == "")
                {
                    return;
                }
                if (TextBox3.Text.Trim() == "")
                {
                    return;
                }

                if (id > 0) { 
                    estado = context.RegistraSalidaUsuarioInterno(id);
                    if (estado != 0)
                    {
                        ListBox1.Items.Add("SE REGISTRO LA SALIDA DEL USUARIO CORRECTAMENTE: ");
                        this.Timer1.Enabled = false;
                        this.Button2.Enabled = true;
                        this.Button3.Enabled = false;
                        this.Button4.Enabled = false;
                        return;
                    }
                    
                }
                


            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int resultado;
            using (ServicioChat.WebChatClient context = new ServicioChat.WebChatClient())
            {
                if (TextBox1.Text.Trim() == "")
                {
                    resultado = context.verificarteclado(chatId, "E", 0);
                }
                else
                {
                    resultado = context.verificarteclado(chatId, "E", 1);
                }
            }
        }
    }
}