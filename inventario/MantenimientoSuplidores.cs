using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using utilidades;

namespace inventario
{
    public partial class MantenimientoSuplidores : Mantenimientos
    {
        public MantenimientoSuplidores()
        {
            InitializeComponent();
        }

        private void textbox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text.Trim()))
                return;

            ds = utilidad.ejecuta("select * from suplidor where codsup='" + txtcodigo.Text.Trim() + "'");
           
            if (utilidad.dsTieneDatos(ds))
            {
                // llenar los textbox
                txtnombre.Text = ds.Tables[0].Rows[0]["nomsup"].ToString().Trim();
                ckestado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
                txtemail.Text = ds.Tables[0].Rows[0]["email"].ToString().Trim();
                txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString().Trim();
                //otros campos
            }
            else
            {
                txtnombre.Text = "";
                ckestado.Checked = false;
                txtemail.Text = "";
                txtdireccion.Text = "";
            }

        }

        public override void Salvar()
        {
            if (utilidad.ValidaForm(this,errorProvider1))
                return;

            string cmd = string.Format("exec suplidoresActualia '{0}','{1}','{2}','{3}','{4}'",
                txtcodigo.Text.Trim(), txtnombre.Text.Trim(), txtemail.Text.Trim(), txtdireccion.Text.Trim(),
                ckestado.Checked);

            ds = utilidad.ejecuta(cmd);
            Limpiar();
        }

        public override void Limpiar()
        {
            base.Limpiar();
            txtcodigo.Text = "";
            txtnombre.Text = "";
            ckestado.Checked = false;
            txtemail.Text = "";
            txtdireccion.Text = "";
            txtcodigo.Focus();

        }

        public override void Eliminar()
        {
            ds = utilidad.ejecuta("exec suplidorelimina '" + txtcodigo.Text.Trim() + "'");
            Limpiar();
        }

        public override void Consultar()
        {
            ConsultaSuplidores obj = new ConsultaSuplidores();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                int pos = obj.dataGridView3.CurrentCell.RowIndex;

                txtcodigo.Text = obj.dataGridView3.Rows[pos].Cells[0].Value.ToString().Trim();
                // primera forma
                txtcodigo.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton3_Click(object sender, EventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {

        }

        private void boton2_Click(object sender, EventArgs e)
        {

        }

        private void mantesuplidpores_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ckestado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
