namespace App
{
    partial class frmGraficoBarrasSatisfaccion
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
            this.PROC_REPORTE_SATISFACCION_GENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chatDataSet = new App.chatDataSet();
            this.PROC_REPORTE_SATISFACCION_GENTableAdapter = new App.chatDataSetTableAdapters.PROC_REPORTE_SATISFACCION_GENTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFechaF = new System.Windows.Forms.Label();
            this.lbFechaI = new System.Windows.Forms.Label();
            this.dtFechaF = new System.Windows.Forms.DateTimePicker();
            this.dtFechaI = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rvGraficoBarras = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCION_GENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PROC_REPORTE_SATISFACCION_GENBindingSource
            // 
            this.PROC_REPORTE_SATISFACCION_GENBindingSource.DataMember = "PROC_REPORTE_SATISFACCION_GEN";
            this.PROC_REPORTE_SATISFACCION_GENBindingSource.DataSource = this.chatDataSet;
            // 
            // chatDataSet
            // 
            this.chatDataSet.DataSetName = "chatDataSet";
            this.chatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PROC_REPORTE_SATISFACCION_GENTableAdapter
            // 
            this.PROC_REPORTE_SATISFACCION_GENTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(817, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbFechaF
            // 
            this.lbFechaF.AutoSize = true;
            this.lbFechaF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaF.Location = new System.Drawing.Point(210, 25);
            this.lbFechaF.Name = "lbFechaF";
            this.lbFechaF.Size = new System.Drawing.Size(71, 15);
            this.lbFechaF.TabIndex = 20;
            this.lbFechaF.Text = "Fecha Final";
            // 
            // lbFechaI
            // 
            this.lbFechaI.AutoSize = true;
            this.lbFechaI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaI.Location = new System.Drawing.Point(27, 25);
            this.lbFechaI.Name = "lbFechaI";
            this.lbFechaI.Size = new System.Drawing.Size(76, 15);
            this.lbFechaI.TabIndex = 19;
            this.lbFechaI.Text = "Fecha Inicial";
            // 
            // dtFechaF
            // 
            this.dtFechaF.CustomFormat = "";
            this.dtFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaF.Location = new System.Drawing.Point(213, 49);
            this.dtFechaF.Name = "dtFechaF";
            this.dtFechaF.Size = new System.Drawing.Size(111, 20);
            this.dtFechaF.TabIndex = 18;
            // 
            // dtFechaI
            // 
            this.dtFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaI.Location = new System.Drawing.Point(30, 49);
            this.dtFechaI.Name = "dtFechaI";
            this.dtFechaI.Size = new System.Drawing.Size(111, 20);
            this.dtFechaI.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::App.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(377, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 44);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rvGraficoBarras
            // 
            reportDataSource1.Name = "dsGraficoSatisfaccionBarras";
            reportDataSource1.Value = this.PROC_REPORTE_SATISFACCION_GENBindingSource;
            this.rvGraficoBarras.LocalReport.DataSources.Add(reportDataSource1);
            this.rvGraficoBarras.LocalReport.ReportEmbeddedResource = "App.Reportes.graficoBarrasSatisfaccion.rdlc";
            this.rvGraficoBarras.Location = new System.Drawing.Point(12, 75);
            this.rvGraficoBarras.Name = "rvGraficoBarras";
            this.rvGraficoBarras.Size = new System.Drawing.Size(826, 514);
            this.rvGraficoBarras.TabIndex = 21;
            // 
            // frmGraficoBarrasSatisfaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 601);
            this.Controls.Add(this.rvGraficoBarras);
            this.Controls.Add(this.lbFechaF);
            this.Controls.Add(this.lbFechaI);
            this.Controls.Add(this.dtFechaF);
            this.Controls.Add(this.dtFechaI);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGraficoBarrasSatisfaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGraficoBarrasSatisfaccion";
            this.Load += new System.EventHandler(this.frmGraficoBarrasSatisfaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCION_GENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource PROC_REPORTE_SATISFACCION_GENBindingSource;
        private chatDataSet chatDataSet;
        private chatDataSetTableAdapters.PROC_REPORTE_SATISFACCION_GENTableAdapter PROC_REPORTE_SATISFACCION_GENTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFechaF;
        private System.Windows.Forms.Label lbFechaI;
        private System.Windows.Forms.DateTimePicker dtFechaF;
        private System.Windows.Forms.DateTimePicker dtFechaI;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer rvGraficoBarras;

    }
}