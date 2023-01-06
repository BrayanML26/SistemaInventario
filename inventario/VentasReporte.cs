using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
    public partial class VentasReporte : Form
    {

        public List<DatosVentas> Ventas = new List<DatosVentas>();

        public VentasReporte()
        {
            InitializeComponent();
        }

        private void VentasReporte_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet7", Ventas));
            this.reportViewer1.RefreshReport();
        }
    }
}
