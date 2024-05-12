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
    public partial class FormElectron : Form
    {
        public FormElectron()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormElectron_Load(object sender, EventArgs e)
        {
            MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
            conH1.Open();
            MySqlCommand cmdH1;
            cmdH1 = conH1.CreateCommand();
            cmdH1.CommandText = "SELECT oxidation_states FROM electrons where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
            while (sdrH1.Read())
            {
                labelOxidationStates.Text = sdrH1.GetValue(0).ToString();
            }
            MySqlConnection conH2 = new MySqlConnection(Classatom.ConnectionString());
            conH2.Open();
            MySqlCommand cmdH2;
            cmdH2 = conH2.CreateCommand();
            cmdH2.CommandText = "SELECT energy_level FROM electrons where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH2 = cmdH2.ExecuteReader();
            while (sdrH2.Read())
            {
                labelEnergyLevels.Text = sdrH2.GetValue(0).ToString();
            }
            MySqlConnection conH3 = new MySqlConnection(Classatom.ConnectionString());
            conH3.Open();
            MySqlCommand cmdH3;
            cmdH3 = conH3.CreateCommand();
            cmdH3.CommandText = "SELECT quantum_number FROM electrons where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH3 = cmdH3.ExecuteReader();
            while (sdrH3.Read())
            {
                labelQuantumNumbers.Text = sdrH3.GetValue(0).ToString();
            }
            MySqlConnection conH4 = new MySqlConnection(Classatom.ConnectionString());
            conH4.Open();
            MySqlCommand cmdH4;
            cmdH4 = conH4.CreateCommand();
            cmdH4.CommandText = "SELECT isotopes FROM electrons where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH4 = cmdH4.ExecuteReader();
            while (sdrH4.Read())
            {
                labelIsotopes.Text = sdrH4.GetValue(0).ToString();
            }
            
            MySqlConnection con1 = new MySqlConnection(Classatom.ConnectionString());
            con1.Open();
            MySqlCommand cmd1;
            cmd1 = con1.CreateCommand();
            cmd1.CommandText = "SELECT SUBSTR(s_up, 1, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr1 = cmd1.ExecuteReader();
            while (sdr1.Read())
            {
                labelsu1.Text = sdr1.GetValue(0).ToString();
            }
            MySqlConnection con2 = new MySqlConnection(Classatom.ConnectionString());
            con2.Open();
            MySqlCommand cmd2;
            cmd2 = con2.CreateCommand();
            cmd2.CommandText = "SELECT SUBSTR(s_up, 2, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr2 = cmd2.ExecuteReader();
            while (sdr2.Read())
            {
                labelsu2.Text = sdr2.GetValue(0).ToString();
            }
            MySqlConnection con3 = new MySqlConnection(Classatom.ConnectionString());
            con3.Open();
            MySqlCommand cmd3;
            cmd3 = con3.CreateCommand();
            cmd3.CommandText = "SELECT SUBSTR(s_up, 3, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr3 = cmd3.ExecuteReader();
            while (sdr3.Read())
            {
                labelsu3.Text = sdr3.GetValue(0).ToString();
            }
            MySqlConnection con4 = new MySqlConnection(Classatom.ConnectionString());
            con4.Open();
            MySqlCommand cmd4;
            cmd4 = con4.CreateCommand();
            cmd4.CommandText = "SELECT SUBSTR(s_up, 4, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr4 = cmd4.ExecuteReader();
            while (sdr4.Read())
            {
                labelsu4.Text = sdr4.GetValue(0).ToString();
            }
            MySqlConnection con5 = new MySqlConnection(Classatom.ConnectionString());
            con5.Open();
            MySqlCommand cmd5;
            cmd5 = con5.CreateCommand();
            cmd5.CommandText = "SELECT SUBSTR(s_up, 5, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr5 = cmd5.ExecuteReader();
            while (sdr5.Read())
            {
                labelsu5.Text = sdr5.GetValue(0).ToString();
            }
            /*MySqlConnection con6 = new MySqlConnection(Classatom.ConnectionString());
            con6.Open();
            MySqlCommand cmd6;
            cmd6 = con6.CreateCommand();
            cmd6.CommandText = "SELECT SUBSTR(s_up, 6, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr6 = cmd6.ExecuteReader();
            while (sdr6.Read())
            {
                labelsu6.Text = sdr6.GetValue(0).ToString();
            }
            MySqlConnection con7 = new MySqlConnection(Classatom.ConnectionString());
            con7.Open();
            MySqlCommand cmd7;
            cmd7 = con7.CreateCommand();
            cmd7.CommandText = "SELECT SUBSTR(s_up, 7, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr7 = cmd7.ExecuteReader();
            while (sdr7.Read())
            {
                labelsu7.Text = sdr7.GetValue(0).ToString();
            }*/
            MySqlConnection con8 = new MySqlConnection(Classatom.ConnectionString());
            con8.Open();
            MySqlCommand cmd8;
            cmd8 = con8.CreateCommand();
            cmd8.CommandText = "SELECT SUBSTR(s_down, 1, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr8 = cmd8.ExecuteReader();
            while (sdr8.Read())
            {
                labelsd1.Text = sdr8.GetValue(0).ToString();
            }
            MySqlConnection con9 = new MySqlConnection(Classatom.ConnectionString());
            con9.Open();
            MySqlCommand cmd9;
            cmd9 = con9.CreateCommand();
            cmd9.CommandText = "SELECT SUBSTR(s_down, 2, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr9 = cmd9.ExecuteReader();
            while (sdr9.Read())
            {
                labelsd2.Text = sdr9.GetValue(0).ToString();
            }
            MySqlConnection con10 = new MySqlConnection(Classatom.ConnectionString());
            con10.Open();
            MySqlCommand cmd10;
            cmd10 = con10.CreateCommand();
            cmd10.CommandText = "SELECT SUBSTR(s_down, 3, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr10 = cmd10.ExecuteReader();
            while (sdr10.Read())
            {
                labelsd3.Text = sdr10.GetValue(0).ToString();
            }
            MySqlConnection con11 = new MySqlConnection(Classatom.ConnectionString());
            con11.Open();
            MySqlCommand cmd11;
            cmd11 = con11.CreateCommand();
            cmd11.CommandText = "SELECT SUBSTR(s_down, 4, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr11 = cmd11.ExecuteReader();
            while (sdr11.Read())
            {
                labelsd4.Text = sdr11.GetValue(0).ToString();
            }
            MySqlConnection con12 = new MySqlConnection(Classatom.ConnectionString());
            con12.Open();
            MySqlCommand cmd12;
            cmd12 = con12.CreateCommand();
            cmd12.CommandText = "SELECT SUBSTR(s_down, 5, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr12 = cmd12.ExecuteReader();
            while (sdr12.Read())
            {
                labelsd5.Text = sdr12.GetValue(0).ToString();
            }
            /*MySqlConnection con13 = new MySqlConnection(Classatom.ConnectionString());
            con13.Open();
            MySqlCommand cmd13;
            cmd13 = con13.CreateCommand();
            cmd13.CommandText = "SELECT SUBSTR(s_down, 6, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr13 = cmd13.ExecuteReader();
            while (sdr13.Read())
            {
                labelsd6.Text = sdr13.GetValue(0).ToString();
            }
            MySqlConnection con14 = new MySqlConnection(Classatom.ConnectionString());
            con14.Open();
            MySqlCommand cmd14;
            cmd14 = con14.CreateCommand();
            cmd14.CommandText = "SELECT SUBSTR(s_down, 7, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr14 = cmd14.ExecuteReader();
            while (sdr14.Read())
            {
                labelsd7.Text = sdr14.GetValue(0).ToString();
            }*/
            MySqlConnection con15 = new MySqlConnection(Classatom.ConnectionString());
            con15.Open();
            MySqlCommand cmd15;
            cmd15 = con15.CreateCommand();
            cmd15.CommandText = "SELECT SUBSTR(p_up, 1, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr15 = cmd15.ExecuteReader();
            while (sdr15.Read())
            {
                labelpu21.Text = sdr15.GetValue(0).ToString();
            }
            MySqlConnection con16 = new MySqlConnection(Classatom.ConnectionString());
            con16.Open();
            MySqlCommand cmd16;
            cmd16 = con16.CreateCommand();
            cmd16.CommandText = "SELECT SUBSTR(p_up, 2, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr16 = cmd16.ExecuteReader();
            while (sdr16.Read())
            {
                labelpu22.Text = sdr16.GetValue(0).ToString();
            }
            MySqlConnection con17 = new MySqlConnection(Classatom.ConnectionString());
            con17.Open();
            MySqlCommand cmd17;
            cmd17 = con17.CreateCommand();
            cmd17.CommandText = "SELECT SUBSTR(p_up, 3, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr17 = cmd17.ExecuteReader();
            while (sdr17.Read())
            {
                labelpu23.Text = sdr17.GetValue(0).ToString();
            }
            MySqlConnection con18 = new MySqlConnection(Classatom.ConnectionString());
            con18.Open();
            MySqlCommand cmd18;
            cmd18 = con18.CreateCommand();
            cmd18.CommandText = "SELECT SUBSTR(p_up, 4, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr18 = cmd18.ExecuteReader();
            while (sdr18.Read())
            {
                labelpu31.Text = sdr18.GetValue(0).ToString();
            }
            MySqlConnection con19 = new MySqlConnection(Classatom.ConnectionString());
            con19.Open();
            MySqlCommand cmd19;
            cmd19 = con19.CreateCommand();
            cmd19.CommandText = "SELECT SUBSTR(p_up, 5, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr19 = cmd19.ExecuteReader();
            while (sdr19.Read())
            {
                labelpu32.Text = sdr19.GetValue(0).ToString();
            }
            MySqlConnection con20 = new MySqlConnection(Classatom.ConnectionString());
            con20.Open();
            MySqlCommand cmd20;
            cmd20 = con20.CreateCommand();
            cmd20.CommandText = "SELECT SUBSTR(p_up, 6, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr20 = cmd20.ExecuteReader();
            while (sdr20.Read())
            {
                labelpu33.Text = sdr20.GetValue(0).ToString();
            }
            MySqlConnection con21 = new MySqlConnection(Classatom.ConnectionString());
            con21.Open();
            MySqlCommand cmd21;
            cmd21 = con21.CreateCommand();
            cmd21.CommandText = "SELECT SUBSTR(p_up, 7, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr21 = cmd21.ExecuteReader();
            while (sdr21.Read())
            {
                labelpu41.Text = sdr21.GetValue(0).ToString();
            }
            MySqlConnection con22 = new MySqlConnection(Classatom.ConnectionString());
            con22.Open();
            MySqlCommand cmd22;
            cmd22 = con22.CreateCommand();
            cmd22.CommandText = "SELECT SUBSTR(p_up, 8, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr22 = cmd22.ExecuteReader();
            while (sdr22.Read())
            {
                labelpu42.Text = sdr22.GetValue(0).ToString();
            }
            MySqlConnection con23 = new MySqlConnection(Classatom.ConnectionString());
            con23.Open();
            MySqlCommand cmd23;
            cmd23 = con23.CreateCommand();
            cmd23.CommandText = "SELECT SUBSTR(p_up, 9, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr23 = cmd23.ExecuteReader();
            while (sdr23.Read())
            {
                labelpu43.Text = sdr23.GetValue(0).ToString();
            }
            /*MySqlConnection con24 = new MySqlConnection(Classatom.ConnectionString());
            con24.Open();
            MySqlCommand cmd24;
            cmd24 = con24.CreateCommand();
            cmd24.CommandText = "SELECT SUBSTR(p_up, 10, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr24 = cmd24.ExecuteReader();
            while (sdr24.Read())
            {
                labelpu51.Text = sdr24.GetValue(0).ToString();
            }
            MySqlConnection con25 = new MySqlConnection(Classatom.ConnectionString());
            con25.Open();
            MySqlCommand cmd25;
            cmd25 = con25.CreateCommand();
            cmd25.CommandText = "SELECT SUBSTR(p_up, 11, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr25 = cmd25.ExecuteReader();
            while (sdr25.Read())
            {
                labelpu52.Text = sdr25.GetValue(0).ToString();
            }
            MySqlConnection con26 = new MySqlConnection(Classatom.ConnectionString());
            con26.Open();
            MySqlCommand cmd26;
            cmd26 = con26.CreateCommand();
            cmd26.CommandText = "SELECT SUBSTR(p_up, 12, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr26 = cmd26.ExecuteReader();
            while (sdr26.Read())
            {
                labelpu53.Text = sdr26.GetValue(0).ToString();
            }
            MySqlConnection con27 = new MySqlConnection(Classatom.ConnectionString());
            con27.Open();
            MySqlCommand cmd27;
            cmd27 = con27.CreateCommand();
            cmd27.CommandText = "SELECT SUBSTR(p_up, 13, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr27 = cmd27.ExecuteReader();
            while (sdr27.Read())
            {
                labelpu61.Text = sdr27.GetValue(0).ToString();
            }
            MySqlConnection con28 = new MySqlConnection(Classatom.ConnectionString());
            con28.Open();
            MySqlCommand cmd28;
            cmd28 = con28.CreateCommand();
            cmd28.CommandText = "SELECT SUBSTR(p_up, 14, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr28 = cmd28.ExecuteReader();
            while (sdr28.Read())
            {
                labelpu62.Text = sdr28.GetValue(0).ToString();
            }
            MySqlConnection con29 = new MySqlConnection(Classatom.ConnectionString());
            con29.Open();
            MySqlCommand cmd29;
            cmd29 = con29.CreateCommand();
            cmd29.CommandText = "SELECT SUBSTR(p_up, 15, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr29 = cmd29.ExecuteReader();
            while (sdr29.Read())
            {
                labelpu63.Text = sdr29.GetValue(0).ToString();
            }
            MySqlConnection con30 = new MySqlConnection(Classatom.ConnectionString());
            con30.Open();
            MySqlCommand cmd30;
            cmd30 = con30.CreateCommand();
            cmd30.CommandText = "SELECT SUBSTR(p_up, 16, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr30 = cmd30.ExecuteReader();
            while (sdr30.Read())
            {
                labelpu71.Text = sdr30.GetValue(0).ToString();
            }
            MySqlConnection con31 = new MySqlConnection(Classatom.ConnectionString());
            con31.Open();
            MySqlCommand cmd31;
            cmd31 = con31.CreateCommand();
            cmd31.CommandText = "SELECT SUBSTR(p_up, 17, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr31 = cmd31.ExecuteReader();
            while (sdr31.Read())
            {
                labelpu72.Text = sdr31.GetValue(0).ToString();
            }
            MySqlConnection con32 = new MySqlConnection(Classatom.ConnectionString());
            con32.Open();
            MySqlCommand cmd32;
            cmd32 = con32.CreateCommand();
            cmd32.CommandText = "SELECT SUBSTR(p_up, 18, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr32 = cmd32.ExecuteReader();
            while (sdr32.Read())
            {
                labelpu73.Text = sdr32.GetValue(0).ToString();
            }*/
            MySqlConnection con33 = new MySqlConnection(Classatom.ConnectionString());
            con33.Open();
            MySqlCommand cmd33;
            cmd33 = con33.CreateCommand();
            cmd33.CommandText = "SELECT SUBSTR(p_down, 1, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr33 = cmd33.ExecuteReader();
            while (sdr33.Read())
            {
                labelpd21.Text = sdr33.GetValue(0).ToString();
            }
            MySqlConnection con34 = new MySqlConnection(Classatom.ConnectionString());
            con34.Open();
            MySqlCommand cmd34;
            cmd34 = con34.CreateCommand();
            cmd34.CommandText = "SELECT SUBSTR(p_down, 2, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr34 = cmd34.ExecuteReader();
            while (sdr34.Read())
            {
                labelpd22.Text = sdr34.GetValue(0).ToString();
            }
            MySqlConnection con35 = new MySqlConnection(Classatom.ConnectionString());
            con35.Open();
            MySqlCommand cmd35;
            cmd35 = con35.CreateCommand();
            cmd35.CommandText = "SELECT SUBSTR(p_down, 3, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr35 = cmd35.ExecuteReader();
            while (sdr35.Read())
            {
                labelpd23.Text = sdr35.GetValue(0).ToString();
            }
            MySqlConnection con36 = new MySqlConnection(Classatom.ConnectionString());
            con36.Open();
            MySqlCommand cmd36;
            cmd36 = con36.CreateCommand();
            cmd36.CommandText = "SELECT SUBSTR(p_down, 4, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr36 = cmd36.ExecuteReader();
            while (sdr36.Read())
            {
                labelpd31.Text = sdr36.GetValue(0).ToString();
            }
            MySqlConnection con37 = new MySqlConnection(Classatom.ConnectionString());
            con37.Open();
            MySqlCommand cmd37;
            cmd37 = con37.CreateCommand();
            cmd37.CommandText = "SELECT SUBSTR(p_down, 5, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr37 = cmd37.ExecuteReader();
            while (sdr37.Read())
            {
                labelpd32.Text = sdr37.GetValue(0).ToString();
            }
            MySqlConnection con38 = new MySqlConnection(Classatom.ConnectionString());
            con38.Open();
            MySqlCommand cmd38;
            cmd38 = con38.CreateCommand();
            cmd38.CommandText = "SELECT SUBSTR(p_down, 6, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr38 = cmd38.ExecuteReader();
            while (sdr38.Read())
            {
                labelpd33.Text = sdr38.GetValue(0).ToString();
            }
            MySqlConnection con39 = new MySqlConnection(Classatom.ConnectionString());
            con39.Open();
            MySqlCommand cmd39;
            cmd39 = con39.CreateCommand();
            cmd39.CommandText = "SELECT SUBSTR(p_down, 7, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr39 = cmd39.ExecuteReader();
            while (sdr39.Read())
            {
                labelpd41.Text = sdr39.GetValue(0).ToString();
            }
            MySqlConnection con40 = new MySqlConnection(Classatom.ConnectionString());
            con40.Open();
            MySqlCommand cmd40;
            cmd40 = con40.CreateCommand();
            cmd40.CommandText = "SELECT SUBSTR(p_down, 8, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr40 = cmd40.ExecuteReader();
            while (sdr40.Read())
            {
                labelpd42.Text = sdr40.GetValue(0).ToString();
            }
            MySqlConnection con41 = new MySqlConnection(Classatom.ConnectionString());
            con41.Open();
            MySqlCommand cmd41;
            cmd41 = con41.CreateCommand();
            cmd41.CommandText = "SELECT SUBSTR(p_down, 9, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr41 = cmd41.ExecuteReader();
            while (sdr41.Read())
            {
                labelpd43.Text = sdr41.GetValue(0).ToString();
            }
            /*MySqlConnection con42 = new MySqlConnection(Classatom.ConnectionString());
            con42.Open();
            MySqlCommand cmd42;
            cmd42 = con42.CreateCommand();
            cmd42.CommandText = "SELECT SUBSTR(p_down, 10, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr42 = cmd42.ExecuteReader();
            while (sdr42.Read())
            {
                labelpd51.Text = sdr42.GetValue(0).ToString();
            }
            MySqlConnection con43 = new MySqlConnection(Classatom.ConnectionString());
            con43.Open();
            MySqlCommand cmd43;
            cmd43 = con43.CreateCommand();
            cmd43.CommandText = "SELECT SUBSTR(p_down, 11, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr43 = cmd43.ExecuteReader();
            while (sdr43.Read())
            {
                labelpd52.Text = sdr43.GetValue(0).ToString();
            }
            MySqlConnection con44 = new MySqlConnection(Classatom.ConnectionString());
            con44.Open();
            MySqlCommand cmd44;
            cmd44 = con44.CreateCommand();
            cmd44.CommandText = "SELECT SUBSTR(p_down, 12, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr44 = cmd44.ExecuteReader();
            while (sdr44.Read())
            {
                labelpd53.Text = sdr44.GetValue(0).ToString();
            }
            MySqlConnection con45 = new MySqlConnection(Classatom.ConnectionString());
            con45.Open();
            MySqlCommand cmd45;
            cmd45 = con45.CreateCommand();
            cmd45.CommandText = "SELECT SUBSTR(p_down, 13, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr45 = cmd45.ExecuteReader();
            while (sdr45.Read())
            {
                labelpd61.Text = sdr45.GetValue(0).ToString();
            }
            MySqlConnection con46 = new MySqlConnection(Classatom.ConnectionString());
            con46.Open();
            MySqlCommand cmd46;
            cmd46 = con46.CreateCommand();
            cmd46.CommandText = "SELECT SUBSTR(p_down, 14, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr46 = cmd46.ExecuteReader();
            while (sdr46.Read())
            {
                labelpd62.Text = sdr46.GetValue(0).ToString();
            }
            MySqlConnection con461 = new MySqlConnection(Classatom.ConnectionString());
            con461.Open();
            MySqlCommand cmd461;
            cmd461 = con461.CreateCommand();
            cmd461.CommandText = "SELECT SUBSTR(p_down, 15, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr461 = cmd461.ExecuteReader();
            while (sdr461.Read())
            {
                labelpd63.Text = sdr461.GetValue(0).ToString();
            }
            MySqlConnection con47 = new MySqlConnection(Classatom.ConnectionString());
            con47.Open();
            MySqlCommand cmd47;
            cmd47 = con47.CreateCommand();
            cmd47.CommandText = "SELECT SUBSTR(p_down, 16, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr47 = cmd47.ExecuteReader();
            while (sdr47.Read())
            {
                labelpd71.Text = sdr47.GetValue(0).ToString();
            }
            MySqlConnection con48 = new MySqlConnection(Classatom.ConnectionString());
            con48.Open();
            MySqlCommand cmd48;
            cmd48 = con48.CreateCommand();
            cmd48.CommandText = "SELECT SUBSTR(p_down, 17, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr48 = cmd48.ExecuteReader();
            while (sdr48.Read())
            {
                labelpd72.Text = sdr48.GetValue(0).ToString();
            }
            MySqlConnection con49 = new MySqlConnection(Classatom.ConnectionString());
            con49.Open();
            MySqlCommand cmd49;
            cmd49 = con49.CreateCommand();
            cmd49.CommandText = "SELECT SUBSTR(p_down, 18, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr49 = cmd49.ExecuteReader();
            while (sdr49.Read())
            {
                labelpd73.Text = sdr49.GetValue(0).ToString();
            }*/
            
            MySqlConnection con50 = new MySqlConnection(Classatom.ConnectionString());
            con50.Open();
            MySqlCommand cmd50;
            cmd50 = con50.CreateCommand();
            cmd50.CommandText = "SELECT SUBSTR(d_up, 1, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr50 = cmd50.ExecuteReader();
            while (sdr50.Read())
            {
                labeldu31.Text = sdr50.GetValue(0).ToString();
            }
            MySqlConnection con51 = new MySqlConnection(Classatom.ConnectionString());
            con51.Open();
            MySqlCommand cmd51;
            cmd51 = con51.CreateCommand();
            cmd51.CommandText = "SELECT SUBSTR(d_up, 2, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr51 = cmd51.ExecuteReader();
            while (sdr51.Read())
            {
                labeldu32.Text = sdr51.GetValue(0).ToString();
            }
            MySqlConnection con52 = new MySqlConnection(Classatom.ConnectionString());
            con52.Open();
            MySqlCommand cmd52;
            cmd52 = con52.CreateCommand();
            cmd52.CommandText = "SELECT SUBSTR(d_up, 3, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr52 = cmd52.ExecuteReader();
            while (sdr52.Read())
            {
                labeldu33.Text = sdr52.GetValue(0).ToString();
            }
            MySqlConnection con53 = new MySqlConnection(Classatom.ConnectionString());
            con53.Open();
            MySqlCommand cmd53;
            cmd53 = con53.CreateCommand();
            cmd53.CommandText = "SELECT SUBSTR(d_up, 4, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr53 = cmd53.ExecuteReader();
            while (sdr53.Read())
            {
                labeldu34.Text = sdr53.GetValue(0).ToString();
            }
            MySqlConnection con54 = new MySqlConnection(Classatom.ConnectionString());
            con54.Open();
            MySqlCommand cmd54;
            cmd54 = con54.CreateCommand();
            cmd54.CommandText = "SELECT SUBSTR(d_up, 5, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr54 = cmd54.ExecuteReader();
            while (sdr54.Read())
            {
                labeldu35.Text = sdr54.GetValue(0).ToString();
            }
            MySqlConnection con56 = new MySqlConnection(Classatom.ConnectionString());
            con56.Open();
            MySqlCommand cmd56;
            cmd56 = con56.CreateCommand();
            cmd56.CommandText = "SELECT SUBSTR(d_up, 6, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr56 = cmd56.ExecuteReader();
            while (sdr56.Read())
            {
                labeldu41.Text = sdr56.GetValue(0).ToString();
            }
            MySqlConnection con57 = new MySqlConnection(Classatom.ConnectionString());
            con57.Open();
            MySqlCommand cmd57;
            cmd57 = con57.CreateCommand();
            cmd57.CommandText = "SELECT SUBSTR(d_up, 7, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr57 = cmd57.ExecuteReader();
            while (sdr57.Read())
            {
                labeldu42.Text = sdr57.GetValue(0).ToString();
            }
            MySqlConnection con58 = new MySqlConnection(Classatom.ConnectionString());
            con58.Open();
            MySqlCommand cmd58;
            cmd58 = con58.CreateCommand();
            cmd58.CommandText = "SELECT SUBSTR(d_up, 8, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr58 = cmd58.ExecuteReader();
            while (sdr58.Read())
            {
                labeldu43.Text = sdr58.GetValue(0).ToString();
            }
            MySqlConnection con59 = new MySqlConnection(Classatom.ConnectionString());
            con59.Open();
            MySqlCommand cmd59;
            cmd59 = con59.CreateCommand();
            cmd59.CommandText = "SELECT SUBSTR(d_up, 9, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr59 = cmd59.ExecuteReader();
            while (sdr59.Read())
            {
                labeldu44.Text = sdr59.GetValue(0).ToString();
            }
            MySqlConnection con60 = new MySqlConnection(Classatom.ConnectionString());
            con60.Open();
            MySqlCommand cmd60;
            cmd60 = con60.CreateCommand();
            cmd60.CommandText = "SELECT SUBSTR(d_up, 10, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr60 = cmd60.ExecuteReader();
            while (sdr60.Read())
            {
                labeldu45.Text = sdr60.GetValue(0).ToString();
            }
            /*MySqlConnection con61 = new MySqlConnection(Classatom.ConnectionString());
            con61.Open();
            MySqlCommand cmd61;
            cmd61 = con61.CreateCommand();
            cmd61.CommandText = "SELECT SUBSTR(d_up, 11, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr61 = cmd61.ExecuteReader();
            while (sdr61.Read())
            {
                labeldu51.Text = sdr61.GetValue(0).ToString();
            }
            MySqlConnection con62 = new MySqlConnection(Classatom.ConnectionString());
            con62.Open();
            MySqlCommand cmd62;
            cmd62 = con62.CreateCommand();
            cmd62.CommandText = "SELECT SUBSTR(d_up, 12, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr62 = cmd62.ExecuteReader();
            while (sdr62.Read())
            {
                labeldu52.Text = sdr62.GetValue(0).ToString();
            }
            MySqlConnection con63 = new MySqlConnection(Classatom.ConnectionString());
            con63.Open();
            MySqlCommand cmd63;
            cmd63 = con63.CreateCommand();
            cmd63.CommandText = "SELECT SUBSTR(d_up, 13, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr63 = cmd63.ExecuteReader();
            while (sdr63.Read())
            {
                labeldu53.Text = sdr63.GetValue(0).ToString();
            }
            MySqlConnection con64 = new MySqlConnection(Classatom.ConnectionString());
            con64.Open();
            MySqlCommand cmd64;
            cmd64 = con64.CreateCommand();
            cmd64.CommandText = "SELECT SUBSTR(d_up, 14, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr64 = cmd64.ExecuteReader();
            while (sdr64.Read())
            {
                labeldu54.Text = sdr64.GetValue(0).ToString();
            }
            MySqlConnection con65 = new MySqlConnection(Classatom.ConnectionString());
            con65.Open();
            MySqlCommand cmd65;
            cmd65 = con65.CreateCommand();
            cmd65.CommandText = "SELECT SUBSTR(d_up, 15, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr65 = cmd65.ExecuteReader();
            while (sdr65.Read())
            {
                labeldu55.Text = sdr65.GetValue(0).ToString();
            }
            MySqlConnection con66 = new MySqlConnection(Classatom.ConnectionString());
            con66.Open();
            MySqlCommand cmd66;
            cmd66 = con66.CreateCommand();
            cmd66.CommandText = "SELECT SUBSTR(d_up, 16, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr66 = cmd66.ExecuteReader();
            while (sdr66.Read())
            {
                labeldu61.Text = sdr66.GetValue(0).ToString();
            }
            MySqlConnection con67 = new MySqlConnection(Classatom.ConnectionString());
            con67.Open();
            MySqlCommand cmd67;
            cmd67 = con67.CreateCommand();
            cmd67.CommandText = "SELECT SUBSTR(d_up, 17, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr67 = cmd67.ExecuteReader();
            while (sdr67.Read())
            {
                labeldu62.Text = sdr67.GetValue(0).ToString();
            }
            MySqlConnection con68 = new MySqlConnection(Classatom.ConnectionString());
            con68.Open();
            MySqlCommand cmd68;
            cmd68 = con68.CreateCommand();
            cmd68.CommandText = "SELECT SUBSTR(d_up, 18, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr68 = cmd68.ExecuteReader();
            while (sdr68.Read())
            {
                labeldu63.Text = sdr68.GetValue(0).ToString();
            }
            MySqlConnection con69 = new MySqlConnection(Classatom.ConnectionString());
            con69.Open();
            MySqlCommand cmd69;
            cmd69 = con69.CreateCommand();
            cmd69.CommandText = "SELECT SUBSTR(d_up, 19, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr69 = cmd69.ExecuteReader();
            while (sdr69.Read())
            {
                labeldu64.Text = sdr69.GetValue(0).ToString();
            }
            MySqlConnection con70 = new MySqlConnection(Classatom.ConnectionString());
            con70.Open();
            MySqlCommand cmd70;
            cmd70 = con70.CreateCommand();
            cmd70.CommandText = "SELECT SUBSTR(d_up, 20, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr70 = cmd70.ExecuteReader();
            while (sdr70.Read())
            {
                labeldu65.Text = sdr70.GetValue(0).ToString();
            }*/
            MySqlConnection con71 = new MySqlConnection(Classatom.ConnectionString());
            con71.Open();
            MySqlCommand cmd71;
            cmd71 = con71.CreateCommand();
            cmd71.CommandText = "SELECT SUBSTR(d_down, 1, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr71 = cmd71.ExecuteReader();
            while (sdr71.Read())
            {
                labeldd31.Text = sdr71.GetValue(0).ToString();
            }
            MySqlConnection con72 = new MySqlConnection(Classatom.ConnectionString());
            con72.Open();
            MySqlCommand cmd72;
            cmd72 = con72.CreateCommand();
            cmd72.CommandText = "SELECT SUBSTR(d_down, 2, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr72 = cmd72.ExecuteReader();
            while (sdr72.Read())
            {
                labeldd32.Text = sdr72.GetValue(0).ToString();
            }
            MySqlConnection con73 = new MySqlConnection(Classatom.ConnectionString());
            con73.Open();
            MySqlCommand cmd73;
            cmd73 = con73.CreateCommand();
            cmd73.CommandText = "SELECT SUBSTR(d_down, 3, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr73 = cmd73.ExecuteReader();
            while (sdr73.Read())
            {
                labeldd33.Text = sdr73.GetValue(0).ToString();
            }
            MySqlConnection con74 = new MySqlConnection(Classatom.ConnectionString());
            con74.Open();
            MySqlCommand cmd74;
            cmd74 = con74.CreateCommand();
            cmd74.CommandText = "SELECT SUBSTR(d_down, 4, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr74 = cmd74.ExecuteReader();
            while (sdr74.Read())
            {
                labeldd34.Text = sdr74.GetValue(0).ToString();
            }
            MySqlConnection con75 = new MySqlConnection(Classatom.ConnectionString());
            con75.Open();
            MySqlCommand cmd75;
            cmd75 = con75.CreateCommand();
            cmd75.CommandText = "SELECT SUBSTR(d_down, 5, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr75 = cmd75.ExecuteReader();
            while (sdr75.Read())
            {
                labeldd35.Text = sdr75.GetValue(0).ToString();
            }
            MySqlConnection con76 = new MySqlConnection(Classatom.ConnectionString());
            con76.Open();
            MySqlCommand cmd76;
            cmd76 = con76.CreateCommand();
            cmd76.CommandText = "SELECT SUBSTR(d_down, 6, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr76 = cmd76.ExecuteReader();
            while (sdr76.Read())
            {
                labeldd41.Text = sdr76.GetValue(0).ToString();
            }
            MySqlConnection con77 = new MySqlConnection(Classatom.ConnectionString());
            con77.Open();
            MySqlCommand cmd77;
            cmd77 = con77.CreateCommand();
            cmd77.CommandText = "SELECT SUBSTR(d_down, 7, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr77 = cmd77.ExecuteReader();
            while (sdr77.Read())
            {
                labeldd42.Text = sdr77.GetValue(0).ToString();
            }
            MySqlConnection con78 = new MySqlConnection(Classatom.ConnectionString());
            con78.Open();
            MySqlCommand cmd78;
            cmd78 = con78.CreateCommand();
            cmd78.CommandText = "SELECT SUBSTR(d_down, 8, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr78 = cmd78.ExecuteReader();
            while (sdr78.Read())
            {
                labeldd43.Text = sdr78.GetValue(0).ToString();
            }
            MySqlConnection con79 = new MySqlConnection(Classatom.ConnectionString());
            con79.Open();
            MySqlCommand cmd79;
            cmd79 = con79.CreateCommand();
            cmd79.CommandText = "SELECT SUBSTR(d_down, 9, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr79 = cmd79.ExecuteReader();
            while (sdr79.Read())
            {
                labeldd44.Text = sdr79.GetValue(0).ToString();
            }
            MySqlConnection con80 = new MySqlConnection(Classatom.ConnectionString());
            con80.Open();
            MySqlCommand cmd80;
            cmd80 = con80.CreateCommand();
            cmd80.CommandText = "SELECT SUBSTR(d_down, 10, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr80 = cmd80.ExecuteReader();
            while (sdr80.Read())
            {
                labeldd45.Text = sdr80.GetValue(0).ToString();
            }
            /*MySqlConnection con81 = new MySqlConnection(Classatom.ConnectionString());
            con81.Open();
            MySqlCommand cmd81;
            cmd81 = con81.CreateCommand();
            cmd81.CommandText = "SELECT SUBSTR(d_down, 11, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr81 = cmd81.ExecuteReader();
            while (sdr81.Read())
            {
                labeldd51.Text = sdr81.GetValue(0).ToString();
            }
            MySqlConnection con82 = new MySqlConnection(Classatom.ConnectionString());
            con82.Open();
            MySqlCommand cmd82;
            cmd82 = con82.CreateCommand();
            cmd82.CommandText = "SELECT SUBSTR(d_down, 12, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr82 = cmd82.ExecuteReader();
            while (sdr82.Read())
            {
                labeldd52.Text = sdr82.GetValue(0).ToString();
            }
            MySqlConnection con83 = new MySqlConnection(Classatom.ConnectionString());
            con83.Open();
            MySqlCommand cmd83;
            cmd83 = con83.CreateCommand();
            cmd83.CommandText = "SELECT SUBSTR(d_down, 13, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr83 = cmd83.ExecuteReader();
            while (sdr83.Read())
            {
                labeldd53.Text = sdr83.GetValue(0).ToString();
            }
            MySqlConnection con84 = new MySqlConnection(Classatom.ConnectionString());
            con84.Open();
            MySqlCommand cmd84;
            cmd84 = con84.CreateCommand();
            cmd84.CommandText = "SELECT SUBSTR(d_down, 14, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr84 = cmd84.ExecuteReader();
            while (sdr84.Read())
            {
                labeldd54.Text = sdr84.GetValue(0).ToString();
            }
            MySqlConnection con85 = new MySqlConnection(Classatom.ConnectionString());
            con85.Open();
            MySqlCommand cmd85;
            cmd85 = con85.CreateCommand();
            cmd85.CommandText = "SELECT SUBSTR(d_down, 15, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr85 = cmd85.ExecuteReader();
            while (sdr85.Read())
            {
                labeldd55.Text = sdr85.GetValue(0).ToString();
            }
            MySqlConnection con86 = new MySqlConnection(Classatom.ConnectionString());
            con86.Open();
            MySqlCommand cmd86;
            cmd86 = con86.CreateCommand();
            cmd86.CommandText = "SELECT SUBSTR(d_down, 16, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr86 = cmd86.ExecuteReader();
            while (sdr86.Read())
            {
                labeldd61.Text = sdr86.GetValue(0).ToString();
            }
            MySqlConnection con87 = new MySqlConnection(Classatom.ConnectionString());
            con87.Open();
            MySqlCommand cmd87;
            cmd87 = con87.CreateCommand();
            cmd87.CommandText = "SELECT SUBSTR(d_down, 17, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr87 = cmd87.ExecuteReader();
            while (sdr87.Read())
            {
                labeldd62.Text = sdr87.GetValue(0).ToString();
            }
            MySqlConnection con88 = new MySqlConnection(Classatom.ConnectionString());
            con88.Open();
            MySqlCommand cmd88;
            cmd88 = con88.CreateCommand();
            cmd88.CommandText = "SELECT SUBSTR(d_down, 18, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr88 = cmd88.ExecuteReader();
            while (sdr88.Read())
            {
                labeldd63.Text = sdr88.GetValue(0).ToString();
            }
            MySqlConnection con89 = new MySqlConnection(Classatom.ConnectionString());
            con89.Open();
            MySqlCommand cmd89;
            cmd89 = con89.CreateCommand();
            cmd89.CommandText = "SELECT SUBSTR(d_down, 19, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr89 = cmd89.ExecuteReader();
            while (sdr89.Read())
            {
                labeldd64.Text = sdr89.GetValue(0).ToString();
            }
            MySqlConnection con90 = new MySqlConnection(Classatom.ConnectionString());
            con90.Open();
            MySqlCommand cmd90;
            cmd90 = con90.CreateCommand();
            cmd90.CommandText = "SELECT SUBSTR(d_down, 20, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr90 = cmd90.ExecuteReader();
            while (sdr90.Read())
            {
                labeldd65.Text = sdr90.GetValue(0).ToString();
            }
            MySqlConnection con91 = new MySqlConnection(Classatom.ConnectionString());
            con91.Open();
            MySqlCommand cmd91;
            cmd91 = con91.CreateCommand();
            cmd91.CommandText = "SELECT SUBSTR(f_up, 1, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr91 = cmd91.ExecuteReader();
            while (sdr91.Read())
            {
                labelfu41.Text = sdr91.GetValue(0).ToString();
            }
            MySqlConnection con92 = new MySqlConnection(Classatom.ConnectionString());
            con92.Open();
            MySqlCommand cmd92;
            cmd92 = con92.CreateCommand();
            cmd92.CommandText = "SELECT SUBSTR(f_up, 2, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr92 = cmd92.ExecuteReader();
            while (sdr92.Read())
            {
                labelfu42.Text = sdr92.GetValue(0).ToString();
            }
            MySqlConnection con93 = new MySqlConnection(Classatom.ConnectionString());
            con93.Open();
            MySqlCommand cmd93;
            cmd93 = con93.CreateCommand();
            cmd93.CommandText = "SELECT SUBSTR(f_up, 3, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr93 = cmd93.ExecuteReader();
            while (sdr93.Read())
            {
                labelfu43.Text = sdr93.GetValue(0).ToString();
            }
            MySqlConnection con94 = new MySqlConnection(Classatom.ConnectionString());
            con94.Open();
            MySqlCommand cmd94;
            cmd94 = con94.CreateCommand();
            cmd94.CommandText = "SELECT SUBSTR(f_up, 4, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr94 = cmd94.ExecuteReader();
            while (sdr94.Read())
            {
                labelfu44.Text = sdr94.GetValue(0).ToString();
            }
            
            MySqlConnection con951 = new MySqlConnection(Classatom.ConnectionString());
            con951.Open();
            MySqlCommand cmd951;
            cmd951 = con951.CreateCommand();
            cmd951.CommandText = "SELECT SUBSTR(f_up, 5, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr951 = cmd951.ExecuteReader();
            while (sdr951.Read())
            {
                labelfu45.Text = sdr951.GetValue(0).ToString();
            }
            MySqlConnection con96 = new MySqlConnection(Classatom.ConnectionString());
            con96.Open();
            MySqlCommand cmd96;
            cmd96 = con96.CreateCommand();
            cmd96.CommandText = "SELECT SUBSTR(f_up, 6, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr96 = cmd96.ExecuteReader();
            while (sdr96.Read())
            {
                labelfu46.Text = sdr96.GetValue(0).ToString();
            }
            MySqlConnection con97 = new MySqlConnection(Classatom.ConnectionString());
            con97.Open();
            MySqlCommand cmd97;
            cmd97 = con97.CreateCommand();
            cmd97.CommandText = "SELECT SUBSTR(f_up, 7, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr97 = cmd97.ExecuteReader();
            while (sdr97.Read())
            {
                labelfu47.Text = sdr97.GetValue(0).ToString();
            }
            MySqlConnection con98 = new MySqlConnection(Classatom.ConnectionString());
            con98.Open();
            MySqlCommand cmd98;
            cmd98 = con98.CreateCommand();
            cmd98.CommandText = "SELECT SUBSTR(f_up, 8, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr98 = cmd98.ExecuteReader();
            while (sdr98.Read())
            {
                labelfu51.Text = sdr98.GetValue(0).ToString();
            }
            MySqlConnection con99 = new MySqlConnection(Classatom.ConnectionString());
            con99.Open();
            MySqlCommand cmd99;
            cmd99 = con99.CreateCommand();
            cmd99.CommandText = "SELECT SUBSTR(f_up, 9, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr99 = cmd99.ExecuteReader();
            while (sdr99.Read())
            {
                labelfu52.Text = sdr99.GetValue(0).ToString();
            }
            MySqlConnection con100 = new MySqlConnection(Classatom.ConnectionString());
            con100.Open();
            MySqlCommand cmd100;
            cmd100 = con100.CreateCommand();
            cmd100.CommandText = "SELECT SUBSTR(f_up, 10, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr100 = cmd100.ExecuteReader();
            while (sdr100.Read())
            {
                labelfu53.Text = sdr100.GetValue(0).ToString();
            }
            MySqlConnection con101 = new MySqlConnection(Classatom.ConnectionString());
            con101.Open();
            MySqlCommand cmd101;
            cmd101 = con101.CreateCommand();
            cmd101.CommandText = "SELECT SUBSTR(f_up, 11, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr101 = cmd101.ExecuteReader();
            while (sdr101.Read())
            {
                labelfu54.Text = sdr101.GetValue(0).ToString();
            }
            MySqlConnection con102 = new MySqlConnection(Classatom.ConnectionString());
            con102.Open();
            MySqlCommand cmd102;
            cmd102= con102.CreateCommand();
            cmd102.CommandText = "SELECT SUBSTR(f_up, 12, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr102 = cmd102.ExecuteReader();
            while (sdr102.Read())
            {
                labelfu55.Text = sdr102.GetValue(0).ToString();
            }
            MySqlConnection con103 = new MySqlConnection(Classatom.ConnectionString());
            con103.Open();
            MySqlCommand cmd103;
            cmd103 = con103.CreateCommand();
            cmd103.CommandText = "SELECT SUBSTR(f_up, 13, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr103 = cmd103.ExecuteReader();
            while (sdr103.Read())
            {
                labelfu56.Text = sdr103.GetValue(0).ToString();
            }
            MySqlConnection con104 = new MySqlConnection(Classatom.ConnectionString());
            con104.Open();
            MySqlCommand cmd104;
            cmd104 = con104.CreateCommand();
            cmd104.CommandText = "SELECT SUBSTR(f_up, 14, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr104 = cmd104.ExecuteReader();
            while (sdr104.Read())
            {
                labelfu57.Text = sdr104.GetValue(0).ToString();
            }
            MySqlConnection con105 = new MySqlConnection(Classatom.ConnectionString());
            con105.Open();
            MySqlCommand cmd105;
            cmd105 = con105.CreateCommand();
            cmd105.CommandText = "SELECT SUBSTR(f_down, 1, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr105 = cmd105.ExecuteReader();
            while (sdr105.Read())
            {
                labelfd41.Text = sdr105.GetValue(0).ToString();
            }
            MySqlConnection con106 = new MySqlConnection(Classatom.ConnectionString());
            con106.Open();
            MySqlCommand cmd106;
            cmd106 = con106.CreateCommand();
            cmd106.CommandText = "SELECT (f_down, 2, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr106 = cmd106.ExecuteReader();
            while (sdr106.Read())
            {
                labelfd42.Text = sdr106.GetValue(0).ToString();
            }
            MySqlConnection con107 = new MySqlConnection(Classatom.ConnectionString());
            con107.Open();
            MySqlCommand cmd107;
            cmd107 = con107.CreateCommand();
            cmd107.CommandText = "SELECT (f_down, 3, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr107 = cmd107.ExecuteReader();
            while (sdr107.Read())
            {
                labelfd43.Text = sdr107.GetValue(0).ToString();
            }
            MySqlConnection con108 = new MySqlConnection(Classatom.ConnectionString());
            con108.Open();
            MySqlCommand cmd108;
            cmd108 = con108.CreateCommand();
            cmd108.CommandText = "SELECT (f_down, 4, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr108 = cmd108.ExecuteReader();
            while (sdr108.Read())
            {
                labelfd44.Text = sdr108.GetValue(0).ToString();
            }
            MySqlConnection con109 = new MySqlConnection(Classatom.ConnectionString());
            con109.Open();
            MySqlCommand cmd109;
            cmd109 = con109.CreateCommand();
            cmd109.CommandText = "SELECT (f_down, 5, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr109 = cmd109.ExecuteReader();
            while (sdr109.Read())
            {
                labelfd45.Text = sdr109.GetValue(0).ToString();
            }
            MySqlConnection con110 = new MySqlConnection(Classatom.ConnectionString());
            con110.Open();
            MySqlCommand cmd110;
            cmd110 = con110.CreateCommand();
            cmd110.CommandText = "SELECT (f_down, 6, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr110 = cmd110.ExecuteReader();
            while (sdr110.Read())
            {
                labelfd46.Text = sdr110.GetValue(0).ToString();
            }
            MySqlConnection con111 = new MySqlConnection(Classatom.ConnectionString());
            con111.Open();
            MySqlCommand cmd111;
            cmd111 = con111.CreateCommand();
            cmd111.CommandText = "SELECT (f_down, 7, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr111 = cmd111.ExecuteReader();
            while (sdr111.Read())
            {
                labelfd47.Text = sdr111.GetValue(0).ToString();
            }
            MySqlConnection con112 = new MySqlConnection(Classatom.ConnectionString());
            con112.Open();
            MySqlCommand cmd112;
            cmd112 = con112.CreateCommand();
            cmd112.CommandText = "SELECT (f_down, 8, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr112 = cmd112.ExecuteReader();
            while (sdr112.Read())
            {
                labelfd51.Text = sdr112.GetValue(0).ToString();
            }
            MySqlConnection con113 = new MySqlConnection(Classatom.ConnectionString());
            con113.Open();
            MySqlCommand cmd113;
            cmd113 = con113.CreateCommand();
            cmd113.CommandText = "SELECT (f_down, 9, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr113 = cmd113.ExecuteReader();
            while (sdr113.Read())
            {
                labelfd52.Text = sdr113.GetValue(0).ToString();
            }
            MySqlConnection con114 = new MySqlConnection(Classatom.ConnectionString());
            con114.Open();
            MySqlCommand cmd114;
            cmd114 = con114.CreateCommand();
            cmd114.CommandText = "SELECT (f_down, 10, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr114 = cmd114.ExecuteReader();
            while (sdr114.Read())
            {
                labelfd53.Text = sdr114.GetValue(0).ToString();
            }
            MySqlConnection con115 = new MySqlConnection(Classatom.ConnectionString());
            con115.Open();
            MySqlCommand cmd115;
            cmd115 = con115.CreateCommand();
            cmd115.CommandText = "SELECT (f_down, 11, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr115 = cmd115.ExecuteReader();
            while (sdr115.Read())
            {
                labelfd54.Text = sdr115.GetValue(0).ToString();
            }
            MySqlConnection con116 = new MySqlConnection(Classatom.ConnectionString());
            con116.Open();
            MySqlCommand cmd116;
            cmd116 = con116.CreateCommand();
            cmd116.CommandText = "SELECT (f_down, 12, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr116 = cmd116.ExecuteReader();
            while (sdr116.Read())
            {
                labelfd55.Text = sdr116.GetValue(0).ToString();
            }
            MySqlConnection con117 = new MySqlConnection(Classatom.ConnectionString());
            con117.Open();
            MySqlCommand cmd117;
            cmd117 = con117.CreateCommand();
            cmd117.CommandText = "SELECT (f_down, 13, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr117 = cmd117.ExecuteReader();
            while (sdr117.Read())
            {
                labelfd56.Text = sdr117.GetValue(0).ToString();
            }
            MySqlConnection con118 = new MySqlConnection(Classatom.ConnectionString());
            con118.Open();
            MySqlCommand cmd118;
            cmd118 = con118.CreateCommand();
            cmd118.CommandText = "SELECT (f_down, 14, 1) FROM configuration where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdr118 = cmd118.ExecuteReader();
            while (sdr118.Read())
            {
                labelfd57.Text = sdr118.GetValue(0).ToString();
            }*/
            
        }

        private void buttonHomeF1_Click(object sender, EventArgs e)
        {
            FormHome cs = new FormHome();
            this.Hide();
            cs.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPropertiesF1_Click(object sender, EventArgs e)
        {
            FormProperties cs = new FormProperties();
            this.Hide();
            cs.Show();
        }

        private void buttonAbundanceF1_Click(object sender, EventArgs e)
        {
            FormAbundance cs = new FormAbundance();
            this.Hide();
            cs.Show();
        }

        private void labelpu211_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }
    }
}
