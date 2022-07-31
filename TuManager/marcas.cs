using System;
using QuickTools; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 
using System.Threading.Tasks;

namespace TuManager
{
    internal class Marcas
    {
            public static string LeerLista()
        {
            
            return Reader.ReadFile("lista2.txt");
        }
    }
}
