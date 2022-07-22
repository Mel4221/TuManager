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
    
    public partial class InterfasCliente : UserControl
    {
        public InterfasCliente()
        {
            InitializeComponent();
        }

        private void CancelarRegistro_Click(object sender, EventArgs e)
        {
            Parent.Visible = false; 
        }
    }
}
