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
    public partial class ConsultaSuplidores : Consultas
    {
        public ConsultaSuplidores()
        {
            InitializeComponent();
            dataGridView3.AutoGenerateColumns = false;
        }

        public override void Consultar()
        {
            dataGridView3.DataSource = null;  // blanquear 

            string cmd = "select * from suplidor";
            //select * from departamentos where nomsup like('%xx%')
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
                cmd += " where nomsup like('%" + textBox1.Text.Trim() + "%')";

            ds = utilidades.utilidad.ejecuta(cmd);

            if (utilidades.utilidad.dsTieneDatos(ds))
                dataGridView3.DataSource = ds.Tables[0];  // lleno el datagridviw
            else
                MessageBox.Show("No hay datos");

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

        private void consultasuplidores_Load(object sender, EventArgs e)
        {

        }

        private void cmdimprimir_Click(object sender, EventArgs e)
        {
            DatosSup Suplidor = new DatosSup();
            ReporteSuplidores RS = new ReporteSuplidores();

            Suplidor.codsup = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            Suplidor.nomsup = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            Suplidor.email = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            Suplidor.direccion = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            Suplidor.status = Convert.ToBoolean(dataGridView3.CurrentRow.Cells[4].Value.ToString());

            RS.Suplidor.Add(Suplidor);
            RS.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
