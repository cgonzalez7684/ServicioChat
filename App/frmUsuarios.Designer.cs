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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.BtnModiRespuesta = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.dgRespuestas = new System.Windows.Forms.DataGridView();
            this.dgcTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnidRespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtDetalleRespuesta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTituloRespuesta = new System.Windows.Forms.TextBox();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminaCat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OptCatExiste = new System.Windows.Forms.RadioButton();
            this.optCatNuevo = new System.Windows.Forms.RadioButton();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarCat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpEstado.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRespuestas)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.panel2.Controls.Add(this.BtnModiRespuesta);
            this.panel2.Controls.Add(this.BtnSalvar);
            this.panel2.Controls.Add(this.dgRespuestas);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.TxtDetalleRespuesta);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.TxtTituloRespuesta);
            this.panel2.Controls.Add(this.line2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(487, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 372);
            this.panel2.TabIndex = 1;
            // 
            // BtnModiRespuesta
            // 
            this.BtnModiRespuesta.Image = global::App.Properties.Resources.Modificar;
            this.BtnModiRespuesta.Location = new System.Drawing.Point(214, 286);
            this.BtnModiRespuesta.Name = "BtnModiRespuesta";
            this.BtnModiRespuesta.Size = new System.Drawing.Size(75, 63);
            this.BtnModiRespuesta.TabIndex = 54;
            this.BtnModiRespuesta.Text = "Modificar";
            this.BtnModiRespuesta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModiRespuesta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnModiRespuesta.UseVisualStyleBackColor = true;
            this.BtnModiRespuesta.Click += new System.EventHandler(this.BtnModiRespuesta_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Image = global::App.Properties.Resources.NewAnswer;
            this.BtnSalvar.Location = new System.Drawing.Point(114, 286);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(68, 63);
            this.BtnSalvar.TabIndex = 53;
            this.BtnSalvar.Text = "Nuevo";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dgRespuestas
            // 
            this.dgRespuestas.AllowUserToAddRows = false;
            this.dgRespuestas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRespuestas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcTitulo,
            this.dgcRespuesta,
            this.dgnidRespuesta});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRespuestas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgRespuestas.Location = new System.Drawing.Point(21, 198);
            this.dgRespuestas.Name = "dgRespuestas";
            this.dgRespuestas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRespuestas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgRespuestas.RowHeadersVisible = false;
            this.dgRespuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRespuestas.Size = new System.Drawing.Size(391, 82);
            this.dgRespuestas.TabIndex = 52;
            this.dgRespuestas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRespuestas_CellEnter);
            this.dgRespuestas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRespuestas_RowEnter);
            this.dgRespuestas.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRespuestas_RowValidated);
            this.dgRespuestas.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgRespuestas_RowValidating);
            // 
            // dgcTitulo
            // 
            this.dgcTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgcTitulo.DataPropertyName = "cTitulo";
            this.dgcTitulo.HeaderText = "Titulo";
            this.dgcTitulo.Name = "dgcTitulo";
            this.dgcTitulo.ReadOnly = true;
            this.dgcTitulo.Width = 58;
            // 
            // dgcRespuesta
            // 
            this.dgcRespuesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcRespuesta.DataPropertyName = "cRespuesta";
            this.dgcRespuesta.HeaderText = "Respuesta";
            this.dgcRespuesta.Name = "dgcRespuesta";
            this.dgcRespuesta.ReadOnly = true;
            // 
            // dgnidRespuesta
            // 
            this.dgnidRespuesta.DataPropertyName = "nidRespuesta";
            this.dgnidRespuesta.HeaderText = "IdRespuesta";
            this.dgnidRespuesta.Name = "dgnidRespuesta";
            this.dgnidRespuesta.ReadOnly = true;
            this.dgnidRespuesta.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Respuesta";
            // 
            // TxtDetalleRespuesta
            // 
            this.TxtDetalleRespuesta.Location = new System.Drawing.Point(21, 131);
            this.TxtDetalleRespuesta.Multiline = true;
            this.TxtDetalleRespuesta.Name = "TxtDetalleRespuesta";
            this.TxtDetalleRespuesta.ReadOnly = true;
            this.TxtDetalleRespuesta.Size = new System.Drawing.Size(391, 56);
            this.TxtDetalleRespuesta.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Título";
            // 
            // TxtTituloRespuesta
            // 
            this.TxtTituloRespuesta.Location = new System.Drawing.Point(21, 68);
            this.TxtTituloRespuesta.Name = "TxtTituloRespuesta";
            this.TxtTituloRespuesta.ReadOnly = true;
            this.TxtTituloRespuesta.Size = new System.Drawing.Size(160, 20);
            this.TxtTituloRespuesta.TabIndex = 48;
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
            this.label5.Location = new System.Drawing.Point(405, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEliminaCat);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.line3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnGuardarCat);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtCategoria);
            this.panel3.Controls.Add(this.lblCategoria);
            this.panel3.Controls.Add(this.cmbCategorias);
            this.panel3.Location = new System.Drawing.Point(487, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 305);
            this.panel3.TabIndex = 2;
            // 
            // btnEliminaCat
            // 
            this.btnEliminaCat.Image = global::App.Properties.Resources.delete;
            this.btnEliminaCat.Location = new System.Drawing.Point(250, 243);
            this.btnEliminaCat.Name = "btnEliminaCat";
            this.btnEliminaCat.Size = new System.Drawing.Size(64, 48);
            this.btnEliminaCat.TabIndex = 47;
            this.btnEliminaCat.UseVisualStyleBackColor = true;
            this.btnEliminaCat.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OptCatExiste);
            this.groupBox3.Controls.Add(this.optCatNuevo);
            this.groupBox3.Location = new System.Drawing.Point(21, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 44);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo";
            // 
            // OptCatExiste
            // 
            this.OptCatExiste.AutoSize = true;
            this.OptCatExiste.Location = new System.Drawing.Point(161, 19);
            this.OptCatExiste.Name = "OptCatExiste";
            this.OptCatExiste.Size = new System.Drawing.Size(163, 17);
            this.OptCatExiste.TabIndex = 1;
            this.OptCatExiste.Text = "Modificar Categoría existente";
            this.OptCatExiste.UseVisualStyleBackColor = true;
            this.OptCatExiste.CheckedChanged += new System.EventHandler(this.OptCatExiste_CheckedChanged);
            // 
            // optCatNuevo
            // 
            this.optCatNuevo.AutoSize = true;
            this.optCatNuevo.Checked = true;
            this.optCatNuevo.Location = new System.Drawing.Point(48, 20);
            this.optCatNuevo.Name = "optCatNuevo";
            this.optCatNuevo.Size = new System.Drawing.Size(107, 17);
            this.optCatNuevo.TabIndex = 0;
            this.optCatNuevo.TabStop = true;
            this.optCatNuevo.Text = "Categoría Nueva";
            this.optCatNuevo.UseVisualStyleBackColor = true;
            this.optCatNuevo.CheckedChanged += new System.EventHandler(this.optCatNuevo_CheckedChanged);
            // 
            // line3
            // 
            this.line3.ForeColor = System.Drawing.Color.Red;
            this.line3.Location = new System.Drawing.Point(3, 24);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(261, 10);
            this.line3.TabIndex = 45;
            this.line3.Text = "line3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Categorias de Chats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(405, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "X";
            // 
            // btnGuardarCat
            // 
            this.btnGuardarCat.Image = global::App.Properties.Resources.guardar;
            this.btnGuardarCat.Location = new System.Drawing.Point(165, 243);
            this.btnGuardarCat.Name = "btnGuardarCat";
            this.btnGuardarCat.Size = new System.Drawing.Size(64, 48);
            this.btnGuardarCat.TabIndex = 40;
            this.btnGuardarCat.UseVisualStyleBackColor = true;
            this.btnGuardarCat.Click += new System.EventHandler(this.btnGuardarCat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Ingresar categoría";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(57, 185);
            this.txtCategoria.MaxLength = 50;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(288, 20);
            this.txtCategoria.TabIndex = 33;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(54, 107);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(71, 16);
            this.lblCategoria.TabIndex = 32;
            this.lblCategoria.Text = "Categorias:";
            this.lblCategoria.Visible = false;
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(57, 125);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(288, 21);
            this.cmbCategorias.TabIndex = 31;
            this.cmbCategorias.Visible = false;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 712);
            this.Controls.Add(this.panel3);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgRespuestas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.Line line2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminaCat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton OptCatExiste;
        private System.Windows.Forms.RadioButton optCatNuevo;
        private DevComponents.DotNetBar.Controls.Line line3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardarCat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.DataGridView dgRespuestas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtDetalleRespuesta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTituloRespuesta;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRespuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnidRespuesta;
        private System.Windows.Forms.Button BtnModiRespuesta;
    }
}