namespace App
{
    partial class frmChat
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblIdChat = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblEstadoUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnNoDispo = new System.Windows.Forms.Button();
            this.BtnHabilitarChat = new System.Windows.Forms.Button();
            this.BtnCerrarChat = new System.Windows.Forms.Button();
            this.BtnExpandir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCorreoCliente = new System.Windows.Forms.TextBox();
            this.TxtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.TxtDirIP = new System.Windows.Forms.TextBox();
            this.TxtRecibidoCliente = new System.Windows.Forms.TextBox();
            this.TxtEnviadoUsuario = new System.Windows.Forms.TextBox();
            this.TxtMinutosCliente = new System.Windows.Forms.TextBox();
            this.TxtIngresoCliente = new System.Windows.Forms.TextBox();
            this.pnlTxtFijos = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnEnviarMensaje = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtEscribeMensaje = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtVchat = new System.Windows.Forms.RichTextBox();
            this.TimerMinutosChat = new System.Windows.Forms.Timer(this.components);
            this.TimerRecibirMensajes = new System.Windows.Forms.Timer(this.components);
            this.TmBlinking = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.popMensajes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtInactividadCliente = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.pnlTxtFijos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(10, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 512);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblIdChat,
            this.toolLabelUsuario,
            this.LblEstadoUsuario});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(671, 20);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 15);
            this.toolStripStatusLabel1.Text = "IdChat:";
            // 
            // LblIdChat
            // 
            this.LblIdChat.Margin = new System.Windows.Forms.Padding(0, 3, 315, 2);
            this.LblIdChat.Name = "LblIdChat";
            this.LblIdChat.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.LblIdChat.Size = new System.Drawing.Size(13, 15);
            this.LblIdChat.Text = "0";
            // 
            // toolLabelUsuario
            // 
            this.toolLabelUsuario.Name = "toolLabelUsuario";
            this.toolLabelUsuario.Size = new System.Drawing.Size(0, 0);
            // 
            // LblEstadoUsuario
            // 
            this.LblEstadoUsuario.Name = "LblEstadoUsuario";
            this.LblEstadoUsuario.Size = new System.Drawing.Size(0, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnNoDispo);
            this.splitContainer1.Panel1.Controls.Add(this.BtnHabilitarChat);
            this.splitContainer1.Panel1.Controls.Add(this.BtnCerrarChat);
            this.splitContainer1.Panel1.Controls.Add(this.BtnExpandir);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.TxtCorreoCliente);
            this.splitContainer1.Panel1.Controls.Add(this.TxtTelefonoCliente);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.TxtNombreCliente);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pnlDatos);
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(671, 489);
            this.splitContainer1.SplitterDistance = 371;
            this.splitContainer1.TabIndex = 22;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // BtnNoDispo
            // 
            this.BtnNoDispo.FlatAppearance.BorderSize = 0;
            this.BtnNoDispo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.BtnNoDispo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.BtnNoDispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNoDispo.Image = global::App.Properties.Resources.BtnChatNoDisponible;
            this.BtnNoDispo.Location = new System.Drawing.Point(238, 330);
            this.BtnNoDispo.Name = "BtnNoDispo";
            this.BtnNoDispo.Size = new System.Drawing.Size(75, 70);
            this.BtnNoDispo.TabIndex = 16;
            this.BtnNoDispo.UseVisualStyleBackColor = true;
            this.BtnNoDispo.Click += new System.EventHandler(this.BtnNoDispo_Click);
            this.BtnNoDispo.MouseLeave += new System.EventHandler(this.BtnNoDispo_MouseLeave);
            this.BtnNoDispo.MouseHover += new System.EventHandler(this.BtnNoDispo_MouseHover);
            // 
            // BtnHabilitarChat
            // 
            this.BtnHabilitarChat.FlatAppearance.BorderSize = 0;
            this.BtnHabilitarChat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.BtnHabilitarChat.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.BtnHabilitarChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHabilitarChat.Image = global::App.Properties.Resources.ChatBtn;
            this.BtnHabilitarChat.Location = new System.Drawing.Point(138, 330);
            this.BtnHabilitarChat.Name = "BtnHabilitarChat";
            this.BtnHabilitarChat.Size = new System.Drawing.Size(75, 70);
            this.BtnHabilitarChat.TabIndex = 15;
            this.BtnHabilitarChat.UseVisualStyleBackColor = true;
            this.BtnHabilitarChat.Click += new System.EventHandler(this.BtnHabilitarChat_Click);
            this.BtnHabilitarChat.MouseLeave += new System.EventHandler(this.BtnHabilitarChat_MouseLeave);
            this.BtnHabilitarChat.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // BtnCerrarChat
            // 
            this.BtnCerrarChat.FlatAppearance.BorderSize = 0;
            this.BtnCerrarChat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.BtnCerrarChat.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.BtnCerrarChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarChat.Image = global::App.Properties.Resources.Apagar;
            this.BtnCerrarChat.Location = new System.Drawing.Point(41, 330);
            this.BtnCerrarChat.Name = "BtnCerrarChat";
            this.BtnCerrarChat.Size = new System.Drawing.Size(75, 70);
            this.BtnCerrarChat.TabIndex = 14;
            this.BtnCerrarChat.UseVisualStyleBackColor = true;
            this.BtnCerrarChat.Click += new System.EventHandler(this.BtnCerrarChat_Click);
            this.BtnCerrarChat.MouseLeave += new System.EventHandler(this.BtnCerrarChat_MouseLeave);
            this.BtnCerrarChat.MouseHover += new System.EventHandler(this.BtnCerrarChat_MouseHover);
            // 
            // BtnExpandir
            // 
            this.BtnExpandir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExpandir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExpandir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnExpandir.FlatAppearance.BorderSize = 0;
            this.BtnExpandir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.BtnExpandir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.BtnExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExpandir.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpandir.ForeColor = System.Drawing.Color.Tomato;
            this.BtnExpandir.Image = global::App.Properties.Resources.FlechaDerecha;
            this.BtnExpandir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExpandir.Location = new System.Drawing.Point(335, 0);
            this.BtnExpandir.Name = "BtnExpandir";
            this.BtnExpandir.Size = new System.Drawing.Size(36, 489);
            this.BtnExpandir.TabIndex = 0;
            this.BtnExpandir.UseVisualStyleBackColor = false;
            this.BtnExpandir.Click += new System.EventHandler(this.button1_Click_2);
            this.BtnExpandir.MouseLeave += new System.EventHandler(this.BtnExpandir_MouseLeave);
            this.BtnExpandir.MouseHover += new System.EventHandler(this.BtnExpandir_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Correo";
            // 
            // TxtCorreoCliente
            // 
            this.TxtCorreoCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCorreoCliente.Location = new System.Drawing.Point(74, 103);
            this.TxtCorreoCliente.Name = "TxtCorreoCliente";
            this.TxtCorreoCliente.ReadOnly = true;
            this.TxtCorreoCliente.Size = new System.Drawing.Size(224, 20);
            this.TxtCorreoCliente.TabIndex = 11;
            // 
            // TxtTelefonoCliente
            // 
            this.TxtTelefonoCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTelefonoCliente.Location = new System.Drawing.Point(74, 66);
            this.TxtTelefonoCliente.Name = "TxtTelefonoCliente";
            this.TxtTelefonoCliente.ReadOnly = true;
            this.TxtTelefonoCliente.Size = new System.Drawing.Size(224, 20);
            this.TxtTelefonoCliente.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Teléfono";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombreCliente.Location = new System.Drawing.Point(74, 29);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.ReadOnly = true;
            this.TxtNombreCliente.Size = new System.Drawing.Size(224, 20);
            this.TxtNombreCliente.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.TxtInactividadCliente);
            this.pnlDatos.Controls.Add(this.txtZona);
            this.pnlDatos.Controls.Add(this.TxtDirIP);
            this.pnlDatos.Controls.Add(this.TxtRecibidoCliente);
            this.pnlDatos.Controls.Add(this.TxtEnviadoUsuario);
            this.pnlDatos.Controls.Add(this.TxtMinutosCliente);
            this.pnlDatos.Controls.Add(this.TxtIngresoCliente);
            this.pnlDatos.Controls.Add(this.pnlTxtFijos);
            this.pnlDatos.Location = new System.Drawing.Point(13, 165);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(286, 143);
            this.pnlDatos.TabIndex = 13;
            // 
            // txtZona
            // 
            this.txtZona.BackColor = System.Drawing.SystemColors.Window;
            this.txtZona.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtZona.Location = new System.Drawing.Point(122, 100);
            this.txtZona.Name = "txtZona";
            this.txtZona.ReadOnly = true;
            this.txtZona.Size = new System.Drawing.Size(162, 20);
            this.txtZona.TabIndex = 8;
            this.txtZona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDirIP
            // 
            this.TxtDirIP.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDirIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDirIP.Location = new System.Drawing.Point(122, 80);
            this.TxtDirIP.Name = "TxtDirIP";
            this.TxtDirIP.ReadOnly = true;
            this.TxtDirIP.Size = new System.Drawing.Size(162, 20);
            this.TxtDirIP.TabIndex = 7;
            this.TxtDirIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtRecibidoCliente
            // 
            this.TxtRecibidoCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtRecibidoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtRecibidoCliente.Location = new System.Drawing.Point(122, 60);
            this.TxtRecibidoCliente.Name = "TxtRecibidoCliente";
            this.TxtRecibidoCliente.ReadOnly = true;
            this.TxtRecibidoCliente.Size = new System.Drawing.Size(162, 20);
            this.TxtRecibidoCliente.TabIndex = 5;
            this.TxtRecibidoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEnviadoUsuario
            // 
            this.TxtEnviadoUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.TxtEnviadoUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtEnviadoUsuario.Location = new System.Drawing.Point(122, 40);
            this.TxtEnviadoUsuario.Name = "TxtEnviadoUsuario";
            this.TxtEnviadoUsuario.ReadOnly = true;
            this.TxtEnviadoUsuario.Size = new System.Drawing.Size(162, 20);
            this.TxtEnviadoUsuario.TabIndex = 4;
            this.TxtEnviadoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtMinutosCliente
            // 
            this.TxtMinutosCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtMinutosCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtMinutosCliente.Location = new System.Drawing.Point(122, 20);
            this.TxtMinutosCliente.Name = "TxtMinutosCliente";
            this.TxtMinutosCliente.ReadOnly = true;
            this.TxtMinutosCliente.Size = new System.Drawing.Size(162, 20);
            this.TxtMinutosCliente.TabIndex = 3;
            this.TxtMinutosCliente.Text = "00:00:00.000";
            this.TxtMinutosCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtIngresoCliente
            // 
            this.TxtIngresoCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtIngresoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtIngresoCliente.Location = new System.Drawing.Point(122, 0);
            this.TxtIngresoCliente.Name = "TxtIngresoCliente";
            this.TxtIngresoCliente.ReadOnly = true;
            this.TxtIngresoCliente.Size = new System.Drawing.Size(162, 20);
            this.TxtIngresoCliente.TabIndex = 2;
            this.TxtIngresoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlTxtFijos
            // 
            this.pnlTxtFijos.Controls.Add(this.textBox2);
            this.pnlTxtFijos.Controls.Add(this.textBox1);
            this.pnlTxtFijos.Controls.Add(this.textBox12);
            this.pnlTxtFijos.Controls.Add(this.textBox10);
            this.pnlTxtFijos.Controls.Add(this.textBox8);
            this.pnlTxtFijos.Controls.Add(this.textBox6);
            this.pnlTxtFijos.Controls.Add(this.textBox4);
            this.pnlTxtFijos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTxtFijos.Location = new System.Drawing.Point(0, 0);
            this.pnlTxtFijos.Name = "pnlTxtFijos";
            this.pnlTxtFijos.Size = new System.Drawing.Size(122, 141);
            this.pnlTxtFijos.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Zona";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.White;
            this.textBox12.Location = new System.Drawing.Point(0, 80);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(122, 20);
            this.textBox12.TabIndex = 4;
            this.textBox12.Text = "Dirección IP";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(0, 60);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(122, 20);
            this.textBox10.TabIndex = 3;
            this.textBox10.Text = "Recibido";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(0, 40);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(122, 20);
            this.textBox8.TabIndex = 2;
            this.textBox8.Text = "Enviado";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(0, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(122, 20);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "Minutos";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(122, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Ingreso";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnEnviarMensaje);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 413);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 76);
            this.panel4.TabIndex = 24;
            // 
            // BtnEnviarMensaje
            // 
            this.BtnEnviarMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEnviarMensaje.Enabled = false;
            this.BtnEnviarMensaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.BtnEnviarMensaje.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnEnviarMensaje.Image = global::App.Properties.Resources.Mensaje;
            this.BtnEnviarMensaje.Location = new System.Drawing.Point(0, 0);
            this.BtnEnviarMensaje.Name = "BtnEnviarMensaje";
            this.BtnEnviarMensaje.Size = new System.Drawing.Size(296, 76);
            this.BtnEnviarMensaje.TabIndex = 0;
            this.BtnEnviarMensaje.Text = "Enviar";
            this.BtnEnviarMensaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEnviarMensaje.UseVisualStyleBackColor = true;
            this.BtnEnviarMensaje.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtEscribeMensaje);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 58);
            this.panel3.TabIndex = 23;
            // 
            // TxtEscribeMensaje
            // 
            this.TxtEscribeMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEscribeMensaje.Enabled = false;
            this.TxtEscribeMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtEscribeMensaje.Location = new System.Drawing.Point(0, 0);
            this.TxtEscribeMensaje.Name = "TxtEscribeMensaje";
            this.TxtEscribeMensaje.Size = new System.Drawing.Size(296, 58);
            this.TxtEscribeMensaje.TabIndex = 21;
            this.TxtEscribeMensaje.Text = "";
            this.TxtEscribeMensaje.Enter += new System.EventHandler(this.TxtEscribeMensaje_Enter);
            this.TxtEscribeMensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEscribeMensaje_KeyDown);
            this.TxtEscribeMensaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEscribeMensaje_KeyPress);
            this.TxtEscribeMensaje.Leave += new System.EventHandler(this.TxtEscribeMensaje_Leave);
            this.TxtEscribeMensaje.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtEscribeMensaje_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtVchat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 355);
            this.panel2.TabIndex = 22;
            // 
            // txtVchat
            // 
            this.txtVchat.BackColor = System.Drawing.Color.White;
            this.txtVchat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVchat.Enabled = false;
            this.txtVchat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtVchat.Location = new System.Drawing.Point(0, 0);
            this.txtVchat.Name = "txtVchat";
            this.txtVchat.ReadOnly = true;
            this.txtVchat.Size = new System.Drawing.Size(296, 355);
            this.txtVchat.TabIndex = 20;
            this.txtVchat.Text = "";
            this.txtVchat.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtVchat_LinkClicked);
            this.txtVchat.TextChanged += new System.EventHandler(this.txtVchat_TextChanged);
            // 
            // TimerMinutosChat
            // 
            this.TimerMinutosChat.Interval = 1000;
            this.TimerMinutosChat.Tick += new System.EventHandler(this.TimerMinutosChat_Tick);
            // 
            // TimerRecibirMensajes
            // 
            this.TimerRecibirMensajes.Interval = 3000;
            this.TimerRecibirMensajes.Tick += new System.EventHandler(this.TimerRecibirMensajes_Tick);
            // 
            // TmBlinking
            // 
            this.TmBlinking.Interval = 500;
            this.TmBlinking.Tick += new System.EventHandler(this.TmBlinking_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "CHAT";
            // 
            // popMensajes
            // 
            this.popMensajes.Name = "popMensajes";
            this.popMensajes.Size = new System.Drawing.Size(61, 4);
            this.popMensajes.Opening += new System.ComponentModel.CancelEventHandler(this.popMensajes_Opening);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(0, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Inactividad cliente";
            // 
            // TxtInactividadCliente
            // 
            this.TxtInactividadCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtInactividadCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtInactividadCliente.Location = new System.Drawing.Point(122, 120);
            this.TxtInactividadCliente.Name = "TxtInactividadCliente";
            this.TxtInactividadCliente.ReadOnly = true;
            this.TxtInactividadCliente.Size = new System.Drawing.Size(162, 20);
            this.TxtInactividadCliente.TabIndex = 9;
            this.TxtInactividadCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 568);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChat_FormClosing_1);
            this.Load += new System.EventHandler(this.frmChat_Load);
            this.Resize += new System.EventHandler(this.frmChat_Resize_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlTxtFijos.ResumeLayout(false);
            this.pnlTxtFijos.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox txtVchat;
        private System.Windows.Forms.RichTextBox TxtEscribeMensaje;
        private System.Windows.Forms.Button BtnExpandir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCorreoCliente;
        private System.Windows.Forms.TextBox TxtTelefonoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblIdChat;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelUsuario;
        private System.Windows.Forms.TextBox TxtRecibidoCliente;
        private System.Windows.Forms.TextBox TxtEnviadoUsuario;
        private System.Windows.Forms.TextBox TxtMinutosCliente;
        private System.Windows.Forms.TextBox TxtIngresoCliente;
        private System.Windows.Forms.Panel pnlTxtFijos;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button BtnCerrarChat;
        private System.Windows.Forms.Button BtnHabilitarChat;
        private System.Windows.Forms.Button BtnNoDispo;
        private System.Windows.Forms.TextBox TxtDirIP;
        private System.Windows.Forms.Timer TimerMinutosChat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnEnviarMensaje;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer TimerRecibirMensajes;
        private System.Windows.Forms.ToolStripStatusLabel LblEstadoUsuario;
        private System.Windows.Forms.Timer TmBlinking;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip popMensajes;
        private System.Windows.Forms.TextBox TxtInactividadCliente;
        private System.Windows.Forms.TextBox textBox2;
    }
}