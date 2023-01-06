using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilidades
{
    public partial class boton2 : System.Windows.Forms.Button
    {
        public boton2()
        {
            InitializeComponent();
        }

        public boton2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
