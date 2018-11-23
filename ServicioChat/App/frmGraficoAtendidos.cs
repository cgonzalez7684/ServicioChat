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
    public partial class frmGraficoAtendidos : Form
    {
        public frmGraficoAtendidos()
        {
            InitializeComponent();
        }

        private void frmGraficoAtendidos_Load(object sender, EventArgs e)
        {
             this.rvChatsAtendidos.RefreshReport();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ReportParameter fechaInicial = new ReportParameter("pFechaInicial", Convert.ToString(dtFechaI.Text));
                ReportParameter fechaFinal = new ReportParameter("pFechaFinal", Convert.ToString(dtFechaF.Text));

                this.PROC_REPORTE_ATENCIONTableAdapter.Fill(this.chatDataSet.PROC_REPORTE_ATENCION, Convert.ToDateTime(dtFechaI.Text), Convert.ToDateTime(dtFechaF.Text));
                this.rvChatsAtendidos.LocalReport.SetParameters(new ReportParameter[] { fechaInicial });
                this.rvChatsAtendidos.LocalReport.SetParameters(new ReportParameter[] { fechaFinal });
                this.rvChatsAtendidos.LocalReport.Refresh();
                this.rvChatsAtendidos.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtFechaI_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
