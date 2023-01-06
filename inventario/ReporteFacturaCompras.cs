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
    public partial class ReporteFacturaCompras : Form
    {
        public ReporteFacturaCompras()
        {
            InitializeComponent();
        }

        private void ReporteFacturaCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet.DatosCompras' Puede moverla o quitarla según sea necesario.
            //this.DatosComprasTableAdapter.Fill(this.inventarioDataSet.DatosCompras);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
