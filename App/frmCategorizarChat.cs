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
    public partial class frmCategorizarChat : Form
    {
        public frmCategorizarChat()
        {
            InitializeComponent();
        }


        public frmCategorizarChat(Form auxForm)
        {
            InitializeComponent();
            //this.Location = new Point(
            //      Screen.PrimaryScreen.WorkingArea.Width / 2 - auxForm.Width / 2,
            //      Screen.PrimaryScreen.WorkingArea.Height / 2 - auxForm.Height / 2);

            this.Parent = auxForm;
            this.StartPosition = FormStartPosition.CenterParent;
            
        }

        

        private void frmCategorizarChat_Load(object sender, EventArgs e)
        {

            try
            {
                using (chatEntidad context = new chatEntidad())
                {


                    var totRes = (from item in context.categorias
                                  select new { nCategoriaChat = item.nCategoriaChat, cNombreCate = item.cNombreCate }).ToList();


                    CbxCategoria.DataSource = totRes;
                    CbxCategoria.DisplayMember = "cNombreCate";
                    CbxCategoria.ValueMember = "nCategoriaChat";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error seleccionando la categoría: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnEstablecerCategoria_Click(object sender, EventArgs e)
        {
            int respuesta;
            respuesta = Int32.Parse((CbxCategoria.SelectedValue.ToString()));
            frmChat.CategoriaChat = respuesta;
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
