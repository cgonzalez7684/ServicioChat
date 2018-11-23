namespace App
{
    partial class frmGraficoAtendidos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFechaF = new System.Windows.Forms.Label();
            this.lbFechaI = new System.Windows.Forms.Label();
            this.dtFechaF = new System.Windows.Forms.DateTimePicker();
            this.dtFechaI = new System.Windows.Forms.DateTimePicker();
            this.rvChatsAtendidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chatDataSet = new App.chatDataSet();
            this.PROC_REPORTE_ATENCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROC_REPORTE_ATENCIONTableAdapter = new App.chatDataSetTableAdapters.PROC_REPORTE_ATENCIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_ATENCIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::App.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(384, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 44);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(819, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbFechaF
            // 
            this.lbFechaF.AutoSize = true;
            this.lbFechaF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaF.Location = new System.Drawing.Point(208, 24);
            this.lbFechaF.Name = "lbFechaF";
            this.lbFechaF.Size = new System.Drawing.Size(71, 15);
            this.lbFechaF.TabIndex = 24;
            this.lbFechaF.Text = "Fecha Final";
            // 
            // lbFechaI
            // 
            this.lbFechaI.AutoSize = true;
            this.lbFechaI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaI.Location = new System.Drawing.Point(25, 24);
            this.lbFechaI.Name = "lbFechaI";
            this.lbFechaI.Size = new System.Drawing.Size(76, 15);
            this.lbFechaI.TabIndex = 23;
            this.lbFechaI.Text = "Fecha Inicial";
            // 
            // dtFechaF
            // 
            this.dtFechaF.CustomFormat = "";
            this.dtFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaF.Location = new System.Drawing.Point(211, 48);
            this.dtFechaF.Name = "dtFechaF";
            this.dtFechaF.Size = new System.Drawing.Size(111, 20);
            this.dtFechaF.TabIndex = 22;
            // 
            // dtFechaI
            // 
            this.dtFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaI.Location = new System.Drawing.Point(28, 48);
            this.dtFechaI.Name = "dtFechaI";
            this.dtFechaI.Size = new System.Drawing.Size(111, 20);
            this.dtFechaI.TabIndex = 21;
            // 
            // rvChatsAtendidos
            // 
            reportDataSource1.Name = "dsChatsAtendidos";
            reportDataSource1.Value = this.PROC_REPORTE_ATENCIONBindingSource;
            this.rvChatsAtendidos.LocalReport.DataSources.Add(reportDataSource1);
            this.rvChatsAtendidos.LocalReport.ReportEmbeddedResource = "App.Reportes.graficoChatAtendidos.rdlc";
            this.rvChatsAtendidos.Location = new System.Drawing.Point(12, 74);
            this.rvChatsAtendidos.Name = "rvChatsAtendidos";
            this.rvChatsAtendidos.Size = new System.Drawing.Size(831, 480);
            this.rvChatsAtendidos.TabIndex = 25;
            // 
            // chatDataSet
            // 
            this.chatDataSet.DataSetName = "chatDataSet";
            this.chatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PROC_REPORTE_ATENCIONBindingSource
            // 
            this.PROC_REPORTE_ATENCIONBindingSource.DataMember = "PROC_REPORTE_ATENCION";
            this.PROC_REPORTE_ATENCIONBindingSource.DataSource = this.chatDataSet;
            // 
            // PROC_REPORTE_ATENCIONTableAdapter
            // 
            this.PROC_REPORTE_ATENCIONTableAdapter.ClearBeforeFill = true;
            // 
            // frmGraficoAtendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 566);
            this.Controls.Add(this.rvChatsAtendidos);
            this.Controls.Add(this.lbFechaF);
            this.Controls.Add(this.lbFechaI);
            this.Controls.Add(this.dtFechaF);
            this.Controls.Add(this.dtFechaI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGraficoAtendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGraficoAtendidos";
            this.Load += new System.EventHandler(this.frmGraficoAtendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_ATENCIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFechaF;
        private System.Windows.Forms.Label lbFechaI;
        private System.Windows.Forms.DateTimePicker dtFechaF;
        private System.Windows.Forms.DateTimePicker dtFechaI;
        private Microsoft.Reporting.WinForms.ReportViewer rvChatsAtendidos;
        private System.Windows.Forms.BindingSource PROC_REPORTE_ATENCIONBindingSource;
        private chatDataSet chatDataSet;
        private chatDataSetTableAdapters.PROC_REPORTE_ATENCIONTableAdapter PROC_REPORTE_ATENCIONTableAdapter;

    }
}