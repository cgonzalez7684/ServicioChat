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
    public partial class dashboardReportes : Form
    {
        public dashboardReportes()
        {
            InitializeComponent();
        }

        private void prueba_Load(object sender, EventArgs e)
        {

           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ReportParameter fechaInicial = new ReportParameter("pFechaInicial", Convert.ToString(dtFechaI.Text));
            ReportParameter fechaFinal = new ReportParameter("pFechaFinal", Convert.ToString(dtFechaF.Text));

            this.PROC_REPORTE_ATENCIONTableAdapter.Fill(this.chatDataSet.PROC_REPORTE_ATENCION, Convert.ToDateTime(dtFechaI.Text), Convert.ToDateTime(dtFechaF.Text));
            this.PROC_REPORTE_SATISFACCION_GENTableAdapter.Fill(this.chatDataSet.PROC_REPORTE_SATISFACCION_GEN, Convert.ToDateTime(dtFechaI.Text), Convert.ToDateTime(dtFechaF.Text));

            this.rvGraficoBarrasSatisf.LocalReport.SetParameters(new ReportParameter[] { fechaInicial });
            this.rvGraficoBarrasSatisf.LocalReport.SetParameters(new ReportParameter[] { fechaFinal });
            this.rvGraficoBarrasSatisf.LocalReport.Refresh();
            this.rvGraficoBarrasSatisf.RefreshReport();


            this.rvGraficoBarrasSatisf.RefreshReport();

            this.reportViewer2.LocalReport.SetParameters(new ReportParameter[] { fechaInicial });
            this.reportViewer2.LocalReport.SetParameters(new ReportParameter[] { fechaFinal });
            this.reportViewer2.LocalReport.Refresh();
            this.reportViewer2.RefreshReport();


            this.reportViewer2.RefreshReport();
        }
    }
}
