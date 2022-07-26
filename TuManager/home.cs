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
         //   this.CambiaFormatoDeFecha(); // no funciono como esperava 
            PanelCliente.Visible = false;
            PanelProveedor.Visible = false;
            PanelReportesClientes.Visible = false;
            PanelReporteProveedor.Visible = false;
            PanelOperacionesVentas.Visible = false;
            PanelOperacionesDevoluciones.Visible = false;
            PanelProductos.Visible = false;
            InventarioProveedor.Visible = false;


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
        
        private async void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var carga = new Cargando();


            carga.Show();
            await Task.Delay(2000);

            carga.Close();
            this.HideAll();

            PanelOperacionesDevoluciones.Visible = true;    

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
            this.HideAll(); 
            PanelReporteProveedor.Visible = true; 
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HideAll();
            PanelOperacionesVentas.Visible = true; 

        }

        private void CerrarVentasBtn_Click(object sender, EventArgs e)
        {
            this.HideAll(); 
        }

        private void CerrarDevolucionesBtn_Click(object sender, EventArgs e)
        {
            this.HideAll(); 
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HideAll();
            PanelProductos.Visible = true; 

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HideAll();
            InventarioProveedor.Visible = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.HideAll(); 
        }

        private void CerrarInventarioProducto_Click(object sender, EventArgs e)
        {

            this.HideAll(); 
        }

        private void CerrarSuplidoresBtn_Click(object sender, EventArgs e)
        {
            this.HideAll(); 
        }

        /*
        private void CambiaFormatoDeFecha()
        {
            // Create a new DateTimePicker control and initialize it.
            DateTimePicker dateTimePicker1 = new DateTimePicker();

            // Set the MinDate and MaxDate.
            dateTimePicker1.MinDate = new DateTime(2022, 1, 1);
            dateTimePicker1.MaxDate = DateTime.Today;

            // Set the CustomFormat string.
            dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Show the CheckBox and display the control as an up-down control.
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;
            this.Controls.Add(dateTimePicker1); 
        }
        */
    }
}
