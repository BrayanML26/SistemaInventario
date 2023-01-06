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
    public partial class ReporteCompras : Reportes
    {
        public ReporteCompras()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelbutones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView8.DataSource = null;

            String cmd = "SELECT	Compras.numfac, Compras.fecfac, Compras.codsup, Compras.status, suplidor.nomsup, " +
                "suplidor.email, Comprasdetalles.cancom, Comprasdetalles.precom, Comprasdetalles.cancom * Comprasdetalles.precom as importe, " +
                "productos.codpro, productos.nompro FROM Compras INNER JOIN Comprasdetalles ON Compras.numfac = Comprasdetalles.numfac " +
                "INNER JOIN suplidor ON Compras.codsup = suplidor.codsup " +
                "INNER JOIN productos ON Comprasdetalles.codpro = productos.codpro " +
                "where Compras.fecfac between '" + FechaInicio.Value.ToShortDateString() + "' AND '" + FechaFinal.Value.ToShortDateString() + "'";

            ds = utilidades.utilidad.ejecuta(cmd);

            if (utilidades.utilidad.dsTieneDatos(ds))
                dataGridView8.DataSource = ds.Tables[0];

            else
                MessageBox.Show("No existen datos en esta fecha.");

            suma();
        }

        void suma()
        {
            double total = dataGridView8.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[8].Value));
            /*
            for (int i = 0; i < dataGridView8.Rows.Count; i++)
            {
                total += Convert.ToDouble(dataGridView8.Rows[i].Cells[4].Value);
            }*/
            txtTotal.Text = total.ToString();
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public override void Imprimir()
        {
            DatosCompras DC = new DatosCompras();
            ComprasReporte CR = new ComprasReporte();

            DC.numfac = Convert.ToInt32(dataGridView8.CurrentRow.Cells[0].Value.ToString());
            DC.fecfac = Convert.ToDateTime(dataGridView8.CurrentRow.Cells[1].Value.ToString());
            DC.codsup = Convert.ToInt32(dataGridView8.CurrentRow.Cells[2].Value.ToString());
            DC.status = Convert.ToBoolean(dataGridView8.CurrentRow.Cells[3].Value.ToString());
            DC.nomsup = dataGridView8.CurrentRow.Cells[4].Value.ToString();
            DC.email = dataGridView8.CurrentRow.Cells[5].Value.ToString();
            DC.cancom = Convert.ToDouble(dataGridView8.CurrentRow.Cells[6].Value.ToString());
            DC.precom = Convert.ToDouble(dataGridView8.CurrentRow.Cells[7].Value.ToString());
            DC.importe = Convert.ToDouble(dataGridView8.CurrentRow.Cells[8].Value.ToString());
            DC.codpro = Convert.ToInt32(dataGridView8.CurrentRow.Cells[9].Value.ToString());
            DC.nompro = dataGridView8.CurrentRow.Cells[10].Value.ToString();

            CR.Compras.Add(DC);
            CR.Show();
        }

    }
}
