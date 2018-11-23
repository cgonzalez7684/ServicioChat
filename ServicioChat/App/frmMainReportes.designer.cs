namespace App
{
    partial class frmMainReportes
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
            this.btnGraficoSatisfaccion = new System.Windows.Forms.Button();
            this.btnChatAtendidos = new System.Windows.Forms.Button();
            this.BtnSatisXMes = new System.Windows.Forms.Button();
            this.btnGraficoSatisfaccionUsu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGraficoSatisfaccion
            // 
            this.btnGraficoSatisfaccion.BackgroundImage = global::App.Properties.Resources.SatifacionServicio_Grafico;
            this.btnGraficoSatisfaccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGraficoSatisfaccion.Location = new System.Drawing.Point(78, 34);
            this.btnGraficoSatisfaccion.Name = "btnGraficoSatisfaccion";
            this.btnGraficoSatisfaccion.Size = new System.Drawing.Size(253, 148);
            this.btnGraficoSatisfaccion.TabIndex = 0;
            this.btnGraficoSatisfaccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGraficoSatisfaccion.UseVisualStyleBackColor = true;
            this.btnGraficoSatisfaccion.Click += new System.EventHandler(this.btnGraficoSatisfaccion_Click);
            // 
            // btnChatAtendidos
            // 
            this.btnChatAtendidos.BackgroundImage = global::App.Properties.Resources.ChatsAtendidos2_Grafico;
            this.btnChatAtendidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChatAtendidos.Location = new System.Drawing.Point(78, 217);
            this.btnChatAtendidos.Name = "btnChatAtendidos";
            this.btnChatAtendidos.Size = new System.Drawing.Size(253, 159);
            this.btnChatAtendidos.TabIndex = 1;
            this.btnChatAtendidos.UseVisualStyleBackColor = true;
            this.btnChatAtendidos.Click += new System.EventHandler(this.btnChatAtendidos_Click);
            // 
            // BtnSatisXMes
            // 
            this.BtnSatisXMes.BackgroundImage = global::App.Properties.Resources.SatisfaccionServicio_GraficoMensual3;
            this.BtnSatisXMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSatisXMes.Location = new System.Drawing.Point(420, 34);
            this.BtnSatisXMes.Name = "BtnSatisXMes";
            this.BtnSatisXMes.Size = new System.Drawing.Size(253, 148);
            this.BtnSatisXMes.TabIndex = 2;
            this.BtnSatisXMes.UseVisualStyleBackColor = true;
            this.BtnSatisXMes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGraficoSatisfaccionUsu
            // 
            this.btnGraficoSatisfaccionUsu.BackgroundImage = global::App.Properties.Resources.SatisfacionPorAgente_Grafico;
            this.btnGraficoSatisfaccionUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGraficoSatisfaccionUsu.Location = new System.Drawing.Point(420, 217);
            this.btnGraficoSatisfaccionUsu.Name = "btnGraficoSatisfaccionUsu";
            this.btnGraficoSatisfaccionUsu.Size = new System.Drawing.Size(253, 159);
            this.btnGraficoSatisfaccionUsu.TabIndex = 3;
            this.btnGraficoSatisfaccionUsu.UseVisualStyleBackColor = true;
            this.btnGraficoSatisfaccionUsu.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnGraficoSatisfaccion);
            this.panel1.Controls.Add(this.btnGraficoSatisfaccionUsu);
            this.panel1.Controls.Add(this.btnChatAtendidos);
            this.panel1.Controls.Add(this.BtnSatisXMes);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 415);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(724, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmMainReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 451);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainReportes";
            this.Text = "frmPrincipalReportes";
            this.Load += new System.EventHandler(this.frmMainReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGraficoSatisfaccion;
        private System.Windows.Forms.Button btnChatAtendidos;
        private System.Windows.Forms.Button BtnSatisXMes;
        private System.Windows.Forms.Button btnGraficoSatisfaccionUsu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;


    }
}