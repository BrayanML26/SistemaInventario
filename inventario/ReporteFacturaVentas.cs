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
    public partial class ReporteFacturaVentas : Form
    {

        public ReporteFacturaVentas()
        {
            InitializeComponent();
        }

        private void ReporteFacturaVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet.DatosFactura' Puede moverla o quitarla según sea necesario.
            //this.DatosFacturaTableAdapter.Fill(this.inventarioDataSet.DatosFactura);

            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
