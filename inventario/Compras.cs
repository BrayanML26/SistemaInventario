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
    public partial class Compras : Procesos
    {
        public Compras()
        {
            InitializeComponent();
        }

        public Compras(DataSet ds1)
        {
            InitializeComponent();
        }

        public Compras(DataSet ds1,string nombrerepote)
        {
            InitializeComponent();

        }
        private void txtcodcli_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodsup.Text.Trim()))
                return;

            ds = utilidad.ejecuta("select * from suplidor where codsup='" + txtcodsup.Text.Trim() + "'");

            if (utilidad.dsTieneDatos( ds))
            {
                txtnomsup.Text = ds.Tables[0].Rows[0]["nomsup"].ToString().Trim();
              
            }
            else
            {
                txtnomsup.Text = "";
                MessageBox.Show("suplidor invalido");
                txtcodsup.Focus();
                return;
            }
        }

        private void txtcodart_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodart.Text.Trim()))
                return;

            ds = utilidad.ejecuta("SELECT * from productos where codpro='" + txtcodart.Text.Trim() + "'");

            //if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            if(utilidad.dsTieneDatos(ds))
            {
                txtdesart.Text = ds.Tables[0].Rows[0]["nompro"].ToString().Trim();
                txtprecom.Text = Convert.ToDouble(ds.Tables[0].Rows[0]["precom"]).ToString("N2");
                txtcancom.Text = "1.00";
            }
            else
            {
                txtcodart.Text = "";
                txtdesart.Text = "";
                txtprecom.Text = "";
                txtcancom.Text = "1.00";
                MessageBox.Show("Producto invalido");
                txtcodart.Focus();
                return;
            }
        }

        private void cmdsalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodart.Text.Trim()))
                return;

            double importe = Convert.ToDouble(txtcancom.Text.Trim()) 
                * Convert.ToDouble(txtprecom.Text.Trim());

            dataGridView1.Rows.Add(txtcodart.Text.Trim(), txtdesart.Text, 
                Convert.ToDouble(txtcancom.Text.Trim()),
                Convert.ToDouble(txtprecom.Text.Trim()), importe);

            dataGridView1.Refresh();
            limpialinea();
            suma();
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                suma();
            }
            
        }

        void suma()
        {
            double total = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[4].Value));
            /*
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }*/
            txttotal.Text = total.ToString("N2");
        }
        public override void Limpiar()
        {
            txttotal.Text = "0.00";
            limpialinea();
            txtcodsup.Text = "";
            txtnomsup.Text = "";
            dataGridView1.Rows.Clear();

        }
        void limpialinea()
        {
            txtcodart.Text = txtdesart.Text = txtcancom.Text = txtprecom.Text = "";

            txtcodart.Focus();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            // copiar aqui la progrmacion del metiodo consultar del mante. de Suplidor

            ConsultaSuplidores obj = new ConsultaSuplidores();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                //posicion del cursor o registro activo
                int pos = obj.dataGridView3.CurrentCell.RowIndex;

                txtcodsup.Text = obj.dataGridView3.Rows[pos].Cells[0].Value.ToString().Trim();

                txtcodsup.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }

        /*public override void Consultar()
        {
            consultadepartamentos obj = new consultadepartamentos();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                //posicion del cursor o registro activo
                int pos = obj.dataGridView1.CurrentCell.RowIndex;

                txtcodsup.Text = obj.dataGridView1.Rows[pos].Cells[0].Value.ToString().Trim();

                txtcodsup.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public override void Salvar()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para procesar");
                return;
            }

            string Numfac = "";
            string Fecfac = "";
            string Codsup = txtcodsup.Text.Trim();
            int Status = 0;
         
            string cmd = string.Format("exec Actualizacompra '{0}','{1}','{2}','{3}'",
                Numfac, Fecfac, Codsup, Status);

            DataSet ds1 =utilidad.ejecuta(cmd);
            if (utilidad.dsTieneDatos(ds1) == false)
            {
                MessageBox.Show("Error registrando factura");
                return;
            }
           Numfac = ds1.Tables[0].Rows[0]["numfac"].ToString().Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string Codpro = row.Cells[0].Value.ToString();
                double Cancom =Convert.ToDouble( row.Cells[2].Value);
                double Precom = Convert.ToDouble(row.Cells[3].Value);

                cmd = string.Format("exec ActualizaComprasdetalles '{0}','{1}','{2}','{3}'",
                    Numfac, Codpro, Cancom, Precom);

                 ds1 = utilidad.ejecuta(cmd);
                if (utilidad.dsTieneDatos(ds1) == false)
                {
                    MessageBox.Show("Error registrando factura");
                    return;
                }

            }
            ds1 = utilidad.ejecuta("exec DatosCompras '" + Numfac + "'");
            if (utilidad.dsTieneDatos(ds1) == false)
            {
                MessageBox.Show("EFactura sin datos");
                return;
            }

            // imprimir
            //MessageBox.Show("imprimiendo");

            ReporteFacturaCompras fac = new ReporteFacturaCompras();

            fac.reportViewer1.LocalReport.DataSources[0].Value = ds1.Tables[0];
            fac.ShowDialog();

            Limpiar();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnomsup_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultaProductos obj = new ConsultaProductos();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                //posicion del cursor o registro activo
                int pos = obj.dataGridView2.CurrentCell.RowIndex;

                txtcodart.Text = obj.dataGridView2.Rows[pos].Cells[0].Value.ToString().Trim();

                txtcodart.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }

        private void txtcodsup_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpreven_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcanven_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
