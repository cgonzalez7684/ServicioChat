using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public class Persona
    {

        public int pIdChat;
        public int contador;
        Timer T;

        public Persona()
        {
            contador = 0;
            T = new Timer();
            T.Interval = 1000;
            T.Enabled = true;

        }

        public void Contando(int pId)
        {
            pIdChat = pId;
            T.Start();
        }

        private void CadaToque(object sender, System.EventArgs e)
        {
            contador = contador + 1;
        }


    }
}
