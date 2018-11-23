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
    public partial class frmMainReportes : Form
    {
        public frmMainReportes()
        {
            InitializeComponent();
        }

        private void btnGraficoSatisfaccion_Click(object sender, EventArgs e)
        {
           frmGraficoSatisfaccion grafico = new frmGraficoSatisfaccion();
        //    grafico.MdiParent = this;
            grafico.Show();
        }

        private void btnChatAtendidos_Click(object sender, EventArgs e)
        {
            frmGraficoAtendidos grafico = new frmGraficoAtendidos();
            //    grafico.MdiParent = this;
            grafico.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGraficoBarrasSatisfaccion grafico = new frmGraficoBarrasSatisfaccion();
            //    grafico.MdiParent = this;
            grafico.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGraficoSatisfaccionEmpl grafico = new frmGraficoSatisfaccionEmpl();
            //    grafico.MdiParent = this;
            grafico.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMainReportes_Load(object sender, EventArgs e)
        {
            
            ToolTip toolTip1 = new ToolTip();
            
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;            
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btnGraficoSatisfaccion, "Grafico de satisifacción");
            toolTip1.SetToolTip(this.BtnSatisXMes, "Grafico de satisifacción por mes");
            toolTip1.SetToolTip(this.btnGraficoSatisfaccionUsu, "Grafico de satisifacción por agente");
            toolTip1.SetToolTip(this.btnChatAtendidos, "Grafico de Chats atendidos");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
