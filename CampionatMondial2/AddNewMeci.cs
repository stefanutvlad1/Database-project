using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampionatMondial2
{
    public partial class AddNewMeci : Form
    {
        public AddNewMeci()
        {
            InitializeComponent();

            ErrorLabel.Hide();
            StatusLabel.Hide();
        }

        protected Form frmMeciuri = new FormMeciuri();

        private void AddNewMeci_Load(object sender, EventArgs e)
        {
            SqlDataReader drm2;

            string loadEchipa1Afisaj;
            string loadEchipa2Afisaj;
            string loadStadioaneAfisaj;
            SqlCommand cmdME1;
            SqlCommand cmdME2;
            SqlCommand cmdMS;

            SqlConnection conM2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");

                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();


                loadEchipa1Afisaj = "SELECT Nume \n" +
                    "FROM Echipe ";
                loadEchipa2Afisaj = "SELECT Nume \n" +
                    "FROM Echipe ";

                loadStadioaneAfisaj = "SELECT Nume \n" +
                    "FROM Stadioane";

                cmdME1 = new SqlCommand(loadEchipa1Afisaj, conM2);
                cmdME2 = new SqlCommand(loadEchipa2Afisaj, conM2);
                cmdMS = new SqlCommand(loadStadioaneAfisaj, conM2);


                conM2.Open();
                drm2 = cmdME1.ExecuteReader();


                while (drm2.Read())
                {
                    comboBox1.Items.Add(drm2.GetString(0));


                }
                drm2.Close();

                drm2 = cmdME2.ExecuteReader();
                while (drm2.Read())
                {
                    comboBox2.Items.Add(drm2.GetString(0));

                }

                drm2.Close();


                drm2 = cmdMS.ExecuteReader();
                while (drm2.Read())
                {
                    comboBox3.Items.Add(drm2.GetString(0));


                }

                dateTimePicker1.Value = DateTime.Now;

                drm2.Close();
                conM2.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMeciuri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Echipa1NumeModificat = comboBox1.Text.ToString();
            string Echipa2NumeModificat = comboBox2.Text.ToString();
            string StadionNumeModificat = comboBox3.Text.ToString();
            DateTime DateTimeModificat = dateTimePicker1.Value;

            if(Echipa1NumeModificat == "")
            {
                ErrorLabel.Show();
                ErrorLabel.Text = "Eroare: Nu a fost selectata prima echipa.";
                return;
            }
            if (Echipa2NumeModificat == "")
            {
                ErrorLabel.Show();
                ErrorLabel.Text = "Eroare: Nu a fost selectata a doua echipa.";
                return;
            }
            if (StadionNumeModificat == "")
            {
                ErrorLabel.Show();
                ErrorLabel.Text = "Eroare: Nu a fost selectat stadionul.";
                return;
            }
            if (Echipa1NumeModificat == Echipa2NumeModificat)
            {
                ErrorLabel.Show();
                ErrorLabel.Text = "Eroare: Meciurile nu pot avea aceeasi echipa de 2 ori.";
                return;
            }

            SqlConnection conM = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");

            SqlCommand commandModify = new SqlCommand();
            commandModify.CommandText = "INSERT INTO Meciuri (ID_Stadion, ID_Echipa1, ID_Echipa2, Data)\n" +
                "VALUES((SELECT TOP 1 S.ID_Stadion FROM Stadioane S WHERE S.Nume ='" + StadionNumeModificat + "'),\n" +
                " (SELECT TOP 1 E1.ID_Echipa FROM Echipe E1 WHERE E1.Nume ='" + Echipa1NumeModificat + "'), \n" +
                " (SELECT TOP 1 E2.ID_Echipa FROM Echipe E2 WHERE E2.Nume ='" + Echipa2NumeModificat + "'),\n" +
                " '" + DateTimeModificat.ToString("MM/dd/yyyy hh:mm:ss") + "')";

            commandModify.Connection = conM;

            conM.Open();
            commandModify.ExecuteNonQuery();
            StatusLabel.Show();
            StatusLabel.Text = "Meciul a fost adaugat.";

            ErrorLabel.Hide();

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
