using Microsoft.Reporting.WinForms;
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
    public partial class ConsultaClientes : Consultas
    {
        public ConsultaClientes()
        {
            InitializeComponent();
            dataGridView3.AutoGenerateColumns = false;
        }
        public override void Consultar()
        {
            dataGridView3.DataSource = null;  // blanquear 

            string cmd = "select * from clientes";
            //select * from departamentos where nomcli like('%xx%')
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
                cmd += " where nomcli like('%" + textBox1.Text.Trim() + "%')";

            ds = utilidades.utilidad.ejecuta(cmd);

            if (utilidades.utilidad.dsTieneDatos(ds))
                dataGridView3.DataSource = ds.Tables[0];  // lleno el datagridviw            

        }

        private void cmdseleccionar_Click(object sender, EventArgs e)
        {
            if (utilidades.utilidad.dsTieneDatos(ds))
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            MessageBox.Show("No hay datos para seleccionar.");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            DatosCli Cliente = new DatosCli();
            ReporteClientes RC = new ReporteClientes();

            Cliente.codcli = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            Cliente.nomcli = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            Cliente.email = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            Cliente.direccion = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            Cliente.status = Convert.ToBoolean(dataGridView3.CurrentRow.Cells[4].Value.ToString());

            RC.Cliente.Add(Cliente);
            RC.Show();
        }

        private void panelbutones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consultaclientes2_Load(object sender, EventArgs e)
        {
            //Consultar();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //Consultar();
        }
    }
}
