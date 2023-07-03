using System;
using System.Data.SqlClient;
using TrainingProject2.Common;

namespace TrainingProject2.Business
{
    public class MainPageInfoBusiness
    {
        public static string GetMainPageInfoText(MainPageEditableEnum commentTyepId)
        {
            string textInfo = "";
            SqlConnection con = MyConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [dbTraining].[dbo].[tbMainPageInfo] WHERE(commentType = " + (int)commentTyepId + ")", con);
            cmd.ExecuteNonQuery();
            SqlDataReader oku = cmd.ExecuteReader();


            while (oku.Read())
            {
                textInfo = oku["comment"].ToString();
            }
            oku.Close();
            con.Close();
            return textInfo;
        }

        public static void InsertOrUpdateInfoText(string textInfo, MainPageEditableEnum commentType)
        {
            if (isTextInfoExists(commentType))
            {
                updateTextInfo(textInfo, commentType);
            }
            else
            {
                insertTextInfo(textInfo, commentType);
            }
        }

        private static void insertTextInfo(string textInfo, MainPageEditableEnum commentType)
        {
            string query = "INSERT INTO dbTraining.dbo.tbMainPageInfo " +
                "values(" + (int)commentType + ",'" + textInfo + "',1,0,'" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "',null,null)";
            MyConnection.ExecuteCommand(query);
        }

        private static void updateTextInfo(string textInfo, MainPageEditableEnum commentType)
        {
            string query = "UPDATE dbTraining.dbo.tbMainPageInfo SET comment ='" + textInfo + "',updatedOn = '" + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "' where commentType=" + (int)commentType;
            MyConnection.ExecuteCommand(query);

        }

        private static bool isTextInfoExists(MainPageEditableEnum commentType)
        {
            string query = "SELECT COUNT(1) from  [dbTraining].[dbo].[tbMainPageInfo] WHERE(commentType = " + (int)commentType + ")";
            int count =  (int)MyConnection.ExecuteScalar(query);
            return count > 0;
        }
    }
}