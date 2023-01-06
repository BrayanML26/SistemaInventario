using System;
using System.Windows.Forms;

namespace inventario
{
    public partial class ConsultaDepartamentos : Consultas
    {
        public ConsultaDepartamentos()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        public override void Consultar()
        {
            dataGridView1.DataSource = null;  // blanquear 

            string cmd = "select * from departamentos";
            //select * from departamentos where desdep like('%xx%')
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
                cmd += " where desdep like('%" + textBox1.Text.Trim() + "%')";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdimprimir_Click(object sender, EventArgs e)
        {
            DatosDep Departamento = new DatosDep();
            ReporteDepartamentos RD = new ReporteDepartamentos();

            Departamento.coddep = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Departamento.desdep = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Departamento.status = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[2].Value.ToString());

            RD.Departamento.Add(Departamento);
            RD.Show();
        }
    }
}
