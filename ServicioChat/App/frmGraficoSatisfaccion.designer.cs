namespace App
{
    partial class frmGraficoSatisfaccion
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
            this.dtFechaI = new System.Windows.Forms.DateTimePicker();
            this.dtFechaF = new System.Windows.Forms.DateTimePicker();
            this.lbFechaI = new System.Windows.Forms.Label();
            this.lbFechaF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rvGraficoSatisfaccion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chatDataSet = new App.chatDataSet();
            this.PROC_REPORTE_SATISFACCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROC_REPORTE_SATISFACCIONTableAdapter = new App.chatDataSetTableAdapters.PROC_REPORTE_SATISFACCIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaI
            // 
            this.dtFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaI.Location = new System.Drawing.Point(68, 36);
            this.dtFechaI.Name = "dtFechaI";
            this.dtFechaI.Size = new System.Drawing.Size(105, 20);
            this.dtFechaI.TabIndex = 2;
            // 
            // dtFechaF
            // 
            this.dtFechaF.CustomFormat = "";
            this.dtFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaF.Location = new System.Drawing.Point(251, 36);
            this.dtFechaF.Name = "dtFechaF";
            this.dtFechaF.Size = new System.Drawing.Size(89, 20);
            this.dtFechaF.TabIndex = 3;
            // 
            // lbFechaI
            // 
            this.lbFechaI.AutoSize = true;
            this.lbFechaI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaI.Location = new System.Drawing.Point(65, 12);
            this.lbFechaI.Name = "lbFechaI";
            this.lbFechaI.Size = new System.Drawing.Size(76, 15);
            this.lbFechaI.TabIndex = 4;
            this.lbFechaI.Text = "Fecha Inicial";
            // 
            // lbFechaF
            // 
            this.lbFechaF.AutoSize = true;
            this.lbFechaF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaF.Location = new System.Drawing.Point(248, 12);
            this.lbFechaF.Name = "lbFechaF";
            this.lbFechaF.Size = new System.Drawing.Size(71, 15);
            this.lbFechaF.TabIndex = 5;
            this.lbFechaF.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(787, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::App.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(402, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 44);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rvGraficoSatisfaccion
            // 
            this.rvGraficoSatisfaccion.DocumentMapWidth = 55;
            reportDataSource1.Name = "dataSetChat";
            reportDataSource1.Value = this.PROC_REPORTE_SATISFACCIONBindingSource;
            this.rvGraficoSatisfaccion.LocalReport.DataSources.Add(reportDataSource1);
            this.rvGraficoSatisfaccion.LocalReport.ReportEmbeddedResource = "App.Reportes.graficoSatisfaccion.rdlc";
            this.rvGraficoSatisfaccion.Location = new System.Drawing.Point(12, 76);
            this.rvGraficoSatisfaccion.Name = "rvGraficoSatisfaccion";
            this.rvGraficoSatisfaccion.Size = new System.Drawing.Size(799, 497);
            this.rvGraficoSatisfaccion.TabIndex = 14;
            // 
            // chatDataSet
            // 
            this.chatDataSet.DataSetName = "chatDataSet";
            this.chatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PROC_REPORTE_SATISFACCIONBindingSource
            // 
            this.PROC_REPORTE_SATISFACCIONBindingSource.DataMember = "PROC_REPORTE_SATISFACCION";
            this.PROC_REPORTE_SATISFACCIONBindingSource.DataSource = this.chatDataSet;
            // 
            // PROC_REPORTE_SATISFACCIONTableAdapter
            // 
            this.PROC_REPORTE_SATISFACCIONTableAdapter.ClearBeforeFill = true;
            // 
            // frmGraficoSatisfaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 585);
            this.Controls.Add(this.rvGraficoSatisfaccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFechaF);
            this.Controls.Add(this.lbFechaI);
            this.Controls.Add(this.dtFechaF);
            this.Controls.Add(this.dtFechaI);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGraficoSatisfaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGraficos";
            this.Load += new System.EventHandler(this.frmGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtFechaI;
        private System.Windows.Forms.DateTimePicker dtFechaF;
        private System.Windows.Forms.Label lbFechaI;
        private System.Windows.Forms.Label lbFechaF;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rvGraficoSatisfaccion;
        private System.Windows.Forms.BindingSource PROC_REPORTE_SATISFACCIONBindingSource;
        private chatDataSet chatDataSet;
        private chatDataSetTableAdapters.PROC_REPORTE_SATISFACCIONTableAdapter PROC_REPORTE_SATISFACCIONTableAdapter;


    }
}