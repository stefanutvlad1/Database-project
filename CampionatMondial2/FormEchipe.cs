using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CampionatMondial2
{
    public partial class FormEchipe : Form
    {
        int CoechipierID;
        int CoechipierTipInitial;
        int IDelete = 0;
        int [] antrenorIDList = {1,2,3,4,5,6,7,8,9,10};
        int antrenorIDIndex = 0;
        string[] coechipierTipList = { "Detinator", "Antrenor", "Mijlocas", "Atacant", "Portar" };

        SqlConnection conE = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");
        string cmdFind = "SELECT Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Nume\n" +
               "ORDER BY Nume ASC";

        public FormEchipe()
        {
            InitializeComponent();

            CastiguriEchipa.Hide();
            PierderiEchipa.Hide();
            LabelCoechipieri.Hide();

            label3.Hide();
            label4.Hide(); 
            label5.Hide(); 
            label6.Hide();
            label7.Hide();
            label8.Hide();

            textBox1.Hide();
            textBox2.Hide();
            comboBox1.Hide();
            textBox3.Hide();
            textBox4.Hide();
            comboBox2.Hide();

            button2.Hide();
            button3.Hide();
            button6.Hide(); 

            StatusLabel.Hide();
            ErrorLabel.Hide();

            SqlDataReader drm;

            SqlCommand cmdE = new SqlCommand(cmdFind);

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

        private void Btn_Click2(object sender, EventArgs e)
        {
            ErrorLabel.Hide();
            StatusLabel.Hide();

            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            CoechipierID = (int)btn.Tag;

            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();

            textBox1.Show();
            textBox2.Show();
            comboBox1.Show();
            textBox3.Show();
            textBox4.Show();
            comboBox2.Show();
            button3.Show();
            button2.Show();

            SqlDataReader drm;
            SqlConnection conC = conE;
            string loadCoechipier = "SELECT C.Nume, C.Prenume, C.ID_Coechipier\n" +
            "FROM Coechipieri  C RIGHT JOIN Echipe E ON C.ID_Echipa = E.ID_Echipa\n" +
            "WHERE E.Nume = '" + comboBoxEchipa.Text + "' AND C.Tip = 1 ";

            comboBox1.Items.Clear();
            int i;
            for (i = 0; i < coechipierTipList.Length; i++)
            {
                comboBox1.Items.Add(coechipierTipList[i]);
            }

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

            loadCoechipier = "SELECT Tip \n" +
            "FROM Coechipieri WHERE ID_Coechipier = '"+CoechipierID+"'";
            
            cmdC = new SqlCommand(loadCoechipier, conC);

            drm = cmdC.ExecuteReader();
            drm.Read();
            CoechipierTipInitial = drm.GetInt32(0);
            if (CoechipierTipInitial <= 1)
            {
                comboBox2.Hide();
                label8.Hide();
            }
            else
            {
                drm.Close() ;
                loadCoechipier = "SELECT TOP 1 C.Nume, C.Prenume \n" +
                "FROM Coechipieri  C LEFT JOIN Coechipieri C2 ON C.ID_Coechipier = C2.ID_Antrenor WHERE C2.ID_Coechipier = '"+CoechipierID+"' ";

                cmdC = new SqlCommand(loadCoechipier, conC);
                drm = cmdC.ExecuteReader();
                if (drm.Read())
                {
                    comboBox2.Text = drm.GetString(0) + " " + drm.GetString(1);

                }

            }
            drm.Close();

            loadCoechipier = "SELECT Nume, Prenume, Tip, Castiguri, Pierderi\n" +
                "FROM Coechipieri WHERE ID_Coechipier = '" +CoechipierID+ "'";

            cmdC = new SqlCommand(loadCoechipier, conC);
            drm = cmdC.ExecuteReader();
            drm.Read();
            textBox1.Text = drm.GetString(0);
            textBox2.Text = drm.GetString(1);
            comboBox1.Text = coechipierTipList[drm.GetInt32(2)];
            textBox3.Text = drm.GetInt32(3).ToString();
            textBox4.Text = drm.GetInt32(4).ToString();
            conC.Close();
            drm.Close();

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEchipe_Load(object sender, EventArgs e)
        {            

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void comboBoxEchipa_SelectedIndexChanged(object sender, EventArgs e)
        {
            button6.Show();
            button1.Show();
            ErrorLabel.Hide();
            StatusLabel.Hide();

            CastiguriEchipa.Show();
            PierderiEchipa.Show();
            LabelCoechipieri.Show();

            SqlDataReader drm;

            string loadEchipa = "SELECT Castiguri, Pierderi\n" +
                "FROM Echipe WHERE Nume = '"+comboBoxEchipa.Text+"'";

            SqlCommand cmdE = new SqlCommand(loadEchipa, conE);
            conE.Open();
            drm = cmdE.ExecuteReader();
            drm.Read();
            CastiguriEchipa.Text ="Castiguri: " + drm.GetInt32(0).ToString();
            PierderiEchipa.Text ="Pierderi: " + drm.GetInt32(1).ToString();
            conE.Close();

            loadEchipa = "SELECT C.Nume, C.Prenume, C.ID_Coechipier \n" +
            "FROM Coechipieri  C LEFT JOIN Echipe E ON C.ID_Echipa = E.ID_Echipa WHERE E.Nume = '"+comboBoxEchipa.Text +"' ";

            cmdE = new SqlCommand(loadEchipa, conE);

            conE.Open();
            drm = cmdE.ExecuteReader();
            flowLayoutPanel1.Controls.Clear();
            while (drm.Read())
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = drm.GetString(0) + " " + drm.GetString(1);
                btn.Tag = drm.GetInt32(2);
                btn.Width = 200;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click2;

            }
            drm.Close();

            conE.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frmMain = new Form3();
            this.Hide();
            frmMain.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text != "Antrenor" && comboBox1.Text != "Detinator" )
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

        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBoxEchipa.Text == "")
            {
                ErrorLabel.Show();
                ErrorLabel.Text = "Eroare: Nu s-a gasit o echipa selectata.";
                return;
            }



            if (IDelete == 0)
            {
                button2.Text = "Confirma";
                IDelete = 1;
                return;

            }

            if (IDelete == 1)
            {
   
                SqlCommand commandDelete = new SqlCommand();
                commandDelete.CommandText = "DELETE FROM Coechipieri\n" +
                   "WHERE ID_Coechipier = '"+CoechipierID+"' ";

                commandDelete.Connection = conE;

                conE.Open();
                commandDelete.ExecuteNonQuery();

                StatusLabel.Show();
                StatusLabel.Text = "Coechipierul a fost sters din baza de date.";
                button2.Hide();
                button3.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();

                textBox1.Hide();
                textBox2.Hide();
                comboBox1.Hide();
                textBox3.Hide();
                textBox4.Hide();
                comboBox2.Hide();
                button3.Hide();

                conE.Close();

                IDelete = 0;

                flowLayoutPanel1.Controls.Clear();

                string loadEchipa = "SELECT C.Nume, C.Prenume, C.ID_Coechipier \n" +
                "FROM Coechipieri  C LEFT JOIN Echipe E ON C.ID_Echipa = E.ID_Echipa WHERE E.Nume = '"+comboBoxEchipa.Text+"' ";

                SqlDataReader dre;
                SqlCommand cmdE = new SqlCommand(loadEchipa, conE);

                conE.Open();
                dre = cmdE.ExecuteReader();
                flowLayoutPanel1.Controls.Clear();
                while (dre.Read())
                {
                    System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                    btn.Text = dre.GetString(0) + " " + dre.GetString(1);
                    btn.Tag = dre.GetInt32(2);
                    btn.Width = 200;
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += Btn_Click2;

                }
                dre.Close();

                conE.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tipIndex;
            for(tipIndex = 0; tipIndex<coechipierTipList.Length;tipIndex++ )
            {
                if(comboBox1.Text == coechipierTipList[tipIndex])
                {
                    break;
                }

            }
            if (tipIndex != 1 && CoechipierTipInitial == 1)
            {
                SqlCommand commandUnassignTrainer = new SqlCommand();
                commandUnassignTrainer.CommandText = "UPDATE Coechipieri\n" +
                    "SET ID_Antrenor = NULL\n" +
                    "WHERE ID_Antrenor = '" + CoechipierID + "'";
                commandUnassignTrainer.Connection= conE;
                conE.Open();
                commandUnassignTrainer.ExecuteNonQuery();
                conE.Close();
            }
            if (tipIndex != 0 && CoechipierTipInitial == 0)
            {
                SqlCommand commandUnassignOwner = new SqlCommand();
                commandUnassignOwner.CommandText = "UPDATE Echipe\n" +
                    "SET ID_Detinator = NULL\n" +
                    "WHERE ID_Detinator = '" + CoechipierID + "' AND Nume LIKE '"+comboBoxEchipa.Text+"'";
                commandUnassignOwner.Connection = conE;
                conE.Open();
                commandUnassignOwner.ExecuteNonQuery();
                conE.Close();
            }
            if (tipIndex == 0)
            {
                SqlCommand commandAssignOwner = new SqlCommand();
                commandAssignOwner.CommandText = "UPDATE Echipe\n" +
                    "SET ID_Detinator = '"+ CoechipierID+"'\n" +
                    "WHERE ID_Detinator = NULL AND Nume LIKE '" + comboBoxEchipa.Text + "'";
                commandAssignOwner.Connection = conE;
                conE.Open();
                commandAssignOwner.ExecuteNonQuery();
                conE.Close();
            }

            SqlCommand commandModify = new SqlCommand();
            commandModify.CommandText = "UPDATE Coechipieri\n" +
                "SET ID_Antrenor = (SELECT TOP 1 C2.ID_Coechipier FROM Coechipieri C2 WHERE C2.ID_Coechipier  = '" + antrenorIDList[antrenorIDIndex] +"'),\n" +
                "Tip = '" + tipIndex + "',\n" +
                "Nume = '" + textBox1.Text + "',\n" +
                "Prenume = '" + textBox2.Text + "',\n" +
                "Castiguri = '" + textBox3.Text + "',\n" +
                "Pierderi = '" + textBox4.Text + "'\n" +
               "WHERE ID_Coechipier = '" + CoechipierID + "'";
            

            commandModify.Connection = conE;

            conE.Open();
            commandModify.ExecuteNonQuery();

            StatusLabel.Show();
            StatusLabel.Text = "Datele coechipierului au fost modificate.";
            button2.Hide();
            button3.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();

            textBox1.Hide();
            textBox2.Hide();
            comboBox1.Hide();
            textBox3.Hide();
            textBox4.Hide();
            comboBox2.Hide();
            button3.Hide();

            conE.Close();

            IDelete = 0;

            flowLayoutPanel1.Controls.Clear();

            string loadEchipa = "SELECT C.Nume, C.Prenume, C.ID_Coechipier \n" +
            "FROM Coechipieri  C LEFT JOIN Echipe E ON C.ID_Echipa = E.ID_Echipa WHERE E.Nume = '" + comboBoxEchipa.Text + "' ";
            SqlDataReader dre;
            SqlCommand cmdE = new SqlCommand(loadEchipa, conE);
            conE.Open();
            dre = cmdE.ExecuteReader();
 
            flowLayoutPanel1.Controls.Clear();
            while (dre.Read())
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = dre.GetString(0) + " " + dre.GetString(1);
                btn.Tag = dre.GetInt32(2);
                btn.Width = 200;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click2;

            }
            dre.Close();

            conE.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newCoechipier = new FormCoechipierNou();
            newCoechipier.Show();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            antrenorIDIndex = comboBox2.SelectedIndex;
        }

        int deleteConfirm = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if(deleteConfirm == 0)
            {
                deleteConfirm= 1;
                button6.Text = "Confirma";
                return;

            }
            else
            {
                SqlDataReader drm;
                deleteConfirm = 0;
                SqlCommand commandDeleteTeam = new SqlCommand();
                SqlCommand commandRefreshTeam = new SqlCommand();

                commandRefreshTeam.CommandText = "SELECT Nume FROM Echipe";
                commandDeleteTeam.CommandText = "DELETE FROM Echipe\n" +
                    "WHERE Nume LIKE '"+comboBoxEchipa.Text+"'";

                commandDeleteTeam.Connection = conE;
                commandRefreshTeam.Connection = conE;

                comboBoxEchipa.Items.Clear();
                conE.Open();
                commandDeleteTeam.ExecuteNonQuery();
                drm = commandRefreshTeam.ExecuteReader();

                while (drm.Read())
                {

                    comboBoxEchipa.Items.Add(drm.GetString(0));


                }
                drm.Close();
                conE.Close();
                CastiguriEchipa.Hide();
                PierderiEchipa.Hide();
                LabelCoechipieri.Hide();

                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();

                textBox1.Hide();
                textBox2.Hide();
                comboBox1.Hide();
                textBox3.Hide();
                textBox4.Hide();
                comboBox2.Hide();

                button2.Hide();
                button3.Hide();
                button6.Hide();
                
                StatusLabel.Show();
                StatusLabel.Text = "Echipa a fost stearsa din baza de date";

                button6.Text = "Sterge echipa";

                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newEchipa = new FormEchipaNoua();
            newEchipa.Show();
        }

        private void PierderiEchipa_Click(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if(comboBoxFind.SelectedIndex == 0)
            {
                if(numericUpDownFind.Value == 0)
                    cmdFind = "SELECT Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Nume\n" +
               "ORDER BY Nume ASC";
                else
                    cmdFind = "SELECT TOP "+numericUpDownFind.Value+" Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Nume\n" +
               "ORDER BY Nume ASC";
            }
            if (comboBoxFind.SelectedIndex == 1)
            {
                if (numericUpDownFind.Value == 0)
                    cmdFind = "SELECT Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Nume\n" +
               "ORDER BY Nume DESC";
                else
                    cmdFind = "SELECT TOP " + numericUpDownFind.Value + " Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Nume\n" +
               "ORDER BY Nume DESC";
            }
            if (comboBoxFind.SelectedIndex == 2)
            {
                if (numericUpDownFind.Value == 0)
                    cmdFind = "SELECT Nume\n" +
               "FROM Echipe \n" +
               "GROUP BY Castiguri, Nume, ID_Echipa\n" +
               "ORDER BY Castiguri + (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
               "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 > S1.Scor_1)) ASC";
                else
                    cmdFind = "SELECT TOP " + numericUpDownFind.Value + " Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Castiguri, Nume\n" +
                "ORDER BY Castiguri + (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
                "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 > S1.Scor_1)) ASC";

            }
            if (comboBoxFind.SelectedIndex == 3)
            {
                if (numericUpDownFind.Value == 0)
                    cmdFind = "SELECT Nume\n" +
               "FROM Echipe \n" +
               "GROUP BY Castiguri, Nume, ID_Echipa\n" +
               "ORDER BY Castiguri + (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
               "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 > S1.Scor_1)) DESC";
                else
                    cmdFind = "SELECT TOP " + numericUpDownFind.Value + " Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Castiguri, Nume, ID_Echipa\n" +
                "ORDER BY Castiguri + (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
                "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 > S1.Scor_1)) DESC";

            }
            if (comboBoxFind.SelectedIndex == 4)
            {
                if (numericUpDownFind.Value == 0)
                    cmdFind = "SELECT Nume\n" +
               "FROM Echipe \n" +
               "GROUP BY Castiguri, Nume, ID_Echipa\n" +
               "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
               "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 > S1.Scor_1)) ASC";
                else
                    cmdFind = "SELECT TOP " + numericUpDownFind.Value + " Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Castiguri, Nume, ID_Echipa\n" +
                "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
                "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 > S1.Scor_1)) ASC";

            }
            if (comboBoxFind.SelectedIndex == 5)
            {
                if (numericUpDownFind.Value == 0)
                    cmdFind = "SELECT Nume\n" +
               "FROM Echipe \n" +
               "GROUP BY Castiguri, Nume, ID_Echipa\n" +
               "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
               "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 > S1.Scor_1))  DESC";
                else
                    cmdFind = "SELECT TOP " + numericUpDownFind.Value + " Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Castiguri, Nume, ID_Echipa\n" +
                "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
                "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 > S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 > S1.Scor_1))  DESC";

            }
            if (comboBoxFind.SelectedIndex == 6)
            {
                if (numericUpDownFind.Value == 0)
                    cmdFind = "SELECT Nume\n" +
               "FROM Echipe \n" +
               "GROUP BY Pierderi, Nume,ID_Echipa\n" +
               "ORDER BY Pierderi + (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
               "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 < S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 < S1.Scor_1)) ASC";
                else
                    cmdFind = "SELECT TOP " + numericUpDownFind.Value + " Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Pierderi, Nume,ID_Echipa\n" +
                "ORDER BY Pierderi + (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
                "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 < S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 < S1.Scor_1)) ASC";

            }
            if (comboBoxFind.SelectedIndex == 7)
            {
                if (numericUpDownFind.Value == 0)
                    cmdFind = "SELECT Nume\n" +
               "FROM Echipe \n" +
               "GROUP BY Pierderi, Nume,ID_Echipa\n" +
               "ORDER BY Pierderi + (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
               "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 < S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 < S1.Scor_1)) DESC";
                else
                    cmdFind = "SELECT TOP " + numericUpDownFind.Value + " Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Pierderi, Nume,ID_Echipa\n" +
                "ORDER BY  Pierderi + (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
                "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 < S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 < S1.Scor_1)) DESC";

            }
            if (comboBoxFind.SelectedIndex == 8)
            {
                if (numericUpDownFind.Value == 0)
                    cmdFind = "SELECT Nume\n" +
               "FROM Echipe \n" +
               "GROUP BY Pierderi, Nume,ID_Echipa\n" +
               "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
               "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 < S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 < S1.Scor_1)) ASC";
                else
                    cmdFind = "SELECT TOP " + numericUpDownFind.Value + " Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Pierderi, Nume,ID_Echipa\n" +
                "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
                "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 < S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 < S1.Scor_1)) ASC";

            }
            if (comboBoxFind.SelectedIndex == 9)
            {
                if (numericUpDownFind.Value == 0)
                    cmdFind = "SELECT Nume\n" +
               "FROM Echipe \n" +
               "GROUP BY Pierderi, Nume,ID_Echipa\n" +
               "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
               "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 < S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 < S1.Scor_1))  DESC";
                else
                    cmdFind = "SELECT TOP " + numericUpDownFind.Value + " Nume\n" +
               "FROM Echipe\n" +
               "GROUP BY Pierderi, Nume,ID_Echipa\n" +
                "ORDER BY (SELECT COUNT(S1.ID_Scor) FROM Scor S1 LEFT JOIN Meciuri M1 ON M1.ID_Meci = S1.ID_Meci \n"+
                "WHERE (M1.ID_Echipa1 = ID_Echipa AND S1.Scor_1 < S1.Scor_2) OR (M1.ID_Echipa2 = ID_Echipa AND S1.Scor_2 < S1.Scor_1))  DESC";

            }
            if (comboBoxFind.SelectedIndex == 10)
            {
                if (numericUpDownFind.Value == 0)
                    if (numericUpDownFind.Value == 0)
                        cmdFind = "SELECT E.Nume\n" +
                   "FROM Echipe E LEFT JOIN Coechipieri C ON C.ID_Coechipier = E.ID_Detinator\n" +
                   "GROUP BY E.Nume, E.ID_Detinator\n" +
                   "ORDER BY C.Nume ASC";
                    else
                        cmdFind = "SELECT TOP " + numericUpDownFind.Value +" E.Nume\n" +
                   "FROM Echipe E LEFT JOIN Coechipieri C ON C.ID_Coechipier = E.ID_Detinator\n" +
                   "GROUP BY E.Nume, E.ID_Detinator\n" +
                   "ORDER BY C.Nume ASC";
            }
            if (comboBoxFind.SelectedIndex == 11)
            {
                if (numericUpDownFind.Value == 0)
                    cmdFind = "SELECT E.Nume\n" +
                   "FROM Echipe E LEFT JOIN Coechipieri C ON C.ID_Coechipier = E.ID_Detinator\n" +
                   "GROUP BY E.Nume, E.ID_Detinator\n" +
                   "ORDER BY C.Nume DESC";
                else
                    cmdFind = "SELECT TOP " + numericUpDownFind.Value + " E.Nume\n" +
                   "FROM Echipe E LEFT JOIN Coechipieri C ON C.ID_Coechipier = E.ID_Detinator\n" +
                   "GROUP BY E.Nume, E.ID_Detinator\n" +
                   "ORDER BY C.Nume DESC";
            }


            SqlDataReader drm;

            SqlCommand cmdE = new SqlCommand(cmdFind);

            cmdE.Connection = conE;
            comboBoxEchipa.Items.Clear();

            conE.Open();
            drm = cmdE.ExecuteReader();
            while (drm.Read())
            {

                comboBoxEchipa.Items.Add(drm.GetString(0));


            }
            drm.Close();

            conE.Close();
        }
    }
}
