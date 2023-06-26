﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TrainingProject2
{
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection("Data Source=KORKMAZ;Initial Catalog=Kindergarten;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)

                VeriListele();
        }

        protected void VeriListele()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [Kindergarten].[dbo].[Tbl_Anasayfayorum] WHERE(YorumId = 1)", con);
            cmd.ExecuteNonQuery();
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                lblAnasayfaMesaj.Text = oku["Anasayfayorum"].ToString();
            }
            oku.Close();
            con.Close();

        }
    }
}