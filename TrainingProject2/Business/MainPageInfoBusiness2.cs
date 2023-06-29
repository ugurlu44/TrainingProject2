using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TrainingProject2.Common;

namespace TrainingProject2.Business
{
    public class MainPageInfoBusiness2
    {
        public static string GetMainPageInfoText()
        {
            string textInfo = "";
            SqlConnection con = Connection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [dbTraining].[dbo].[tbMainPageInfo] WHERE(CommentId = 2)", con);
            cmd.ExecuteNonQuery();
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                textInfo = oku["Comment"].ToString();
            }
            oku.Close();
            con.Close();
            return textInfo;
        }

        public static void InsertOrUpdateInfoText(string textInfo)
        {
            if(isTextInfoExists())
            {
                updateTextInfo(textInfo);
            }
            else
            {
                insertTextInfo(textInfo);
            }
        }

        private static void insertTextInfo(string textInfo)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd2 = new SqlCommand("INSERT INTO dbTraining.dbo.tbMainPageInfo VALUES(@p1,@p2)", con);
            cmd2.Parameters.AddWithValue("@p1", 2);
            cmd2.Parameters.AddWithValue("@p2", textInfo);
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        private static void updateTextInfo(string textInfo)
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd2 = new SqlCommand("UPDATE dbTraining.dbo.tbMainPageInfo SET Comment =@p1 where CommentId=@p2", con);
            cmd2.Parameters.AddWithValue("@p1", textInfo);
            cmd2.Parameters.AddWithValue("@p2", 2);
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        private static bool isTextInfoExists()
        {
            string sql = "SELECT COUNT(1) from  [dbTraining].[dbo].[tbMainPageInfo] WHERE(CommentId = 2)";
            SqlConnection con = Connection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            int count= (int)cmd.ExecuteScalar();
            con.Close();
            return count > 0;

        }
    }
}