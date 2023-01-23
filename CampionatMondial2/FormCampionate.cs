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
    public partial class FormCampionate : Form
    {
        SqlConnection conC = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");
        SqlDataReader drc;
        int selectedStadionID = 0;
        int selectedCampionatID = 0;
        int[] stadioaneIDList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int stadioaneIDindex = 0;
        string[] campionateTipList = {"Fotbal","Tenis","Baschetbal","Handbal" };
        string cmdFind = "SELECT ID_Campionat, Nume FROM Campionate ORDER BY Nume ASC,ID_Campionat ";
        public FormCampionate()
        {
            InitializeComponent();
            StatusLabel.Hide();
            ErrorLabel.Hide();
            buttonRemoveStadion.Hide();
            buttonStergeCampionat.Hide();
            comboBoxStadioane.Hide();
            for(int i = 0; i < campionateTipList.Length; i++)
            {
                comboBoxTip.Items.Add(campionateTipList[i]);
            }
            SqlCommand cmdS = new SqlCommand(cmdFind, conC);
            conC.Open();
            drc = cmdS.ExecuteReader();
            flowLayoutPanelCampionate.Controls.Clear();
            while (drc.Read())
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = drc.GetString(1);
                btn.Tag = drc.GetInt32(0);
                btn.Width = 200;
                flowLayoutPanelCampionate.Controls.Add(btn);
                btn.Click += Btn_Click; ;

            }
            drc.Close();
            string loadCampionate = "SELECT Nume, ID_Stadion FROM Stadioane";
            cmdS = new SqlCommand(loadCampionate, conC);
            comboBoxStadioane.Items.Clear();
            drc = cmdS.ExecuteReader();
            stadioaneIDindex = 0;
            while (drc.Read())
            {
                comboBoxStadioane.Items.Add(drc.GetString(0));
                stadioaneIDList[stadioaneIDindex] = drc.GetInt32(1);
                stadioaneIDindex++;
            }
            conC.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            selectedCampionatID = (int)btn.Tag;
            buttonStergeCampionat.Show();
            buttonAddStadion.Show();
            comboBoxStadioane.Show();
            string loadSelectedCampionat = "SELECT Nume, Data_inceperii, Data_finalizarii,Tip FROM Campionate WHERE ID_Campionat = '" + selectedCampionatID + "'";
            SqlCommand cmdC = new SqlCommand(loadSelectedCampionat, conC);
            conC.Open();
            drc = cmdC.ExecuteReader();
            drc.Read();
            textBoxNume.Text = drc.GetString(0);
            dateTimePicker1.Value = drc.GetDateTime(1);
            dateTimePicker2.Value = drc.GetDateTime(2);
            comboBoxTip.SelectedIndex = drc.GetInt32(3);
            drc.Close();
            loadSelectedCampionat = "SELECT S.Nume, S.ID_Stadion FROM Stadioane S RIGHT JOIN Stadioane_Campionate SC ON S.ID_Stadion = SC.ID_Stadion\n" +
                "WHERE SC.ID_Campionat = '" + selectedCampionatID + "'";
            cmdC = new SqlCommand(loadSelectedCampionat, conC);
            string loadOtherCampionate = "SELECT S.Nume, S.ID_Stadion FROM Stadioane S RIGHT JOIN Stadioane_Campionate SC ON S.ID_Stadion = SC.ID_Stadion\n" +
                "WHERE SC.ID_Campionat != '" + selectedCampionatID + "'";

            SqlCommand cmdIC = new SqlCommand(loadOtherCampionate, conC);

            drc = cmdC.ExecuteReader();
            flowLayoutPanelStadioane.Controls.Clear();
            while (drc.Read())
            {
                if (drc.IsDBNull(0) == true || drc.IsDBNull(1) == true)
                    break;
                System.Windows.Forms.Button btn2 = new System.Windows.Forms.Button();
                btn2.Text = drc.GetString(0);
                btn2.Tag = drc.GetInt32(1);
                btn2.Width = 200;
                flowLayoutPanelStadioane.Controls.Add(btn2);
                btn2.Click += Btn2_Click; 
            }
            drc.Close();
            comboBoxStadioane.Items.Clear();
            drc = cmdIC.ExecuteReader();
            stadioaneIDindex = 0;
            while (drc.Read())
            {
                if (drc.IsDBNull(0) == true || drc.IsDBNull(1) == true)
                    continue;
                comboBoxStadioane.Items.Add(drc.GetString(0));
                stadioaneIDList[stadioaneIDindex] = drc.GetInt32(1);
                stadioaneIDindex++;

            }
            conC.Close();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn2 = (System.Windows.Forms.Button)sender;
            selectedStadionID = (int)btn2.Tag;
            buttonRemoveStadion.Show();

        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            Form frmMain = new Form3();
            this.Hide();
            frmMain.Show();
        }

        private void FormCampionate_Load(object sender, EventArgs e)
        {

        }

        int campionatRemoveConfirm = 0;
        private void buttonStergeCampionat_Click(object sender, EventArgs e)
        {
            if(campionatRemoveConfirm == 0)
            {
                campionatRemoveConfirm++;
                buttonStergeCampionat.Text = "Confirma";

            }
            else
            {
                campionatRemoveConfirm = 0;

                string removeCampionat = "DELETE FROM Campionate \n" +
                   "WHERE ID_Campionat = '" + selectedCampionatID + "'";
                SqlCommand removeCommand = new SqlCommand(removeCampionat, conC);
                conC.Open();
                removeCommand.ExecuteNonQuery();
                StatusLabel.Text = "Campioantul a fost sters din baza de date.";
                StatusLabel.Show();
                string loadCampionate = "SELECT ID_Campionat,Nume FROM Campionate";
                SqlCommand cmdC = new SqlCommand(loadCampionate, conC);
                drc = cmdC.ExecuteReader();
                flowLayoutPanelCampionate.Controls.Clear();
                while (drc.Read())
                {
                    System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                    btn.Text = drc.GetString(1);
                    btn.Tag = drc.GetInt32(0);
                    btn.Width = 200;
                    flowLayoutPanelCampionate.Controls.Add(btn);
                    btn.Click += Btn_Click;

                }
                drc.Close();
                conC.Close();
                flowLayoutPanelStadioane.Controls.Clear();
                comboBoxStadioane.Items.Clear();
                comboBoxStadioane.Hide();
                buttonAdaugaCampionat.Hide();
                buttonStergeCampionat.Hide();
            }
        }

        int stadionRemoveConfirm = 0;

        private void buttonRemoveStadion_Click(object sender, EventArgs e)
        {
            if (stadionRemoveConfirm == 0)
            {
                buttonRemoveStadion.Text = "Confirma.";
                stadionRemoveConfirm = 1;
            }
            else
            {
                stadionRemoveConfirm = 0;
                string removeStadionAssigned = "DELETE FROM Stadioane_Campionate \n" +
                    "WHERE ID_Stadion = '" + selectedStadionID + "' AND ID_Campionat = '" + selectedCampionatID + "'";
                SqlCommand removeCommand = new SqlCommand(removeStadionAssigned, conC);
                conC.Open();
                removeCommand.ExecuteNonQuery();
                string loadSelectedCampionat = "SELECT S.Nume, S.ID_Stadion FROM Stadioane S RIGHT JOIN Stadioane_Campionate SC ON S.ID_Stadion = SC.ID_Stadion\n" +
                      "WHERE SC.ID_Campionat = '" + selectedCampionatID + "'";
                SqlCommand cmdC = new SqlCommand(loadSelectedCampionat, conC);
                string loadOtherCampionate = "SELECT S.Nume, S.ID_Stadion FROM Stadioane S RIGHT JOIN Stadioane_Campionate SC ON S.ID_Stadion = SC.ID_Stadion\n" +
                    "WHERE SC.ID_Campionat != '" + selectedCampionatID + "'";

                SqlCommand cmdIC = new SqlCommand(loadOtherCampionate, conC);

                drc = cmdC.ExecuteReader();
                flowLayoutPanelStadioane.Controls.Clear();
                while (drc.Read())
                {
                    if (drc.IsDBNull(0) == true || drc.IsDBNull(1) == true)
                        break;
                    System.Windows.Forms.Button btn2 = new System.Windows.Forms.Button();
                    btn2.Text = drc.GetString(0);
                    btn2.Tag = drc.GetInt32(1);
                    btn2.Width = 200;
                    flowLayoutPanelStadioane.Controls.Add(btn2);
                    btn2.Click += Btn2_Click;
                }
                drc.Close();
                comboBoxStadioane.Items.Clear();
                drc = cmdIC.ExecuteReader();
                stadioaneIDindex = 0;
                while (drc.Read())
                {
                    if (drc.IsDBNull(0) == true || drc.IsDBNull(1) == true)
                        continue;
                    comboBoxStadioane.Items.Add(drc.GetString(0));
                    stadioaneIDList[stadioaneIDindex] = drc.GetInt32(1);
                    stadioaneIDindex++;

                }
                drc.Close();
                string loadCampionate = "SELECT ID_Campionat,Nume FROM Campionate";
                cmdC = new SqlCommand(loadCampionate, conC);
                drc = cmdC.ExecuteReader();
                flowLayoutPanelCampionate.Controls.Clear();
                while (drc.Read())
                {
                    System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                    btn.Text = drc.GetString(1);
                    btn.Tag = drc.GetInt32(0);
                    btn.Width = 200;
                    flowLayoutPanelCampionate.Controls.Add(btn);
                    btn.Click += Btn_Click;

                }
                drc.Close();
                StatusLabel.Text = "Stadionul a fost sters din lista.";
                StatusLabel.Show();
                conC.Close();
            }

        }

        private void buttonAddStadion_Click(object sender, EventArgs e)
        {
            if(comboBoxStadioane.Text == "")
            {
                ErrorLabel.Text = "Eroare: niciun stadion nu a fost selectat pentru adaugare.";
                ErrorLabel.Show();
            }
            else
            {
                string addStadion = "INSERT INTO Stadioane_Campionate (ID_Stadion,ID_Campionat)\n" +
                    "VALUES('" + stadioaneIDList[stadioaneIDindex] + "','" + selectedCampionatID + "')";
                SqlCommand cmdS = new SqlCommand(addStadion, conC);
                conC.Open();
                cmdS.ExecuteNonQuery();
                ErrorLabel.Hide();
                StatusLabel.Text = "Stadionul a fost adaugat in lista.";
                StatusLabel.Show();
                string loadSelectedCampionat = "SELECT S.Nume, S.ID_Stadion FROM Stadioane S RIGHT JOIN Stadioane_Campionate SC ON S.ID_Stadion = SC.ID_Stadion\n" +
                      "WHERE SC.ID_Campionat = '" + selectedCampionatID + "'";
                SqlCommand cmdC = new SqlCommand(loadSelectedCampionat, conC);
                string loadOtherCampionate = "SELECT S.Nume, S.ID_Stadion FROM Stadioane S RIGHT JOIN Stadioane_Campionate SC ON S.ID_Stadion = SC.ID_Stadion\n" +
                    "WHERE SC.ID_Campionat != '" + selectedCampionatID + "'";

                SqlCommand cmdIC = new SqlCommand(loadOtherCampionate, conC);

                drc = cmdC.ExecuteReader();
                flowLayoutPanelStadioane.Controls.Clear();
                while (drc.Read())
                {
                    if (drc.IsDBNull(0) == true || drc.IsDBNull(1) == true)
                        break;
                    System.Windows.Forms.Button btn2 = new System.Windows.Forms.Button();
                    btn2.Text = drc.GetString(0);
                    btn2.Tag = drc.GetInt32(1);
                    btn2.Width = 200;
                    flowLayoutPanelStadioane.Controls.Add(btn2);
                    btn2.Click += Btn2_Click;
                }
                drc.Close();
                comboBoxStadioane.Items.Clear();
                drc = cmdIC.ExecuteReader();
                stadioaneIDindex = 0;
                while (drc.Read())
                {
                    if (drc.IsDBNull(0) == true || drc.IsDBNull(1) == true)
                        continue;
                    comboBoxStadioane.Items.Add(drc.GetString(0));
                    stadioaneIDList[stadioaneIDindex] = drc.GetInt32(1);
                    stadioaneIDindex++;

                }
                drc.Close();
                conC.Close();
            }

        }

        private void buttonAdaugaCampionat_Click(object sender, EventArgs e)
        {
            if (textBoxNume.Text == "")
            {
                ErrorLabel.Text = "Eroare: Nu a fost scris numele campionatului.";
                ErrorLabel.Show();
                return;

            }
            if(comboBoxTip.Text == "")
            {
                ErrorLabel.Text = "Eroare: nu s-a ales tipul campionatului sportiv.";
                ErrorLabel.Show(); 
                return;

            }
            if(dateTimePicker1.Value == dateTimePicker2.Value) 
            {

                ErrorLabel.Text = "Eroare: Data inceperii si finalizarii trebuie sa difere.";
                ErrorLabel.Show();
                return;

            }
            string findSimilarCampionat = "SELECT ID_Campionat FROM Campionate WHERE Nume LIKE('" + textBoxNume.Text + "') AND Data_inceperii LIKE('"+dateTimePicker1.Value+"') AND Data_finalizarii LIKE('"+dateTimePicker2.Value+"') AND Tip = '"+comboBoxTip.SelectedIndex+"'";
            SqlCommand findCommand = new SqlCommand(findSimilarCampionat, conC);
            conC.Open();
            drc = findCommand.ExecuteReader();
            while (drc.Read())
            {
                if (drc.IsDBNull(0) == false)
                {
                    break;
                }
                else
                {
                    ErrorLabel.Text = "Eroare: nu este permisa introducerea unui campionat cu date similare.";
                    return;
                }
            }
            drc.Close();
            string addCampionat = "INSERT INTO Campionate (Nume,Data_inceperii,Data_finalizarii,Tip)\n" +
                "VALUES('" + textBoxNume.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy hh:mm:ss") + "','"+dateTimePicker2.Value.ToString("MM/dd/yyyy hh:mm:ss") + "','"+comboBoxTip.SelectedIndex+"')";
            SqlCommand addCampionatCommand = new SqlCommand(addCampionat, conC);
            addCampionatCommand.ExecuteNonQuery();
            string loadCampionate = "SELECT ID_Campionat,Nume FROM Campionate";
            SqlCommand cmdC = new SqlCommand(loadCampionate, conC);
            drc = cmdC.ExecuteReader();
            flowLayoutPanelCampionate.Controls.Clear();
            while (drc.Read())
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = drc.GetString(1);
                btn.Tag = drc.GetInt32(0);
                btn.Width = 200;
                flowLayoutPanelCampionate.Controls.Add(btn);
                btn.Click += Btn_Click;

            }
            drc.Close();
            StatusLabel.Text = "Campionatul a fost adaugat in baza de date.";
            StatusLabel.Show();
            conC.Close();
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonModifyCampionat_Click(object sender, EventArgs e)
        {
            if (textBoxNume.Text == "")
            {
                ErrorLabel.Text = "Eroare: Nu a fost scris numele campionatului.";
                ErrorLabel.Show();
                return;

            }
            if (comboBoxTip.Text == "")
            {
                ErrorLabel.Text = "Eroare: nu s-a ales tipul campionatului sportiv.";
                ErrorLabel.Show();
                return;

            }
            if (dateTimePicker1.Value == dateTimePicker2.Value)
            {

                ErrorLabel.Text = "Eroare: Data inceperii si finalizarii trebuie sa difere.";
                ErrorLabel.Show();
                return;

            }
            string findSimilarCampionat = "SELECT ID_Campionat FROM Campionate WHERE Nume LIKE('" + textBoxNume.Text + "') AND Data_inceperii LIKE('" + dateTimePicker1.Value + "') AND Data_finalizarii LIKE('" + dateTimePicker2.Value + "') AND Tip = '"+comboBoxTip.SelectedIndex+"'";
            SqlCommand findCommand = new SqlCommand(findSimilarCampionat, conC);
            conC.Open();
            drc = findCommand.ExecuteReader();
            while (drc.Read())
            {
                if (drc.IsDBNull(0) == false)
                {
                    break;
                }
                else
                {
                    ErrorLabel.Text = "Eroare: nu este permisa introducerea unui campionat cu date similare.";
                    return;
                }
            }
            drc.Close();
            string updateCampionat = "UPDATE Campionate\n" +
                "SET Nume = '" + textBoxNume.Text + "',\n" +
                "Data_inceperii = '" + dateTimePicker1.Value + "'\n" +
                "Data_finalizarii = '" + dateTimePicker2.Value + "',\n" +
                "Tip = '" + comboBoxTip.SelectedIndex+ "'\n" +
                "WHERE ID_Campionat = '" + selectedCampionatID + "'";
            SqlCommand addCampionatCommand = new SqlCommand(updateCampionat, conC);
            addCampionatCommand.ExecuteNonQuery();
            string addAssignedCampionate;
            string testAssignedCampionate;
            SqlCommand assignedCampionateCommand;
            for (int i = 0; i < stadioaneIDindex; i++)
            {
                testAssignedCampionate = "SELECT TOP 1 ID_Campionat FROM Stadioane_Campionate \n" +
                    "WHERE ID_Campionat = '" + selectedCampionatID+ "' AND ID_Stadion = '" + stadioaneIDList[i] + "' ";
                assignedCampionateCommand = new SqlCommand(testAssignedCampionate, conC);
                drc = assignedCampionateCommand.ExecuteReader();
                drc.Read();
                if (drc.IsDBNull(0) == false)
                    continue;
                addAssignedCampionate = "INSERT INTO Stadioane_Campionate (ID_Stadion,ID_Campionat)\n" +
                    "VALUES('" + selectedCampionatID + "','" + stadioaneIDList[i] + "')";
                assignedCampionateCommand = new SqlCommand(addAssignedCampionate, conC);
                assignedCampionateCommand.ExecuteNonQuery();


            }




            string loadCampionate = "SELECT ID_Campionat,Nume FROM Campionate";
            SqlCommand cmdC = new SqlCommand(loadCampionate, conC);
            drc = cmdC.ExecuteReader();
            flowLayoutPanelCampionate.Controls.Clear();
            while (drc.Read())
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = drc.GetString(1);
                btn.Tag = drc.GetInt32(0);
                btn.Width = 200;
                flowLayoutPanelCampionate.Controls.Add(btn);
                btn.Click += Btn_Click;

            }
            drc.Close();
            StatusLabel.Text = "Campionatul a fost modificat.";
            StatusLabel.Show();
            conC.Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (comboBoxFind.SelectedIndex == 0)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT ID_Campionat,Nume FROM Campionate ORDER BY Nume ASC,ID_Campionat";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "  ID_Campionat, Nume FROM Campionate ORDER BY Nume ASC,ID_Campionat";
            }
            if (comboBoxFind.SelectedIndex == 1)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT  ID_Campionat, Nume FROM Campionate ORDER BY Nume DESC,ID_Campionat";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "   ID_Campionat, Nume FROM Campionate ORDER BY Nume DESC,ID_Campionat";
            }
            if (comboBoxFind.SelectedIndex == 2)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT  ID_Campionat, Nume FROM Campionate ORDER BY Data_inceperii ASC,Nume ,ID_Campionat";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "   ID_Campionat, Nume FROM Campionate ORDER BY Data_inceperii ASC,Nume ,ID_Campionat";
            }
            if (comboBoxFind.SelectedIndex == 3)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT  ID_Campionat, Nume FROM Campionate ORDER BY Data_inceperii DESC,Nume ,ID_Campionat";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "   ID_Campionat, NumeFROM Stadioane ORDER BY Data_inceperii DESC,Nume ,ID_Campionat";
            }
            if (comboBoxFind.SelectedIndex == 4)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT  ID_Campionat, Nume FROM Campionate ORDER BY Data_finalizarii ASC,Nume ,ID_Campionat";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "   ID_Campionat, Nume FROM Campionate ORDER BY Data_finalizarii ASC,Nume ,ID_Campionat";
            }
            if (comboBoxFind.SelectedIndex == 5)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT  ID_Campionat, Nume FROM Campionate ORDER BY Data_finalizarii DESC,Nume ,ID_Campionat";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "   ID_Campionat, NumeFROM Stadioane ORDER BY Data_finalizarii DESC,Nume ,ID_Campionat";
            }
            if (comboBoxFind.SelectedIndex == 6)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT  C.ID_Campionat, C.Nume FROM Campionate C LEFT JOIN Stadioane_Campionate SC ON C.ID_Campionat = SC.ID_Campionat\n"+
                        "GROUP BY C.Nume,C.ID_Campionat ORDER BY COUNT(C.ID_Campionat) ASC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "  C.ID_Campionat, C.Nume FROM Campionate C LEFT JOIN Stadioane_Campionate \n"+ 
                        " SC ON C.ID_Campionat = SC.ID_Campionat GROUP BY C.Nume,C.ID_Campionat ORDER BY COUNT(C.ID_Campionat) ASC";
            }
            if (comboBoxFind.SelectedIndex == 7)
            {
                if ((int)numericUpDownFind.Value == 0)
                    cmdFind = "SELECT ID_Campionat, Nume FROM Campionate GROUP BY Nume,ID_Campionat ORDER BY (SELECT COUNT(SC.ID_Campionat) \n"+
                        "FROM Stadioane_Campionate SC WHERE SC.ID_Campionat = ID_Campionat) DESC";
                else
                    cmdFind = "SELECT TOP " + (int)numericUpDownFind.Value + "  SELECT ID_Campionat, Nume FROM Campionate GROUP BY Nume,ID_Campionat\n"+
                        "ORDER BY (SELECT COUNT(SC.ID_Campionat) FROM Stadioane_Campionate SC WHERE SC.ID_Campionat = ID_Campionat) DESC";
            }
            SqlCommand cmdS = new SqlCommand(cmdFind, conC);
            conC.Open();
            drc = cmdS.ExecuteReader();
            flowLayoutPanelCampionate.Controls.Clear();
            while (drc.Read())
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = drc.GetString(1);
                btn.Tag = drc.GetInt32(0);
                btn.Width = 200;
                flowLayoutPanelCampionate.Controls.Add(btn);
                btn.Click += Btn_Click; ;

            }
            drc.Close();
            conC.Close();
        }
    }
}
