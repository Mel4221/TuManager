﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 
using QuickTools; 
using System.Windows.Forms;

namespace TuManager
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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
