using System;
using System.Data.SqlClient;

namespace SampleDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sql data client
            string dbConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\''Dell''\source\repos\SGT2\MyFirstDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(dbConnection))
            {
                connection.Open();

                string query = "select * from Users ORDER BY [Registered on] ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // read row by row
                        while (reader.Read())
                        {
                            string firstName = Convert.ToString(reader["First name"]);
                            string lastName = Convert.ToString(reader["Last name"]);
                            DateTime registeredOn = Convert.ToDateTime(reader["Registered on"]);

                            Console.WriteLine("User {0} {1}, created on {2}", firstName, lastName, registeredOn);
                        }
                    }
                }

                connection.Close();
            }


        }
    }
}
