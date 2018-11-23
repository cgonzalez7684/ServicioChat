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
            cargarCombos2();



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
            try
            {
                using (chatEntidad context = new chatEntidad())
                {
                    if(txtUsuario.Text.Trim() == ""){
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
                    if(optActivo.Checked){
                        nEstadoU = 1;
                    }

                    idRol = Int32.Parse((cmbRol.SelectedValue.ToString()));

                    var usuario = context.usuarios.FirstOrDefault(n => (n.cCodigousu == txtUsuario.Text.Trim()));
                    if (this.optNuevo.Checked) {
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


        private void llenarCampos2()
        {

            if (cmbrespuesta.SelectedValue == null)
            {
                return;
            }

            int idRespuesta = Int32.Parse((cmbrespuesta.SelectedValue.ToString()));
            try
            {
                using (chatEntidad context = new chatEntidad())
                {
                    var respuesta = context.respuesta.FirstOrDefault(n => (n.nidRespuesta == idRespuesta));
                    if (respuesta == null)
                    {
                        MessageBox.Show("La respuesta predeterminada no existe en base de datos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        this.txtrespuesta.Text = respuesta.cRespuesta;
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


        private void cargarCombos2()
        {
            try
            {
                using (chatEntidad context = new chatEntidad())
                {
                   

                    var totRes = (from item in context.respuesta
                                  select new { nidRespuesta = item.nidRespuesta, crespuesta = item.cRespuesta }).ToList();


                    cmbrespuesta.DataSource = totRes;
                    cmbrespuesta.DisplayMember = "crespuesta";
                    cmbrespuesta.ValueMember = "nidRespuesta";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (chatEntidad context = new chatEntidad())
                {
                    if (txtrespuesta.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe digitar una respuesta valida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtUsuario.Focus();
                        return;
                    }
                    if (txtrespuesta.Text.Trim().Length < 3)
                    {
                        MessageBox.Show("Debe digitar una respuesta valida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtUsuario.Focus();
                        return;
                    }

                    int nEstadoR = 0;
                    int idRespuesta; ;
                    if (optnuevo2.Checked)
                    {
                        nEstadoR = 1;
                    }

                    
                    if (this.optnuevo2.Checked)
                    {
                        respuesta RNuevo = new respuesta();
                        RNuevo.cRespuesta = txtrespuesta.Text.Trim();
                        context.respuesta.Add(RNuevo);
                        context.SaveChanges();  
                    }
                    else
                    {
                        if (cmbrespuesta.SelectedValue == null)
                        {
                            return;
                        }
                        idRespuesta = Int32.Parse((cmbrespuesta.SelectedValue.ToString()));
                        var respuesta = context.respuesta.FirstOrDefault(n => (n.nidRespuesta == idRespuesta));
                        if (respuesta == null)
                        {
                            MessageBox.Show("La respuesta a modificar no existe.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.txtrespuesta.Focus();
                            return;
                        }
                        else
                        {
                            respuesta.cRespuesta = txtrespuesta.Text.Trim();
                            context.SaveChanges();
                        }
                    }
                    this.optNuevo.Checked = true;
                    this.txtrespuesta.Text = "";

                    MessageBox.Show("Actualización exitosa", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarCombos2();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.optnuevo2.Checked)
            {
                lblRespuesta.Visible = false;
                cmbrespuesta.Visible = false;
                this.txtrespuesta.Text = "";
            }
            else
            {
                lblRespuesta.Visible = true;
                cmbrespuesta.Visible = true;
                this.txtrespuesta.Text = "";
                llenarCampos2();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("Desea eliminar el registro?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result != DialogResult.Yes)
                {
                    return;
                }


                if (optnuevo2.Checked)
                {
                    return;
                }

                using (chatEntidad context = new chatEntidad())
                {


                    int idRespuesta;
                    
                    if (cmbrespuesta.SelectedValue == null)
                    {
                        return;
                    }
                    idRespuesta = Int32.Parse((cmbrespuesta.SelectedValue.ToString()));
                    var respuesta = context.respuesta.FirstOrDefault(n => (n.nidRespuesta == idRespuesta));
                    if (respuesta == null)
                    {
                        MessageBox.Show("La respuesta a eliminar no existe.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtrespuesta.Focus();
                        return;
                    }
                    else
                    {
                        context.respuesta.Remove(respuesta);
                        context.SaveChanges();
                    }
                   
                    this.optNuevo.Checked = true;
                    this.txtrespuesta.Text = "";

                    MessageBox.Show("El registro se eliminó correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarCombos2();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbrespuesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.optnuevo2.Checked)
            {
                return;
            }
            llenarCampos2();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
