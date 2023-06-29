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
            txtFirstLinieMessage.Text = MainPageInfoBusiness2.GetMainPageInfoText();
            txtSecondLinieMessage.Text = MainPageInfoBusiness.GetMainPageInfoText();
        }

        protected void btn_updateSecondLinie_Click(object sender, EventArgs e)
        {
            MainPageInfoBusiness.InsertOrUpdateInfoText(txtSecondLinieMessage.Text);
            Response.Write("Kayıt güncellenmiştir.");
        }

        protected void btn_updateFirstLinie_Click(object sender, EventArgs e)
        {
            MainPageInfoBusiness2.InsertOrUpdateInfoText(txtFirstLinieMessage.Text);
            Response.Write("Kayıt güncellenmiştir.");
        }
    }
}