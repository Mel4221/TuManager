using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuManager
{
    public partial class InterfasProveedor : UserControl
    {
        public InterfasProveedor()
        {
            InitializeComponent();
        }

        private void SerrarRegistro(object sender, EventArgs e)
        {
            // this visisble will be a better aproauch 
            this.Visible = false; 
        }
    }
}
