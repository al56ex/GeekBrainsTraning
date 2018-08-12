using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Value
    {
        

        public static int LblValue()
        {
            Random rnd = new Random();
            int val = rnd.Next(1, 100);
            return val;
        }

        public static string LblString()
        {
           string str = LblValue().ToString();
            return str;
        }
    }
}
