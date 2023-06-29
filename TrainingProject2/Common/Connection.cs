using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TrainingProject2.Common
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