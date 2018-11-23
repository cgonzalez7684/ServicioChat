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
using ChatEntity;
using Microsoft.Reporting.WinForms;
namespace App
{
    public partial class frmGraficoSatisfaccionEmpl : Form
    {
        int idEmpleado;
        String nombreAgente;

        public frmGraficoSatisfaccionEmpl()
        {
            InitializeComponent();
        }
       
        private void frmGraficoSatisfaccionEmpl_Load(object sender, EventArgs e)
        {
            try
            {
                using (chatEntidad context = new chatEntidad())
                {
                    var totEmp = (from item in context.usuarios
                                  select new { id = item.nIdUsuario, Nombre = item.cNomUsuari }).ToList();
                    totEmp.Add(new { id = 0, Nombre = "Seleccione un Agente" });


                    var totEmp2 = totEmp.OrderBy(x => x.id).ToList();

                    cmbEmpleados.DataSource = totEmp2;
                    cmbEmpleados.DisplayMember = "Nombre";
                    cmbEmpleados.ValueMember = "id";

                }
                this.rvGraficoSatisfaccionEmp.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            this.rvGraficoSatisfaccionEmp.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                nombreAgente = cmbEmpleados.Text;
                idEmpleado = Int32.Parse((cmbEmpleados.SelectedValue.ToString()));
                if (idEmpleado == 0)
                {
                    MessageBox.Show("Para generar el gráfico de satisfacción por agente, debe de seleccionar un agente.", "Información del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                }
                else {
                    ReportParameter pAgente = new ReportParameter("pAgente", Convert.ToString(nombreAgente));
                    this.rvGraficoSatisfaccionEmp.LocalReport.SetParameters(new ReportParameter[] { pAgente });
                    this.rvGraficoSatisfaccionEmp.LocalReport.Refresh();
                    this.PROC_REPORTE_SATISFACCION_USUTableAdapter.Fill(this.chatDataSet.PROC_REPORTE_SATISFACCION_USU, Convert.ToDateTime(dtFechaI.Text), Convert.ToDateTime(dtFechaF.Text), idEmpleado);
                    this.rvGraficoSatisfaccionEmp.RefreshReport();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
            }
 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rvGraficoSatisfaccionEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
