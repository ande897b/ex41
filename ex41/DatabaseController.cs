using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ex41
{
    public class DatabaseController
    {
        private static string connectionString = "Server=EALSQL1.eal.local; Database= C_DB01_2018; User Id= C_STUDENT01; Password= C_OPENDB01";
        public void InsertPet(string petName, string petType, string petBreed, string petDOB, string petWeight, string ownerID)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("InsertPet", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
              
                    cmd1.Parameters.Add(new SqlParameter("@PetName", petName));
                    cmd1.Parameters.Add(new SqlParameter("@PetType", petType));
                    cmd1.Parameters.Add(new SqlParameter("@PetBreed", petBreed));
                    cmd1.Parameters.Add(new SqlParameter("@PetDOB", petDOB));
                    cmd1.Parameters.Add(new SqlParameter("@PetWeight", petWeight));
                    cmd1.Parameters.Add(new SqlParameter("@OwnerID", ownerID));

                    cmd1.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("ups" + e.Message);
                }
            }
        }
        public void ShowPets()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("GetPets", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string petName = reader["petName"].ToString();
                            string petType = reader["petType"].ToString();
                            string petBreed = reader["petBreed"].ToString();
                            string petDOB = reader["petDOB"].ToString();
                            string petWeight = reader["petWeight"].ToString();
                            string ownerID = reader["ownerID"].ToString();

                            Console.WriteLine(petName + " " + petType + " " + petBreed + " " + petDOB + " " + petWeight + " " + ownerID);

                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("ups" + e.Message);
                }
            }
        }
    }
}

