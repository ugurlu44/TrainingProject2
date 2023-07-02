using System.Data.SqlClient;

namespace TrainingProject2.Business
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=Korkmaz;Initial Catalog=dbTraining;Integrated Security=True");
            return con;
        }
    }
}