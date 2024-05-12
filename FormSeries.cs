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
    public partial class FormSeries : Form
    {
        public FormSeries()
        {
            InitializeComponent();
        }

        private void FormSeries_Load(object sender, EventArgs e)
        {
            if (MyGlobal.TheUgly == 201)
            {
                /*
            MySqlConnection conH12 = new MySqlConnection(Classatom.ConnectionString());
            conH12.Open();
            MySqlCommand cmdH12;
            cmdH12 = conH12.CreateCommand();
            cmdH12.CommandText = "SELECT name FROM atoms where atomic_number = " + MyGlobal.TheUgly;
            MySqlDataReader sdrH12 = cmdH12.ExecuteReader();
            while (sdrH12.Read())
            {
                labelNameF2.Text = sdrH12.GetValue(0).ToString();
            }
                 */
                labelSeriesName.Text = "Alkali Metal";
                MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
                conH1.Open();
                MySqlCommand cmdH1;
                cmdH1 = conH1.CreateCommand();
                cmdH1.CommandText = "SELECT atomic_number,atomic_symbol,weight,electronegativity,melting_point,boiling_point,electron_affinity FROM atom_series, properties WHERE atom_series.series = properties.series and atom_series.series = 'Alkali Metal' ORDER BY atomic_number";// + globalSeries.TheJoker;
                MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdrH1);
                conH1.Close();
                dataGridView1.DataSource = dt;
            }
            else if (MyGlobal.TheUgly == 202)
            {
                labelSeriesName.Text = "Alkaline Earth Metal";
                MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
                conH1.Open();
                MySqlCommand cmdH1;
                cmdH1 = conH1.CreateCommand();
                cmdH1.CommandText = "SELECT atomic_number,atomic_symbol,weight,electronegativity,melting_point,boiling_point,electron_affinity FROM atom_series, properties WHERE atom_series.series = properties.series and atom_series.series = 'Alkaline Earth Metal' ORDER BY atomic_number";// + globalSeries.TheJoker;
                MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdrH1);
                conH1.Close();
                dataGridView1.DataSource = dt;
            }
            else if (MyGlobal.TheUgly == 203)
            {
                labelSeriesName.Text = "Transition Metal";
                MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
                conH1.Open();
                MySqlCommand cmdH1;
                cmdH1 = conH1.CreateCommand();
                cmdH1.CommandText = "SELECT atomic_number,atomic_symbol,weight,electronegativity,melting_point,boiling_point,electron_affinity FROM atom_series, properties WHERE atom_series.series = properties.series and atom_series.series = 'Transition Metal' ORDER BY atomic_number";// + globalSeries.TheJoker;
                MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdrH1);
                conH1.Close();
                dataGridView1.DataSource = dt;
            }
            else if (MyGlobal.TheUgly == 204)
            {
                labelSeriesName.Text = "Lanthanoide";
                MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
                conH1.Open();
                MySqlCommand cmdH1;
                cmdH1 = conH1.CreateCommand();
                cmdH1.CommandText = "SELECT atomic_number,atomic_symbol,weight,electronegativity,melting_point,boiling_point,electron_affinity FROM atom_series, properties WHERE atom_series.series = properties.series and atom_series.series = 'Lanthanoide' ORDER BY atomic_number";// + globalSeries.TheJoker;
                MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdrH1);
                conH1.Close();
                dataGridView1.DataSource = dt;
            }
            else if (MyGlobal.TheUgly == 205)
            {
                labelSeriesName.Text = "Actinoids";
                MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
                conH1.Open();
                MySqlCommand cmdH1;
                cmdH1 = conH1.CreateCommand();
                cmdH1.CommandText = "SELECT atomic_number,atomic_symbol,weight,electronegativity,melting_point,boiling_point,electron_affinity FROM atom_series, properties WHERE atom_series.series = properties.series and atom_series.series = 'Actinoids' ORDER BY atomic_number";// + globalSeries.TheJoker;
                MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdrH1);
                conH1.Close();
                dataGridView1.DataSource = dt;
            }
            else if (MyGlobal.TheUgly == 206)
            {
                labelSeriesName.Text = "Post-transition Metal";
                MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
                conH1.Open();
                MySqlCommand cmdH1;
                cmdH1 = conH1.CreateCommand();
                cmdH1.CommandText = "SELECT atomic_number,atomic_symbol,weight,electronegativity,melting_point,boiling_point,electron_affinity FROM atom_series, properties WHERE atom_series.series = properties.series and atom_series.series = 'Post-transition Metal' ORDER BY atomic_number";// + globalSeries.TheJoker;
                MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdrH1);
                conH1.Close();
                dataGridView1.DataSource = dt;
            }
            else if (MyGlobal.TheUgly == 207)
            {
                labelSeriesName.Text = "Metalloids";
                MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
                conH1.Open();
                MySqlCommand cmdH1;
                cmdH1 = conH1.CreateCommand();
                cmdH1.CommandText = "SELECT atomic_number,atomic_symbol,weight,electronegativity,melting_point,boiling_point,electron_affinity FROM atom_series, properties WHERE atom_series.series = properties.series and atom_series.series = 'Metalloids' ORDER BY atomic_number";// + globalSeries.TheJoker;
                MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdrH1);
                conH1.Close();
                dataGridView1.DataSource = dt;
            }
            else if (MyGlobal.TheUgly == 208)
            {
                labelSeriesName.Text = "Reactive Non-metal";
                MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
                conH1.Open();
                MySqlCommand cmdH1;
                cmdH1 = conH1.CreateCommand();
                cmdH1.CommandText = "SELECT atomic_number,atomic_symbol,weight,electronegativity,melting_point,boiling_point,electron_affinity FROM atom_series, properties WHERE atom_series.series = properties.series and atom_series.series = 'Reactive Non-metal' ORDER BY atomic_number";// + globalSeries.TheJoker;
                MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdrH1);
                conH1.Close();
                dataGridView1.DataSource = dt;
            }
            else if (MyGlobal.TheUgly == 209)
            {
                labelSeriesName.Text = "Noble Gas";
                MySqlConnection conH1 = new MySqlConnection(Classatom.ConnectionString());
                conH1.Open();
                MySqlCommand cmdH1;
                cmdH1 = conH1.CreateCommand();
                cmdH1.CommandText = "SELECT atomic_number,atomic_symbol,weight,electronegativity,melting_point,boiling_point,electron_affinity FROM atom_series, properties WHERE atom_series.series = properties.series and atom_series.series = 'Noble Gas' ORDER BY atomic_number";// + globalSeries.TheJoker;
                MySqlDataReader sdrH1 = cmdH1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdrH1);
                conH1.Close();
                dataGridView1.DataSource = dt;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormHome cs = new FormHome();
            this.Hide();
            cs.Show();
        }
    }//"SELECT atomic_number,atomic_symbol FROM atom_series, properties WHERE atom_series.series = properties.series and atom_series.series =" + globalSeries.TheJoker;
}
