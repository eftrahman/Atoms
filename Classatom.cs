using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atoms_01_02
{
    class Classatom
    {
        public static string ConnectionString()
        {

            string constring = "Server = localhost; database = atomdata; Uid= root; Pwd = ''; SslMode = none";
            return constring;
        }
    }
}
