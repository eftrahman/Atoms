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
    public partial class FormAbundance : Form
    {
        public FormAbundance()
        {
            InitializeComponent();
        }

        private void buttonHomeF1_Click(object sender, EventArgs e)
        {
            FormHome cs = new FormHome();
            this.Hide();
            cs.Show();
        }

        private void buttonPropertiesF1_Click(object sender, EventArgs e)
        {
            FormProperties cs = new FormProperties();
            this.Hide();
            cs.Show();
        }

        private void FormAbundance_Load(object sender, EventArgs e)
        {
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelNameF2.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT discovered FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelDiscoveredF2.Text = sdrH2.GetValue(0).ToString();
            }
            MySqlConnection conH3 = new MySqlConnection(Classatom.ConnectionString());
            conH3.Open();
            MySqlCommand cmdH3;
            cmdH3 = conH3.CreateCommand();
            cmdH3.CommandText = "SELECT atomic_symbol FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH3 = cmdH3.ExecuteReader();
            while (sdrH3.Read())
            {
                labelSymbolF2.Text = sdrH3.GetValue(0).ToString();
            }
            MySqlConnection conH4 = new MySqlConnection(Classatom.ConnectionString());
            conH4.Open();
            MySqlCommand cmdH4;
            cmdH4 = conH4.CreateCommand();
            cmdH4.CommandText = "SELECT atomic_number FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH4 = cmdH4.ExecuteReader();
            while (sdrH4.Read())
            {
                labelNumberF2.Text = sdrH4.GetValue(0).ToString();
            }
            MySqlConnection conH5 = new MySqlConnection(Classatom.ConnectionString());
            conH5.Open();
            MySqlCommand cmdH5;
            cmdH5 = conH5.CreateCommand();
            cmdH5.CommandText = "SELECT universe FROM abundance where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH5 = cmdH5.ExecuteReader();
            while (sdrH5.Read())
            {
                labelUniverse.Text = sdrH5.GetValue(0).ToString();
            }
            MySqlConnection conH6 = new MySqlConnection(Classatom.ConnectionString());
            conH6.Open();
            MySqlCommand cmdH6;
            cmdH6 = conH6.CreateCommand();
            cmdH6.CommandText = "SELECT solar FROM abundance where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH6 = cmdH6.ExecuteReader();
            while (sdrH6.Read())
            {
                labelSolar.Text = sdrH6.GetValue(0).ToString();
            }
            MySqlConnection conH7 = new MySqlConnection(Classatom.ConnectionString());
            conH7.Open();
            MySqlCommand cmdH7;
            cmdH7 = conH7.CreateCommand();
            cmdH7.CommandText = "SELECT meteor FROM abundance where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH7 = cmdH7.ExecuteReader();
            while (sdrH7.Read())
            {
                labelMeteor.Text = sdrH7.GetValue(0).ToString();
            }
            MySqlConnection conH8 = new MySqlConnection(Classatom.ConnectionString());
            conH8.Open();
            MySqlCommand cmdH8;
            cmdH8 = conH8.CreateCommand();
            cmdH8.CommandText = "SELECT crust FROM abundance where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH8 = cmdH8.ExecuteReader();
            while (sdrH8.Read())
            {
                labelEarth.Text = sdrH8.GetValue(0).ToString();
            }
            MySqlConnection conH9 = new MySqlConnection(Classatom.ConnectionString());
            conH9.Open();
            MySqlCommand cmdH9;
            cmdH9 = conH9.CreateCommand();
            cmdH9.CommandText = "SELECT ocean FROM abundance where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH9 = cmdH9.ExecuteReader();
            while (sdrH9.Read())
            {
                labelOcean.Text = sdrH9.GetValue(0).ToString();
            }
            MySqlConnection conH10 = new MySqlConnection(Classatom.ConnectionString());
            conH10.Open();
            MySqlCommand cmdH10;
            cmdH10 = conH10.CreateCommand();
            cmdH10.CommandText = "SELECT human FROM abundance where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH10 = cmdH10.ExecuteReader();
            while (sdrH10.Read())
            {
                labelHuman.Text = sdrH10.GetValue(0).ToString();
            }
        }

        private void buttonElectronF1_Click(object sender, EventArgs e)
        {
            FormElectron cs = new FormElectron();
            this.Hide();
            cs.Show();
        }
    }
}
