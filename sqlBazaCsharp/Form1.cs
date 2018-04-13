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
using System.Data.SqlClient;

namespace sqlBazaCsharp
{
    public partial class Form1 : Form
    {
        List<string> databaseList = new List<string>();
        List<string> tableList = new List<string>();
        bool activeTableList = true;
        bool inTable = false;
        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
        public Form1()
        {


           



            InitializeComponent();
        }
        
       
        private string connString()
        {
          string connectionString =
        "Server=" + server.Text + ";" +
        "Database=" + database.Text + ";" +
        "Uid=" + user.Text + ";" +
        "Pwd=" + password.Text + ";";
            return connectionString;
        }
        
        private void connectBtn_Click(object sender, EventArgs e)
        {

            databaseList.Clear();
            listView1.Clear();
            listView1.Columns.Add("Databases");
            string connectionString =
   "Server=" + server.Text + ";" +

   "Uid=" + user.Text + ";" +
   "Pwd=" + password.Text + ";";


            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
              MessageBox.Show("Connected to MySql database");
                //  MySqlCommand command = connection.CreateCommand();
                // command.CommandText = "Select * FROM konta;";
                // MySqlDataAdapter adap = new MySqlDataAdapter(command);
                // DataSet ds = new DataSet();
                // adap.Fill(ds);
                //  dataGridView1.DataSource = ds.Tables[0].DefaultView;
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "show databases";
                MySqlDataReader Reader;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    string row = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        row += Reader.GetValue(i).ToString();
                    databaseList.Add(row);
                }
                for (int i = 0; i < databaseList.Count; i++)
                {
                    listView1.Items.Add(databaseList[i]);
                }
              //  MessageBox.Show(listView1.SelectedItems[1].SubItems[1].Text);

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

        private void queryBtn_Click(object sender, EventArgs e)
        {
            insertBtn.Enabled = true;
            
     

            MySqlConnection connection = new MySqlConnection(connString());
            try
            {
                connection.Open();
                //MessageBox.Show("Connected to MySql database");
                MySqlCommand command = connection.CreateCommand();


                string oldString = queryText.Text;
                int lastIndex = oldString.LastIndexOf(" ");
                string newString = oldString;
                if (lastIndex != -1)
                {
                    newString = oldString.Remove(lastIndex).Trim();
                }
                queryText.Text = newString + " " + tableName.Text;

                command.CommandText = queryText.Text;
                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                autoComplete.Add(queryText.Text);
                queryText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                queryText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                queryText.AutoCompleteCustomSource = autoComplete;


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

        private void insertBtn_Click(object sender, EventArgs e)
        {
            insertSubmit.Enabled = true;
    

            MySqlConnection connection = new MySqlConnection(connString());
            try
            {
                connection.Open();
                //  MessageBox.Show("Connected to MySql database");


               MySqlCommand command = connection.CreateCommand();
                //command.CommandText = "INSERT INTO KONTA(id,login,haslo) values (@id,@login,@haslo);";
                //command.Parameters.AddWithValue("@id", "dawdawdawd");
                //command.Parameters.AddWithValue("@login", "awdwad");
                //command.Parameters.AddWithValue("@haslo", "sefse");
                command.CommandText = "select * from " + tableName.Text;
                MySqlDataAdapter adap = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                int dataGridCounter = dataGridView1.Rows.Count - 1;

                for (int i = 0; i < dataGridCounter; i++)
                {


                    dataGridView1.Rows.RemoveAt(0);
                  







                }





                //MessageBox.Show(dataGridView1.Rows[2].Cells[0].Value.ToString());


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insertSubmit_Click(object sender, EventArgs e)
        {
           
   

            MySqlConnection connection = new MySqlConnection(connString());
            try
            {
                connection.Open();
                //MessageBox.Show("Connected to MySql database");
                MySqlCommand command = connection.CreateCommand();

                string headerNames = "";
               // string gridValuesToInsert = "";
                string headerNamesButWithAtSign = "";
                List<string> valueList = new List<string>();
                List<string> columnList = new List<string>();
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    valueList.Insert(i, dataGridView1.Rows[0].Cells[i].Value.ToString());
                    columnList.Insert(i, "@" + dataGridView1.Columns[i].HeaderText);
                }



                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    headerNames += dataGridView1.Columns[i].HeaderText + ",";
                    headerNamesButWithAtSign += "@"+ dataGridView1.Columns[i].HeaderText + ",";
                   // gridValuesToInsert += "@" + dataGridView1.Rows[0].Cells[i].Value.ToString() + ","; // TODO: Zrobic zeby dzialalo dla kilku wierszy

                }
                headerNames = headerNames.Substring(0, headerNames.Length - 1);
                headerNamesButWithAtSign = headerNamesButWithAtSign.Substring(0, headerNamesButWithAtSign.Length - 1);
               // gridValuesToInsert = gridValuesToInsert.Substring(0, gridValuesToInsert.Length - 1);

               command.CommandText = "INSERT INTO " + tableName.Text + " ("+headerNames+ ") VALUES (" + headerNamesButWithAtSign + ")"; // TODO: Poprawa tego zeby dzialla, ewentualnie zabawa z ` ' "
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    command.Parameters.AddWithValue(columnList[i], valueList[i]);
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Query added");

                int dataGridCounter = dataGridView1.Rows.Count - 1;

                for (int i = 0; i < dataGridCounter; i++)
                {


                    dataGridView1.Rows.RemoveAt(0);








                }


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

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (activeTableList)
            {
                database.Text = listView1.SelectedItems[0].SubItems[0].Text;
                 databaseList.Clear();
                 listView1.Clear();
                listView1.Columns.Add("Tables");
   


                MySqlConnection connection = new MySqlConnection(connString());
                try
                {

                    connection.Open();

                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "show tables";
                    MySqlDataReader Reader;
                    Reader = command.ExecuteReader();
                    while (Reader.Read())
                    {
                        string row = "";
                        for (int i = 0; i < Reader.FieldCount; i++)
                            row += Reader.GetValue(i).ToString();
                        tableList.Add(row);
                    }
                    for (int i = 0; i < tableList.Count; i++)
                    {
                        listView1.Items.Add(tableList[i]);
                    }

                  


                }

                catch (Exception e1)
                {

                    MessageBox.Show("Error" + e1);
                }
                finally
                {
                    activeTableList = false;
                    
                    connection.Close();
                }
             
            }
            if (inTable)
            {         
                tableName.Text = listView1.SelectedItems[0].SubItems[0].Text;

                string oldString = queryText.Text;
                int lastIndex = oldString.LastIndexOf(" ");
                string newString = oldString;
                if (lastIndex != -1)
                {
                    newString = oldString.Remove(lastIndex).Trim();
                }
                queryText.Text = newString + " " + tableName.Text;
            }
            inTable = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int deleteIndexRow = dataGridView1.CurrentCell.RowIndex;
            int deleteIndexCol = dataGridView1.CurrentCell.ColumnIndex;


            MySqlConnection connection = new MySqlConnection(connString());
            try
            {
                connection.Open();
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                       MySqlCommand command = connection.CreateCommand();
                       command.CommandText = "delete from " + tableName.Text + " where " + dataGridView1.Columns[deleteIndexCol].HeaderText + " = " + dataGridView1[deleteIndexCol, deleteIndexRow].Value.ToString();
                       command.ExecuteNonQuery();
                       command.CommandText = queryText.Text;
                    MySqlDataAdapter adap = new MySqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    autoComplete.Add(queryText.Text);
                }
                else
                {
                    
                }
                //  MessageBox.Show("Connected to MySql database");
                //  MySqlCommand command = connection.CreateCommand();
                // command.CommandText = "Select * FROM konta;";
                // MySqlDataAdapter adap = new MySqlDataAdapter(command);
                // DataSet ds = new DataSet();
                // adap.Fill(ds);
                //  dataGridView1.DataSource = ds.Tables[0].DefaultView;
              
               
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int updateIndexRow = dataGridView1.CurrentCell.RowIndex;
            int updateIndexCol = dataGridView1.CurrentCell.ColumnIndex;

      

            MySqlConnection connection = new MySqlConnection(connString());
            try
            {
                connection.Open();
                // MessageBox.Show("Connected to MySql database");
                //  MySqlCommand command = connection.CreateCommand();
                // command.CommandText = "Select * FROM konta;";
                // MySqlDataAdapter adap = new MySqlDataAdapter(command);
                // DataSet ds = new DataSet();
                // adap.Fill(ds);
                //  dataGridView1.DataSource = ds.Tables[0].DefaultView;
                MySqlCommand command = connection.CreateCommand();

                //MessageBox.Show("update " + tableName.Text + " set " + dataGridView1.Columns[updateIndexCol].HeaderText
                //    + "=" + dataGridView1[updateIndexCol, updateIndexRow].Value.ToString()
                //    + " where " + dataGridView1.Columns[0].HeaderText + "="  // assuming primary key is in the frist col
                //    + dataGridView1[0, updateIndexRow].Value.ToString());


                command.CommandText = "update " + tableName.Text + " set " + dataGridView1.Columns[updateIndexCol].HeaderText
                    + "='" + dataGridView1[updateIndexCol, updateIndexRow].Value.ToString()
                    + "' where " + dataGridView1.Columns[0].HeaderText + "="  // assuming primary key is in the frist col
                    + dataGridView1[0, updateIndexRow].Value.ToString();

                command.ExecuteNonQuery();

                MessageBox.Show("Query OK");
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

        private void backBtn_Click(object sender, EventArgs e)
        {

            tableList.Clear();
            listView1.Clear();
            listView1.Columns.Add("Databases");



            MySqlConnection connection = new MySqlConnection(connString());
            try
            {
                connection.Open();       
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "show databases";
                MySqlDataReader Reader;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    string row = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        row += Reader.GetValue(i).ToString();
                    databaseList.Add(row);
                }
                for (int i = 0; i < databaseList.Count; i++)
                {
                    listView1.Items.Add(databaseList[i]);
                }
              

            }
            catch (Exception e1)
            {
                MessageBox.Show("Connection failed Due to " + e1.ToString());

            }
            finally
            {
                inTable = false;
                activeTableList = true;
                connection.Close();
            }
        }
    }


}
