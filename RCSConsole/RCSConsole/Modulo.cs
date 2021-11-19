using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSConsole
{
    class Modulo
    {
        public static Color sColorMod(Color x)
        {
            int r = (int)x % 4;
            return r < 0 ? (Color)r + 4 : (Color)r;
        }
        
        public static int sIntMod(Color x)
        {
            int r = (int)x % 4;
            return r < 0 ? r + 4 : r;
        }
    }
}
