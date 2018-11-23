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
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.AccountManagement;
using System.Security.Principal;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Transactions;
using ChatEntity;



namespace App
{
    public partial class FrmMain : Form
    {
        public static string cUsuario;
        public static string cNombreCom;
        public static int idUsuario;
        public static int idRol;

        


        public FrmMain()
        {
            InitializeComponent();
        }

        private void MainBtnGestion_Click(object sender, EventArgs e)
        {

        


            //FormGestionChat.Show()
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {


            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() != typeof(frmDash))
                {
                    frm.Close();
                }
            }


            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmDash))
                {
                    return;
                }
            }
            
            frmDash dashBoard = new frmDash();
            dashBoard.MdiParent = this;
            dashBoard.Show();
            dashBoard.WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() != typeof(frmChat))
                {
                    frm.Close();
                }
            }


            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmChat))
                {
                    return;
                }
            }

            frmChat viewChat = new frmChat();
            //viewChat.MdiParent = this;
            viewChat.Show();
            //viewChat.WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() != typeof(frmConsulta))
                {
                    frm.Close();
                }
            }


            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmConsulta))
                {
                    return;
                }
            }
            
            frmConsulta consulta = new frmConsulta();
            consulta.MdiParent = this;
            consulta.Show();
            consulta.WindowState = FormWindowState.Maximized;
        
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string[] splitName = WindowsIdentity.GetCurrent().Name.Split('\\');
            cUsuario = splitName[1].Trim();
             using (chatEntidad context = new chatEntidad())
            {
                var ObjUsuario = context.usuarios.FirstOrDefault(n => (n.cCodigousu == cUsuario) && (n.nEstadousu == 1));
                if (ObjUsuario == null)
                {
                    MessageBox.Show("El usuario " + cUsuario + " no tiene acceso a este sistema. Contacte al administrador del sistema", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
                else
                {
                    cNombreCom = ObjUsuario.cNomUsuari;
                    idUsuario = ObjUsuario.nIdUsuario;
                    idRol = ObjUsuario.nIdRol;

                }
                
                 if (idRol != 2)
                {

                    using (ServicioChat.WebChatClient chatContext = new ServicioChat.WebChatClient())
                    {
                        int respuesta = chatContext.RegistrarUsuarioInterno(idUsuario, cNombreCom, "WcfChatCoope");
                        int respuesta2 = chatContext.HabilitarUsuarioInterno(idUsuario, 2, "WcfChatCoope");
                        if ((respuesta != 1)&& (respuesta2 != 1))
                        {
                            MessageBox.Show("No se pudo registrar el usuario para atender chats. Contacte al administrador del sistema", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Exit();
                        }

                    }
                }


            }


        }

        private void tsUsuarios_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() != typeof(frmUsuarios))
                {
                    frm.Close();
                }
            }


            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmUsuarios))
                {
                    return;
                }
            }

            frmUsuarios usuario = new frmUsuarios();
            usuario.MdiParent = this;
            usuario.Show();
            usuario.WindowState = FormWindowState.Maximized;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (idRol != 2)
            {
                using (ServicioChat.WebChatClient chatContext = new ServicioChat.WebChatClient())
                {
                    int respuesta = chatContext.RegistraSalidaUsuarioInterno(idUsuario, string.Empty, "I", "WcfChatCoope");
                    if (respuesta != 1)
                    {
                        MessageBox.Show("No se pudo registrar la salida del usuario. Contacte al administrador del sistema", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Exit();
                    }

                }
            }

            //

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
           
            
            FrmAbout obgFrm = new FrmAbout();
            obgFrm.ShowDialog();
          
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() != typeof(dashboardGraficos))
                {
                    frm.Close();
                }
            }


            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(dashboardGraficos))
                {
                    return;
                }
            }

            dashboardGraficos grafico = new dashboardGraficos();
            grafico.MdiParent = this;
            grafico.Show();
            grafico.WindowState = FormWindowState.Maximized;
        }
    }
}
