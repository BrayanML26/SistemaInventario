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
    public partial class ReporteVentas : Reportes
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelbutones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView7.DataSource = null;

            String cmd = "SELECT facturas.numfac, facturas.fecfac, facturas.codcli, facturas.status, clientes.nomcli, " +
                "clientes.email, detalles.canven, detalles.preven, detalles.canven * detalles.preven as importe, productos.codpro, " +
                "productos.nompro FROM facturas INNER JOIN detalles ON facturas.numfac = detalles.numfac INNER JOIN clientes " +
                "ON facturas.codcli = clientes.codcli INNER JOIN productos ON detalles.codpro = productos.codpro " +
                "where facturas.fecfac between '"+ FechaInicio.Value.ToShortDateString() + "' AND '" + FechaFinal.Value.ToShortDateString() + "'";

            ds = utilidades.utilidad.ejecuta(cmd);

            if (utilidades.utilidad.dsTieneDatos(ds))
                dataGridView7.DataSource = ds.Tables[0];

            else
                MessageBox.Show("No existen datos en esta fecha.");

            suma();

        }

        void suma()
        {
            double total = dataGridView7.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[8].Value));
            /*
            for (int i = 0; i < dataGridView7.Rows.Count; i++)
            {
                total += Convert.ToDouble(dataGridView7.Rows[i].Cells[4].Value);
            }*/
            txtTotal.Text = total.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public override void Imprimir()
        {
            DatosVentas DV = new DatosVentas();
            VentasReporte VR = new VentasReporte();

            DV.numfac = Convert.ToInt32(dataGridView7.CurrentRow.Cells[0].Value.ToString());
            DV.fecfac = Convert.ToDateTime(dataGridView7.CurrentRow.Cells[1].Value.ToString());
            DV.codcli = Convert.ToInt32(dataGridView7.CurrentRow.Cells[2].Value.ToString());
            DV.status = Convert.ToBoolean(dataGridView7.CurrentRow.Cells[3].Value.ToString());
            DV.nomcli = dataGridView7.CurrentRow.Cells[4].Value.ToString();
            DV.email = dataGridView7.CurrentRow.Cells[5].Value.ToString();
            DV.canven = Convert.ToDouble(dataGridView7.CurrentRow.Cells[6].Value.ToString());
            DV.preven = Convert.ToDouble(dataGridView7.CurrentRow.Cells[7].Value.ToString());
            DV.importe = Convert.ToDouble(dataGridView7.CurrentRow.Cells[8].Value.ToString());
            DV.codpro = Convert.ToInt32(dataGridView7.CurrentRow.Cells[9].Value.ToString());
            DV.nompro = dataGridView7.CurrentRow.Cells[10].Value.ToString();

            VR.Ventas.Add(DV);
            VR.Show();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
