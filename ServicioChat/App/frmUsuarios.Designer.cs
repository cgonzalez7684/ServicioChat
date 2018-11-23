namespace App
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optIexiste = new System.Windows.Forms.RadioButton();
            this.optNuevo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.optInactivo = new System.Windows.Forms.RadioButton();
            this.optActivo = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblAgente = new System.Windows.Forms.Label();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optexiste2 = new System.Windows.Forms.RadioButton();
            this.optnuevo2 = new System.Windows.Forms.RadioButton();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtrespuesta = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.cmbrespuesta = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpEstado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.line1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbRol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grpEstado);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.lblAgente);
            this.panel1.Controls.Add(this.cmbEmpleados);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 460);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // line1
            // 
            this.line1.ForeColor = System.Drawing.Color.Red;
            this.line1.Location = new System.Drawing.Point(3, 26);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(261, 10);
            this.line1.TabIndex = 43;
            this.line1.Text = "line1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 15);
            this.label10.TabIndex = 42;
            this.label10.Text = "Control de Usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(407, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::App.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(192, 400);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 48);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optIexiste);
            this.groupBox1.Controls.Add(this.optNuevo);
            this.groupBox1.Location = new System.Drawing.Point(21, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 44);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // optIexiste
            // 
            this.optIexiste.AutoSize = true;
            this.optIexiste.Location = new System.Drawing.Point(120, 19);
            this.optIexiste.Name = "optIexiste";
            this.optIexiste.Size = new System.Drawing.Size(153, 17);
            this.optIexiste.TabIndex = 1;
            this.optIexiste.Text = "Modificar Usuario Existente";
            this.optIexiste.UseVisualStyleBackColor = true;
            // 
            // optNuevo
            // 
            this.optNuevo.AutoSize = true;
            this.optNuevo.Checked = true;
            this.optNuevo.Location = new System.Drawing.Point(7, 20);
            this.optNuevo.Name = "optNuevo";
            this.optNuevo.Size = new System.Drawing.Size(96, 17);
            this.optNuevo.TabIndex = 0;
            this.optNuevo.TabStop = true;
            this.optNuevo.Text = "Usuario Nuevo";
            this.optNuevo.UseVisualStyleBackColor = true;
            this.optNuevo.CheckedChanged += new System.EventHandler(this.optNuevo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Rol:";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(21, 284);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(288, 21);
            this.cmbRol.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Usuario de Active Directory:";
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.optInactivo);
            this.grpEstado.Controls.Add(this.optActivo);
            this.grpEstado.Location = new System.Drawing.Point(21, 336);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(193, 44);
            this.grpEstado.TabIndex = 35;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Estado";
            // 
            // optInactivo
            // 
            this.optInactivo.AutoSize = true;
            this.optInactivo.Location = new System.Drawing.Point(83, 19);
            this.optInactivo.Name = "optInactivo";
            this.optInactivo.Size = new System.Drawing.Size(63, 17);
            this.optInactivo.TabIndex = 1;
            this.optInactivo.Text = "Inactivo";
            this.optInactivo.UseVisualStyleBackColor = true;
            // 
            // optActivo
            // 
            this.optActivo.AutoSize = true;
            this.optActivo.Checked = true;
            this.optActivo.Location = new System.Drawing.Point(7, 20);
            this.optActivo.Name = "optActivo";
            this.optActivo.Size = new System.Drawing.Size(55, 17);
            this.optActivo.TabIndex = 0;
            this.optActivo.TabStop = true;
            this.optActivo.Text = "Activo";
            this.optActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 234);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(288, 20);
            this.txtNombre.TabIndex = 34;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(21, 187);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(288, 20);
            this.txtUsuario.TabIndex = 33;
            // 
            // lblAgente
            // 
            this.lblAgente.AutoSize = true;
            this.lblAgente.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgente.Location = new System.Drawing.Point(18, 105);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(50, 16);
            this.lblAgente.TabIndex = 32;
            this.lblAgente.Text = "Agente:";
            this.lblAgente.Visible = false;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(21, 123);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(288, 21);
            this.cmbEmpleados.TabIndex = 31;
            this.cmbEmpleados.Visible = false;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.line2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtrespuesta);
            this.panel2.Controls.Add(this.lblRespuesta);
            this.panel2.Controls.Add(this.cmbrespuesta);
            this.panel2.Location = new System.Drawing.Point(487, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 324);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Image = global::App.Properties.Resources.delete;
            this.button2.Location = new System.Drawing.Point(214, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 48);
            this.button2.TabIndex = 47;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optexiste2);
            this.groupBox2.Controls.Add(this.optnuevo2);
            this.groupBox2.Location = new System.Drawing.Point(21, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 44);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // optexiste2
            // 
            this.optexiste2.AutoSize = true;
            this.optexiste2.Location = new System.Drawing.Point(120, 19);
            this.optexiste2.Name = "optexiste2";
            this.optexiste2.Size = new System.Drawing.Size(162, 17);
            this.optexiste2.TabIndex = 1;
            this.optexiste2.Text = "Modificar respuesta existente";
            this.optexiste2.UseVisualStyleBackColor = true;
            // 
            // optnuevo2
            // 
            this.optnuevo2.AutoSize = true;
            this.optnuevo2.Checked = true;
            this.optnuevo2.Location = new System.Drawing.Point(7, 20);
            this.optnuevo2.Name = "optnuevo2";
            this.optnuevo2.Size = new System.Drawing.Size(111, 17);
            this.optnuevo2.TabIndex = 0;
            this.optnuevo2.TabStop = true;
            this.optnuevo2.Text = "Respuesta Nueva";
            this.optnuevo2.UseVisualStyleBackColor = true;
            this.optnuevo2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // line2
            // 
            this.line2.ForeColor = System.Drawing.Color.Red;
            this.line2.Location = new System.Drawing.Point(3, 24);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(261, 10);
            this.line2.TabIndex = 45;
            this.line2.Text = "line2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "Respuestas Preestablecidas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(407, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Image = global::App.Properties.Resources.guardar;
            this.button1.Location = new System.Drawing.Point(129, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 48);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Ingresar respuesta";
            // 
            // txtrespuesta
            // 
            this.txtrespuesta.Location = new System.Drawing.Point(21, 190);
            this.txtrespuesta.Name = "txtrespuesta";
            this.txtrespuesta.Size = new System.Drawing.Size(288, 20);
            this.txtrespuesta.TabIndex = 33;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(18, 112);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(70, 16);
            this.lblRespuesta.TabIndex = 32;
            this.lblRespuesta.Text = "Respuesta:";
            this.lblRespuesta.Visible = false;
            // 
            // cmbrespuesta
            // 
            this.cmbrespuesta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrespuesta.FormattingEnabled = true;
            this.cmbrespuesta.Location = new System.Drawing.Point(21, 130);
            this.cmbrespuesta.Name = "cmbrespuesta";
            this.cmbrespuesta.Size = new System.Drawing.Size(288, 21);
            this.cmbrespuesta.TabIndex = 31;
            this.cmbrespuesta.Visible = false;
            this.cmbrespuesta.SelectedIndexChanged += new System.EventHandler(this.cmbrespuesta_SelectedIndexChanged);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.RadioButton optActivo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblAgente;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.RadioButton optInactivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optIexiste;
        private System.Windows.Forms.RadioButton optNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.ComboBox cmbrespuesta;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.Line line2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtrespuesta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optexiste2;
        private System.Windows.Forms.RadioButton optnuevo2;
        private System.Windows.Forms.Button button2;
    }
}