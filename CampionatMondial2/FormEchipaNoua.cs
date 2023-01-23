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

    public partial class FormEchipaNoua : Form
    {

        SqlConnection conE = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");

        public FormEchipaNoua()
        {
            InitializeComponent();
            ErrorLabel.Hide();
            StatusLabel.Hide();
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxNume.Text == "")
            {
                ErrorLabel.Text = "Eroare: Nu s-a introdus un nume pentru echipa.";
                ErrorLabel.Show();
                return;

            }
            if (textBoxCastiguri.Text == "")
            {
                ErrorLabel.Text = "Eroare: Trebuie introdus istoricul castigurilor.";
                ErrorLabel.Show();
                return;

            }
            if (textBoxPierderi.Text == "")
            {
                ErrorLabel.Text = "Eroare: Trebuie introdus istoricul pierderilor.";
                ErrorLabel.Show();
                return;

            }
            SqlCommand commandAddTeam = new SqlCommand();
            commandAddTeam.CommandText = "INSERT INTO Echipe (Nume,Castiguri,Pierderi) \n" +
                "VALUES('" + textBoxNume.Text + "','" + textBoxCastiguri.Text + "','" + textBoxPierderi.Text + "')";
            commandAddTeam.Connection = conE;
            conE.Open();
            commandAddTeam.ExecuteNonQuery();

            StatusLabel.Show();
            StatusLabel.Text = "Echipa a fost adaugata.";

            ErrorLabel.Hide();

            conE.Close();
        }



        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form frmEchipe = new FormEchipe();
            this.Hide();
            frmEchipe.Show();
        }

        private void FormEchipaNoua_Load(object sender, EventArgs e)
        {

        }
    }
}
