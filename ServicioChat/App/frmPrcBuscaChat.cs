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

namespace App
{
    public partial class frmPrcBuscaChat : Form
    {
        int idChat = 0;

        public frmPrcBuscaChat(int x, int y)
        {
            InitializeComponent();
            this.Location = new Point(x, y);
        }

        public frmPrcBuscaChat()
        {
            InitializeComponent();
            int idChat = 0;
        }

        private void frmPrcBuscaChat_Load(object sender, EventArgs e)
        {
            int idChat = 0;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            idChat = 0;
            timer1.Stop();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void EstablecerChat()
        {
            using (ServicioChat.WebChatClient chatContext = new ServicioChat.WebChatClient())
            {

                idChat = chatContext.ObtenerIdChatAtender("WcfChatCoope");
                idChat = chatContext.AsignarChat(idChat, frmChat.idEmpleado, "WcfChatCoope");

                if (idChat == 0)
                {
                    return;
                }
                else
                {
                    timer1.Stop();
                    frmChat.idChat = idChat;
                    this.Close();
                    
                    
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            EstablecerChat();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //FrmMain.ActiveForm.WindowState = FormWindowState.Minimized;
            
            
        }
    }
}
