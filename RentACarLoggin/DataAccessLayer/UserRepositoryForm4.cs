using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarLoggin.DataAccessLayer
{
    public class UserRepositoryForm4 
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RentAcar0;Integrated Security=True;";

        public bool ValidateUser(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Bilgi WHERE kullanici_adi = @username AND sifre = @password";
                using (SqlCommand com = new SqlCommand(query, con))
                {
                    com.Parameters.AddWithValue("@username", username);
                    com.Parameters.AddWithValue("@password", password);

                    con.Open();
                    using (SqlDataReader dr = com.ExecuteReader())
                    {
                        return dr.Read();
                    }
                }
            }
        }
    }

}
