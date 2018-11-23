namespace App
{
    partial class detalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVchat = new System.Windows.Forms.RichTextBox();
            this.dgChat = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cNomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dfechaing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFechaAte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCalifica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cComentInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cComentExt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDirIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTextoChat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idChat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtVchat);
            this.panel1.Controls.Add(this.dgChat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblDetalle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 520);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtVchat
            // 
            this.txtVchat.Location = new System.Drawing.Point(15, 318);
            this.txtVchat.Name = "txtVchat";
            this.txtVchat.ReadOnly = true;
            this.txtVchat.Size = new System.Drawing.Size(608, 167);
            this.txtVchat.TabIndex = 19;
            this.txtVchat.Text = "";
            // 
            // dgChat
            // 
            this.dgChat.AllowUserToAddRows = false;
            this.dgChat.AllowUserToDeleteRows = false;
            this.dgChat.AllowUserToOrderColumns = true;
            this.dgChat.AllowUserToResizeColumns = false;
            this.dgChat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgChat.BackgroundColor = System.Drawing.Color.White;
            this.dgChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgChat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgChat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgChat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNomCliente,
            this.cTelCliente,
            this.cEmail,
            this.cNombreEmp,
            this.dfechaing,
            this.dFechaAte,
            this.dFechaFin,
            this.nCalifica,
            this.cComentInt,
            this.cComentExt,
            this.cDirIp,
            this.zona,
            this.cTextoChat,
            this.idChat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgChat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgChat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgChat.Location = new System.Drawing.Point(15, 63);
            this.dgChat.Name = "dgChat";
            this.dgChat.RowHeadersVisible = false;
            this.dgChat.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgChat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChat.Size = new System.Drawing.Size(608, 191);
            this.dgChat.TabIndex = 18;
            this.dgChat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgChat.SelectionChanged += new System.EventHandler(this.dgChat_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(12, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Chat";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDetalle.Location = new System.Drawing.Point(11, 7);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(67, 24);
            this.lblDetalle.TabIndex = 15;
            this.lblDetalle.Text = "Detalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(607, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cNomCliente
            // 
            this.cNomCliente.DataPropertyName = "NombreCliente";
            this.cNomCliente.HeaderText = "Cliente";
            this.cNomCliente.Name = "cNomCliente";
            this.cNomCliente.ReadOnly = true;
            // 
            // cTelCliente
            // 
            this.cTelCliente.DataPropertyName = "TelCliente";
            this.cTelCliente.HeaderText = "Teléfono";
            this.cTelCliente.Name = "cTelCliente";
            this.cTelCliente.ReadOnly = true;
            // 
            // cEmail
            // 
            this.cEmail.DataPropertyName = "EmailCliente";
            this.cEmail.HeaderText = "Email";
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            // 
            // cNombreEmp
            // 
            this.cNombreEmp.DataPropertyName = "NomUsuari";
            this.cNombreEmp.HeaderText = "Agente";
            this.cNombreEmp.Name = "cNombreEmp";
            this.cNombreEmp.ReadOnly = true;
            // 
            // dfechaing
            // 
            this.dfechaing.DataPropertyName = "dFechaIng";
            this.dfechaing.HeaderText = "Ingreso";
            this.dfechaing.Name = "dfechaing";
            this.dfechaing.ReadOnly = true;
            this.dfechaing.Width = 130;
            // 
            // dFechaAte
            // 
            this.dFechaAte.DataPropertyName = "dFechaAte";
            this.dFechaAte.HeaderText = "Atención";
            this.dFechaAte.Name = "dFechaAte";
            this.dFechaAte.ReadOnly = true;
            this.dFechaAte.Width = 130;
            // 
            // dFechaFin
            // 
            this.dFechaFin.DataPropertyName = "dFechaFin";
            this.dFechaFin.HeaderText = "Finalización";
            this.dFechaFin.Name = "dFechaFin";
            this.dFechaFin.ReadOnly = true;
            this.dFechaFin.Width = 130;
            // 
            // nCalifica
            // 
            this.nCalifica.DataPropertyName = "nCalifica";
            this.nCalifica.HeaderText = "Calificación";
            this.nCalifica.Name = "nCalifica";
            this.nCalifica.ReadOnly = true;
            // 
            // cComentInt
            // 
            this.cComentInt.DataPropertyName = "cComentInt";
            this.cComentInt.HeaderText = "Coment. Agente";
            this.cComentInt.Name = "cComentInt";
            this.cComentInt.ReadOnly = true;
            // 
            // cComentExt
            // 
            this.cComentExt.DataPropertyName = "cComentExt";
            this.cComentExt.HeaderText = "Coment. Cliente";
            this.cComentExt.Name = "cComentExt";
            this.cComentExt.ReadOnly = true;
            // 
            // cDirIp
            // 
            this.cDirIp.DataPropertyName = "direccionIp";
            this.cDirIp.HeaderText = "Dirección Ip";
            this.cDirIp.Name = "cDirIp";
            this.cDirIp.ReadOnly = true;
            // 
            // zona
            // 
            this.zona.DataPropertyName = "zona";
            this.zona.HeaderText = "Zona";
            this.zona.Name = "zona";
            this.zona.ReadOnly = true;
            // 
            // cTextoChat
            // 
            this.cTextoChat.DataPropertyName = "cTextoChat";
            this.cTextoChat.HeaderText = "textocha";
            this.cTextoChat.Name = "cTextoChat";
            this.cTextoChat.ReadOnly = true;
            this.cTextoChat.Visible = false;
            // 
            // idChat
            // 
            this.idChat.DataPropertyName = "nIdchat";
            this.idChat.HeaderText = "id";
            this.idChat.Name = "idChat";
            this.idChat.ReadOnly = true;
            this.idChat.Visible = false;
            // 
            // detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 526);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "detalle";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.detalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DataGridView dgChat;
        private System.Windows.Forms.RichTextBox txtVchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTelCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfechaing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFechaAte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCalifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn cComentInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cComentExt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDirIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTextoChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChat;
    }
}