namespace App
{
    partial class frmCategorizarChat
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEstablecerCategoria = new System.Windows.Forms.Button();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(561, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Favor categorizar el chat según el contexto de conversación";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnEstablecerCategoria
            // 
            this.BtnEstablecerCategoria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnEstablecerCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstablecerCategoria.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnEstablecerCategoria.Location = new System.Drawing.Point(138, 272);
            this.BtnEstablecerCategoria.Name = "BtnEstablecerCategoria";
            this.BtnEstablecerCategoria.Size = new System.Drawing.Size(393, 47);
            this.BtnEstablecerCategoria.TabIndex = 4;
            this.BtnEstablecerCategoria.Text = "Establecer categoria";
            this.BtnEstablecerCategoria.UseVisualStyleBackColor = false;
            this.BtnEstablecerCategoria.Click += new System.EventHandler(this.BtnEstablecerCategoria_Click);
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(210, 196);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(254, 45);
            this.CbxCategoria.TabIndex = 5;
            this.CbxCategoria.SelectedIndexChanged += new System.EventHandler(this.CbxCategoria_SelectedIndexChanged);
            // 
            // frmCategorizarChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 492);
            this.Controls.Add(this.CbxCategoria);
            this.Controls.Add(this.BtnEstablecerCategoria);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategorizarChat";
            this.Opacity = 0.9D;
            this.Text = "frmCategorizarChat";
            this.Load += new System.EventHandler(this.frmCategorizarChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEstablecerCategoria;
        private System.Windows.Forms.ComboBox CbxCategoria;
    }
}