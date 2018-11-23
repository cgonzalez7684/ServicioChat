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
using System.Threading;

namespace App
{

    
    
    public partial class Test : Form
    {

        

        //Thread oHilo;
        static int idChat;
        List<Persona> Listado;
        
        public Test()
        {
            InitializeComponent();
            idChat = 0;
            Listado = new List<Persona>();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Persona();
            idChat = idChat + 1;
            oPersona.Contando(idChat);
            Listado.Add(oPersona);
            dg1.DataSource = Listado.ToList();

        }

   
    }

   
}
