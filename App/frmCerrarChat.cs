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
    public partial class frmCerrarChat : Form
    {
        public frmCerrarChat()
        {
            InitializeComponent();
        }

        public frmCerrarChat(Form auxForm)
        {
            InitializeComponent();
            
            this.Location = new Point(
            Screen.PrimaryScreen.WorkingArea.Width / 2 - auxForm.Width / 2,
            Screen.PrimaryScreen.WorkingArea.Height / 2 - auxForm.Height / 2);

        }

      

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtMensajeCerrar.TextLength <= 0)
            {
                return;
            }

            frmChat.MsjUsuCierreChat = TxtMensajeCerrar.Text.Trim();
            this.Close();
        }

        
    }
}
