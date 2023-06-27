using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using TrainingProject2.Common;
using TrainingProject2.Business;

namespace TrainingProject2.Admin
{
    public partial class ModifyMainpageFirstField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getTextInfo();
            }
        }

        private void getTextInfo()
        {
            txtMainpageMessage.Text = MainPageInfoBusiness.GetMainPageInfoText();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            MainPageInfoBusiness.InsertOrUpdateInfoText(txtMainpageMessage.Text);
            Response.Write("Kayıt güncellenmiştir.");
        }

    }
}