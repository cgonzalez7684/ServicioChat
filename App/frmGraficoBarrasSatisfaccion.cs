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

using Microsoft.Reporting.WinForms;
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
    public partial class frmGraficoBarrasSatisfaccion : Form
    {
        public frmGraficoBarrasSatisfaccion()
        {
            InitializeComponent();
        }

        private void frmGraficoBarrasSatisfaccion_Load(object sender, EventArgs e)
        {
             this.rvGraficoBarras.RefreshReport();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ReportParameter fechaInicial = new ReportParameter("pFechaInicial", Convert.ToString(dtFechaI.Text));
                ReportParameter fechaFinal = new ReportParameter("pFechaFinal", Convert.ToString(dtFechaF.Text));
                
                this.PROC_REPORTE_SATISFACCION_GENTableAdapter.Fill(this.chatDataSet.PROC_REPORTE_SATISFACCION_GEN, Convert.ToDateTime(dtFechaI.Text), Convert.ToDateTime(dtFechaF.Text));
                this.rvGraficoBarras.LocalReport.SetParameters(new ReportParameter[] { fechaInicial });
                this.rvGraficoBarras.LocalReport.SetParameters(new ReportParameter[] { fechaFinal });
                this.rvGraficoBarras.LocalReport.Refresh();
                this.rvGraficoBarras.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
