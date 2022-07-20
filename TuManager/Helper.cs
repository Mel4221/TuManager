using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickTools; 

namespace TuManager
{
    internal class Helper
    {     

           
            public static string ConectionString()
            {
            byte[] saveFormat = Convert.FromBase64String("RGF0YSBTb3VyY2U9ZGF0YTEuY3d6eXN2dzBteGpuLnVzLWVhc3QtMi5yZHMuYW1hem9uYXdzLmNvbTtJbml0aWFsIENhdGFsb2c9dXNlcnM7UGVyc2lzdCBTZWN1cml0eSBJbmZvPVRydWU7VXNlciBJRD1hZG1pbjtQYXNzd29yZD1EbWVscXVpMjAxODE=");
            string backText = Encoding.ASCII.GetString(saveFormat);
            string connection = backText; 
                return connection;
            }
       
    }
}
