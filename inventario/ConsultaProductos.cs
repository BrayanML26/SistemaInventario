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
    public partial class ConsultaProductos : Consultas
    {
        public ConsultaProductos()
        {
            InitializeComponent();
            dataGridView2.AutoGenerateColumns = false;
        }
        public override void Consultar()
        {
            dataGridView2.DataSource = null;  // blanquear 

            string cmd = "select * from productos";

            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
                cmd += " where nompro like('%" + textBox1.Text.Trim() + "%')";

            ds = utilidades.utilidad.ejecuta(cmd);

            if (utilidades.utilidad.dsTieneDatos(ds))
                dataGridView2.DataSource = ds.Tables[0];  // lleno el datagridviw
            else
                MessageBox.Show("No hay datos");

        }
        
        private void consultaproductos_Load(object sender, EventArgs e)
        {

        }

        private void cmdseleccionar_Click(object sender, EventArgs e)
        {
            if (utilidades.utilidad.dsTieneDatos(ds))
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            MessageBox.Show("no hay datos para seleccionar");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdimprimir_Click(object sender, EventArgs e)
        {
            DatosProd Producto = new DatosProd();
            ReporteProductos RP = new ReporteProductos();

            Producto.codpro = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            Producto.nompro = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Producto.preven = Convert.ToDouble(dataGridView2.CurrentRow.Cells[2].Value.ToString());
            Producto.precom = Convert.ToDouble(dataGridView2.CurrentRow.Cells[3].Value.ToString());
            Producto.exipro = Convert.ToDouble(dataGridView2.CurrentRow.Cells[4].Value.ToString());
            Producto.punreo = Convert.ToDouble(dataGridView2.CurrentRow.Cells[5].Value.ToString());
            Producto.status = Convert.ToBoolean(dataGridView2.CurrentRow.Cells[6].Value.ToString());
            Producto.coddep = Convert.ToInt32(dataGridView2.CurrentRow.Cells[7].Value.ToString());

            RP.Producto.Add(Producto);
            RP.Show();
        }
    }
}
