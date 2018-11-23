namespace App
{
    partial class frmManual
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
            this.wbManualUsuario = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbManualUsuario
            // 
            this.wbManualUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbManualUsuario.Location = new System.Drawing.Point(0, 0);
            this.wbManualUsuario.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbManualUsuario.Name = "wbManualUsuario";
            this.wbManualUsuario.Size = new System.Drawing.Size(1242, 620);
            this.wbManualUsuario.TabIndex = 0;
            this.wbManualUsuario.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbManualUsuario_DocumentCompleted);
            // 
            // frmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 620);
            this.Controls.Add(this.wbManualUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManual";
            this.Text = "frmManual";
            this.Load += new System.EventHandler(this.frmManual_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbManualUsuario;
    }
}