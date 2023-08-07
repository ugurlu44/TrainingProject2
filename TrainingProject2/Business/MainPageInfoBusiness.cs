using System;
using System.Data;
using System.Data.SqlClient;
using TrainingProject2.Common;
using TrainingProject2.Entity;

namespace TrainingProject2.Business
{
    public class MainPageInfoBusiness
    {
        public static MainPageInfoEntity GetMainPageInfoText(MainPageEditableEnum commentType)
        {
           
            SqlConnection con = MyConnection.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [dbTraining].[dbo].[tbMainPageInfo] WHERE(commentType = " + (int)commentType + ")", con);
            cmd.ExecuteNonQuery();
            SqlDataReader oku = cmd.ExecuteReader();
            MainPageInfoEntity entity = new MainPageInfoEntity();

            while (oku.Read())
            {
               
                 entity.Comment = oku["comment"].ToString();
                 entity.Explanation = oku["explanation"].ToString();
                 entity.IsActive =Convert.ToBoolean(oku["isActive"]);
                 entity.Info = oku["info"].ToString();

            }
            oku.Close();
            con.Close();
            
            return entity;
            
            //isActive
        }


        public static void InsertOrUpdateInfoText(string textInfo, MainPageEditableEnum commentType, bool isActive, DateTime addedUpdatedOn, string explanation)
        {
            if (isTextInfoExists(commentType))
            {
                updateTextInfo(textInfo, commentType, isActive, addedUpdatedOn, explanation);
            }
            else
            {
                insertTextInfo(textInfo, commentType, isActive, addedUpdatedOn, explanation);
            }
        }

        

        private static void insertTextInfo(string textInfo, MainPageEditableEnum commentType, bool isActive,DateTime addedOn, string explanation)
        {
            SqlCommand command = new SqlCommand("sp_InsertRecord");
            // Stored Procedure için parametrelerin eklenmesi
            command.Parameters.AddWithValue("@commentType", (int)commentType);
            command.Parameters.AddWithValue("@comment", textInfo);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@isDeleted", 0);
            command.Parameters.AddWithValue("@addedOn", addedOn.ToString("yyyyMMdd HH:mm:ss"));
            command.Parameters.AddWithValue("@updatedOn", DBNull.Value);
            command.Parameters.AddWithValue("@deletedOn", DBNull.Value);
            command.Parameters.AddWithValue("@explanation", explanation);
            MyConnection.ExecuteCommand(command);

        }

        private static void updateTextInfo(string textInfo, MainPageEditableEnum commentType, bool isActive,DateTime updatedOn, string explanation)
        {
            SqlCommand command = new SqlCommand("sp_UpdateRecord");
            // Stored Procedure için parametrelerin eklenmesi
            command.Parameters.AddWithValue("@comment", textInfo);
            command.Parameters.AddWithValue("@updatedOn", updatedOn.ToString("yyyyMMdd HH:mm:ss"));
            command.Parameters.AddWithValue("@commentType", (int)commentType);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@explanation", explanation);
            MyConnection.ExecuteCommand(command);

        }

        private static bool isTextInfoExists(MainPageEditableEnum commentType)
        {
            string query = "SELECT COUNT(1) from  [dbTraining].[dbo].[tbMainPageInfo] WHERE(commentType = " + (int)commentType + ")";
            int count = (int)MyConnection.ExecuteScalar(query);
            return count > 0;
        }


        public static void InsertOrUpdateInfoTextWithEntity(MainPageInfoEntity entity)
        {
            if (isTextInfoExists(entity.CommentType))
            {
                updateTextInfoWithEntity(entity);
            }
            else
            {
                insertTextInfoWithEntity(entity);
            }
        }

        private static void insertTextInfoWithEntity(MainPageInfoEntity entity)
        {
            SqlCommand command = new SqlCommand("sp_InsertRecord");
            // Stored Procedure için parametrelerin eklenmesi
            command.Parameters.AddWithValue("@commentType", (int)entity.CommentType);
            command.Parameters.AddWithValue("@comment", entity.Comment);
            command.Parameters.AddWithValue("@isActive", entity.IsActive);
            command.Parameters.AddWithValue("@isDeleted", 0);
            command.Parameters.AddWithValue("@addedOn", entity.AddedOn.ToString("yyyyMMdd HH:mm:ss"));
            command.Parameters.AddWithValue("@updatedOn", DBNull.Value);
            command.Parameters.AddWithValue("@deletedOn", DBNull.Value);
            command.Parameters.AddWithValue("@explanation",entity.Explanation);
            command.Parameters.AddWithValue("@info", entity.Info);
            MyConnection.ExecuteCommand(command);
        }

        private static void updateTextInfoWithEntity(MainPageInfoEntity entity)
        {
            SqlCommand command = new SqlCommand("sp_UpdateRecord");
            // Stored Procedure için parametrelerin eklenmesi
            command.Parameters.AddWithValue("@comment", entity.Comment);
            command.Parameters.AddWithValue("@updatedOn", entity.UpdatedOn.ToString("yyyyMMdd HH:mm:ss"));
            command.Parameters.AddWithValue("@commentType", (int)entity.CommentType);
            command.Parameters.AddWithValue("@isActive", entity.IsActive);
            command.Parameters.AddWithValue("@explanation", entity.Explanation);
            command.Parameters.AddWithValue("@info", entity.Info);
            MyConnection.ExecuteCommand(command);
        }
    }
}