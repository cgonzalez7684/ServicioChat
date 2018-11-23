namespace App
{
    partial class dashboardReportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PROC_REPORTE_SATISFACCION_GENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chatDataSet = new App.chatDataSet();
            this.PROC_REPORTE_ATENCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvGraficoBarrasSatisf = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PROC_REPORTE_SATISFACCION_GENTableAdapter = new App.chatDataSetTableAdapters.PROC_REPORTE_SATISFACCION_GENTableAdapter();
            this.PROC_REPORTE_ATENCIONTableAdapter = new App.chatDataSetTableAdapters.PROC_REPORTE_ATENCIONTableAdapter();
            this.lbFechaF = new System.Windows.Forms.Label();
            this.lbFechaI = new System.Windows.Forms.Label();
            this.dtFechaF = new System.Windows.Forms.DateTimePicker();
            this.dtFechaI = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCION_GENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_ATENCIONBindingSource)).BeginInit();
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
            // PROC_REPORTE_ATENCIONBindingSource
            // 
            this.PROC_REPORTE_ATENCIONBindingSource.DataMember = "PROC_REPORTE_ATENCION";
            this.PROC_REPORTE_ATENCIONBindingSource.DataSource = this.chatDataSet;
            // 
            // rvGraficoBarrasSatisf
            // 
            reportDataSource1.Name = "dsGraficoSatisfaccionBarras";
            reportDataSource1.Value = this.PROC_REPORTE_SATISFACCION_GENBindingSource;
            this.rvGraficoBarrasSatisf.LocalReport.DataSources.Add(reportDataSource1);
            this.rvGraficoBarrasSatisf.LocalReport.ReportEmbeddedResource = "App.Reportes.graficoBarrasSatisfaccion.rdlc";
            this.rvGraficoBarrasSatisf.Location = new System.Drawing.Point(29, 83);
            this.rvGraficoBarrasSatisf.Name = "rvGraficoBarrasSatisf";
            this.rvGraficoBarrasSatisf.Size = new System.Drawing.Size(643, 396);
            this.rvGraficoBarrasSatisf.TabIndex = 0;
            this.rvGraficoBarrasSatisf.ZoomPercent = 75;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "dsChatsAtendidos";
            reportDataSource2.Value = this.PROC_REPORTE_ATENCIONBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "App.Reportes.graficoChatAtendidos.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(678, 83);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(570, 396);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.ZoomPercent = 75;
            // 
            // PROC_REPORTE_SATISFACCION_GENTableAdapter
            // 
            this.PROC_REPORTE_SATISFACCION_GENTableAdapter.ClearBeforeFill = true;
            // 
            // PROC_REPORTE_ATENCIONTableAdapter
            // 
            this.PROC_REPORTE_ATENCIONTableAdapter.ClearBeforeFill = true;
            // 
            // lbFechaF
            // 
            this.lbFechaF.AutoSize = true;
            this.lbFechaF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaF.Location = new System.Drawing.Point(218, 24);
            this.lbFechaF.Name = "lbFechaF";
            this.lbFechaF.Size = new System.Drawing.Size(71, 15);
            this.lbFechaF.TabIndex = 23;
            this.lbFechaF.Text = "Fecha Final";
            // 
            // lbFechaI
            // 
            this.lbFechaI.AutoSize = true;
            this.lbFechaI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaI.Location = new System.Drawing.Point(35, 24);
            this.lbFechaI.Name = "lbFechaI";
            this.lbFechaI.Size = new System.Drawing.Size(76, 15);
            this.lbFechaI.TabIndex = 22;
            this.lbFechaI.Text = "Fecha Inicial";
            // 
            // dtFechaF
            // 
            this.dtFechaF.CustomFormat = "";
            this.dtFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaF.Location = new System.Drawing.Point(221, 48);
            this.dtFechaF.Name = "dtFechaF";
            this.dtFechaF.Size = new System.Drawing.Size(112, 20);
            this.dtFechaF.TabIndex = 21;
            // 
            // dtFechaI
            // 
            this.dtFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaI.Location = new System.Drawing.Point(38, 48);
            this.dtFechaI.Name = "dtFechaI";
            this.dtFechaI.Size = new System.Drawing.Size(105, 20);
            this.dtFechaI.TabIndex = 20;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::App.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(359, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 44);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dashboardReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 585);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbFechaF);
            this.Controls.Add(this.lbFechaI);
            this.Controls.Add(this.dtFechaF);
            this.Controls.Add(this.dtFechaI);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.rvGraficoBarrasSatisf);
            this.Name = "dashboardReportes";
            this.Text = "prueba";
            this.Load += new System.EventHandler(this.prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCION_GENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_ATENCIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvGraficoBarrasSatisf;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource PROC_REPORTE_SATISFACCION_GENBindingSource;
        private chatDataSet chatDataSet;
        private chatDataSetTableAdapters.PROC_REPORTE_SATISFACCION_GENTableAdapter PROC_REPORTE_SATISFACCION_GENTableAdapter;
        private System.Windows.Forms.BindingSource PROC_REPORTE_ATENCIONBindingSource;
        private chatDataSetTableAdapters.PROC_REPORTE_ATENCIONTableAdapter PROC_REPORTE_ATENCIONTableAdapter;
        private System.Windows.Forms.Label lbFechaF;
        private System.Windows.Forms.Label lbFechaI;
        private System.Windows.Forms.DateTimePicker dtFechaF;
        private System.Windows.Forms.DateTimePicker dtFechaI;
        private System.Windows.Forms.Button btnBuscar;
    }
}