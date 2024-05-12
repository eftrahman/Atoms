using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atoms_01_02
{
    class globalSeries
    {
        private static string TheBatman = "Alkali Metal";
        public static string TheJoker
        {
            get { return TheBatman; }
            set { TheBatman = value; }
        }

    }
}
