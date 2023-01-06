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
    public partial class ComprasReporte : Form
    {

        public List<DatosCompras> Compras = new List<DatosCompras>();

        public ComprasReporte()
        {
            InitializeComponent();
        }

        private void ComprasReporte_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet8", Compras));
            this.reportViewer1.RefreshReport();
        }
    }
}
