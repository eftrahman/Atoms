using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atoms_01_02
{
    class MyGlobal
    {
        private static int TheGood = 1;
      //private static int TheBad= 1;
        public static int TheUgly
        {
            get { return TheGood; }
            set { TheGood = value; }
        }

    }
}
