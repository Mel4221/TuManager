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
            ///<summary>
            /// Esta area sierra todos los paneles cuando son inicializados 
            /// </summary>
            PanelCliente.Visible = false;
            PanelProveedor.Visible = false;
            PanelReportesClientes.Visible = false;
            PanelReporteProveedor.Visible = false;

            //Get.C(Helper.ConectionString()); // tiene que ser cambiada la base de datos selecionada 
            //adding acomment

        }
        private void HideAll()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        //    ToolStrip btn = (ToolStrip)sender;

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            
        }

        private void gestiónDeEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
 
        // esto llama espesificamente el bonton que necesito 
        private void AdministrarGestion(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            //MessageBox.Show(btn.Text); //for testing porpuses ONLY

            //Gestión de usuarios
            //Gestión de empresas
            switch(menu.Text)
            {
                case "Gestión de usuarios":
                    this.HideAll();
                    PanelCliente.Visible = true;  

                    break;

                case "Gestión de empresas":
                    this.HideAll();
                    PanelProveedor.Visible = true; 
                    break; 
            }

        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var carga = new Cargando();
          
            carga.Show();
            

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox input = (TextBox)sender;
            
            

        }

     

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.HideAll();
            PanelReportesClientes.Visible = true; 
        }

        private void CerrarReporteBtn_Click(object sender, EventArgs e)
        {
            PanelReportesClientes.Visible = false; 
        }

        private void CerrarReportesPBtn_Click(object sender, EventArgs e)
        {
            this.HideAll(); 

        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PanelReporteProveedor.Visible = true; 
        }
    }
}
