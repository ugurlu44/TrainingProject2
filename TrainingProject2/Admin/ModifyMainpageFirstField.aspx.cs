using System;
using System.Web.UI;
using TrainingProject2.Business;
using TrainingProject2.Common;

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
            txtFirstLinieMessage.Text = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.FirstLineHeader);
            txtSecondLinieMessage.Text = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.SecondLineContent);
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            MainPageInfoBusiness.InsertOrUpdateInfoText(txtFirstLinieMessage.Text, MainPageEditableEnum.FirstLineHeader);
            MainPageInfoBusiness.InsertOrUpdateInfoText(txtSecondLinieMessage.Text, MainPageEditableEnum.SecondLineContent);
            Response.Write(CommonConst.RecordSaveSuccusfully);
        }
    }
}