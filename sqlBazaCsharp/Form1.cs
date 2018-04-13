using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sqlBazaCsharp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
           
            



            InitializeComponent();
        }
        
       

        private void connectBtn_Click(object sender, EventArgs e)
        {
            

            string connectionString =
            "Server="+server.Text+";" +
            "Database=" + database.Text + ";" +
            "Uid=" + user.Text + ";" +
            "Pwd=" + password.Text + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Connected to MySql database");
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "Select * FROM konta;";
                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Connection failed Due to " + e1.ToString());
                
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
