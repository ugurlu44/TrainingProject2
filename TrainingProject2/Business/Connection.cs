using System.Data.SqlClient;

namespace TrainingProject2.Business
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4ISBFD4;Initial Catalog=dbTraining;Integrated Security=True");
            return con;
        }
    }
}