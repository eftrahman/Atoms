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
    public partial class FormProperties : Form
    {
        public FormProperties()
        {
            InitializeComponent();
        }

        private void labelenergytext_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelWeight_Click(object sender, EventArgs e)
        {

        }

        private void labelheattext_Click(object sender, EventArgs e)
        {

        }

        private void FormProperties_Load(object sender, EventArgs e)
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
            cmdH5.CommandText = "SELECT series FROM properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH5 = cmdH5.ExecuteReader();
            while (sdrH5.Read())
            {
                labelSeries.Text = sdrH5.GetValue(0).ToString();
            }
            MySqlConnection conH6 = new MySqlConnection(Classatom.ConnectionString());
            conH6.Open();
            MySqlCommand cmdH6;
            cmdH6 = conH6.CreateCommand();
            cmdH6.CommandText = "SELECT weight FROM properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH6 = cmdH6.ExecuteReader();
            while (sdrH6.Read())
            {
                labelWeight.Text = sdrH6.GetValue(0).ToString();
            }
            MySqlConnection conH7 = new MySqlConnection(Classatom.ConnectionString());
            conH7.Open();
            MySqlCommand cmdH7;
            cmdH7 = conH7.CreateCommand();
            cmdH7.CommandText = "SELECT energy_level FROM properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH7 = cmdH7.ExecuteReader();
            while (sdrH7.Read())
            {
                labelEnergyLevel.Text = sdrH7.GetValue(0).ToString();
            }
            MySqlConnection conH8 = new MySqlConnection(Classatom.ConnectionString());
            conH8.Open();
            MySqlCommand cmdH8;
            cmdH8 = conH8.CreateCommand();
            cmdH8.CommandText = "SELECT electronegativity FROM properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH8 = cmdH8.ExecuteReader();
            while (sdrH8.Read())
            {
                labelElectronegativity.Text = sdrH8.GetValue(0).ToString();
            }
            MySqlConnection conH9 = new MySqlConnection(Classatom.ConnectionString());
            conH9.Open();
            MySqlCommand cmdH9;
            cmdH9 = conH9.CreateCommand();
            cmdH9.CommandText = "SELECT melting_point FROM properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH9 = cmdH9.ExecuteReader();
            while (sdrH9.Read())
            {
                labelMeltingPoint.Text = sdrH9.GetValue(0).ToString();
            }
            MySqlConnection conH10 = new MySqlConnection(Classatom.ConnectionString());
            conH10.Open();
            MySqlCommand cmdH10;
            cmdH10 = conH10.CreateCommand();
            cmdH10.CommandText = "SELECT boiling_point FROM properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH10 = cmdH10.ExecuteReader();
            while (sdrH10.Read())
            {
                labelBoilingPoint.Text = sdrH10.GetValue(0).ToString();
            }
            MySqlConnection conH11 = new MySqlConnection(Classatom.ConnectionString());
            conH11.Open();
            MySqlCommand cmdH11;
            cmdH11 = conH11.CreateCommand();
            cmdH11.CommandText = "SELECT electron_affinity FROM properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH11 = cmdH11.ExecuteReader();
            while (sdrH11.Read())
            {
                labelElectronAffinity.Text = sdrH11.GetValue(0).ToString();
            }
            MySqlConnection conH12 = new MySqlConnection(Classatom.ConnectionString());
            conH12.Open();
            MySqlCommand cmdH12;
            cmdH12 = conH12.CreateCommand();
            cmdH12.CommandText = "SELECT hardness_brinell FROM detailed_properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH12 = cmdH12.ExecuteReader();
            while (sdrH12.Read())
            {
                labelHardness.Text = sdrH12.GetValue(0).ToString();
            }
            MySqlConnection conH13 = new MySqlConnection(Classatom.ConnectionString());
            conH13.Open();
            MySqlCommand cmdH13;
            cmdH13 = conH13.CreateCommand();
            cmdH13.CommandText = "SELECT density_stp FROM detailed_properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH13 = cmdH13.ExecuteReader();
            while (sdrH13.Read())
            {
                labelDensity.Text = sdrH13.GetValue(0).ToString();
            }
            MySqlConnection conH14 = new MySqlConnection(Classatom.ConnectionString());
            conH14.Open();
            MySqlCommand cmdH14;
            cmdH14 = conH14.CreateCommand();
            cmdH14.CommandText = "SELECT conductivity_thermal FROM detailed_properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH14 = cmdH14.ExecuteReader();
            while (sdrH14.Read())
            {
                labelConductivity.Text = sdrH14.GetValue(0).ToString();
            }
            MySqlConnection conH15 = new MySqlConnection(Classatom.ConnectionString());
            conH15.Open();
            MySqlCommand cmdH15;
            cmdH15 = conH15.CreateCommand();
            cmdH15.CommandText = "SELECT modulus_bulk FROM detailed_properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH15 = cmdH15.ExecuteReader();
            while (sdrH15.Read())
            {
                labelModulus.Text = sdrH15.GetValue(0).ToString();
            }
            MySqlConnection conH16 = new MySqlConnection(Classatom.ConnectionString());
            conH16.Open();
            MySqlCommand cmdH16;
            cmdH16 = conH16.CreateCommand();
            cmdH16.CommandText = "SELECT heat_spacific FROM detailed_properties where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH16 = cmdH16.ExecuteReader();
            while (sdrH16.Read())
            {
                labelHeat.Text = sdrH16.GetValue(0).ToString();
            }
            MySqlConnection conH17 = new MySqlConnection(Classatom.ConnectionString());
            conH17.Open();
            MySqlCommand cmdH17;
            cmdH17 = conH17.CreateCommand();
            cmdH17.CommandText = "SELECT radius_calculated FROM radius where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH17 = cmdH17.ExecuteReader();
            while (sdrH17.Read())
            {
                labelRadius.Text = sdrH17.GetValue(0).ToString();
            }
        }

        private void labelDiscoveredF2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPropertiesF1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbundanceF1_Click(object sender, EventArgs e)
        {
            FormAbundance cs = new FormAbundance();
            this.Hide();
            cs.Show();
        }

        private void buttonHomeF1_Click(object sender, EventArgs e)
        {
            FormHome cs = new FormHome();
            this.Hide();
            cs.Show();
        }

        private void buttonElectronF1_Click(object sender, EventArgs e)
        {
            FormElectron cs = new FormElectron();
            this.Hide();
            cs.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMore cs = new FormMore();
            this.Hide();
            cs.Show();
        }
    }
}
