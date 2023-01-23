using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampionatMondial2
{
    public partial class FormMeciuri : Form
    {
        int MeciID = 0;
        string Echipa1Nume;
        string Echipa2Nume;
        string StadionNume;
        int IDelete = 0;
        SqlConnection conM = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");
        SqlConnection conM2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");
        string cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
        "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
         "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
         "GROUP BY M.Data , E1.Nume, E2.Nume, M.ID_Meci\n" +
            "ORDER BY M.Data ASC";

        DateTime DateTimeInitial;

        public FormMeciuri()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'campionat_mondialDataSet.Echipe' table. You can move, or remove it, as needed.
            this.echipeTableAdapter.Fill(this.campionat_mondialDataSet.Echipe);
            SqlDataReader drm;


            SqlCommand cmdM = new SqlCommand(cmdFind);

            
            cmdM.Connection= conM;

            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();

            comboBox1.Hide();
            comboBox2.Hide();
            comboBox3.Hide();
            dateTimePicker1.Hide();

            button2.Hide();
            button3.Hide();

            ErrorLabel.Hide();
            StatusLabel.Hide(); 

            conM.Open();
            int i = 0;
            drm = cmdM.ExecuteReader();
            while (drm.Read())
            {



                Button btn = new Button();
                btn.Text = drm.GetString(i) + "-" + drm.GetString(i+1);
                i += 2;
                btn.Tag = drm.GetInt32(i);
             
                i = 0;
                btn.Width = 200;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;





            }
            drm.Close();

            conM.Close();

            // TODO: This line of code loads data into the 'campionat_mondialDataSet.Meciuri' table. You can move, or remove it, as needed.
            this.meciuriTableAdapter.Fill(this.campionat_mondialDataSet.Meciuri);
            // TODO: This line of code loads data into the 'campionat_mondialDataSet.Campionate' table. You can move, or remove it, as needed.
           this.campionateTableAdapter.Fill(this.campionat_mondialDataSet.Campionate);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmMain = new Form3();
            this.Hide();
            frmMain.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            ErrorLabel.Hide();
            StatusLabel.Hide();

            Button btn = (Button)sender;
            MeciID = (int)btn.Tag;

            SqlDataReader drm;
            SqlDataReader drm2;
            string loadMeciuriAfisaj = "SELECT E1.Nume, E2.Nume, S.Nume, M.Data \n" +
               "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
               "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
               "LEFT JOIN Stadioane S ON M.ID_Stadion = S.ID_Stadion\n" +
               "WHERE M.ID_Meci = ' "+ MeciID +"' " ;

            string loadEchipa1Afisaj;
            string loadEchipa2Afisaj;
            string loadStadioaneAfisaj;

            SqlCommand cmdM = new SqlCommand(loadMeciuriAfisaj);
            SqlCommand cmdME1;
            SqlCommand cmdME2;
            SqlCommand cmdMS;

            
           cmdM.Connection = conM;


            conM.Open();

            drm = cmdM.ExecuteReader();

            while (drm.Read())
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();

                Echipa1Nume = drm.GetString(0);
                Echipa2Nume = drm.GetString(1);
                StadionNume = drm.GetString(2);

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
                
                
                while(drm2.Read())
                {
                    comboBox1.Items.Add(drm2.GetString(0));


                }
                drm2.Close();

                comboBox1.Text = Echipa1Nume;

                drm2= cmdME2.ExecuteReader();
                while (drm2.Read())
                {
                    comboBox2.Items.Add(drm2.GetString(0));

                }

                drm2.Close();

                comboBox2.Text = Echipa2Nume;

               
                drm2 = cmdMS.ExecuteReader();
                while (drm2.Read())
                {
                    comboBox3.Items.Add(drm2.GetString(0));


                }

                drm2.Close();
                conM2.Close();


                comboBox3.Text = StadionNume;

                DateTimeInitial = drm.GetDateTime(3).ToUniversalTime();
                dateTimePicker1.Value = DateTimeInitial;

                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();

                comboBox1.Show();
                comboBox2.Show();
                comboBox3.Show();
                dateTimePicker1.Show();

                button2.Show();
                button3.Show();


            }
            drm.Close();

            conM.Close();








        }

        private void button2_Click(object sender, EventArgs e)
        {


            if(MeciID == 0)
            {
                ErrorLabel.Show();
                ErrorLabel.Text = "Eroare: Nu s-a gasit un meci selectat.";
                return;
            }
            


            if(IDelete == 0)
            {
                button2.Text = "Confirma";
                IDelete= 1;
                return;

            }
            
            if(IDelete == 1)
            {
               
                SqlCommand commandDelete = new SqlCommand();
                commandDelete.CommandText = "DELETE FROM Meciuri\n" +
                   "WHERE ID_Meci = ' " + MeciID + "' ";

                commandDelete.Connection = conM;

                conM.Open();
                commandDelete.ExecuteNonQuery();

                StatusLabel.Show();
                StatusLabel.Text = "Meciul a fost sters din baza de date.";
                button2.Hide();
                button3.Hide();

                conM.Close();

                IDelete=0;

                flowLayoutPanel1.Controls.Clear();

                SqlDataReader drm;

                SqlCommand cmdM = new SqlCommand(cmdFind);

                cmdM.Connection = conM2;

                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();

                comboBox1.Hide();
                comboBox2.Hide();
                comboBox3.Hide();
                dateTimePicker1.Hide();

                button2.Hide();
                button3.Hide();

                conM2.Open();
                int i = 0;
                drm = cmdM.ExecuteReader();
                while (drm.Read())
                {



                    Button btn = new Button();
                    btn.Text = drm.GetString(i) + "-" + drm.GetString(i + 1);
                    i += 2;
                    btn.Tag = drm.GetInt32(i);

                    i = 0;
                    btn.Width = 200;
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += Btn_Click;





                }
                drm.Close();

                conM2.Close();
            }
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MeciID == 0)
            {
                ErrorLabel.Show();
                ErrorLabel.Text = "Eroare: Nu s-a gasit un meci selectat.";
                return;
            }
            

            string Echipa1NumeModificat = comboBox1.Text.ToString();
            string Echipa2NumeModificat = comboBox2.Text.ToString();
            string StadionNumeModificat = comboBox3.Text.ToString();
            DateTime DateTimeModificat = dateTimePicker1.Value;
            
           
            if (Echipa1NumeModificat == Echipa1Nume && Echipa2NumeModificat == Echipa2Nume && StadionNumeModificat == StadionNume && DateTimeModificat == DateTimeInitial)
            {
                ErrorLabel.Show();
                ErrorLabel.Text = "Atentie: nu exista nicio modificare pentru meci.";
                return;

            }
            if (Echipa1NumeModificat == Echipa2NumeModificat)
            {
                ErrorLabel.Show();
                ErrorLabel.Text = "Eroare: Meciurile nu pot avea aceeasi echipa de 2 ori.";
                return;
            }

            SqlCommand commandModify = new SqlCommand();
            commandModify.CommandText = "UPDATE Meciuri\n" +
                "SET ID_Stadion = (SELECT TOP 1 S.ID_Stadion FROM Stadioane S WHERE S.Nume ='"  +StadionNumeModificat+ "'),\n" +
                " ID_Echipa1 = (SELECT TOP 1 E1.ID_Echipa FROM Echipe E1 WHERE E1.Nume ='" +Echipa1NumeModificat+ "'), \n" +
                " ID_Echipa2 = (SELECT TOP 1 E2.ID_Echipa FROM Echipe E2 WHERE E2.Nume ='" +Echipa2NumeModificat+ "'),\n" +
                " Data = '"+DateTimeModificat.ToString("MM/dd/yyyy hh:mm:ss")+"'\n" +
                "WHERE ID_Meci = ' " + MeciID + "' ;";

            commandModify.Connection = conM;

            conM.Open();
                commandModify.ExecuteNonQuery();
                StatusLabel.Show();
                StatusLabel.Text = "Meciul a fost modificat.";

            MeciID = 0;

            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();

            comboBox1.Hide();
            comboBox2.Hide();
            comboBox3.Hide();
            dateTimePicker1.Hide();

            conM.Close();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmAdd = new AddNewMeci();
            frmAdd.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (comboBoxFind.SelectedIndex == 0)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY M.Data, E1.Nume, E2.Nume, M.ID_Meci\n" +
                    "ORDER BY M.Data ASC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + " E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY M.Data, E1.Nume, E2.Nume, M.ID_Meci\n" +
                    "ORDER BY M.Data ASC";
            }
            if (comboBoxFind.SelectedIndex == 1)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
                     "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                     "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                     "GROUP BY M.Data, E1.Nume, E2.Nume, M.ID_Meci\n" +
                "ORDER BY M.Data DESC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + " E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY M.Data, E1.Nume, E2.Nume, M.ID_Meci\n" +
                "ORDER BY M.Data DESC";
            }
            if (comboBoxFind.SelectedIndex == 2)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci\n" +
                    "ORDER BY COUNT(ID_Stadion) ASC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + " E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci\n" +
                    "ORDER BY COUNT(ID_Stadion) ASC";
            }
            if (comboBoxFind.SelectedIndex == 3)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci\n" +
                    "ORDER BY COUNT(ID_Stadion) DESC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + " E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci\n" +
                    "ORDER BY COUNT(ID_Stadion) DESC";
            }
            if (comboBoxFind.SelectedIndex == 4)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                    "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci WHERE\n"+
                    " (M1.ID_Echipa1 = M.ID_Echipa1 AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = M.ID_Echipa2 AND S1.Scor_2 > S1.Scor_1)) ASC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + " E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                    "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci WHERE \n"+
                    "(M1.ID_Echipa1 = M.ID_Echipa1 AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = M.ID_Echipa2 AND S1.Scor_2 > S1.Scor_1)) ASC";
            }
            if (comboBoxFind.SelectedIndex == 5)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                     "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci WHERE \n"+
                     "(M1.ID_Echipa1 = M.ID_Echipa1 AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = M.ID_Echipa2 AND S1.Scor_2 > S1.Scor_1)) ASC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + " E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                      "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci WHERE \n"+
                      "(M1.ID_Echipa1 = M.ID_Echipa1 AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = M.ID_Echipa2 AND S1.Scor_2 > S1.Scor_1)) ASC";
            }
            if (comboBoxFind.SelectedIndex == 6)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
                   "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                   "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                   "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                   "ORDER BY (SELECT SUM(M2.Punctaj) FROM Marcari M2 LEFT JOIN Coechipieri C ON M2.ID_Marcant = C.ID_Coechipier\n"+
                   " WHERE C.ID_Echipa IN (SELECT DISTINCT E.ID_Echipa FROM Echipe E WHERE E.ID_Echipa = M.ID_Echipa1 OR E.ID_Echipa = M.ID_Echipa2) ) ASC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + " E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                    "ORDER BY (SELECT SUM(M2.Punctaj) FROM Marcari M2 LEFT JOIN Coechipieri C ON M2.ID_Marcant = C.ID_Coechipier \n"+
                    "WHERE C.ID_Echipa IN (SELECT DISTINCT E.ID_Echipa FROM Echipe E WHERE E.ID_Echipa = M.ID_Echipa1 OR E.ID_Echipa = M.ID_Echipa2) ) ASC";
            }
            if (comboBoxFind.SelectedIndex == 7)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                    "ORDER BY (SELECT SUM(M2.Punctaj) FROM Marcari M2 LEFT JOIN Coechipieri C ON M2.ID_Marcant = C.ID_Coechipier\n"+
                    " WHERE C.ID_Echipa IN (SELECT DISTINCT E.ID_Echipa FROM Echipe E WHERE E.ID_Echipa = M.ID_Echipa1 OR E.ID_Echipa = M.ID_Echipa2) ) DESC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + " E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                    "ORDER BY (SELECT SUM(M2.Punctaj) FROM Marcari M2 LEFT JOIN Coechipieri C ON M2.ID_Marcant = C.ID_Coechipier \n"+
                    " WHERE C.ID_Echipa IN (SELECT DISTINCT E.ID_Echipa FROM Echipe E WHERE E.ID_Echipa = M.ID_Echipa1 OR E.ID_Echipa = M.ID_Echipa2 ) ) DESC";
            }
            SqlDataReader drm;


            SqlCommand cmdM = new SqlCommand(cmdFind);


            cmdM.Connection = conM;
            conM.Open();
            int i = 0;
            drm = cmdM.ExecuteReader();
            flowLayoutPanel1.Controls.Clear();
            while (drm.Read())
            {



                Button btn = new Button();
                btn.Text = drm.GetString(i) + "-" + drm.GetString(i + 1);
                i += 2;
                btn.Tag = drm.GetInt32(i);

                i = 0;
                btn.Width = 200;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;





            }
            drm.Close();

            conM.Close();
        }
    }
}
