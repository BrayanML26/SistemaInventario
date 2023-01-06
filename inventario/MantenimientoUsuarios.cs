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
    public partial class MantenimientoUsuarios : Mantenimientos
    {
        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }
        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()))
                return;

            ds = utilidad.ejecuta("select * from Usuarios where CodUsuario='" + txtCodigo.Text.Trim() + "'");

            if (utilidad.dsTieneDatos(ds))
            {
                // llenar los textbox
                txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString().Trim();
                ckEstado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Status"]);
                txtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString().Trim();
                txtUsuario.Text = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                txtPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString().Trim();
                //otros campos
            }
            else
            {
                txtNombre.Text = "";
                ckEstado.Checked = false;
                txtEmail.Text = "";
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
        }

        public override void Salvar()
        {
            if (utilidad.ValidaForm(this, errorProvider1))
                return;

            string cmd = string.Format("exec ActualizarUsuarios '{0}','{1}','{2}','{3}','{4}','{5}'",
                txtCodigo.Text.Trim(), txtNombre.Text.Trim(), txtEmail.Text.Trim(), txtUsuario.Text.Trim(),
                txtPassword.Text.Trim(),ckEstado.Checked);

            ds = utilidad.ejecuta(cmd);
            Limpiar();
        }

        public override void Limpiar()
        {
            base.Limpiar();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            ckEstado.Checked = false;
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtCodigo.Focus();

        }

        public override void Eliminar()
        {
            ds = utilidad.ejecuta("exec EliminarUsuario '" + txtCodigo.Text.Trim() + "'");
            Limpiar();
        }

        public override void Consultar()
        {
            ConsultaUsuarios obj = new ConsultaUsuarios();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                int pos = obj.dataGridView4.CurrentCell.RowIndex;

                txtCodigo.Text = obj.dataGridView4.Rows[pos].Cells[0].Value.ToString().Trim();
                // primera forma
                txtCodigo.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }

        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boton3_Click(object sender, EventArgs e)
        {

        }
    }
}
