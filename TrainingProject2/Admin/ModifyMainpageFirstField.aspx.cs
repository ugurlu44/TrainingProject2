using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TrainingProject2.Admin
{
    public partial class ModifyMainpageFirstField : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=KORKMAZ;Initial Catalog=Kindergarten;Integrated Security=True");
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)

            VeriListele();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("UPDATE Tbl_Anasayfayorum SET Anasayfayorum =@p1 where YorumId=@p2", con);
            con.Open();
            cmd2.Parameters.AddWithValue("@p1", txtMainpageMessage.Text);
            cmd2.Parameters.AddWithValue("@p2", 1);
            cmd2.ExecuteNonQuery();
            con.Close();
            Response.Write("Kayıt güncellenmiştir.");
        }

        protected void VeriListele()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [Kindergarten].[dbo].[Tbl_Anasayfayorum] WHERE(YorumId = 1)", con);
            cmd.ExecuteNonQuery();
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                txtMainpageMessage.Text = oku["Anasayfayorum"].ToString();
            }
            oku.Close();
            con.Close();

        }
    }
}