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
            Reader.ReadFile("lista2.txt");
            return Reader.Stored.RowData; 
        }
    }
}
