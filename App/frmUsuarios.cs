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
using System.Data.SqlClient;
using System.Data.Entity;
using System.Transactions;
using ChatEntity;

namespace App
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

            cargarCombos();
            CargaRespuestas();
            dgRespuestas.Focus();




        }

        private void optNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.optNuevo.Checked)
            {
                lblAgente.Visible = false;
                cmbEmpleados.Visible = false;
                txtUsuario.ReadOnly = false;
                this.txtUsuario.Text = "";
                this.txtNombre.Text = "";
                this.optActivo.Checked = true;
                this.cmbRol.SelectedIndex = 1;
            }
            else
            {
                lblAgente.Visible = true;
                cmbEmpleados.Visible = true;
                txtUsuario.ReadOnly = true;
                llenarCampos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Guardar el registro?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (chatEntidad context = new chatEntidad())
                {
                    if (txtUsuario.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe digitar un usuario de active directory", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtUsuario.Focus();
                        return;
                    }
                    if (txtNombre.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe digitar un nombre para el usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtNombre.Focus();
                        return;
                    }

                    int nEstadoU = 0;
                    int idRol;
                    if (optActivo.Checked)
                    {
                        nEstadoU = 1;
                    }

                    idRol = Int32.Parse((cmbRol.SelectedValue.ToString()));

                    var usuario = context.usuarios.FirstOrDefault(n => (n.cCodigousu == txtUsuario.Text.Trim()));
                    if (this.optNuevo.Checked)
                    {
                        if (usuario == null)
                        {
                            usuarios uNuevo = new usuarios();
                            uNuevo.cCodigousu = txtUsuario.Text.Trim();
                            uNuevo.cNomUsuari = txtNombre.Text.Trim();
                            uNuevo.nIdRol = idRol;
                            uNuevo.nEstadousu = nEstadoU;
                            context.usuarios.Add(uNuevo);
                            context.SaveChanges();
                        }
                        else
                        {
                            usuario = null;
                            MessageBox.Show("Este usuario ya existe en la base de datos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.txtNombre.Focus();
                            return;
                        }
                    }
                    else
                    {
                        if (usuario == null)
                        {
                            MessageBox.Show("El usuario no existe en la base de datos favor verifique.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.txtNombre.Focus();
                            return;
                        }
                        else
                        {
                            usuario.cNomUsuari = txtNombre.Text.Trim();
                            usuario.nIdRol = idRol;
                            usuario.nEstadousu = nEstadoU;
                            context.SaveChanges();


                        }
                    }
                    this.optNuevo.Checked = true;

                    MessageBox.Show("Actualización exitosa", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.optNuevo.Checked)
            {
                return;
            }
            llenarCampos();



        }

        private void llenarCampos()
        {
            int idEmpleado = Int32.Parse((cmbEmpleados.SelectedValue.ToString()));
            try
            {
                using (chatEntidad context = new chatEntidad())
                {
                    var usuario = context.usuarios.FirstOrDefault(n => (n.nIdUsuario == idEmpleado));
                    if (usuario == null)
                    {
                        MessageBox.Show("El usuario no existe en la base de datos favor verifique.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        this.txtUsuario.Text = usuario.cCodigousu;
                        this.txtNombre.Text = usuario.cNomUsuari;
                        this.optActivo.Checked = true;
                        if (usuario.nEstadousu == 0)
                        {
                            this.optActivo.Checked = true;
                        }

                        for (int i = 0; i <= cmbRol.Items.Count - 1; i++)
                        {
                            cmbRol.SelectedIndex = i;
                            if (usuario.nIdRol == Int32.Parse((cmbRol.SelectedValue.ToString())))
                            {
                                break;
                            }
                        }


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }





        private void CargaRespuestas()
        {
            try
            {
                using (chatEntidad context = new chatEntidad())
                {
                    List<respuesta> lista = (from dato in context.respuesta
                                                  orderby dato.nidRespuesta descending
                                                  select dato).ToList();
                    dgRespuestas.DataSource = lista;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void llenarCampos3()
        {

            if (cmbCategorias.SelectedValue == null)
            {
                return;
            }

            int idRespuesta = Int32.Parse((cmbCategorias.SelectedValue.ToString()));
            try
            {
                using (chatEntidad context = new chatEntidad())
                {
                    var respuesta = context.categorias.FirstOrDefault(n => (n.nCategoriaChat == idRespuesta));
                    if (respuesta == null)
                    {
                        MessageBox.Show("La categoría no existe en base de datos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        this.txtCategoria.Text = respuesta.cNombreCate;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargarCombos()
        {
            try
            {
                using (chatEntidad context = new chatEntidad())
                {
                    var totEmp = (from item in context.usuarios
                                  select new { id = item.nIdUsuario, Nombre = item.cNomUsuari }).ToList();


                    var totRol = (from item in context.roles
                                  select new { idRol = item.nIdRol, nombreRol = item.cNombre }).ToList();


                    cmbEmpleados.DataSource = totEmp;
                    cmbEmpleados.DisplayMember = "Nombre";
                    cmbEmpleados.ValueMember = "id";

                    cmbRol.DataSource = totRol;
                    cmbRol.DisplayMember = "nombreRol";
                    cmbRol.ValueMember = "idRol";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }








        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }








        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optCatNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.optCatNuevo.Checked)
            {
                lblCategoria.Visible = false;
                cmbCategorias.Visible = false;
                this.txtCategoria.Text = "";
            }
            else
            {
                lblCategoria.Visible = true;
                cmbCategorias.Visible = true;
                this.txtCategoria.Text = "";
                llenarCampos3();
            }
        }

        private void optexiste2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarCat_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Desea Guardar el registro?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (chatEntidad context = new chatEntidad())
                {
                    if (txtCategoria.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe digitar una categoría valida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtUsuario.Focus();
                        return;
                    }
                    if (txtCategoria.Text.Trim().Length < 3)
                    {
                        MessageBox.Show("Debe digitar una categoría valida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtUsuario.Focus();
                        return;
                    }

                    int idRespuesta;

                    if (this.optCatNuevo.Checked)
                    {
                        categorias CatNuevo = new categorias();
                        CatNuevo.cNombreCate = txtCategoria.Text.Trim();
                        context.categorias.Add(CatNuevo);
                        context.SaveChanges();
                    }
                    else
                    {
                        if (cmbCategorias.SelectedValue == null)
                        {
                            return;
                        }
                        idRespuesta = Int32.Parse((cmbCategorias.SelectedValue.ToString()));
                        var categoria = context.categorias.FirstOrDefault(n => (n.nCategoriaChat == idRespuesta));
                        if (categoria == null)
                        {
                            MessageBox.Show("La categoría a modificar no existe.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            // this.txtrespuesta.Focus();
                            return;
                        }
                        else
                        {
                            categoria.cNombreCate = txtCategoria.Text.Trim();
                            context.SaveChanges();
                        }
                    }
                    this.optCatNuevo.Checked = true;
                    this.txtCategoria.Text = "";

                    MessageBox.Show("Actualización exitosa", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("Desea eliminar el registro?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result != DialogResult.Yes)
                {
                    return;
                }


                if (optCatNuevo.Checked)
                {
                    return;
                }

                using (chatEntidad context = new chatEntidad())
                {


                    int idRespuesta;

                    if (cmbCategorias.SelectedValue == null)
                    {
                        return;
                    }
                    idRespuesta = Int32.Parse((cmbCategorias.SelectedValue.ToString()));
                    var categoria = context.categorias.FirstOrDefault(n => (n.nCategoriaChat == idRespuesta));
                    if (categoria == null)
                    {
                        MessageBox.Show("La categoría a eliminar no existe.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //this.txtrespuesta.Focus();
                        return;
                    }
                    else
                    {
                        context.categorias.Remove(categoria);
                        context.SaveChanges();
                    }

                    this.optCatNuevo.Checked = true;
                    this.txtCategoria.Text = "";

                    MessageBox.Show("El registro se eliminó correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {


                if (BtnSalvar.Text == "Nuevo")
                {
                    BtnSalvar.Text = "Guardar";
                    TxtTituloRespuesta.Text = String.Empty;
                    TxtDetalleRespuesta.Text = String.Empty;
                    TxtTituloRespuesta.ReadOnly = false;
                    TxtDetalleRespuesta.ReadOnly = false;
                    TxtTituloRespuesta.Focus();
                    //BtnRefrescarHitos.Image = MigraCoopecaja.Properties.Resources.Cargando;
                    BtnSalvar.Image = App.Properties.Resources.GuardarRespuesta;
                    BtnModiRespuesta.Enabled = false;
                    return;
                }


                if (BtnSalvar.Text == "Guardar")
                {

                    if (TxtTituloRespuesta.Text == String.Empty || TxtDetalleRespuesta.Text == String.Empty)
                    {
                        MessageBox.Show("Debe ingresar los datos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TxtTituloRespuesta.Focus();
                        return;
                    }

                    using (chatEntidad context = new chatEntidad())
                    {

                        respuesta objrespuesta = new respuesta();
                        objrespuesta.cTitulo = TxtTituloRespuesta.Text.Trim();
                        objrespuesta.cRespuesta = TxtDetalleRespuesta.Text.Trim();
                        context.respuesta.Add(objrespuesta);
                        context.SaveChanges();

                    }
                    TxtTituloRespuesta.Text = String.Empty;
                    TxtDetalleRespuesta.Text = String.Empty;
                    TxtTituloRespuesta.ReadOnly = true;
                    TxtDetalleRespuesta.ReadOnly = true;
                    BtnSalvar.Text = "Nuevo";
                    BtnSalvar.Image = App.Properties.Resources.NewAnswer;
                    BtnModiRespuesta.Enabled = true;
                    CargaRespuestas();
                    dgRespuestas.Focus();



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgRespuestas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgRespuestas_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void BtnModiRespuesta_Click(object sender, EventArgs e)
        {

            try
            {

                if (dgRespuestas.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un registro a modificar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (BtnModiRespuesta.Text == "Modificar")
                {
                    BtnModiRespuesta.Text = "Guardar";
                    TxtTituloRespuesta.ReadOnly = false;
                    TxtDetalleRespuesta.ReadOnly = false;
                    BtnModiRespuesta.Image = App.Properties.Resources.GuardarModificacion;
                    BtnSalvar.Enabled = false;
                    TxtTituloRespuesta.Focus();
                    return;

                }

                if (BtnModiRespuesta.Text == "Guardar")
                {

                    if (TxtTituloRespuesta.Text == String.Empty || TxtDetalleRespuesta.Text == String.Empty)
                    {
                        MessageBox.Show("Debe ingresar los datos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TxtTituloRespuesta.Focus();
                        return;
                    }

                    using (chatEntidad context = new chatEntidad())
                    {
                        int idRespuesta = Convert.ToInt32(dgRespuestas.CurrentRow.Cells["dgnidRespuesta"].Value);
                        respuesta objRespuesta = context.respuesta.Find(idRespuesta);
                        objRespuesta.cTitulo = TxtTituloRespuesta.Text.Trim();
                        objRespuesta.cRespuesta = TxtDetalleRespuesta.Text.Trim();
                        context.SaveChanges();
                    }

                    BtnModiRespuesta.Text = "Modificar";
                    TxtTituloRespuesta.ReadOnly = true;
                    TxtDetalleRespuesta.ReadOnly = true;
                    BtnModiRespuesta.Image = App.Properties.Resources.Modificar;
                    BtnSalvar.Enabled = true;
                    CargaRespuestas();
                    dgRespuestas.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void dgRespuestas_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
       
        }

        private void dgRespuestas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TxtTituloRespuesta.Text = dgRespuestas.CurrentRow.Cells["dgcTitulo"].Value.ToString();
            TxtDetalleRespuesta.Text = dgRespuestas.CurrentRow.Cells["dgcRespuesta"].Value.ToString();

            if (BtnSalvar.Text == "Guardar")
            {
                TxtTituloRespuesta.Text = String.Empty;
                TxtDetalleRespuesta.Text = String.Empty;
                BtnSalvar.Text = "Nuevo";
                BtnSalvar.Image = App.Properties.Resources.NewAnswer;
                BtnModiRespuesta.Enabled = true;
            }
        }

        private void OptCatExiste_CheckedChanged(object sender, EventArgs e)
        {

        }





    }
            
          
}
