using System;
using System.Windows.Forms;

namespace inventario
{
    public partial class ConsultaUnidades : Consultas
    {
        public ConsultaUnidades()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        public override void Consultar()
        {
            dataGridView1.DataSource = null;  // blanquear 

            string cmd = "select * from unidades";
            //select * from departamentos where desdep like('%xx%')
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
                cmd += " where desuni like('%" + textBox1.Text.Trim() + "%')";

            ds = utilidades.utilidad.ejecuta(cmd);

            if (utilidades.utilidad.dsTieneDatos(ds))
                dataGridView1.DataSource = ds.Tables[0];  // lleno el datagridviw
            else
                MessageBox.Show("No hay datos");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (utilidades.utilidad.dsTieneDatos(ds))
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            MessageBox.Show("no hay datos para seleccionar");
        }

        private void cmdimprimir_Click(object sender, EventArgs e)
        {
            DatosUnid Unidades = new DatosUnid();
            ReporteUnidades RU = new ReporteUnidades();

            Unidades.coduni = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Unidades.desuni = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Unidades.status = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[2].Value.ToString());

            RU.Unidades.Add(Unidades);
            RU.Show();
        }
    }
}
