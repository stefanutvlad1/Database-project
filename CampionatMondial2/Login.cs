using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampionatMondial2
{
    public partial class Login : Form
    {

        SqlCommand logcmd;
        SqlDataReader logdr;
        SqlConnection logcon;
        Form frm = new Form3();
        
        public Login()
        {
            InitializeComponent();

            logcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Admin.mdf;Integrated Security=True;Connect Timeout=30");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.ToString();
            string password = textBox2.Text;
            logcmd = new SqlCommand();
            logcon.Open();
            logcmd.Connection = logcon;
            logcmd.CommandText = "SELECT * FROM Admin_users WHERE Nume ='" + username + "' AND Parola ='" + password + "'";
            logdr = logcmd.ExecuteReader();
            if (logdr.Read())
            {
                this.DialogResult = DialogResult.OK; ;
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Username/parola incorecta.");
            }
            logcon.Close();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
