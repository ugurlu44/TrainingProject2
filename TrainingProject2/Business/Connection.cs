﻿using System.Data;
using System.Data.SqlClient;

namespace TrainingProject2.Business
{
    public class MyConnection
    {
        public static SqlConnection GetConnection()
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-4ISBFD4;Initial Catalog=dbTraining;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source=Korkmaz;Initial Catalog=dbTraining;Integrated Security=True");
            return con;
        }

        public static void ExecuteCommand(string query)
        {
            SqlConnection con = MyConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public static object ExecuteScalar(string query)
        {
            SqlConnection con = MyConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            object returnVal = cmd.ExecuteScalar();
            con.Close();
            return returnVal;
        }
        public static void ExecuteCommand(SqlCommand cmd)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                }
            }
            catch (System.Exception)
            {

                //Buraya ;
            }

        }
    }
}