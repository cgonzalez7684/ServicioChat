using ChatEntity;
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
    public partial class dashboardGraficos : Form
    {
        int idEmpleado;
        String nombreAgente;

        public dashboardGraficos()
        {
            InitializeComponent();
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
                this.rvGraficoSatisfaccion.LocalReport.SetParameters(new ReportParameter[] { fechaInicial });
                this.rvGraficoSatisfaccion.LocalReport.SetParameters(new ReportParameter[] { fechaFinal });
                this.rvGraficoSatisfaccion.LocalReport.Refresh();
                this.PROC_REPORTE_SATISFACCIONTableAdapter.Fill(this.chatDataSet.PROC_REPORTE_SATISFACCION, Convert.ToDateTime(dtFechaI.Text), Convert.ToDateTime(dtFechaF.Text));
                this.rvGraficoSatisfaccion.RefreshReport();


                //ReportParameter fechaInicial = new ReportParameter("pFechaInicial", Convert.ToString(dtFechaI.Text));
                //ReportParameter fechaFinal = new ReportParameter("pFechaFinal", Convert.ToString(dtFechaF.Text));

                this.PROC_REPORTE_SATISFACCION_GENTableAdapter.Fill(this.chatDataSet.PROC_REPORTE_SATISFACCION_GEN, Convert.ToDateTime(dtFechaI.Text), Convert.ToDateTime(dtFechaF.Text));
                this.rvGraficoBarras.LocalReport.SetParameters(new ReportParameter[] { fechaInicial });
                this.rvGraficoBarras.LocalReport.SetParameters(new ReportParameter[] { fechaFinal });
                this.rvGraficoBarras.LocalReport.Refresh();
                this.rvGraficoBarras.RefreshReport();


                this.PROC_REPORTE_ATENCIONTableAdapter.Fill(this.chatDataSet.PROC_REPORTE_ATENCION, Convert.ToDateTime(dtFechaI.Text), Convert.ToDateTime(dtFechaF.Text));
                this.rvChatsAtendidos.LocalReport.SetParameters(new ReportParameter[] { fechaInicial });
                this.rvChatsAtendidos.LocalReport.SetParameters(new ReportParameter[] { fechaFinal });
                this.rvChatsAtendidos.LocalReport.Refresh();
                this.rvChatsAtendidos.RefreshReport();

                 nombreAgente = cmbEmpleados.Text;
                idEmpleado = Int32.Parse((cmbEmpleados.SelectedValue.ToString()));
                if (idEmpleado == 0)
                {
                    MessageBox.Show("Para generar el gráfico por agente, debe de seleccionar a un agente.", "Alerta del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                }
                else {
                    ReportParameter pAgente = new ReportParameter("pAgente", Convert.ToString(nombreAgente));
                    this.rvGraficoSatisfaccionEmp.LocalReport.SetParameters(new ReportParameter[] { pAgente });
                    this.rvGraficoSatisfaccionEmp.LocalReport.SetParameters(new ReportParameter[] { fechaInicial });
                    this.rvGraficoSatisfaccionEmp.LocalReport.SetParameters(new ReportParameter[] { fechaFinal });
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

        private void dashboardGraficos_Load(object sender, EventArgs e)
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
          
        }
    }
}
