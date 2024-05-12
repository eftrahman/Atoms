using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atoms_01_02
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void labelDiscoveredF1_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void buttonPropertiesF1_Click(object sender, EventArgs e)
        {
            FormProperties cs = new FormProperties();
            this.Hide();
            cs.Show();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 1;
            labelSymbolF1.Text = "H";
            labelNumberF1.Text = "1";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonHe_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 2;
            labelSymbolF1.Text = "He";
            labelNumberF1.Text = "2";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonLi_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 3;
            labelSymbolF1.Text = "Li";
            labelNumberF1.Text = "3";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void labelNumberF1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbundanceF1_Click(object sender, EventArgs e)
        {
            FormAbundance cs = new FormAbundance();
            this.Hide();
            cs.Show();
        }

        private void buttonBe_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 4;
            labelSymbolF1.Text = "Be";
            labelNumberF1.Text = "4";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 5;
            labelSymbolF1.Text = "B";
            labelNumberF1.Text = "5";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 6;
            labelSymbolF1.Text = "C";
            labelNumberF1.Text = "6";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 7;
            labelSymbolF1.Text = "N";
            labelNumberF1.Text = "7";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 8;
            labelSymbolF1.Text = "O";
            labelNumberF1.Text = "8";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 9;
            labelSymbolF1.Text = "F";
            labelNumberF1.Text = "9";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonNe_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 10;
            labelSymbolF1.Text = "Ne";
            labelNumberF1.Text = "10";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonNa_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 11;
            labelSymbolF1.Text = "Na";
            labelNumberF1.Text = "11";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonMg_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 12;
            labelSymbolF1.Text = "Mg";
            labelNumberF1.Text = "12";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonAl_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 13;
            labelSymbolF1.Text = "Al";
            labelNumberF1.Text = "13";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 14;
            labelSymbolF1.Text = "Si";
            labelNumberF1.Text = "14";
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 91;
            show();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 15;
            labelSymbolF1.Text = "P";
            labelNumberF1.Text = "15";
            labelNameF1.Text = "Phosphorus";
            labelDiscoveredF1.Text = "1669";
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 16;
            labelSymbolF1.Text = "S";
            labelNumberF1.Text = "15";
            labelNameF1.Text = "Sulphur";
            labelDiscoveredF1.Text = "500 BCE";
        }

        private void buttonCl_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 17;
            labelSymbolF1.Text = "Cl";
            labelNumberF1.Text = "17";
            labelNameF1.Text = "Chlorine";
            labelDiscoveredF1.Text = "1774";
        }

        private void buttonAr_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 18;
            labelSymbolF1.Text = "S";
            labelNumberF1.Text = "18";
            labelNameF1.Text = "Argon";
            labelDiscoveredF1.Text = "1894";
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 19;
            labelSymbolF1.Text = "K";
            labelNumberF1.Text = "19";
            labelNameF1.Text = "Potassium";
            labelDiscoveredF1.Text = "1807";
        }

        private void buttonCa_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 20;
            labelSymbolF1.Text = "Ca";
            labelNumberF1.Text = "20";
            labelNameF1.Text = "Calcium";
            labelDiscoveredF1.Text = "1808";
        }

        private void buttonSc_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 21;
            labelSymbolF1.Text = "Sc";
            labelNumberF1.Text = "21";
            labelNameF1.Text = "Scandium";
            labelDiscoveredF1.Text = "1879";
        }

        private void buttonTi_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 22;
            labelSymbolF1.Text = "Ti";
            labelNumberF1.Text = "22";
            labelNameF1.Text = "Titanium";
            labelDiscoveredF1.Text = "1791";
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 23;
            labelSymbolF1.Text = "V";
            labelNumberF1.Text = "23";
            labelNameF1.Text = "Vanadium";
            labelDiscoveredF1.Text = "1801";
        }

        private void buttonCr_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 24;
            labelSymbolF1.Text = "Cr";
            labelNumberF1.Text = "24";
            labelNameF1.Text = "Chromium";
            labelDiscoveredF1.Text = "1797";
        }

        private void buttonMn_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 25;
            labelSymbolF1.Text = "Mn";
            labelNumberF1.Text = "25";
            labelNameF1.Text = "Manganese";
            labelDiscoveredF1.Text = "1774";
        }
        void show()
        {
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF1.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF1.Text = sdrH2.GetValue(0).ToString();
            }
            MySqlConnection conH3 = new MySqlConnection(Classatom.ConnectionString());
            conH3.Open();
            MySqlCommand cmdH3;
            cmdH3 = conH3.CreateCommand();
            cmdH3.CommandText = "SELECT atomic_number FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH3 = cmdH3.ExecuteReader();
            while (sdrH3.Read())
            {
                labelNumberF1.Text = sdrH3.GetValue(0).ToString();
            }
            MySqlConnection conH4 = new MySqlConnection(Classatom.ConnectionString());
            conH4.Open();
            MySqlCommand cmdH4;
            cmdH4 = conH4.CreateCommand();
            cmdH4.CommandText = "SELECT atomic_symbol FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH4 = cmdH4.ExecuteReader();
            while (sdrH4.Read())
            {
                labelSymbolF1.Text = sdrH4.GetValue(0).ToString();
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
        }

        private void buttonFe_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 26;
            show();
        }

        private void buttonCo_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 27;
            show();
        }

        private void buttonNi_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 28;
            show();
        }

        private void buttonCu_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 29;
            show();
        }

        private void buttonZn_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 30;
            show();
        }

        private void buttonGa_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 31;
            show();
        }

        private void buttonGe_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 32;
            show();
        }

        private void buttonAs_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 33;
            show();
        }

        private void buttonSe_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 34;
            show();
        }

        private void buttonBr_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 35;
            show();
        }

        private void buttonKr_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 36;
            show();
        }

        private void buttonRb_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 37;
            show();
        }

        private void buttonSr_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 38;
            show();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 39;
            show();
        }

        private void buttonZr_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 40;
            show();
        }

        private void buttonNb_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 41;
            show();
        }

        private void buttonMo_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 42;
            show();
        }

        private void buttonTc_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 43;
            show();
        }

        private void buttonRu_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 44;
            show();
        }

        private void buttonRh_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 45;
            show();
        }

        private void buttonPd_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 46;
            show();
        }

        private void buttonAg_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 47;
            show();
        }

        private void buttonCd_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 48;
            show();
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 49;
            show();
        }

        private void buttonSn_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 50;
            show();
        }

        private void buttonSb_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 51;
            show();
        }

        private void buttonTe_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 52;
            show();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 53;
            show();
        }

        private void buttonXe_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 54;
            show();
        }

        private void buttonCs_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 55;
            show();
        }

        private void buttonBa_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 56;
            show();
        }

        private void buttonHf_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 72;
            show();
        }

        private void buttonTa_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 73;
            show();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 74;
            show();
        }

        private void buttonRe_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 75;
            show();
        }

        private void buttonOs_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 76;
            show();
        }

        private void buttonIr_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 77;
            show();
        }

        private void buttonPt_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 78;
            show();
        }

        private void buttonAu_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 79;
            show();
        }

        private void buttonHg_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 80;
            show();
        }

        private void buttonTl_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 81;
            show();
        }

        private void buttonPb_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 82;
            show();
        }

        private void buttonBi_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 83;
            show();
        }

        private void buttonPo_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 84;
            show();
        }

        private void buttonAt_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 85;
            show();
        }

        private void buttonRn_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 86;
            show();
        }

        private void buttonFr_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 87;
            show();
        }

        private void buttonRa_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 88;
            show();
        }

        private void buttonRf_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 104;
            show();
        }

        private void buttonDb_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 105;
            show();
        }

        private void buttonSg_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 106;
            show();
        }

        private void buttonBh_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 107;
            show();
        }

        private void buttonHs_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 108;
            show();
        }

        private void buttonMt_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 109;
            show();
        }

        private void buttonDs_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 110;
            show();
        }

        private void buttonRg_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 111;
            show();
        }

        private void buttonCp_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 112;
            show();
        }

        private void buttonUut_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 113;
            show();
        }

        private void buttonUuq_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 114;
            show();
        }

        private void buttonUup_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 115;
            show();
        }

        private void buttonUuh_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 116;
            show();
        }

        private void buttonUus_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 117;
            show();
        }

        private void buttonUuo_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 118;
            show();
        }

        private void buttonLa_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 57;
            show();
        }

        private void buttonCe_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 58;
            show();
        }

        private void buttonPr_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 59;
            show();
        }

        private void buttonNd_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 60;
            show();
        }

        private void buttonPm_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 61;
            show();
        }

        private void buttonSm_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 62;
            show();
        }

        private void buttonEu_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 63;
            show();
        }

        private void buttonGd_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 64;
            show();
        }

        private void buttonTb_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 65;
            show();
        }

        private void buttonDy_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 66;
            show();
        }

        private void buttonHo_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 67;
            show();
        }

        private void buttonEr_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 68;
            show();
        }

        private void buttonTm_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 69;
            show();
        }

        private void buttonYb_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 70;
            show();
        }

        private void buttonLu_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 71;
            show();
        }

        private void buttonAc_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 89;
            show();
        }

        private void buttonTh_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 90;
            show();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 92;
            show();
        }

        private void buttonNp_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 93;
            show();
        }

        private void buttonPu_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 94;
            show();
        }

        private void buttonAm_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 95;
            show();
        }

        private void buttonCm_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 96;
            show();
        }

        private void buttonBk_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 97;
            show();
        }

        private void buttonCf_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 98;
            show();
        }

        private void buttonEs_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 99;
            show();
        }

        private void buttonFm_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 100;
            show();
        }

        private void buttonMd_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 101;
            show();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 102;
            show();
        }

        private void buttonLr_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 103;
            show();
        }

        private void buttonElectronF1_Click(object sender, EventArgs e)
        {
            FormElectron cs = new FormElectron();
            this.Hide();
            cs.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlkali_Click(object sender, EventArgs e)
        {
            //globalSeries.TheJoker = "Alkali Metal";
            MyGlobal.TheUgly = 201;
            FormSeries cs = new FormSeries();
            this.Hide();
            cs.Show();
        }

        private void buttonAlkalineEarth_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 202;
            FormSeries cs = new FormSeries();
            this.Hide();
            cs.Show();
        }

        private void buttonTransitionMetal_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 203;
            FormSeries cs = new FormSeries();
            this.Hide();
            cs.Show();
        }

        private void buttonLanthanoid_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 204;
            FormSeries cs = new FormSeries();
            this.Hide();
            cs.Show();
        }

        private void buttonActinoid_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 205;
            FormSeries cs = new FormSeries();
            this.Hide();
            cs.Show();
        }

        private void buttonPostTransition_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 206;
            FormSeries cs = new FormSeries();
            this.Hide();
            cs.Show();
        }

        private void buttonMetalloid_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 207;
            FormSeries cs = new FormSeries();
            this.Hide();
            cs.Show();
        }

        private void buttonReactiveNonmetal_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 208;
            FormSeries cs = new FormSeries();
            this.Hide();
            cs.Show();
        }

        private void buttonNobleGas_Click(object sender, EventArgs e)
        {
            MyGlobal.TheUgly = 209;
            FormSeries cs = new FormSeries();
            this.Hide();
            cs.Show();
        }
    }
}
