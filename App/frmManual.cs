using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App
{
    public partial class frmManual : Form
    {
        string sRutaArchivo = string.Empty;
        public frmManual()
        {
            InitializeComponent();
        }

        private void frmManual_Load(object sender, EventArgs e)
        {
            sRutaArchivo = Directory.GetCurrentDirectory() + "\\ManualUsuarioWebChat.pdf";
            if (System.IO.File.Exists(sRutaArchivo))
            {               
                wbManualUsuario.Navigate(sRutaArchivo);
            }
        }

        private void wbManualUsuario_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
