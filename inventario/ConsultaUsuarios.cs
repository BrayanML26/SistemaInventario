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
    public partial class ConsultaUsuarios : Consultas
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        public override void Consultar()
        {
            dataGridView4.DataSource = null;  // blanquear 

            string cmd = "select * from Usuarios";
            //select * from Usuarios where Nombre like('%xx%')
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
                cmd += " where Nombre like('%" + textBox1.Text.Trim() + "%')";

            ds = utilidades.utilidad.ejecuta(cmd);

            if (utilidades.utilidad.dsTieneDatos(ds))
                dataGridView4.DataSource = ds.Tables[0];  // lleno el datagridviw            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            MessageBox.Show("No hay datos para seleccionar.");
        }

        private void cmdimprimir_Click(object sender, EventArgs e)
        {
            DatosUsu Usuario = new DatosUsu();
            ReporteUsuarios RU = new ReporteUsuarios();

            Usuario.CodUsuario = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value.ToString());
            Usuario.Nombre = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            Usuario.Email = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            Usuario.Usuario = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            Usuario.Password = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            Usuario.Status = Convert.ToBoolean(dataGridView4.CurrentRow.Cells[5].Value.ToString());

            RU.Usuario.Add(Usuario);
            RU.Show();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelbutones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
