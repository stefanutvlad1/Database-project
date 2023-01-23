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
    public partial class Form3 : Form
    {
        SqlConnection conC = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vlad\\source\\repos\\CampionatMondial\\CampionatMondial2\\Campionat_mondial.mdf;Integrated Security=True;Connect Timeout=30;Context Connection=False");
        int[] campionateIDList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public Form3()
        {
            InitializeComponent();

        }

        private void meciuriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.meciuriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.campionat_mondialDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            string load = "SELECT E.Nume\n"+
                "FROM Meciuri M LEFT JOIN Echipe E ON M.ID_Echipa1 = E.ID_Echipa GROUP BY M.Data, E.Nume"
                ;
            SqlCommand cmd = new SqlCommand(load);

            string load2 = "SELECT E.Nume\n" +
                "FROM Meciuri M LEFT JOIN Echipe E ON M.ID_Echipa2 = E.ID_Echipa GROUP BY M.Data, E.Nume"
                ;
            SqlCommand cmd2 = new SqlCommand(load2);

            string load3 = "SELECT S.Nume\n" +
                "FROM Meciuri M LEFT JOIN Stadioane S ON M.ID_Stadion = S.ID_Stadion GROUP BY M.Data, S.Nume"
                ;
            SqlCommand cmd3 = new SqlCommand(load3);

            string load4 = "SELECT Data\n" +
            "FROM Meciuri M LEFT JOIN Stadioane S ON M.ID_Stadion = S.ID_Stadion GROUP BY M.Data, S.Nume ";
            SqlCommand cmd4 = new SqlCommand(load4);

            string loadother = "SELECT E1.Nume, E2.Nume, S.Nume, M.Data \n" +
               "FROM Meciuri M LEFT JOIN Echipe E1 ON M.ID_Echipa1 = E1.ID_Echipa\n" +
               "LEFT JOIN Echipe E2 ON M.ID_Echipa2 = E2.ID_Echipa\n" +
               "LEFT JOIN Stadioane S ON M.ID_Stadion = S.ID_Stadion\n" +
               "WHERE Data NOT IN (SELECT TOP 1 M2.Data FROM Meciuri M2)\n" +
               "GROUP BY M.Data, S.Nume, E1.Nume, E2.Nume";

            SqlCommand cmd5 = new SqlCommand(loadother);

            SqlConnection con = conC;
            cmd.Connection = con;
            cmd2.Connection = con;
            cmd3.Connection = con;
            cmd4.Connection = con;
            cmd5.Connection = con;

            con.Open();

            dr = cmd.ExecuteReader();
            dr.Read();
            labelEchipa1.Text = dr.GetString(0);
            dr.Close();


            
            



            dr = cmd2.ExecuteReader(); 
            dr.Read();
            labelEchipa2.Text= dr.GetString(0);
            dr.Close();








            dr = cmd3.ExecuteReader();
            dr.Read();
            labelStadion1.Text = dr.GetString(0);
            dr.Close();




            dr = cmd4.ExecuteReader();
            dr.Read();
            labelData.Text = dr.GetDateTime(0).ToString();
            dr.Close();

            int i = 0;
            int j = 0;
            dr = cmd5.ExecuteReader();
            while(dr.Read())
            {
                
                listView1.Items.Add(dr.GetString(i));
                i++;
                
                listView1.Items[j].SubItems.Add(dr.GetString(i));
                i++;
                listView1.Items[j].SubItems.Add(dr.GetString(i));
                i++;
                listView1.Items[j].SubItems.Add(dr.GetDateTime(i).ToString());
                i=0;
                j++;
                
                
                

            }
            dr.Close();
         
            con.Close();

            // TODO: This line of code loads data into the 'campionat_mondialDataSet.Meciuri' table. You can move, or remove it, as needed.
            this.meciuriTableAdapter.FillBy2(this.campionat_mondialDataSet.Meciuri);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void meciuriDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmMeciuri = new FormMeciuri();
            frmMeciuri.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmEchipe = new FormEchipe();
            frmEchipe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmScoruri = new FormScoruri();
            frmScoruri.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmStadioane = new FormStadioane();
            frmStadioane.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmCampionate = new FormCampionate();
            frmCampionate.Show();
        }

        private void labelEchipa1_Click(object sender, EventArgs e)
        {

        }
    }
}
