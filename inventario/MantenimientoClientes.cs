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
    public partial class MantenimientoClientes : Mantenimientos
    {
        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        private void txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text.Trim()))
                return;

            
            ds = utilidad.ejecuta("select * from clientes where codcli='" + txtcodigo.Text.Trim() + "'");

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txtnombre.Text = ds.Tables[0].Rows[0]["nomcli"].ToString().Trim();
                ckestado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
                txtemail.Text = ds.Tables[0].Rows[0]["email"].ToString().Trim();
                txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString().Trim();
                //codcli, nomcli, email, direccion, status
                //insert update select delete from 
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
            if (utilidad.ValidaForm(this, errorProvider1))
                return;

            string cmd = string.Format("exec clienteActualiza '{0}','{1}','{2}','{3}','{4}'",
                txtcodigo.Text.Trim(), txtnombre.Text.Trim(),txtemail.Text.Trim(),txtdireccion.Text.Trim(),
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
            ds = utilidad.ejecuta("exec clienteelimina '" + txtcodigo.Text.Trim() + "'");
            Limpiar();
        }

        public override void Consultar()
        {
            ConsultaClientes obj = new ConsultaClientes();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                //posicion del cursor o registro activo
                int pos = obj.dataGridView3.CurrentCell.RowIndex;

                txtcodigo.Text = obj.dataGridView3.Rows[pos].Cells[0].Value.ToString().Trim();

                txtcodigo.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }

        private void boton1_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton3_Click(object sender, EventArgs e)
        {

        }

        private void boton2_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoclietnes_Load(object sender, EventArgs e)
        {

        }

        private void mantenimientoclietnes_KeyPress(object sender, KeyPressEventArgs e)
        {
          /*  if (e.KeyChar == 27)
            {
                this.Close();
            }*/
        }
    }
}
