namespace App
{
    partial class dashboardGraficos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PROC_REPORTE_SATISFACCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chatDataSet = new App.chatDataSet();
            this.PROC_REPORTE_SATISFACCION_GENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROC_REPORTE_ATENCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROC_REPORTE_SATISFACCION_USUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbFechaF = new System.Windows.Forms.Label();
            this.lbFechaI = new System.Windows.Forms.Label();
            this.dtFechaF = new System.Windows.Forms.DateTimePicker();
            this.dtFechaI = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rvGraficoSatisfaccion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PROC_REPORTE_SATISFACCIONTableAdapter = new App.chatDataSetTableAdapters.PROC_REPORTE_SATISFACCIONTableAdapter();
            this.rvGraficoBarras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PROC_REPORTE_SATISFACCION_GENTableAdapter = new App.chatDataSetTableAdapters.PROC_REPORTE_SATISFACCION_GENTableAdapter();
            this.rvChatsAtendidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvGraficoSatisfaccionEmp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PROC_REPORTE_ATENCIONTableAdapter = new App.chatDataSetTableAdapters.PROC_REPORTE_ATENCIONTableAdapter();
            this.lbEmpleado = new System.Windows.Forms.Label();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.PROC_REPORTE_SATISFACCION_USUTableAdapter = new App.chatDataSetTableAdapters.PROC_REPORTE_SATISFACCION_USUTableAdapter();
            this.gbGraficoSatisfaccionAgente = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCION_GENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_ATENCIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCION_USUBindingSource)).BeginInit();
            this.gbGraficoSatisfaccionAgente.SuspendLayout();
            this.SuspendLayout();
            // 
            // PROC_REPORTE_SATISFACCIONBindingSource
            // 
            this.PROC_REPORTE_SATISFACCIONBindingSource.DataMember = "PROC_REPORTE_SATISFACCION";
            this.PROC_REPORTE_SATISFACCIONBindingSource.DataSource = this.chatDataSet;
            // 
            // chatDataSet
            // 
            this.chatDataSet.DataSetName = "chatDataSet";
            this.chatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PROC_REPORTE_SATISFACCION_GENBindingSource
            // 
            this.PROC_REPORTE_SATISFACCION_GENBindingSource.DataMember = "PROC_REPORTE_SATISFACCION_GEN";
            this.PROC_REPORTE_SATISFACCION_GENBindingSource.DataSource = this.chatDataSet;
            // 
            // PROC_REPORTE_ATENCIONBindingSource
            // 
            this.PROC_REPORTE_ATENCIONBindingSource.DataMember = "PROC_REPORTE_ATENCION";
            this.PROC_REPORTE_ATENCIONBindingSource.DataSource = this.chatDataSet;
            // 
            // PROC_REPORTE_SATISFACCION_USUBindingSource
            // 
            this.PROC_REPORTE_SATISFACCION_USUBindingSource.DataMember = "PROC_REPORTE_SATISFACCION_USU";
            this.PROC_REPORTE_SATISFACCION_USUBindingSource.DataSource = this.chatDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(1270, 2);
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
            this.lbFechaF.Location = new System.Drawing.Point(195, 9);
            this.lbFechaF.Name = "lbFechaF";
            this.lbFechaF.Size = new System.Drawing.Size(71, 15);
            this.lbFechaF.TabIndex = 27;
            this.lbFechaF.Text = "Fecha Final";
            // 
            // lbFechaI
            // 
            this.lbFechaI.AutoSize = true;
            this.lbFechaI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaI.Location = new System.Drawing.Point(12, 9);
            this.lbFechaI.Name = "lbFechaI";
            this.lbFechaI.Size = new System.Drawing.Size(76, 15);
            this.lbFechaI.TabIndex = 26;
            this.lbFechaI.Text = "Fecha Inicial";
            // 
            // dtFechaF
            // 
            this.dtFechaF.CustomFormat = "";
            this.dtFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaF.Location = new System.Drawing.Point(198, 33);
            this.dtFechaF.Name = "dtFechaF";
            this.dtFechaF.Size = new System.Drawing.Size(111, 20);
            this.dtFechaF.TabIndex = 25;
            // 
            // dtFechaI
            // 
            this.dtFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaI.Location = new System.Drawing.Point(15, 33);
            this.dtFechaI.Name = "dtFechaI";
            this.dtFechaI.Size = new System.Drawing.Size(111, 20);
            this.dtFechaI.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::App.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(771, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 44);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rvGraficoSatisfaccion
            // 
            reportDataSource1.Name = "dataSetChat";
            reportDataSource1.Value = this.PROC_REPORTE_SATISFACCIONBindingSource;
            this.rvGraficoSatisfaccion.LocalReport.DataSources.Add(reportDataSource1);
            this.rvGraficoSatisfaccion.LocalReport.ReportEmbeddedResource = "App.Reportes.graficoSatisfaccion.rdlc";
            this.rvGraficoSatisfaccion.Location = new System.Drawing.Point(15, 65);
            this.rvGraficoSatisfaccion.Name = "rvGraficoSatisfaccion";
            this.rvGraficoSatisfaccion.Size = new System.Drawing.Size(634, 369);
            this.rvGraficoSatisfaccion.TabIndex = 28;
            this.rvGraficoSatisfaccion.ZoomPercent = 75;
            // 
            // PROC_REPORTE_SATISFACCIONTableAdapter
            // 
            this.PROC_REPORTE_SATISFACCIONTableAdapter.ClearBeforeFill = true;
            // 
            // rvGraficoBarras
            // 
            reportDataSource2.Name = "dsGraficoSatisfaccionBarras";
            reportDataSource2.Value = this.PROC_REPORTE_SATISFACCION_GENBindingSource;
            this.rvGraficoBarras.LocalReport.DataSources.Add(reportDataSource2);
            this.rvGraficoBarras.LocalReport.ReportEmbeddedResource = "App.Reportes.graficoBarrasSatisfaccion.rdlc";
            this.rvGraficoBarras.Location = new System.Drawing.Point(655, 65);
            this.rvGraficoBarras.Name = "rvGraficoBarras";
            this.rvGraficoBarras.Size = new System.Drawing.Size(634, 369);
            this.rvGraficoBarras.TabIndex = 29;
            this.rvGraficoBarras.ZoomPercent = 75;
            // 
            // PROC_REPORTE_SATISFACCION_GENTableAdapter
            // 
            this.PROC_REPORTE_SATISFACCION_GENTableAdapter.ClearBeforeFill = true;
            // 
            // rvChatsAtendidos
            // 
            reportDataSource3.Name = "dsChatsAtendidos";
            reportDataSource3.Value = this.PROC_REPORTE_ATENCIONBindingSource;
            this.rvChatsAtendidos.LocalReport.DataSources.Add(reportDataSource3);
            this.rvChatsAtendidos.LocalReport.ReportEmbeddedResource = "App.Reportes.graficoChatAtendidos.rdlc";
            this.rvChatsAtendidos.Location = new System.Drawing.Point(15, 440);
            this.rvChatsAtendidos.Name = "rvChatsAtendidos";
            this.rvChatsAtendidos.Size = new System.Drawing.Size(634, 369);
            this.rvChatsAtendidos.TabIndex = 30;
            this.rvChatsAtendidos.ZoomPercent = 75;
            // 
            // rvGraficoSatisfaccionEmp
            // 
            reportDataSource4.Name = "dsSatisfaccionUsuario";
            reportDataSource4.Value = this.PROC_REPORTE_SATISFACCION_USUBindingSource;
            this.rvGraficoSatisfaccionEmp.LocalReport.DataSources.Add(reportDataSource4);
            this.rvGraficoSatisfaccionEmp.LocalReport.ReportEmbeddedResource = "App.Reportes.graficoSatisfaccionPorUsuario.rdlc";
            this.rvGraficoSatisfaccionEmp.Location = new System.Drawing.Point(655, 440);
            this.rvGraficoSatisfaccionEmp.Name = "rvGraficoSatisfaccionEmp";
            this.rvGraficoSatisfaccionEmp.Size = new System.Drawing.Size(634, 369);
            this.rvGraficoSatisfaccionEmp.TabIndex = 31;
            this.rvGraficoSatisfaccionEmp.ZoomPercent = 75;
            // 
            // PROC_REPORTE_ATENCIONTableAdapter
            // 
            this.PROC_REPORTE_ATENCIONTableAdapter.ClearBeforeFill = true;
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.AutoSize = true;
            this.lbEmpleado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpleado.Location = new System.Drawing.Point(6, 16);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(48, 15);
            this.lbEmpleado.TabIndex = 33;
            this.lbEmpleado.Text = "Agente:";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(46, 31);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(243, 21);
            this.cmbEmpleados.TabIndex = 32;
            // 
            // PROC_REPORTE_SATISFACCION_USUTableAdapter
            // 
            this.PROC_REPORTE_SATISFACCION_USUTableAdapter.ClearBeforeFill = true;
            // 
            // gbGraficoSatisfaccionAgente
            // 
            this.gbGraficoSatisfaccionAgente.Controls.Add(this.cmbEmpleados);
            this.gbGraficoSatisfaccionAgente.Controls.Add(this.lbEmpleado);
            this.gbGraficoSatisfaccionAgente.Location = new System.Drawing.Point(375, 2);
            this.gbGraficoSatisfaccionAgente.Name = "gbGraficoSatisfaccionAgente";
            this.gbGraficoSatisfaccionAgente.Size = new System.Drawing.Size(363, 59);
            this.gbGraficoSatisfaccionAgente.TabIndex = 34;
            this.gbGraficoSatisfaccionAgente.TabStop = false;
            this.gbGraficoSatisfaccionAgente.Text = "Este parámetro es solo para mostrar el gráfico de satisfacción por agente";
            // 
            // dashboardGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 814);
            this.Controls.Add(this.gbGraficoSatisfaccionAgente);
            this.Controls.Add(this.rvGraficoSatisfaccionEmp);
            this.Controls.Add(this.rvChatsAtendidos);
            this.Controls.Add(this.rvGraficoBarras);
            this.Controls.Add(this.rvGraficoSatisfaccion);
            this.Controls.Add(this.lbFechaF);
            this.Controls.Add(this.lbFechaI);
            this.Controls.Add(this.dtFechaF);
            this.Controls.Add(this.dtFechaI);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboardGraficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboardGraficos";
            this.Load += new System.EventHandler(this.dashboardGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCION_GENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_ATENCIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCION_USUBindingSource)).EndInit();
            this.gbGraficoSatisfaccionAgente.ResumeLayout(false);
            this.gbGraficoSatisfaccionAgente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFechaF;
        private System.Windows.Forms.Label lbFechaI;
        private System.Windows.Forms.DateTimePicker dtFechaF;
        private System.Windows.Forms.DateTimePicker dtFechaI;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer rvGraficoSatisfaccion;
        private System.Windows.Forms.BindingSource PROC_REPORTE_SATISFACCIONBindingSource;
        private chatDataSet chatDataSet;
        private chatDataSetTableAdapters.PROC_REPORTE_SATISFACCIONTableAdapter PROC_REPORTE_SATISFACCIONTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rvGraficoBarras;
        private System.Windows.Forms.BindingSource PROC_REPORTE_SATISFACCION_GENBindingSource;
        private chatDataSetTableAdapters.PROC_REPORTE_SATISFACCION_GENTableAdapter PROC_REPORTE_SATISFACCION_GENTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rvChatsAtendidos;
        private Microsoft.Reporting.WinForms.ReportViewer rvGraficoSatisfaccionEmp;
        private System.Windows.Forms.BindingSource PROC_REPORTE_ATENCIONBindingSource;
        private chatDataSetTableAdapters.PROC_REPORTE_ATENCIONTableAdapter PROC_REPORTE_ATENCIONTableAdapter;
        private System.Windows.Forms.Label lbEmpleado;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.BindingSource PROC_REPORTE_SATISFACCION_USUBindingSource;
        private chatDataSetTableAdapters.PROC_REPORTE_SATISFACCION_USUTableAdapter PROC_REPORTE_SATISFACCION_USUTableAdapter;
        private System.Windows.Forms.GroupBox gbGraficoSatisfaccionAgente;
    }
}