using System;
using System.Data;
using System.Data.SqlClient;

namespace IdentityBase
{
    class Program
    {
        static void Main(string[] args)
        {
           string connetionString = @"Data Source=DESKTOP-BJEHA69; Initial Catalog=IdentityTest; Integrated Security=true";
            var con = new SqlConnection(connetionString);
            /*SqlCommand cmd = new SqlCommand(" INSERT INTO cars (id) VALUES ('ab')", con);*/

            string oString = "Select * from cars";
            SqlCommand oCmd = new SqlCommand(oString, con);
/*            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@param1", "abc");
            cmd.Parameters.AddWithValue("@param2", "red");*/

            con.Open();
            SqlDataReader oReader  = oCmd.ExecuteReader();
            oReader.Read();
            var a = oReader.GetString(oReader.GetOrdinal("id"));
            con.Close();


            SqlCommand cmdInsert = new SqlCommand(" INSERT INTO cars (id,color) VALUES ('ab','red')", con);
            con.Open();
            cmdInsert.ExecuteReader();
            con.Close();
            
            
            SqlCommand cmdUpdate = new SqlCommand(" UPDATE cars Set id = 'a',color = 'red' WHERE id='ab'", con);
            con.Open();
            cmdUpdate.ExecuteReader();
            con.Close();
            
            
            SqlCommand cmdDelete= new SqlCommand("DELETE FROM cars WHERE id='ee'", con);
            con.Open();
            cmdDelete.ExecuteReader();
            con.Close();


        }
    }
}
