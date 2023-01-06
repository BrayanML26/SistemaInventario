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
    public partial class Menu : Form
    {
        private int childFormNumber = 0;

        public Menu()
        {
            InitializeComponent();
            //Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.GreenYellow;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoClientes obj = new MantenimientoClientes();
            obj.MdiParent = this;
            obj.Show();

        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoSuplidores obj = new MantenimientoSuplidores();
            obj.MdiParent = this;
            obj.Show();
        }

        private void eJEMPLOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase) // formulario que esta activo
            {
                FormBase obj = (FormBase)ActiveMdiChild;
               
                obj.Salvar();
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase)
            {
                FormBase obj = (FormBase)ActiveMdiChild;
                obj.Imprimir();


            }
        }

        private void Menu_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase)
            {
                FormBase obj = (FormBase)ActiveMdiChild;
     
                printPreviewToolStripButton.Enabled = obj.PuedeConsultar;
                printToolStripButton.Enabled = obj.PuedeImprimir;
                saveToolStripButton.Enabled = obj.PuedeSalvar;
                toolStripButtoneliminar.Enabled = obj.PuedeEliminar;

            }
        }

        private void toolStripButtoneliminar_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase)
            {
                FormBase obj = (FormBase)ActiveMdiChild;
                obj.Eliminar();


            }
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase) // formulario que esta activo
            {
                FormBase obj = (FormBase)ActiveMdiChild;
                //int a = (int)b;

                obj.Consultar();


            }
        }

        private void departamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MatenimientoDepartamentos obj = new MatenimientoDepartamentos();
            obj.MdiParent = this;
            obj.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas obj = new Ventas();
            obj.MdiParent = this;
            obj.Show();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void examen1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fhfhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MatenimientoUnidades obj = new MatenimientoUnidades();
            obj.MdiParent = this;
            obj.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras obj = new Compras();
            obj.MdiParent = this;
            obj.Show();


        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteVentas obj = new ReporteVentas();
            obj.MdiParent = this;
            obj.Show();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteCompras obj = new ReporteCompras();
            obj.MdiParent = this;
            obj.Show();
        }

        private void examenp1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoProductos obj = new MantenimientoProductos();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void mProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoUsuarios obj = new MantenimientoUsuarios();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
