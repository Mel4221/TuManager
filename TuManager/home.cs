using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 
using QuickTools;
using System.Configuration; 
using System.Windows.Forms;

namespace TuManager
{
 
    public partial class Home : Form
    {
        public Home()
        {
               InitializeComponent();
            //Get.C(Helper.ConectionString()); // tiene que ser cambiada la base de datos selecionada 
            //adding acomment
           
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var app = new RegistrarCliente();
            app.Show(); 
        }

        private void gestiónDeEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var app = new RegistrarProveedor();
            app.Show(); 
        }
        
    }
}
