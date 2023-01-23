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
    public partial class FormStadioane : Form
    {

        SqlConnection conS = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");
        SqlDataReader drs;
        int selectedStadionID = 0;
        int selectedCampionatID = 0;
        int[] campionateIDList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int campionateIDindex = 0;
        string cmdFind = "SELECT ID_Stadion,Nume FROM Stadioane ORDER BY Nume ASC,ID_Stadion ";
        public FormStadioane()
        {
            InitializeComponent();
            StatusLabel.Hide();
            ErrorLabel.Hide();
            buttonRemoveStadion.Hide();
            buttonStergeCampionat.Hide();
            buttonAdaugaCampionat.Hide();
            comboBoxCampionate.Hide();

            SqlCommand cmdS = new SqlCommand(cmdFind,conS);
            conS.Open();
            drs = cmdS.ExecuteReader();
            flowLayoutPanelStadioane.Controls.Clear();
            while(drs.Read()) 
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = drs.GetString(1);
                btn.Tag = drs.GetInt32(0);
                btn.Width = 200;
                flowLayoutPanelStadioane.Controls.Add(btn);
                btn.Click += Btn_Click;

            }
            drs.Close();
            string loadStadioane = "SELECT Nume, ID_Campionat FROM Campionate";
            cmdS = new SqlCommand(loadStadioane,conS);
            comboBoxCampionate.Items.Clear();
            drs = cmdS.ExecuteReader();
            campionateIDindex = 0;
            while(drs.Read())
            {
                comboBoxCampionate.Items.Add(drs.GetString(0));
                campionateIDList[campionateIDindex] = drs.GetInt32(1);
                campionateIDindex++;
            }
            conS.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            selectedStadionID = (int)btn.Tag;
            buttonRemoveStadion.Show();
            buttonAdaugaCampionat.Show();
            comboBoxCampionate.Show();
            string loadSelectedStadion = "SELECT Nume, Adresa FROM Stadioane WHERE ID_Stadion = '"+selectedStadionID+"'";
            SqlCommand cmdS = new SqlCommand(loadSelectedStadion,conS);
            conS.Open();
            drs = cmdS.ExecuteReader();
            drs.Read();
            textBoxNume.Text = drs.GetString(0);
            textBoxAdresa.Text = drs.GetString(1);
            drs.Close();
            loadSelectedStadion = "SELECT C.Nume, C.ID_Campionat FROM Campionate C RIGHT JOIN Stadioane_Campionate SC ON C.ID_Campionat = SC.ID_Campionat \n" +
                "WHERE SC.ID_Stadion = '" + selectedStadionID + "'";
            cmdS = new SqlCommand(loadSelectedStadion,conS);
            string loadOtherCampionate = "SELECT C.Nume, C.ID_Campionat FROM Campionate C RIGHT JOIN Stadioane_Campionate SC ON C.ID_Campionat = SC.ID_Campionat\n" +
                "WHERE SC.ID_Stadion != '" + selectedStadionID + "'";

            SqlCommand cmdIS = new SqlCommand(loadOtherCampionate,conS); 

            drs = cmdS.ExecuteReader();
            flowLayoutPanelCampionate.Controls.Clear();
            while (drs.Read())
            {
                if (drs.IsDBNull(0) == true || drs.IsDBNull(1) == true)
                    break;
                System.Windows.Forms.Button btn2 = new System.Windows.Forms.Button();
                btn2.Text = drs.GetString(0);
                btn2.Tag = drs.GetInt32(1);
                btn2.Width = 200;
                flowLayoutPanelCampionate.Controls.Add(btn2);
                btn2.Click += Btn2_Click;
            }
            drs.Close();
            comboBoxCampionate.Items.Clear();
            drs = cmdIS.ExecuteReader();
            campionateIDindex= 0;
            while(drs.Read())
            {
                if (drs.IsDBNull(0) == true || drs.IsDBNull(1) == true)
                    continue;
                comboBoxCampionate.Items.Add(drs.GetString(0));
                campionateIDList[campionateIDindex] = drs.GetInt32(1);
                campionateIDindex++;

            }
            conS.Close();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn2 = (System.Windows.Forms.Button)sender;
            selectedCampionatID = (int)btn2.Tag;
            buttonStergeCampionat.Show();
            

        }

        private void FormStadioane_Load(object sender, EventArgs e)
        {

        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            Form frmMain = new Form3();
            this.Hide();
            frmMain.Show();
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        int removeStadionConfirm = 0;
        private void buttonRemoveStadion_Click(object sender, EventArgs e)
        {
            if(removeStadionConfirm == 0)
            {
                buttonRemoveStadion.Text = "Confirma.";
                removeStadionConfirm = 1;
            }
            else
            {
                removeStadionConfirm = 0;

                string removeStadion = "DELETE FROM Stadioane \n" +
                    "WHERE ID_Stadion = '" + selectedStadionID + "'";
                SqlCommand removeCommand = new SqlCommand(removeStadion,conS);
                conS.Open();
                removeCommand.ExecuteNonQuery();
                StatusLabel.Text = "Stadionul a fost sters din baza de date.";
                StatusLabel.Show();
                string loadStadioane = "SELECT ID_Stadion,Nume FROM Stadioane";
                SqlCommand cmdS = new SqlCommand(loadStadioane, conS);
                drs = cmdS.ExecuteReader();
                flowLayoutPanelStadioane.Controls.Clear();
                while (drs.Read())
                {
                    System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                    btn.Text = drs.GetString(1);
                    btn.Tag = drs.GetInt32(0);
                    btn.Width = 200;
                    flowLayoutPanelStadioane.Controls.Add(btn);
                    btn.Click += Btn_Click;

                }
                drs.Close();
                conS.Close();
                flowLayoutPanelCampionate.Controls.Clear();
                comboBoxCampionate.Items.Clear();
                comboBoxCampionate.Hide();
                buttonAdaugaCampionat.Hide();
                buttonStergeCampionat.Hide();   
            }
        }
        int removeCampionatConfirm = 0;
        private void buttonStergeCampionat_Click(object sender, EventArgs e)
        {
            if(removeCampionatConfirm == 0 )
            {
                buttonStergeCampionat.Text = "Confirma.";
                removeCampionatConfirm = 1;
            }
            else
            {
                removeCampionatConfirm = 0;
                string removeCampionatAssigned = "DELETE FROM Stadioane_Campionate \n" +
                    "WHERE ID_Stadion = '" + selectedStadionID + "' AND ID_Campionat = '" + selectedCampionatID + "'";
                SqlCommand removeCommand = new SqlCommand(removeCampionatAssigned, conS);
                conS.Open();
                removeCommand.ExecuteNonQuery();
                string loadSelectedStadion = "SELECT C.Nume, C.ID_Campionat FROM Campionate C RIGHT JOIN Stadioane_Campionate SC ON C.ID_Campionat = SC.ID_Campionat \n" +
                "WHERE SC.ID_Stadion = '" + selectedStadionID + "'";
                SqlCommand cmdS = new SqlCommand(loadSelectedStadion, conS);
                string loadOtherCampionate = "SELECT C.Nume, C.ID_Campionat FROM Campionate C RIGHT JOIN Stadioane_Campionate SC ON C.ID_Campionat = SC.ID_Campionat\n" +
                    "WHERE SC.ID_Stadion != '" + selectedStadionID + "'";

                SqlCommand cmdIS = new SqlCommand(loadOtherCampionate, conS);

                drs = cmdS.ExecuteReader();
                flowLayoutPanelCampionate.Controls.Clear();
                while (drs.Read())
                {
                    if (drs.IsDBNull(0) == true || drs.IsDBNull(1) == true)
                        break;
                    System.Windows.Forms.Button btn2 = new System.Windows.Forms.Button();
                    btn2.Text = drs.GetString(0);
                    btn2.Tag = drs.GetInt32(1);
                    btn2.Width = 200;
                    flowLayoutPanelCampionate.Controls.Add(btn2);
                    btn2.Click += Btn2_Click;
                }
                drs.Close();
                comboBoxCampionate.Items.Clear();
                campionateIDindex= 0;
                drs = cmdIS.ExecuteReader();
                while (drs.Read())
                {
                    if (drs.IsDBNull(0) == true || drs.IsDBNull(1) == true)
                        continue;
                    comboBoxCampionate.Items.Add(drs.GetString(0));
                    campionateIDList[campionateIDindex] = drs.GetInt32(1);
                    campionateIDindex++;

                }
                drs.Close();
                string loadStadioane = "SELECT ID_Stadion,Nume FROM Stadioane";
                cmdS = new SqlCommand(loadStadioane, conS);
                drs = cmdS.ExecuteReader();
                flowLayoutPanelStadioane.Controls.Clear();
                while (drs.Read())
                {
                    System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                    btn.Text = drs.GetString(1);
                    btn.Tag = drs.GetInt32(0);
                    btn.Width = 200;
                    flowLayoutPanelStadioane.Controls.Add(btn);
                    btn.Click += Btn_Click;

                }
                drs.Close();
                StatusLabel.Text = "Campionatul a fost sters din lista.";
                StatusLabel.Show();
                conS.Close();

            }

        }

        private void comboBoxCampionate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdaugaCampionat_Click(object sender, EventArgs e)
        {
            if(comboBoxCampionate.Text == "")
            {
                ErrorLabel.Text = "Eroare: niciun campionat nu a fost selectat pentru adaugare.";
                ErrorLabel.Show();
            }
            else
            {
                string addCampionat = "INSERT INTO Stadioane_Campionate (ID_Stadion,ID_Campionat)\n" +
                    "VALUES('" + selectedStadionID + "','" + campionateIDList[comboBoxCampionate.SelectedIndex] +"')";
                SqlCommand cmdS = new SqlCommand(addCampionat, conS);
                conS.Open();
                cmdS.ExecuteNonQuery();
                ErrorLabel.Hide();
                StatusLabel.Text = "Campionatul a fost adaugat in lista.";
                StatusLabel.Show();

                string loadSelectedStadion = "SELECT C.Nume, C.ID_Campionat FROM Campionate C RIGHT JOIN Stadioane_Campionate SC ON C.ID_Campionat = SC.ID_Campionat \n" +
                "WHERE SC.ID_Stadion = '" + selectedStadionID + "'";
                cmdS = new SqlCommand(loadSelectedStadion, conS);
                string loadOtherCampionate = "SELECT C.Nume, C.ID_Campionat FROM Campionate C RIGHT JOIN Stadioane_Campionate SC ON C.ID_Campionat = SC.ID_Campionat\n" +
                    "WHERE SC.ID_Stadion != '" + selectedStadionID + "'";

                SqlCommand cmdIS = new SqlCommand(loadOtherCampionate, conS);
                
                drs = cmdS.ExecuteReader();
                flowLayoutPanelCampionate.Controls.Clear();
                while (drs.Read())
                {
                    if (drs.IsDBNull(0) == true || drs.IsDBNull(1) == true)
                        break;
                    System.Windows.Forms.Button btn2 = new System.Windows.Forms.Button();
                    btn2.Text = drs.GetString(0);
                    btn2.Tag = drs.GetInt32(1);
                    btn2.Width = 200;
                    flowLayoutPanelCampionate.Controls.Add(btn2);
                    btn2.Click += Btn2_Click;
                }
                drs.Close();
                comboBoxCampionate.Items.Clear();
                campionateIDindex= 0;
                drs = cmdIS.ExecuteReader();
                while (drs.Read())
                {
                    if (drs.IsDBNull(0) == true || drs.IsDBNull(1) == true)
                        break;
                    comboBoxCampionate.Items.Add(drs.GetString(0));
                    campionateIDList[campionateIDindex] = drs.GetInt32(1);
                    campionateIDindex++;

                }
                conS.Close();
            }
        }

        private void buttonAddStadion_Click(object sender, EventArgs e)
        {
            if(textBoxAdresa.Text == "")
            {
                ErrorLabel.Text = "Eroare: Nu a fost scrisa adresa stadionului.";
                ErrorLabel.Show();
                return;

            }
            if(textBoxNume.Text == "")
            {
                ErrorLabel.Text = "Eroare: Nu a fost introdus numele stadionului.";
                ErrorLabel.Show();
                return;

            }
            string findSimilarStadion = "SELECT ID_stadion FROM Stadioane WHERE Nume LIKE('" + textBoxNume.Text + "') AND Adresa LIKE('" + textBoxAdresa.Text + "')";
            SqlCommand findCommand = new SqlCommand(findSimilarStadion, conS);
            conS.Open();
            drs = findCommand.ExecuteReader();
            while(drs.Read())
            {
                if (drs.IsDBNull(0) == false)
                {
                    break;
                }
                else
                {
                    ErrorLabel.Text = "Eroare: nu este permisa introducerea unui stadion cu date similare.";
                    return;
                }
            }
            drs.Close();
            string addStadion = "INSERT INTO Stadioane (Nume,Adresa)\n" +
                "VALUES('"+textBoxNume.Text+"','"+textBoxAdresa.Text+"')";
            SqlCommand addStadionCommand = new SqlCommand(addStadion, conS);
            addStadionCommand.ExecuteNonQuery();
            string loadStadioane = "SELECT ID_Stadion,Nume FROM Stadioane";
            SqlCommand cmdS = new SqlCommand(loadStadioane, conS);
            drs = cmdS.ExecuteReader();
            flowLayoutPanelStadioane.Controls.Clear();
            while (drs.Read())
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = drs.GetString(1);
                btn.Tag = drs.GetInt32(0);
                btn.Width = 200;
                flowLayoutPanelStadioane.Controls.Add(btn);
                btn.Click += Btn_Click;

            }
            drs.Close();
            StatusLabel.Text = "Stadionul a fost adaugat in baza de date.";
            StatusLabel.Show();
            conS.Close();

        }

        private void ErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifyStadion_Click(object sender, EventArgs e)
        {
            if (textBoxAdresa.Text == "")
            {
                ErrorLabel.Text = "Eroare: Nu a fost scrisa adresa stadionului.";
                ErrorLabel.Show();
                return;

            }
            if (textBoxNume.Text == "")
            {
                ErrorLabel.Text = "Eroare: Nu a fost introdus numele stadionului.";
                ErrorLabel.Show();
                return;

            }
            string findSimilarStadion = "SELECT ID_stadion FROM Stadioane WHERE Nume LIKE('" + textBoxNume.Text + "') AND Adresa LIKE('" + textBoxAdresa.Text + "')";
            SqlCommand findCommand = new SqlCommand(findSimilarStadion, conS);
            conS.Open();
            drs = findCommand.ExecuteReader();
            while (drs.Read())
            {
                if (drs.IsDBNull(0) == false)
                {
                    break;
                }
                else
                {
                    ErrorLabel.Text = "Eroare: nu este permisa introducerea unui stadion cu date similare.";
                    return;
                }
            }
            drs.Close();
            string updateStadion = "UPDATE Stadioane\n" +
                "SET Nume = '"+textBoxNume.Text+"',\n" +
                "Adresa = '"+textBoxAdresa.Text+"'\n" +
                "WHERE ID_Stadion = '"+selectedStadionID+"'";
            SqlCommand addStadionCommand = new SqlCommand(updateStadion, conS);
            addStadionCommand.ExecuteNonQuery();
            string addAssignedCampionate;
            string testAssignedCampionate;
            SqlCommand assignedCampionateCommand;
            for (int i = 0; i < campionateIDindex; i++)
            {
                testAssignedCampionate = "SELECT TOP 1 ID_Stadion FROM Stadioane_Campionate \n" +
                    "WHERE ID_Stadion = '"+selectedStadionID+"' AND ID_Campionate = '" + campionateIDList[i] +"' ";
                assignedCampionateCommand = new SqlCommand(testAssignedCampionate, conS);
                drs = assignedCampionateCommand.ExecuteReader();
                drs.Read();
                if (drs.IsDBNull(0) == false)
                    continue;
                addAssignedCampionate = "INSERT INTO Stadioane_Campionate (ID_Stadion,ID_Campionat)\n" +
                    "VALUES('"+selectedStadionID+"','" + campionateIDList[i] + "')";
                assignedCampionateCommand = new SqlCommand(addAssignedCampionate, conS);
                assignedCampionateCommand.ExecuteNonQuery() ;


            }
            string loadStadioane = "SELECT ID_Stadion,Nume FROM Stadioane";
            SqlCommand cmdS = new SqlCommand(loadStadioane, conS);
            drs = cmdS.ExecuteReader();
            flowLayoutPanelStadioane.Controls.Clear();
            while (drs.Read())
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = drs.GetString(1);
                btn.Tag = drs.GetInt32(0);
                btn.Width = 200;
                flowLayoutPanelStadioane.Controls.Add(btn);
                btn.Click += Btn_Click;

            }
            drs.Close();
            StatusLabel.Text = "Stadionul a fost modificat.";
            StatusLabel.Show();
            conS.Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if(comboBoxFind.SelectedIndex == 0)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT ID_Stadion,Nume FROM Stadioane ORDER BY Nume ASC,ID_Stadion";
                else
                    cmdFind = "SELECT TOP "+(int)numericUpDownFind.Value+ " ID_Stadion,Nume FROM Stadioane ORDER BY Nume ASC,ID_Stadion";
            }
            if (comboBoxFind.SelectedIndex == 1)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT ID_Stadion,Nume FROM Stadioane ORDER BY Nume DESC,ID_Stadion";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "  ID_Stadion,Nume FROM Stadioane ORDER BY Nume DESC,ID_Stadion";
            }
            if (comboBoxFind.SelectedIndex == 2)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT ID_Stadion,Nume FROM Stadioane ORDER BY Adresa ASC,Nume,ID_Stadion";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "  ID_Stadion,Nume FROM Stadioane ORDER BY Adresa ASC,Nume,ID_Stadion";
            }
            if (comboBoxFind.SelectedIndex == 3)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT ID_Stadion,Nume FROM Stadioane ORDER BY Adresa DESC,Nume,ID_Stadion";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "  ID_Stadion,Nume FROM Stadioane ORDER BY Adresa DESC,Nume,ID_Stadion";
            }
            if (comboBoxFind.SelectedIndex == 4)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT S.ID_Stadion,S.Nume FROM Stadioane S LEFT JOIN Meciuri M ON S.ID_Stadion = M.ID_Stadion \n"+
                        "GROUP BY S.Nume,S.ID_Stadion ORDER BY COUNT(S.ID_Stadion) ASC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "  S.ID_Stadion,S.Nume FROM Stadioane S LEFT JOIN Meciuri M \n"+
                        "ON S.ID_Stadion = M.ID_Stadion GROUP BY S.Nume,S.ID_Stadion ORDER BY COUNT(S.ID_Stadion) ASC";
            }
            if (comboBoxFind.SelectedIndex == 5)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT S.ID_Stadion,S.Nume FROM Stadioane S LEFT JOIN Meciuri M ON S.ID_Stadion = M.ID_Stadion  \n"+
                        "GROUP BY S.Nume,S.ID_Stadion ORDER BY COUNT(S.ID_Stadion) DESC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "  S.ID_Stadion,S.Nume FROM Stadioane S LEFT JOIN Meciuri M \n"+
                        "ON S.ID_Stadion = M.ID_Stadion GROUP BY S.Nume,S.ID_Stadion ORDER BY COUNT(S.ID_Stadion) DESC";
            }
            if (comboBoxFind.SelectedIndex == 6)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT S.ID_Stadion,S.Nume FROM Stadioane S LEFT JOIN Stadioane_Campionate SC ON S.ID_Stadion = SC.ID_Stadion \n"+
                        "GROUP BY S.Nume,S.ID_Stadion ORDER BY COUNT(S.ID_Stadion) ASC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "  S.ID_Stadion,S.Nume FROM Stadioane S  GROUP BY S.Nume,S.ID_Stadion \n"+
                        "ORDER BY COUNT(SELECT SC.ID_Stadion FROM Stadioane_Campionate SC WHERE S.ID_Stadion = SC.ID_Stadion) ASC";
            }
            if (comboBoxFind.SelectedIndex == 7)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT S.ID_Stadion,S.Nume FROM Stadioane S  GROUP BY S.Nume,S.ID_Stadion ORDER BY (SELECT COUNT(SC.ID_Stadion) \n"+
                        "FROM Stadioane_Campionate SC WHERE S.ID_Stadion = SC.ID_Stadion)  DESC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "  S.ID_Stadion,S.Nume FROM Stadioane S  GROUP BY S.Nume,S.ID_Stadion \n"+
                        "ORDER BY (SELECT COUNT(SC.ID_Stadion) FROM Stadioane_Campionate SC WHERE S.ID_Stadion = SC.ID_Stadion) DESC";
            }

            SqlCommand cmdS = new SqlCommand(cmdFind, conS);
            conS.Open();
            drs = cmdS.ExecuteReader();
            flowLayoutPanelStadioane.Controls.Clear();
            while (drs.Read())
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = drs.GetString(1);
                btn.Tag = drs.GetInt32(0);
                btn.Width = 200;
                flowLayoutPanelStadioane.Controls.Add(btn);
                btn.Click += Btn_Click;

            }
            drs.Close();
            conS.Close();
        }
    }
}
