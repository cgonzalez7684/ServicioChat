namespace App
{
    partial class frmConsulta
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
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.chkPalabra = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pctLoad = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.dtFechaF = new System.Windows.Forms.DateTimePicker();
            this.dtFechaI = new System.Windows.Forms.DateTimePicker();
            this.line7 = new DevComponents.DotNetBar.Controls.Line();
            this.line14 = new DevComponents.DotNetBar.Controls.Line();
            this.label25 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.line8 = new DevComponents.DotNetBar.Controls.Line();
            this.lblMalo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblBueno = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.line13 = new DevComponents.DotNetBar.Controls.Line();
            this.line12 = new DevComponents.DotNetBar.Controls.Line();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotChat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbNiveles = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLoad)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbNiveles);
            this.panel1.Controls.Add(this.txtPalabra);
            this.panel1.Controls.Add(this.chkPalabra);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pctLoad);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cmbEmpleados);
            this.panel1.Controls.Add(this.dtFechaF);
            this.panel1.Controls.Add(this.dtFechaI);
            this.panel1.Controls.Add(this.line7);
            this.panel1.Controls.Add(this.line14);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.line2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.line1);
            this.panel1.Location = new System.Drawing.Point(47, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 510);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Enabled = false;
            this.txtPalabra.Location = new System.Drawing.Point(194, 121);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(288, 20);
            this.txtPalabra.TabIndex = 34;
            // 
            // chkPalabra
            // 
            this.chkPalabra.AutoSize = true;
            this.chkPalabra.Location = new System.Drawing.Point(52, 121);
            this.chkPalabra.Name = "chkPalabra";
            this.chkPalabra.Size = new System.Drawing.Size(145, 17);
            this.chkPalabra.TabIndex = 33;
            this.chkPalabra.Text = "Buscar por coincidencias";
            this.chkPalabra.UseVisualStyleBackColor = true;
            this.chkPalabra.CheckedChanged += new System.EventHandler(this.chkPalabra_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(1101, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pctLoad
            // 
            this.pctLoad.Image = global::App.Properties.Resources.load_r;
            this.pctLoad.Location = new System.Drawing.Point(485, 393);
            this.pctLoad.Name = "pctLoad";
            this.pctLoad.Size = new System.Drawing.Size(67, 68);
            this.pctLoad.TabIndex = 31;
            this.pctLoad.TabStop = false;
            this.pctLoad.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Agente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Fecha Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha Inicial:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::App.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(795, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 39);
            this.btnBuscar.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Resultados");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(576, 67);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(193, 21);
            this.cmbEmpleados.TabIndex = 27;
            // 
            // dtFechaF
            // 
            this.dtFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaF.Location = new System.Drawing.Point(247, 68);
            this.dtFechaF.Name = "dtFechaF";
            this.dtFechaF.Size = new System.Drawing.Size(123, 20);
            this.dtFechaF.TabIndex = 26;
            // 
            // dtFechaI
            // 
            this.dtFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaI.Location = new System.Drawing.Point(53, 68);
            this.dtFechaI.Name = "dtFechaI";
            this.dtFechaI.Size = new System.Drawing.Size(123, 20);
            this.dtFechaI.TabIndex = 25;
            // 
            // line7
            // 
            this.line7.ForeColor = System.Drawing.Color.Red;
            this.line7.Location = new System.Drawing.Point(8, 167);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(1103, 10);
            this.line7.TabIndex = 24;
            this.line7.Text = "line7";
            // 
            // line14
            // 
            this.line14.ForeColor = System.Drawing.Color.Red;
            this.line14.Location = new System.Drawing.Point(543, 217);
            this.line14.Name = "line14";
            this.line14.Size = new System.Drawing.Size(469, 10);
            this.line14.TabIndex = 23;
            this.line14.Text = "line14";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(545, 197);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 18);
            this.label25.TabIndex = 22;
            this.label25.Text = "Satisfacción";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblPromedio);
            this.panel4.Controls.Add(this.line8);
            this.panel4.Controls.Add(this.lblMalo);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.lblBueno);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.line13);
            this.panel4.Controls.Add(this.line12);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(543, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 160);
            this.panel4.TabIndex = 21;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Arial Unicode MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.ForeColor = System.Drawing.Color.Blue;
            this.lblPromedio.Location = new System.Drawing.Point(186, 25);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(78, 50);
            this.lblPromedio.TabIndex = 16;
            this.lblPromedio.Text = "0%";
            // 
            // line8
            // 
            this.line8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line8.ForeColor = System.Drawing.SystemColors.Control;
            this.line8.Location = new System.Drawing.Point(195, 89);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(31, 48);
            this.line8.TabIndex = 15;
            this.line8.Text = "line8";
            this.line8.VerticalLine = true;
            // 
            // lblMalo
            // 
            this.lblMalo.AutoSize = true;
            this.lblMalo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMalo.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalo.ForeColor = System.Drawing.Color.Blue;
            this.lblMalo.Location = new System.Drawing.Point(347, 113);
            this.lblMalo.Name = "lblMalo";
            this.lblMalo.Size = new System.Drawing.Size(38, 43);
            this.lblMalo.TabIndex = 14;
            this.lblMalo.Text = "0";
            this.lblMalo.Click += new System.EventHandler(this.lblMalo_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(248, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Regular - Malo";
            // 
            // lblBueno
            // 
            this.lblBueno.AutoSize = true;
            this.lblBueno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBueno.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBueno.ForeColor = System.Drawing.Color.Blue;
            this.lblBueno.Location = new System.Drawing.Point(81, 113);
            this.lblBueno.Name = "lblBueno";
            this.lblBueno.Size = new System.Drawing.Size(38, 43);
            this.lblBueno.TabIndex = 9;
            this.lblBueno.Text = "0";
            this.lblBueno.Click += new System.EventHandler(this.lblBueno_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(7, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 20);
            this.label26.TabIndex = 8;
            this.label26.Text = "Excelente- Bueno";
            // 
            // line13
            // 
            this.line13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line13.ForeColor = System.Drawing.SystemColors.Control;
            this.line13.Location = new System.Drawing.Point(221, 109);
            this.line13.Name = "line13";
            this.line13.Size = new System.Drawing.Size(31, 0);
            this.line13.TabIndex = 7;
            this.line13.Text = "line9";
            this.line13.VerticalLine = true;
            // 
            // line12
            // 
            this.line12.ForeColor = System.Drawing.SystemColors.Control;
            this.line12.Location = new System.Drawing.Point(3, 78);
            this.line12.Name = "line12";
            this.line12.Size = new System.Drawing.Size(462, 10);
            this.line12.TabIndex = 6;
            this.line12.Text = "line12";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(174, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Promedio de satisfacción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chats";
            // 
            // line2
            // 
            this.line2.ForeColor = System.Drawing.Color.Red;
            this.line2.Location = new System.Drawing.Point(26, 217);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(469, 10);
            this.line2.TabIndex = 4;
            this.line2.Text = "line2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTotChat);
            this.panel2.Location = new System.Drawing.Point(26, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 160);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total de Chats";
            // 
            // lblTotChat
            // 
            this.lblTotChat.AutoSize = true;
            this.lblTotChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotChat.Font = new System.Drawing.Font("Arial Unicode MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotChat.ForeColor = System.Drawing.Color.Blue;
            this.lblTotChat.Location = new System.Drawing.Point(160, 22);
            this.lblTotChat.Name = "lblTotChat";
            this.lblTotChat.Size = new System.Drawing.Size(109, 129);
            this.lblTotChat.TabIndex = 6;
            this.lblTotChat.Text = "0";
            this.lblTotChat.Click += new System.EventHandler(this.lblTotChat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Histórico de Chats";
            // 
            // line1
            // 
            this.line1.ForeColor = System.Drawing.Color.Red;
            this.line1.Location = new System.Drawing.Point(8, 28);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1103, 10);
            this.line1.TabIndex = 1;
            this.line1.Text = "line1";
            // 
            // cmbNiveles
            // 
            this.cmbNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNiveles.FormattingEnabled = true;
            this.cmbNiveles.Location = new System.Drawing.Point(405, 67);
            this.cmbNiveles.Name = "cmbNiveles";
            this.cmbNiveles.Size = new System.Drawing.Size(147, 21);
            this.cmbNiveles.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Calificación:";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 776);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLoad)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.Line line7;
        private DevComponents.DotNetBar.Controls.Line line14;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPromedio;
        private DevComponents.DotNetBar.Controls.Line line8;
        private System.Windows.Forms.Label lblMalo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblBueno;
        private System.Windows.Forms.Label label26;
        private DevComponents.DotNetBar.Controls.Line line13;
        private DevComponents.DotNetBar.Controls.Line line12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.Line line2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotChat;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.DateTimePicker dtFechaF;
        private System.Windows.Forms.DateTimePicker dtFechaI;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPalabra;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.ComboBox cmbNiveles;
        private System.Windows.Forms.Label label7;
    }
}