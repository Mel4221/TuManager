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
    public class App: UserControl
    {
        /*
            This will basically close the form that called it no matter which
         */
        public void Close(object sender, EventArgs e)
        {

        }
    }
    public partial class InterfasCliente : UserControl
    {
        public InterfasCliente()
        {
            InitializeComponent();
        }

       
    }
}
