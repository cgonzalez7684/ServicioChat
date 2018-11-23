namespace App
{
    partial class frmGraficoSatisfaccionEmpl
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbFechaF = new System.Windows.Forms.Label();
            this.lbFechaI = new System.Windows.Forms.Label();
            this.dtFechaF = new System.Windows.Forms.DateTimePicker();
            this.dtFechaI = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.lbEmpleado = new System.Windows.Forms.Label();
            this.rvGraficoSatisfaccionEmp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chatDataSet = new App.chatDataSet();
            this.PROC_REPORTE_SATISFACCION_USUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROC_REPORTE_SATISFACCION_USUTableAdapter = new App.chatDataSetTableAdapters.PROC_REPORTE_SATISFACCION_USUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCION_USUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(755, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbFechaF
            // 
            this.lbFechaF.AutoSize = true;
            this.lbFechaF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaF.Location = new System.Drawing.Point(260, 13);
            this.lbFechaF.Name = "lbFechaF";
            this.lbFechaF.Size = new System.Drawing.Size(71, 15);
            this.lbFechaF.TabIndex = 19;
            this.lbFechaF.Text = "Fecha Final";
            // 
            // lbFechaI
            // 
            this.lbFechaI.AutoSize = true;
            this.lbFechaI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaI.Location = new System.Drawing.Point(77, 13);
            this.lbFechaI.Name = "lbFechaI";
            this.lbFechaI.Size = new System.Drawing.Size(76, 15);
            this.lbFechaI.TabIndex = 18;
            this.lbFechaI.Text = "Fecha Inicial";
            // 
            // dtFechaF
            // 
            this.dtFechaF.CustomFormat = "";
            this.dtFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaF.Location = new System.Drawing.Point(263, 37);
            this.dtFechaF.Name = "dtFechaF";
            this.dtFechaF.Size = new System.Drawing.Size(112, 20);
            this.dtFechaF.TabIndex = 17;
            // 
            // dtFechaI
            // 
            this.dtFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaI.Location = new System.Drawing.Point(80, 37);
            this.dtFechaI.Name = "dtFechaI";
            this.dtFechaI.Size = new System.Drawing.Size(105, 20);
            this.dtFechaI.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::App.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(648, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 44);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(409, 37);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(173, 21);
            this.cmbEmpleados.TabIndex = 21;
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.AutoSize = true;
            this.lbEmpleado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpleado.Location = new System.Drawing.Point(406, 13);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(48, 15);
            this.lbEmpleado.TabIndex = 22;
            this.lbEmpleado.Text = "Agente:";
            // 
            // rvGraficoSatisfaccionEmp
            // 
            reportDataSource1.Name = "dsSatisfaccionUsuario";
            reportDataSource1.Value = this.PROC_REPORTE_SATISFACCION_USUBindingSource;
            this.rvGraficoSatisfaccionEmp.LocalReport.DataSources.Add(reportDataSource1);
            this.rvGraficoSatisfaccionEmp.LocalReport.ReportEmbeddedResource = "App.Reportes.graficoSatisfaccionPorUsuario.rdlc";
            this.rvGraficoSatisfaccionEmp.Location = new System.Drawing.Point(9, 63);
            this.rvGraficoSatisfaccionEmp.Name = "rvGraficoSatisfaccionEmp";
            this.rvGraficoSatisfaccionEmp.Size = new System.Drawing.Size(770, 525);
            this.rvGraficoSatisfaccionEmp.TabIndex = 23;
            this.rvGraficoSatisfaccionEmp.Load += new System.EventHandler(this.rvGraficoSatisfaccionEmp_Load);
            // 
            // chatDataSet
            // 
            this.chatDataSet.DataSetName = "chatDataSet";
            this.chatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PROC_REPORTE_SATISFACCION_USUBindingSource
            // 
            this.PROC_REPORTE_SATISFACCION_USUBindingSource.DataMember = "PROC_REPORTE_SATISFACCION_USU";
            this.PROC_REPORTE_SATISFACCION_USUBindingSource.DataSource = this.chatDataSet;
            // 
            // PROC_REPORTE_SATISFACCION_USUTableAdapter
            // 
            this.PROC_REPORTE_SATISFACCION_USUTableAdapter.ClearBeforeFill = true;
            // 
            // frmGraficoSatisfaccionEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 600);
            this.Controls.Add(this.rvGraficoSatisfaccionEmp);
            this.Controls.Add(this.lbEmpleado);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFechaF);
            this.Controls.Add(this.lbFechaI);
            this.Controls.Add(this.dtFechaF);
            this.Controls.Add(this.dtFechaI);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGraficoSatisfaccionEmpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGraficoSatisfaccionEmpl";
            this.Load += new System.EventHandler(this.frmGraficoSatisfaccionEmpl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROC_REPORTE_SATISFACCION_USUBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label lbEmpleado;
        private Microsoft.Reporting.WinForms.ReportViewer rvGraficoSatisfaccionEmp;
        private System.Windows.Forms.BindingSource PROC_REPORTE_SATISFACCION_USUBindingSource;
        private chatDataSet chatDataSet;
        private chatDataSetTableAdapters.PROC_REPORTE_SATISFACCION_USUTableAdapter PROC_REPORTE_SATISFACCION_USUTableAdapter;
    }
}