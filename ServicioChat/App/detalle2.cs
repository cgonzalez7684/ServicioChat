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
    public partial class detalle2 : Form
    {
        int tipoE = 0;
        string detalleE = "";

        public detalle2()
        {
            InitializeComponent();
        }

        public detalle2(int tipo, string detalle)
        {
            tipoE = tipo;
            detalleE = detalle;
            InitializeComponent();
        }

        private void detalle2_Load(object sender, EventArgs e)
        {

            this.lblDetalle.Text = detalleE;

            List<string> nombres = new List<string>();
            try
            {
                using (ServicioChat.WebChatClient chatContext = new ServicioChat.WebChatClient())
                {

                    if (tipoE == 1)
                    {
                        var totEmp = chatContext.ObtenerListaEmpleados("WcfChatCoope");
                        nombres = (from item in totEmp
                                   select item.NombreEmpleado).ToList();
                    }
                    if (tipoE == 2)
                    {
                        var totEmp = chatContext.ObtenerListaEmpleados("WcfChatCoope");
                        nombres = (from item in totEmp
                                   where item.EstadoAtencion == 1
                                   select item.NombreEmpleado).ToList();
                    }

                    if (tipoE == 3)
                    {
                        var totEmp = chatContext.ObtenerListaEmpleados("WcfChatCoope");
                        nombres = (from item in totEmp
                                   where item.EstadoAtencion == 0
                                   select item.NombreEmpleado).ToList();
                    }

                    if (tipoE == 4)
                    {
                        var totEmp = chatContext.ObtenerListaEmpleados("WcfChatCoope");
                        nombres = (from item in totEmp
                                   where item.EstadoAtencion == 2
                                   select item.NombreEmpleado).ToList();
                    }

                }
                this.dgEmp.DataSource = nombres.Select(x => new { Nombre = x }).ToList(); ;


            }
            catch (Exception ex) {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
