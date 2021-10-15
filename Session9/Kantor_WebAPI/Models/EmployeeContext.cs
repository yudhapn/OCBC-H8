using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kantor_WebAPI.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }
        public EmployeeContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM employee", connection);
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader()) { 
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
            }
            return list;
        }

        public List<EmployeeItem> GetEmployee(string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM employee WHERE id=@id", connection);
                mySqlCommand.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
                return list;
            }
        }
    }
}
