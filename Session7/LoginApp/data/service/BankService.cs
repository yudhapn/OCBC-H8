using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace LoginApp.data.service
{
    class BankService
    {
        string connectionString = "";
        public MySqlConnection connection = null;
        public const string SERVER = "localhost";
        const string USERNAME= "root";
        const string PASSWORD = "root";
        const string DATABASE_NAME = "userdata";
        DataSet dataSet;
        DataTable dataTable;
        public string table= "user_info";
        public string connectionType = "";
        string recordSource = "";

        DataGridView dataGridView;

        public BankService() {
            try
            {
                connectionString = $"SERVER={SERVER};DATABASE={DATABASE_NAME};UID={USERNAME};PASSWORD={PASSWORD};SSL Mode=None;";
                connection = new MySqlConnection(connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ExecuteSql(string sqlCommand) {
            nowquiee(sqlCommand);
        }

        private void nowquiee(string sqlCommand)
        {
            try
            {
                connection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(sqlCommand, connection);
                mySqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Execute(string sqlCommand)
        {
            recordSource = sqlCommand;
            connectionType = table;
            dataTable = new DataTable(connectionType);

            try
            {
                string command = recordSource.ToUpper();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(recordSource, connection);

                DataSet tempDataSet = new DataSet();
                dataAdapter.Fill(tempDataSet, connectionType);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string Result(int rowIndex, string columnName) { 
            try
            {
                return dataTable.Rows[rowIndex][columnName].ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
        }

        public string Result(int rowIndex, int columnIndex)
        {
            try
            {
                return dataTable.Rows[rowIndex][columnIndex].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show($"line 99, {e.Message}");
                return dataTable.Rows[rowIndex][columnIndex].ToString();
            }
        }

        public void ExecuteSelect(string sqlCommand)
        {
            recordSource = sqlCommand;
            connectionType = table;

            dataTable = new DataTable(connectionType);
            try
            {
                string command = recordSource.ToUpper();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand, connection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, connectionType);
                dataAdapter.Fill(dataTable);
                dataGridView = new DataGridView();
            }
            catch (Exception e)
            {
                MessageBox.Show($"line 120, {e.Message}");
            }
        }

        public int Count() => dataTable.Rows.Count;
    }
}
