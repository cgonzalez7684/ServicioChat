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
    public partial class frmDash : Form
    {
        public frmDash()
        {
            InitializeComponent();
        }

        private void frmDash_Load(object sender, EventArgs e)
        {
            this.calcular();
        }

        public void calcular()
        {
            this.lblFecha.Text = DateTime.Now.ToString();

            int chatsF = 0;
            int chatsA = 0;
            int chatsP = 0;

            int chatsB = 0;
            int chatsM = 0;

            int EmpTo = 0;
            int EmpAc = 0;
            int EmpIn = 0;
            int EmpNd = 0;

            DateTime fechaM;
            TimeSpan span;

            try
            {

                using (chatEntidad context = new chatEntidad())
                {

                    chatsF = (from item in context.chats where DbFunctions.DiffDays(DateTime.Now, item.dFechaFin) == 0 select item.dFechaFin).Count();
                    chatsB = (from item in context.chats where DbFunctions.DiffDays(DateTime.Now, item.dFechaFin) == 0 && item.nCalifica > 2 select item.dFechaFin).Count();
                    chatsM = (from item in context.chats where DbFunctions.DiffDays(DateTime.Now, item.dFechaFin) == 0 && item.nCalifica < 3 select item.dFechaFin).Count();

                }

                using (ServicioChat.WebChatClient chatContext = new ServicioChat.WebChatClient())
                {
                    var totChats = chatContext.ObtenerListaClientes("WcfChatCoope");
                    chatsA = (from item in totChats where (DateTime.Now - item.FechaIngreso).Days == 0 && item.estado == 1 select item.IdChat).Count();
                    chatsP = (from item in totChats where (DateTime.Now - item.FechaIngreso).Days == 0 && item.estado == 0 select item.IdChat).Count();
                    chatsF = chatsF + (from item in totChats where (DateTime.Now - item.FechaIngreso).Days == 0 && item.estado == -1 select item.IdChat).Count();

                    if (totChats.Count() > 0 && chatsP > 0)
                    {
                        fechaM = (from item in totChats where (DateTime.Now - item.FechaIngreso).Days == 0 && item.estado == 0 select item.FechaIngreso).Max();
                        //fechaM = DateTime.Now;
                    }
                    else
                    {
                        fechaM = DateTime.Now;
                    }
                    chatsB = chatsB + (from item in totChats where (DateTime.Now - item.FechaIngreso).Days == 0 && item.estado == -1 && item.Calificacion > 2 select item.IdChat).Count();
                    chatsM = chatsM + (from item in totChats where (DateTime.Now - item.FechaIngreso).Days == 0 && item.estado == -1 && item.Calificacion < 3 select item.IdChat).Count();

                    var totEmp = chatContext.ObtenerListaEmpleados("WcfChatCoope");
                    EmpTo = (from item in totEmp select item.IdEmpleado).Count();
                    EmpAc = (from item in totEmp where item.EstadoAtencion == 1 select item.IdEmpleado).Count();
                    EmpIn = (from item in totEmp where item.EstadoAtencion == 0 select item.IdEmpleado).Count();
                    EmpNd = (from item in totEmp where item.EstadoAtencion == 2 select item.IdEmpleado).Count();
                }

                span = (DateTime.Now - fechaM);

                this.lblTotChat.Text = (chatsF + chatsA + chatsP).ToString();
                this.lblChatA.Text = chatsA.ToString();
                this.lblChatP.Text = chatsP.ToString();
                this.lblChatF.Text = chatsF.ToString();
                this.lblTEspera.Text = span.Minutes.ToString() + ":" + span.Seconds.ToString();

                this.lblTEmp.Text = EmpTo.ToString();
                this.lblEmpA.Text = EmpAc.ToString();
                this.lblEmpI.Text = EmpIn.ToString();
                this.lblEnd.Text = EmpNd.ToString();

                if (chatsF > 0)
                {
                    this.lblPromedio.Text = ((chatsB * 100) / chatsF).ToString() + "%";
                }
                else
                {
                    this.lblPromedio.Text = "0%";
                }

                this.lblBueno.Text = chatsB.ToString();
                this.lblMalo.Text = chatsM.ToString();


                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void line4_Click(object sender, EventArgs e)
        {

        }

        private void line4_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblChatA_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(detalle))
                {
                    return;
                }
            }
            detalle detchat = new detalle(2, "Chats que está siendo atendidos");
            detchat.Show();
        }

        private void lblTotChat_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(detalle))
                {
                    return;
                }
            }
            detalle detchat = new detalle(1, "Chats del día");
            detchat.Show();
        }

        private void lblChatP_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(detalle))
                {
                    return;
                }
            }
            detalle detchat = new detalle(3, "Chats Pendientes de atender");
            detchat.Show();
        }

        private void lblChatF_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(detalle))
                {
                    return;
                }
            }
            detalle detchat = new detalle(4, "Chats finalizados");
            detchat.Show();
        }

        private void lblBueno_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(detalle))
                {
                    return;
                }
            }
            detalle detchat = new detalle(5, "Chats Excelente - Bueno");
            detchat.Show();
        }

        private void lblMalo_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(detalle))
                {
                    return;
                }
            }
            detalle detchat = new detalle(6, "Chats Regular - Malo");
            detchat.Show();
        }

        private void lblEmpA_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(detalle2))
                {
                    return;
                }
            }
            detalle2 detEmp = new detalle2(2, "Empleados Atendiendo");
            detEmp.Show();
        }

        private void lblEmpI_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(detalle2))
                {
                    return;
                }
            }
            detalle2 detEmp = new detalle2(3, "Sin chats asignados");
            detEmp.Show();
        }

        private void lblEnd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(detalle2))
                {
                    return;
                }
            }
            detalle2 detEmp = new detalle2(4, "Empleados no disponibles");
            detEmp.Show();
        }

        private void lblTEmp_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(detalle2))
                {
                    return;
                }
            }
            detalle2 detEmp = new detalle2(1, "Empleados Activos");
            detEmp.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            calcular();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
