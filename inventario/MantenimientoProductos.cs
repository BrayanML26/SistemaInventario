using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilidades;

namespace inventario
{
    public partial class MantenimientoProductos : Mantenimientos
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            if (utilidad.ValidaForm(this, errorProvider1))
                return;

            string cmd = string.Format("exec productosactualiza '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                txtcodpro.Text.Trim(),txtnompro.Text.Trim(),txtpreven.Text.Trim(),txtprecom.Text.Trim(),
                txtexipro.Text.Trim(),txtpunreo.Text.Trim(), ckestado.Checked, txtcoddep.Text.Trim());

            ds = utilidad.ejecuta(cmd);

            Limpiar();
        }

        public override void Limpiar()
        {
            base.Limpiar();
            txtcodpro.Text = "";
            txtnompro.Text = "";
            txtpreven.Text = "";
            txtprecom.Text = "";
            txtexipro.Text = "";
            txtpunreo.Text = "";
            ckestado.Checked = false;
            txtcoddep.Text = "";
            txtcodpro.Focus();

        }

        public override void Eliminar()
        {
            ds = utilidad.ejecuta("exec productoselimina '" + txtcodpro.Text.Trim() + "'");
            Limpiar();
        }

        public override void Consultar()
        {
            ConsultaProductos obj = new ConsultaProductos();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                //posicion del cursor o registro activo
                int pos = obj.dataGridView2.CurrentCell.RowIndex;

                txtcodpro.Text = obj.dataGridView2.Rows[pos].Cells[0].Value.ToString().Trim();

                txtcodpro.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }

        private void mantenimientoproducto_Load(object sender, EventArgs e)
        {

        }

        private void panelbutones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ckestado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boton3_Click(object sender, EventArgs e)
        {

        }

        private void textbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {

        }

        private void boton2_Click(object sender, EventArgs e)
        {

        }

        private void txtexipro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpunreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void preven_TextChanged(object sender, EventArgs e)
        {

        }

        private void precom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcoddep_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprecom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpreven_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodpro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodpro_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtnompro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpreven_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtprecom_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtexipro_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtpunreo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtcoddep_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtcodpro_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodpro.Text.Trim()))
                return;

            ds = utilidad.ejecuta("SELECT * from productos where codpro='" + txtcodpro.Text.Trim() + "'");

            if (utilidad.dsTieneDatos(ds))
            {
                txtnompro.Text = ds.Tables[0].Rows[0]["nompro"].ToString().Trim();
                txtpreven.Text = ds.Tables[0].Rows[0]["preven"].ToString().Trim();
                txtprecom.Text = ds.Tables[0].Rows[0]["precom"].ToString().Trim();
                txtexipro.Text = ds.Tables[0].Rows[0]["exipro"].ToString().Trim();
                txtpunreo.Text = ds.Tables[0].Rows[0]["punreo"].ToString().Trim();
                ckestado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
                txtcoddep.Text = ds.Tables[0].Rows[0]["coddep"].ToString().Trim();
            }
            else
            {
                txtnompro.Text = "";
                txtpreven.Text = "";
                txtprecom.Text = "";
                txtexipro.Text = "";
                txtpunreo.Text = "";
                ckestado.Checked = false;
                txtcoddep.Text = "";
            }
        }
    }
}
