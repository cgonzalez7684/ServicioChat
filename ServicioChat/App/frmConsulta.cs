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
    public partial class frmConsulta : Form
    {
        DateTime fechaIni;
        DateTime fechaFin;
        int idEmpleado;


        int uPalabra = 0;
        int calificacion = 0;
        string palabra = "";

        public frmConsulta()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            using (chatEntidad context = new chatEntidad())
            {
                var totEmp =  (from item in context.usuarios
                               select new {id = item.nIdUsuario, Nombre = item.cNomUsuari }).ToList();
                totEmp.Add(new { id = 0, Nombre = "TODOS" });


                var totEmp2 = totEmp.OrderBy(x => x.id).ToList();

                cmbEmpleados.DataSource = totEmp2;
                cmbEmpleados.DisplayMember = "Nombre";
                cmbEmpleados.ValueMember = "id";

                var niveles = new[]
                { 
                    new {id = 0, Nombre = "Todos" },
                    new {id = 5, Nombre = "Exelente" },
                    new {id = 4, Nombre = "Muy Bueno" },
                    new {id = 3, Nombre = "Bueno" } ,
                    new {id = 2, Nombre = "Regular" } ,
                    new {id = 1, Nombre = "Malo" } 
                }.ToList();

                cmbNiveles.DataSource = niveles;
                cmbNiveles.DisplayMember = "Nombre";
                cmbNiveles.ValueMember = "id";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            pctLoad.Visible = true;
            int chatsF = 0;
            int chatsB = 0;
            int chatsM = 0;
            
            uPalabra = 0;
            palabra = "";

            uPalabra = (chkPalabra.Checked == true ? 1 : 0);


            try { 
                fechaIni = DateTime.Parse(dtFechaI.Value.Date.ToShortDateString() + " 00:00:00");
                fechaFin = DateTime.Parse(dtFechaF.Value.Date.ToShortDateString() + " 23:59:59");
                idEmpleado = Int32.Parse((cmbEmpleados.SelectedValue.ToString()));

                calificacion = Int32.Parse((cmbNiveles.SelectedValue.ToString()));

                palabra = txtPalabra.Text.Trim();

                /*(chkPalabra.Checked == true ? item.cTextoChat.Contains(palabra) : 0 == 0)*/

                using (chatEntidad context = new chatEntidad())
                {
                    if (idEmpleado == 0)
                    {
                        chatsF = (from item in context.chats 
                                  where
                                    (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin) && (chkPalabra.Checked == true ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                 select item.dFechaFin).Count();
                        chatsB = (from item in context.chats
                                  where (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin) && (chkPalabra.Checked == true ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                      && item.nCalifica > 2  
                                  select item.dFechaFin).Count();
                        chatsM = (from item in context.chats
                                  where (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin) && (chkPalabra.Checked == true ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                      && item.nCalifica < 3 
                                  select item.dFechaFin).Count();
                    }
                    else
                    {
                        chatsF = (from item in context.chats
                                  join item2 in context.usuarios
                                        on item.cCodigoUsu equals item2.cCodigousu 
                                  where
                                    (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin)
                                    && item2.nIdUsuario.ToString() == idEmpleado.ToString() && (chkPalabra.Checked == true ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                  select item.dFechaFin).Count();
                        chatsB = (from item in context.chats
                                  join item2 in context.usuarios
                                        on item.cCodigoUsu equals item2.cCodigousu
                                  where (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin)
                                   && item2.nIdUsuario.ToString() == idEmpleado.ToString() && item.nCalifica > 2 && (chkPalabra.Checked == true ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                  select item.dFechaFin).Count();
                        chatsM = (from item in context.chats
                                  join item2 in context.usuarios
                                        on item.cCodigoUsu equals item2.cCodigousu
                                  where (item.dFechaIng >= fechaIni && item.dFechaIng <= fechaFin)
                                   && item2.nIdUsuario.ToString() == idEmpleado.ToString() && item.nCalifica < 3 && (chkPalabra.Checked == true ? item.cTextoChat.Contains(palabra) : 0 == 0) && (calificacion != 0 ? item.nCalifica == calificacion : 0 == 0)
                                  select item.dFechaFin).Count();
                    }

                }

                this.lblTotChat.Text = chatsF.ToString();
                this.lblBueno.Text = chatsB.ToString();
                this.lblMalo.Text = chatsM.ToString();

                if (chatsF > 0)
                {
                    this.lblPromedio.Text = ((chatsB * 100) / chatsF).ToString() + "%";
                }
                else
                {
                    this.lblPromedio.Text = "0%";
                }


                pctLoad.Visible = false;

            }catch(Exception ex){
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pctLoad.Visible = true;
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
            detalle detchat = new detalle(7, "Total Chats", fechaIni, fechaFin, idEmpleado, uPalabra, palabra, calificacion);
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
            detalle detchat = new detalle(8, "Chats Buenos", fechaIni, fechaFin, idEmpleado, uPalabra, palabra, calificacion);
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
            detalle detchat = new detalle(9, "Total Malos", fechaIni, fechaFin, idEmpleado, uPalabra, palabra, calificacion);
            detchat.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkPalabra_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPalabra.Checked)
            {
                txtPalabra.Text = "";
                txtPalabra.Enabled = true;
                txtPalabra.Focus();
            }
            else
            {
                txtPalabra.Text = "";
                txtPalabra.Enabled = false;
            }
        }
    }
}
