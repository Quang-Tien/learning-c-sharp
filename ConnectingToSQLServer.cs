using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;




namespace ConnectingToSQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server= DESKTOP-U00Q6NP\\SQLEXPRESS; Database= company; Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Employee";

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string name = dr["name"].ToString();
                        string addr = dr["address"].ToString();
                        Console.WriteLine(name + " " + addr);
                    }
                    dr.Close();
                }
                Console.ReadKey();
            }
        }
    }
}