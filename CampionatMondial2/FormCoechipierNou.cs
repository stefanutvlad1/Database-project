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
    public partial class FormCoechipierNou : Form
    {
        int[] antrenorIDList = { 1, 2, 3, 4,5,6,7,8,9,10 };
        int antrenorIDIndex = 0;
        string[] coechipierTipList = { "Detinator", "Antrenor", "Mijlocas", "Atacant", "Portar" };

        SqlConnection conE = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");



        public FormCoechipierNou()
        {
            InitializeComponent();

            label8.Hide();
            comboBox2.Hide();


            ErrorLabel.Hide();
            StatusLabel.Hide();

            comboBox1.Items.Clear();
            int i;
            for (i = 0; i < coechipierTipList.Length; i++)
            {
                comboBox1.Items.Add(coechipierTipList[i]);
            }

            SqlDataReader drm;
            string loadEchipe = "SELECT Nume\n" +
               "FROM Echipe";

            SqlCommand cmdE = new SqlCommand(loadEchipe);

            cmdE.Connection = conE;


            conE.Open();
            drm = cmdE.ExecuteReader();
            while (drm.Read())
            {

                comboBoxEchipa.Items.Add(drm.GetString(0));


            }
            drm.Close();

            conE.Close();

        }

        protected Form frmEchipe = new FormEchipe();

        private void labelcoechipierechipa_Click(object sender, EventArgs e)
        {

        }
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEchipe.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string NumeCoechipiernou = textBoxNume.Text;
            string PrenumeCoechipiernou = textBoxPrenume.Text;
            string istoricCastiguri = textBoxCastiguri.Text;
            string istoricPierderi = textBoxPierderi.Text;
            int tipIndex;
            for (tipIndex = 0; tipIndex < coechipierTipList.Length; tipIndex++)
            {
                if (comboBox1.Text == coechipierTipList[tipIndex])
                {
                    break;
                }

            }
            antrenorIDIndex = comboBox2.SelectedIndex; 


            if (NumeCoechipiernou == "")
            {
                ErrorLabel.Text = "Eroare: numele coechipierului nu este completat.";
                ErrorLabel.Show();
                return;


            }
            if (PrenumeCoechipiernou == "")
            {
                ErrorLabel.Text = "Eroare: prenumele coechipierului nu este completat.";
                ErrorLabel.Show();
                return;

            }
            if (istoricCastiguri == "")
            {
                ErrorLabel.Text = "Eroare: nu a fost introdus numarul de castiguri anterioare.";
                ErrorLabel.Show();
                return;

            }
            if (istoricPierderi == "")
            {
                ErrorLabel.Text = "Eroare: nu a fost introdus numarul de pierderi anterioare.";
                ErrorLabel.Show();
                return;

            }

            SqlCommand commandModify = new SqlCommand();
            if (comboBox1.Text != "Antrenor" && antrenorIDIndex >= 1)
            {
                commandModify.CommandText = "INSERT INTO Coechipieri (ID_Echipa,ID_Antrenor,Tip,Nume,Prenume,Castiguri,Pierderi)\n" +
                     "VALUES((SELECT TOP 1 E.ID_Echipa FROM Echipe E WHERE E.Nume LIKE '" + comboBoxEchipa.Text + "'),\n" +
                     " (SELECT TOP 1 A.ID_Coechipier FROM Coechipieri A WHERE A.ID_Coechipier ='" + antrenorIDList[antrenorIDIndex] + "'), \n" +
                     " '" + tipIndex + "',\n" +
                     " '" + NumeCoechipiernou + "',\n" +
                     " '" + PrenumeCoechipiernou + "',\n" +
                     " '" + istoricCastiguri + "',\n" +
                     " '" + istoricPierderi + "')\n";
            }
            else
            {
                commandModify.CommandText = "INSERT INTO Coechipieri (ID_Echipa,Tip,Nume,Prenume,Castiguri,Pierderi)\n" +
                     "VALUES((SELECT TOP 1 E.ID_Echipa FROM Echipe E WHERE E.Nume LIKE '" + comboBoxEchipa.Text + "'),\n" +
                     " '" + tipIndex + "',\n" +
                     " '" + NumeCoechipiernou + "',\n" +
                     " '" + PrenumeCoechipiernou + "',\n" +
                     " '" + istoricCastiguri + "',\n" +
                     " '" + istoricPierderi + "')\n";


            }

            commandModify.Connection = conE;

            conE.Open();
            commandModify.ExecuteNonQuery();
            StatusLabel.Show();
            StatusLabel.Text = "Coechipierul a fost adaugat.";

            ErrorLabel.Hide();

            conE.Close();



        }

        private void comboBoxEchipa_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataReader drm;
            SqlConnection conC = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");

            string loadCoechipier = "SELECT C.Nume, C.Prenume, C.ID_Coechipier\n" +
            "FROM Coechipieri  C RIGHT JOIN Echipe E ON C.ID_Echipa = E.ID_Echipa\n" +
            "WHERE E.Nume = '" + comboBoxEchipa.Text + "' AND C.Tip = 1 ";

            SqlCommand cmdC = new SqlCommand(loadCoechipier, conC);
            conC.Open();
            drm = cmdC.ExecuteReader();
            comboBox2.Items.Clear();
            antrenorIDIndex = 0;
            while (drm.Read())
            {

                comboBox2.Items.Add(drm.GetString(0) + " " + drm.GetString(1));
                antrenorIDList[antrenorIDIndex] = drm.GetInt32(2);
                antrenorIDIndex++;

            }

            drm.Close();
            if (comboBox1.Text != "Antrenor" && comboBox1.Text != "Detinator")
            {
                comboBox2.Show();
                label8.Show();
            }
            else
            {
                comboBox2.Hide();
                label8.Hide();
            }
        }
    }
}
