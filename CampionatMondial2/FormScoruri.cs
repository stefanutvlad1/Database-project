using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CampionatMondial2
{
    public partial class FormScoruri : Form
    {
        int[] listIDCoechipieri = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        int listIDCoechipieriIndex = 0;
        int selectedMeciID = 0;
        int selectedScorID = 0;
        int selectedMarcareID = 0;
        SqlConnection conM = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");
        SqlConnection conS = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");
        string cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
         "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
          "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
          "GROUP BY M.Data , E1.Nume, E2.Nume, M.ID_Meci\n" +
             "ORDER BY M.Data ASC";
        public FormScoruri()
        {
            InitializeComponent();
            buttonModify.Hide();
            buttonDelete.Hide();
            buttonMarcareNoua.Hide();
            StatusLabel.Hide();
            ErrorLabel.Hide();
            buttonScorDelete.Hide();
            
            labelMarcari.Hide();
            labelMarcant.Hide();
            labelPuncte.Hide();
            labelTime.Hide();

            comboBoxMarcant.Hide();
            timeMarcare.Hide();
            numericPuncte.Hide();

            SqlDataReader drm;

            SqlCommand cmdM = new SqlCommand(cmdFind);

            cmdM.Connection = conM;
            
            conM.Open();
            int i = 0;
            drm = cmdM.ExecuteReader();
            while (drm.Read())
            {



                System.Windows.Forms.Button btnMeciuri = new System.Windows.Forms.Button();
                btnMeciuri.Text = drm.GetString(i) + "-" + drm.GetString(i + 1);
                i += 2;
                btnMeciuri.Tag = drm.GetInt32(i);

                i = 0;
                btnMeciuri.Width = 200;
                flowLayoutPanelMeciuri.Controls.Add(btnMeciuri);
                btnMeciuri.Click += BtnMeciuri_Click;





            }
            drm.Close();

            conM.Close();
        }


        private void BtnMeciuri_Click(object sender, EventArgs e)
        {
            labelMarcari.Hide();
            flowLayoutPanelMarcari.Hide();
            comboBoxMarcant.Hide();
            labelMarcant.Hide();
            numericPuncte.Hide();
            labelPuncte.Hide();
            timeMarcare.Hide();
            labelTime.Hide();

            StatusLabel.Hide();

            System.Windows.Forms.Button btnMeciuri = (System.Windows.Forms.Button)sender;
            selectedMeciID = (int)btnMeciuri.Tag;
            flowLayoutPanelScor.Controls.Clear();
            SqlDataReader drm;
            string loadScor = "SELECT S.Scor_1, S.Scor_2, S.ID_Scor  \n" +
               "FROM Scor S \n" +
               "WHERE S.ID_Meci = '"+selectedMeciID+"'";
            SqlCommand cmdM = new SqlCommand(loadScor);
            
            cmdM.Connection = conM;

            conM.Open();
            drm = cmdM.ExecuteReader();
            while (drm.Read())
            {
                System.Windows.Forms.Button btnMarcari = new System.Windows.Forms.Button();
                btnMarcari.Text = drm.GetInt32(0).ToString() + " - " + drm.GetInt32(1).ToString();
                btnMarcari.Tag = drm.GetInt32(2);
                btnMarcari.Width = 200;
                flowLayoutPanelScor.Controls.Add(btnMarcari);
                btnMarcari.Click += BtnScoruri_Click;

            }
            drm.Close();
            loadScor = "SELECT DISTINCT C.Nume,C.Prenume,E.Nume,C.ID_Coechipier \n" +
                "FROM Coechipieri C LEFT JOIN Echipe E ON C.ID_Echipa = E.ID_Echipa\n" +
                "WHERE C.ID_Echipa = (SELECT ID_Echipa1 FROM Meciuri WHERE ID_Meci = '"+ selectedMeciID + "')\n" +
                "OR C.ID_Echipa = (SELECT ID_Echipa2 FROM Meciuri WHERE ID_Meci = '"+ selectedMeciID +"') ";
            cmdM = new SqlCommand(loadScor,conM);
            comboBoxMarcant.Items.Clear();
            listIDCoechipieriIndex = 0;
            drm = cmdM.ExecuteReader();
            while(drm.Read())
            {
                
                comboBoxMarcant.Items.Add(drm.GetString(0) + " " +drm.GetString(1) + " - "+ drm.GetString(2));
                listIDCoechipieri[listIDCoechipieriIndex] = drm.GetInt32(3);
                listIDCoechipieriIndex++;



            }
            listIDCoechipieriIndex = 0;
            conM.Close();
        }


        private void BtnScoruri_Click(object sender, EventArgs e)
        {
            buttonModify.Show();
            buttonDelete.Show();
            buttonScorDelete.Show();
            labelMarcari.Show();
            buttonModify.Hide();
            buttonDelete.Hide();
            buttonMarcareNoua.Show();

            labelMarcant.Show();
            labelPuncte.Show();
            labelTime.Show();

            comboBoxMarcant.Show();
            timeMarcare.Show();
            numericPuncte.Show();
            flowLayoutPanelMarcari.Show();

            StatusLabel.Hide();
            System.Windows.Forms.Button btnScoruri = (System.Windows.Forms.Button)sender;
            selectedScorID = (int)btnScoruri.Tag;

            SqlDataReader drm;
            string loadScoruri = "SELECT M.Secunda_marcarii, (SELECT E.Nume From Echipe E LEFT JOIN Coechipieri C \n"+
                "ON E.ID_Echipa = C.ID_Echipa WHERE C.ID_Coechipier = M.ID_Marcant),M.ID_Marcare \n" +
               "FROM Marcari M RIGHT JOIN Scor S ON M.ID_Scor = S.ID_Scor\n" +
               "WHERE S.ID_Scor = '" + selectedScorID + "'";
            SqlCommand cmdM = new SqlCommand(loadScoruri);
            flowLayoutPanelMarcari.Controls.Clear();
            cmdM.Connection = conM;

            conM.Open();
            drm = cmdM.ExecuteReader();

            while (drm.Read())
            {
                if (drm.IsDBNull(0) == true || drm.IsDBNull(1) == true)
                    break;
                System.Windows.Forms.Button btnMarcari = new System.Windows.Forms.Button();
                btnMarcari.Text = drm.GetTimeSpan(0).ToString() + " - " + drm.GetString(1);
                btnMarcari.Tag = drm.GetInt32(2);
                btnMarcari.Width = 200;
                flowLayoutPanelMarcari.Controls.Add(btnMarcari);
                btnMarcari.Click += BtnMarcari_Click;

            }
            drm.Close();
            conM.Close();
        }

        private void BtnMarcari_Click(object sender, EventArgs e)
        {
            buttonModify.Show();
            buttonDelete.Show();
            comboBoxMarcant.Show();
            labelMarcant.Show();
            numericPuncte.Show();
            labelPuncte.Show();
            timeMarcare.Show();
            labelTime.Show();
            System.Windows.Forms.Button btnMarcari = (System.Windows.Forms.Button)sender;
           selectedMarcareID = (int)btnMarcari.Tag;
            SqlDataReader drm;
            string loadMarcari = "SELECT  C.Nume ,C.Prenume,(SELECT E.Nume FROM Echipe E RIGHT JOIN Coechipieri C ON\n"+
                " E.ID_Echipa = C.ID_Echipa WHERE C.ID_Coechipier = M.ID_Marcant),M.Punctaj,M.Secunda_marcarii\n" +
                "FROM Marcari M LEFT JOIN Coechipieri C ON M.ID_Marcant = C.ID_Coechipier WHERE M.ID_Marcare = '" + selectedMarcareID + "'";
            SqlCommand commandDisplayMarcare = new SqlCommand(loadMarcari,conM);
            conM.Open();
            drm = commandDisplayMarcare.ExecuteReader();
            while(drm.Read())
            {

                comboBoxMarcant.Text = drm.GetString(0) + " " + drm.GetString(1) + " - " + drm.GetString(2);
                numericPuncte.Value= drm.GetInt32(3);
                timeMarcare.Text = drm.GetTimeSpan(4).ToString();

            }
            drm.Close();
            conM.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frmMain = new Form3();
            this.Hide();
            frmMain.Show();
        }

        private void flowLayoutPanelMeciuri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMarcareNoua_Click(object sender, EventArgs e)
        {
            
            if(comboBoxMarcant.Text == "")
            {
                ErrorLabel.Text = "Eroare: nu a fost ales un marcant.";
                ErrorLabel.Show();
                return;
            
            }
            if (numericPuncte.Value == 0)
            {
                ErrorLabel.Text = "Eroare: o marcare trebuie sa adauge scor.";
                ErrorLabel.Show();
                return;

            }
            if (timeMarcare.Value.ToString() == "")
            {
                ErrorLabel.Text = "Eroare: nu s-a ales timpul marcarii.";
                ErrorLabel.Show();
                return;

            }

            SqlCommand addMarcare = new SqlCommand();
            addMarcare.CommandText = "INSERT INTO Marcari (ID_Marcant,ID_Scor,Punctaj,Secunda_marcarii)\n" +
                "VALUES('" + listIDCoechipieri[comboBoxMarcant.SelectedIndex] + "'," +
                "'"+selectedScorID+"',"+
                "'" + numericPuncte.Value + "'," +
                "'" + timeMarcare.Value.ToString("hh:mm:ss") + "')";
            addMarcare.Connection = conM;
            conM.Open();
            addMarcare.ExecuteNonQuery();
            StatusLabel.Text = "Marcarea a fost adaugata.";
            StatusLabel.Show();
            SqlDataReader drm;
            string loadMarcari = "SELECT M.Secunda_marcarii, (SELECT E.Nume From Echipe E LEFT JOIN Coechipieri C ON E.ID_Echipa = C.ID_Echipa WHERE C.ID_Coechipier = M.ID_Marcant),M.ID_Marcare \n" +
               "FROM Marcari M RIGHT JOIN Scor S ON M.ID_Scor = S.ID_Scor\n" +
               "WHERE S.ID_Scor = '" + selectedScorID + "'";
            SqlCommand cmdM = new SqlCommand(loadMarcari);
            flowLayoutPanelMarcari.Controls.Clear();
            cmdM.Connection = conM;
            drm = cmdM.ExecuteReader();

            while (drm.Read())
            {
                System.Windows.Forms.Button btnMarcari = new System.Windows.Forms.Button();
                btnMarcari.Text = drm.GetTimeSpan(0).ToString() + " - " + drm.GetString(1);
                btnMarcari.Tag = drm.GetInt32(2);
                btnMarcari.Width = 200;
                flowLayoutPanelMarcari.Controls.Add(btnMarcari);
                btnMarcari.Click += BtnMarcari_Click;

            }
            drm.Close();
            string updateScor = "UPDATE Scor \n" +
                "SET Scor_1 = (SELECT SUM(M.Punctaj) FROM Marcari M LEFT JOIN Coechipieri C ON M.ID_Marcant = C.ID_Coechipier WHERE C.ID_Echipa = (SELECT M2.ID_Echipa1 FROM Meciuri M2 WHERE M2.ID_Meci = '" + selectedMeciID + "') AND M.ID_Scor = '" + selectedScorID+"' ),\n" +
                "Scor_2 = (SELECT SUM(M.Punctaj) FROM Marcari M LEFT JOIN Coechipieri C ON M.ID_Marcant = C.ID_Coechipier WHERE C.ID_Echipa = (SELECT M2.ID_Echipa2 FROM Meciuri M2 WHERE M2.ID_Meci = '" + selectedMeciID + "') AND M.ID_Scor = '" + selectedScorID+"')\n" +
            "WHERE ID_Meci = '" + selectedMeciID + "'";
            cmdM = new SqlCommand(updateScor);
            cmdM.Connection = conM;
            cmdM.ExecuteNonQuery();

            string checkScor = "SELECT S.Scor_1, S.Scor_2 \n" +
                "FROM Scor S \n" +
                 "WHERE S.ID_Meci = '" + selectedMeciID + "'";
            SqlCommand cmdS = new SqlCommand(checkScor, conM);
            drm = cmdS.ExecuteReader();
            while (drm.Read())
            {
                if (drm.IsDBNull(0) == true)
                {
                    updateScor = "UPDATE Scor SET Scor_1 = 0 WHERE ID_Meci = '" + selectedMeciID + "'";
                    cmdM = new SqlCommand(updateScor, conS);
                    conS.Open();
                    cmdM.ExecuteNonQuery();
                    conS.Close();
                }
                if (drm.IsDBNull(1) == true)
                {
                    updateScor = "UPDATE Scor SET Scor_2 = 0 WHERE ID_Meci = '" + selectedMeciID + "'";
                    cmdM = new SqlCommand(updateScor, conS);
                    conS.Open();
                    cmdM.ExecuteNonQuery();
                    conS.Close();
                }

            }
            drm.Close();

            string loadScor = "SELECT S.Scor_1, S.Scor_2, S.ID_Scor  \n" +
                  "FROM Scor S \n" +
                  "WHERE S.ID_Meci = '" + selectedMeciID + "'";
            cmdM = new SqlCommand(loadScor);

            cmdM.Connection = conM;

            drm = cmdM.ExecuteReader();
            flowLayoutPanelScor.Controls.Clear();
            while (drm.Read())
            {
                if (drm.IsDBNull(0) == true || drm.IsDBNull(1) == true)
                    break;
                System.Windows.Forms.Button btnMarcari = new System.Windows.Forms.Button();
                btnMarcari.Text = drm.GetInt32(0).ToString() + " - " + drm.GetInt32(1).ToString();
                btnMarcari.Tag = drm.GetInt32(2);
                btnMarcari.Width = 200;
                flowLayoutPanelScor.Controls.Add(btnMarcari);
                btnMarcari.Click += BtnScoruri_Click;

            }
            drm.Close();
            conM.Close();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormScoruri_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddScor_Click(object sender, EventArgs e)
        {
            SqlCommand addScor = new SqlCommand();
            addScor.CommandText = "INSERT INTO Scor (ID_Meci,Scor_1,Scor_2)" +
                "VALUES('"+selectedMeciID+"',0,0)";
            addScor.Connection = conM;
            conM.Open();
            addScor.ExecuteNonQuery();
            SqlDataReader drm;
            string loadScor = "SELECT S.Scor_1, S.Scor_2, S.ID_Scor  \n" +
               "FROM Scor S \n" +
               "WHERE S.ID_Meci = '" + selectedMeciID + "'";
            SqlCommand cmdM = new SqlCommand(loadScor);
            
            cmdM.Connection = conM;
            drm = cmdM.ExecuteReader();
            flowLayoutPanelScor.Controls.Clear();
            while (drm.Read())
            {
                System.Windows.Forms.Button btnMarcari = new System.Windows.Forms.Button();
                btnMarcari.Text = drm.GetInt32(0).ToString() + " - " + drm.GetInt32(1).ToString();
                btnMarcari.Tag = drm.GetInt32(2);
                btnMarcari.Width = 200;
                flowLayoutPanelScor.Controls.Add(btnMarcari);
                btnMarcari.Click += BtnMeciuri_Click;

            }
            drm.Close();

            conM.Close();

        }
        int scorDeleteConfirm = 0;
        private void buttonScorDelete_Click(object sender, EventArgs e)
        {
            if(scorDeleteConfirm == 0) 
            {
                scorDeleteConfirm = 1;
                buttonScorDelete.Text = "Confirma";
                return;
            
            }else
            {
                scorDeleteConfirm= 0;
                buttonScorDelete.Hide();
                buttonScorDelete.Text = "Sterge scor";
                SqlCommand deleteScor = new SqlCommand();
                   deleteScor.CommandText = "DELETE FROM Scor \n" +
                    "WHERE ID_Scor = '"+selectedScorID+"'";
                deleteScor.Connection = conM;
                conM.Open();
                deleteScor.ExecuteNonQuery();
                SqlDataReader drm;
                string loadScor = "SELECT S.Scor_1, S.Scor_2, S.ID_Scor  \n" +
                   "FROM Scor S \n" +
                   "WHERE S.ID_Meci = '" + selectedMeciID + "'";
                SqlCommand cmdM = new SqlCommand(loadScor,conM);
                drm = cmdM.ExecuteReader();
                flowLayoutPanelScor.Controls.Clear();
                while (drm.Read())
                {
                    System.Windows.Forms.Button btnMarcari = new System.Windows.Forms.Button();
                    btnMarcari.Text = drm.GetInt32(0).ToString() + " - " + drm.GetInt32(1).ToString();
                    btnMarcari.Tag = drm.GetInt32(2);
                    btnMarcari.Width = 200;
                    flowLayoutPanelScor.Controls.Add(btnMarcari);
                    btnMarcari.Click += BtnScoruri_Click;

                }
                drm.Close();
                conM.Close();

            }

        }

        int marcareDeleteConfirm;
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (marcareDeleteConfirm == 0)
            {
                marcareDeleteConfirm = 1;
                buttonDelete.Text = "Confirma";
                return;

            }
            else
            {
                marcareDeleteConfirm = 0;
                buttonDelete.Hide();
                buttonDelete.Text = "Sterge";
                SqlCommand deleteMarcare = new SqlCommand();
                deleteMarcare.CommandText = "DELETE FROM Marcari \n" +
                 "WHERE ID_Marcare = '" + selectedMarcareID  + "'";
                deleteMarcare.Connection = conM;
                conM.Open();
                deleteMarcare.ExecuteNonQuery();
                comboBoxMarcant.Hide();
                labelMarcant.Hide();
                numericPuncte.Hide();
                labelPuncte.Hide();
                timeMarcare.Hide();
                labelTime.Hide();
                SqlDataReader drm;
                string loadMarcari = "SELECT M.Secunda_marcarii, (SELECT E.Nume From Echipe E LEFT JOIN Coechipieri C ON E.ID_Echipa = C.ID_Echipa WHERE C.ID_Coechipier = M.ID_Marcant),M.ID_Marcare \n" +
                   "FROM Marcari M RIGHT JOIN Scor S ON M.ID_Scor = S.ID_Scor\n" +
                   "WHERE S.ID_Scor = '" + selectedScorID + "'";
                SqlCommand cmdM = new SqlCommand(loadMarcari);
                flowLayoutPanelMarcari.Controls.Clear();
                cmdM.Connection = conM;

                drm = cmdM.ExecuteReader();

                while (drm.Read())
                {
                    System.Windows.Forms.Button btnMarcari = new System.Windows.Forms.Button();
                    btnMarcari.Text = drm.GetTimeSpan(0).ToString() + " - " + drm.GetString(1);
                    btnMarcari.Tag = drm.GetInt32(2);
                    btnMarcari.Width = 200;
                    flowLayoutPanelMarcari.Controls.Add(btnMarcari);
                    btnMarcari.Click += BtnMarcari_Click;

                }
                drm.Close();
                string updateScor = "UPDATE Scor \n" +
                   "SET Scor_1 = (SELECT SUM(M.Punctaj) FROM Marcari M LEFT JOIN Coechipieri C ON M.ID_Marcant = C.ID_Coechipier WHERE C.ID_Echipa = (SELECT M2.ID_Echipa1 FROM Meciuri M2 WHERE M2.ID_Meci = '" + selectedMeciID + "') AND M.ID_Scor = '" + selectedScorID+"'),\n" +
                   "Scor_2 = (SELECT SUM(M.Punctaj) FROM Marcari M LEFT JOIN Coechipieri C ON M.ID_Marcant = C.ID_Coechipier WHERE C.ID_Echipa = (SELECT M2.ID_Echipa2 FROM Meciuri M2 WHERE M2.ID_Meci = '" + selectedMeciID + "') AND M.ID_Scor = '" + selectedScorID+"')\n" +
                   "WHERE ID_Meci = '" + selectedMeciID + "'";
                cmdM = new SqlCommand(updateScor);
                cmdM.Connection = conM;
                cmdM.ExecuteNonQuery();
                string checkScor = "SELECT S.Scor_1, S.Scor_2 \n" +
                    "FROM Scor S \n" +
                    "WHERE S.ID_Meci = '" + selectedMeciID + "'";
                SqlCommand cmdS = new SqlCommand(checkScor, conM);
                drm = cmdS.ExecuteReader();
                while (drm.Read())
                {
                    if (drm.IsDBNull(0) == true)
                    {
                        updateScor = "UPDATE Scor SET Scor_1 = 0 WHERE ID_Meci = '" + selectedMeciID + "'";
                        cmdM = new SqlCommand(updateScor, conS);
                        conS.Open();
                        cmdM.ExecuteNonQuery();
                        conS.Close();

                    }
                    if (drm.IsDBNull(1) == true)
                    {
                        updateScor = "UPDATE Scor SET Scor_2 = 0 WHERE ID_Meci = '" + selectedMeciID + "'";
                        cmdM = new SqlCommand(updateScor, conS);
                        conS.Open();
                        cmdM.ExecuteNonQuery();
                        conS.Close();
                    }

                }
                drm.Close();
                string loadScor = "SELECT S.Scor_1, S.Scor_2, S.ID_Scor  \n" +
                  "FROM Scor S \n" +
                  "WHERE S.ID_Meci = '" + selectedMeciID + "'";
                cmdM = new SqlCommand(loadScor);

                cmdM.Connection = conM;

                drm = cmdM.ExecuteReader();
                flowLayoutPanelScor.Controls.Clear();
                while (drm.Read())
                {
                    if (drm.IsDBNull(0) == true || drm.IsDBNull(1) == true)
                        break;
                    System.Windows.Forms.Button btnMarcari = new System.Windows.Forms.Button();
                    btnMarcari.Text = drm.GetInt32(0).ToString() + " - " + drm.GetInt32(1).ToString();
                    btnMarcari.Tag = drm.GetInt32(2);
                    btnMarcari.Width = 200;
                    flowLayoutPanelScor.Controls.Add(btnMarcari);
                    btnMarcari.Click += BtnScoruri_Click;

                }
                drm.Close();
                conM.Close();

            }
        }

        private void timeMarcare_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (comboBoxMarcant.Text == "")
            {
                ErrorLabel.Text = "Eroare: nu a fost ales un marcant.";
                ErrorLabel.Show();
                return;

            }
            if (numericPuncte.Value == 0)
            {
                ErrorLabel.Text = "Eroare: o marcare trebuie sa adauge scor.";
                ErrorLabel.Show();
                return;

            }
            if (timeMarcare.Value.ToString() == "")
            {
                ErrorLabel.Text = "Eroare: nu s-a ales timpul marcarii.";
                ErrorLabel.Show();
                return;

            }

            SqlCommand updateMarcare = new SqlCommand();
            updateMarcare.CommandText = "UPDATE Marcari \n" +
                "SET ID_Marcant =  '" + listIDCoechipieri[comboBoxMarcant.SelectedIndex] + "',\n" +
                "Punctaj = '" + numericPuncte.Value + "',\n" +
                "Secunda_marcarii = '"+timeMarcare.Value.ToString("hh:mm:ss")+"'\n" +
                "WHERE ID_Marcare ='"+selectedMarcareID+"'";

            updateMarcare.Connection = conM;
            conM.Open();
            updateMarcare.ExecuteNonQuery();
            StatusLabel.Text = "Marcarea a fost modificata.";

            StatusLabel.Show();
            comboBoxMarcant.Hide();
            labelMarcant.Hide();
            numericPuncte.Hide();
            labelPuncte.Hide();
            timeMarcare.Hide();
            labelTime.Hide();
            SqlDataReader drm;
            string loadMarcari = "SELECT M.Secunda_marcarii, (SELECT E.Nume From Echipe E LEFT JOIN Coechipieri C ON E.ID_Echipa = C.ID_Echipa WHERE C.ID_Coechipier = M.ID_Marcant),M.ID_Marcare \n" +
               "FROM Marcari M RIGHT JOIN Scor S ON M.ID_Scor = S.ID_Scor\n" +
               "WHERE S.ID_Scor = '" + selectedScorID + "'";
            SqlCommand cmdM = new SqlCommand(loadMarcari);
            flowLayoutPanelMarcari.Controls.Clear();
            cmdM.Connection = conM;

            drm = cmdM.ExecuteReader();

            while (drm.Read())
            {
                System.Windows.Forms.Button btnMarcari = new System.Windows.Forms.Button();
                btnMarcari.Text = drm.GetTimeSpan(0).ToString() + " - " + drm.GetString(1);
                btnMarcari.Tag = drm.GetInt32(2);
                btnMarcari.Width = 200;
                flowLayoutPanelMarcari.Controls.Add(btnMarcari);
                btnMarcari.Click += BtnMarcari_Click;

            }
            drm.Close();
            string updateScor = "UPDATE Scor \n" +
                "SET Scor_1 = (SELECT SUM(M.Punctaj) FROM Marcari M LEFT JOIN Coechipieri C ON M.ID_Marcant = C.ID_Coechipier WHERE C.ID_Echipa = (SELECT M2.ID_Echipa1 FROM Meciuri M2 WHERE M2.ID_Meci = '" + selectedMeciID + "') AND M.ID_Scor = '"+selectedScorID+"'),\n" +
                "Scor_2 = (SELECT SUM(M.Punctaj) FROM Marcari M LEFT JOIN Coechipieri C ON M.ID_Marcant = C.ID_Coechipier WHERE C.ID_Echipa = (SELECT M2.ID_Echipa2 FROM Meciuri M2 WHERE M2.ID_Meci = '" + selectedMeciID + "')AND M.ID_Scor = '"+selectedScorID+"')\n" +
                "WHERE ID_Meci = '" + selectedMeciID + "'";
            cmdM = new SqlCommand(updateScor);
            cmdM.Connection = conM;
            cmdM.ExecuteNonQuery();
            string checkScor = "SELECT S.Scor_1, S.Scor_2 \n" +
                  "FROM Scor S \n" +
                  "WHERE S.ID_Meci = '" + selectedMeciID + "'";
            SqlCommand cmdS = new SqlCommand(checkScor,conM);
            drm = cmdS.ExecuteReader();
            
            while (drm.Read())
            {
                if(drm.IsDBNull(0) == true)
                {
                   updateScor = "UPDATE Scor SET Scor_1 = 0 WHERE ID_Meci = '" + selectedMeciID + "'";
                    cmdM = new SqlCommand(updateScor,conS);
                    conS.Open();
                    cmdM.ExecuteNonQuery();
                    conS.Close();

                }
                if (drm.IsDBNull(1) == true)
                {
                    updateScor = "UPDATE Scor SET Scor_2 = 0 WHERE ID_Meci = '" + selectedMeciID + "'";
                    cmdM = new SqlCommand(updateScor, conS);
                    conS.Open();
                    cmdM.ExecuteNonQuery();
                    conS.Close();
                }

            }
            drm.Close();
            string loadScor = "SELECT S.Scor_1, S.Scor_2, S.ID_Scor  \n" +
                  "FROM Scor S \n" +
                  "WHERE S.ID_Meci = '" + selectedMeciID + "'";
            cmdM = new SqlCommand(loadScor);

            cmdM.Connection = conM;

            drm = cmdM.ExecuteReader();
            flowLayoutPanelScor.Controls.Clear();
            while (drm.Read())
            {
                if (drm.IsDBNull(0) == true || drm.IsDBNull(1) == true)
                    break;
                System.Windows.Forms.Button btnMarcari = new System.Windows.Forms.Button();
                btnMarcari.Text = drm.GetInt32(0).ToString() + " - " + drm.GetInt32(1).ToString();
                btnMarcari.Tag = drm.GetInt32(2);
                btnMarcari.Width = 200;
                flowLayoutPanelScor.Controls.Add(btnMarcari);
                btnMarcari.Click += BtnScoruri_Click;

            }
            drm.Close();
            conM.Close();
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
                    "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci WHERE\n"+
                    " (M1.ID_Echipa1 = M.ID_Echipa1 AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = M.ID_Echipa2 AND S1.Scor_2 > S1.Scor_1)) ASC";
            }
            if (comboBoxFind.SelectedIndex == 5)
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
                    "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci WHERE\n"+
                    " (M1.ID_Echipa1 = M.ID_Echipa1 AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = M.ID_Echipa2 AND S1.Scor_2 > S1.Scor_1)) ASC";
            }
            if (comboBoxFind.SelectedIndex == 6)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
                   "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                   "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                   "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                   "ORDER BY (SELECT SUM(M2.Punctaj) FROM Marcari M2 LEFT JOIN Coechipieri C ON M2.ID_Marcant = C.ID_Coechipier WHERE\n"+
                   "C.ID_Echipa IN (SELECT DISTINCT E.ID_Echipa FROM Echipe E WHERE E.ID_Echipa = M.ID_Echipa1 OR E.ID_Echipa = M.ID_Echipa2) ) ASC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + " E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                    "ORDER BY (SELECT SUM(M2.Punctaj) FROM Marcari M2 LEFT JOIN Coechipieri C ON M2.ID_Marcant = C.ID_Coechipier WHERE\n"+
                    " C.ID_Echipa IN (SELECT DISTINCT E.ID_Echipa FROM Echipe E WHERE E.ID_Echipa = M.ID_Echipa1 OR E.ID_Echipa = M.ID_Echipa2) ) ASC";
            }
            if (comboBoxFind.SelectedIndex == 7)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT E1.Nume, E2.Nume, M.ID_Meci \n" +
                     "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                   "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                   "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                   "ORDER BY (SELECT SUM(M2.Punctaj) FROM Marcari M2 LEFT JOIN Coechipieri C ON M2.ID_Marcant = C.ID_Coechipier \n"+
                   "WHERE C.ID_Echipa IN (SELECT DISTINCT E.ID_Echipa FROM Echipe E WHERE E.ID_Echipa = M.ID_Echipa1 \n"+
                   "OR E.ID_Echipa = M.ID_Echipa2) ) DESC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + " E1.Nume, E2.Nume, M.ID_Meci \n" +
                    "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
                    "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
                    "GROUP BY  E1.Nume, E2.Nume, M.ID_Meci, M.ID_Echipa1,M.ID_Echipa2\n" +
                    "ORDER BY (SELECT SUM(M2.Punctaj) FROM Marcari M2 LEFT JOIN Coechipieri C ON M2.ID_Marcant = C.ID_Coechipier \n"+
                    "WHERE C.ID_Echipa IN (SELECT DISTINCT E.ID_Echipa FROM Echipe E WHERE E.ID_Echipa = M.ID_Echipa1 \n"+
                    "OR E.ID_Echipa = M.ID_Echipa2 ) ) DESC";
            }

            SqlDataReader drm;

            SqlCommand cmdM = new SqlCommand(cmdFind);

            cmdM.Connection = conM;

            conM.Open();
            int i = 0;
            drm = cmdM.ExecuteReader();
            flowLayoutPanelMeciuri.Controls.Clear();
            while (drm.Read())
            {



                System.Windows.Forms.Button btnMeciuri = new System.Windows.Forms.Button();
                btnMeciuri.Text = drm.GetString(i) + "-" + drm.GetString(i + 1);
                i += 2;
                btnMeciuri.Tag = drm.GetInt32(i);

                i = 0;
                btnMeciuri.Width = 200;
                flowLayoutPanelMeciuri.Controls.Add(btnMeciuri);
                btnMeciuri.Click += BtnMeciuri_Click;





            }
            drm.Close();

            conM.Close();
        }
    }
}
