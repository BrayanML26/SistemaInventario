
namespace inventario
{
    partial class ReporteFacturaVentas
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
            this.DatosFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet = new inventario.inventarioDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosFacturaTableAdapter = new inventario.inventarioDataSetTableAdapters.DatosFacturaTableAdapter();
            this.hidalsoft4DataSet = new inventario.hidalsoft4DataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new inventario.hidalsoft4DataSetTableAdapters.clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidalsoft4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosFacturaBindingSource
            // 
            this.DatosFacturaBindingSource.DataMember = "DatosFactura";
            this.DatosFacturaBindingSource.DataSource = this.inventarioDataSet;
            // 
            // inventarioDataSet
            // 
            this.inventarioDataSet.DataSetName = "inventarioDataSet";
            this.inventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DatosFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "inventario.FacturaVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DatosFacturaTableAdapter
            // 
            this.DatosFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // hidalsoft4DataSet
            // 
            this.hidalsoft4DataSet.DataSetName = "hidalsoft4DataSet";
            this.hidalsoft4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.hidalsoft4DataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFacturaVenta";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.ReporteFacturaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidalsoft4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DatosFacturaBindingSource;
        private inventarioDataSet inventarioDataSet;
        private inventarioDataSetTableAdapters.DatosFacturaTableAdapter DatosFacturaTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private hidalsoft4DataSet hidalsoft4DataSet;
        private hidalsoft4DataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
    }
}