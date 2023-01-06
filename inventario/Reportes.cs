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
    public partial class Reportes : FormBase
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }
    }
}
