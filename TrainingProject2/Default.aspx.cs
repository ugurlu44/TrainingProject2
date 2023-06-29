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

namespace TrainingProject2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDefaultFirstLineMessage.Text = MainPageInfoBusiness2.GetMainPageInfoText();
            lblDefaultSecondLineMessage.Text = MainPageInfoBusiness.GetMainPageInfoText();
        }
    }
}