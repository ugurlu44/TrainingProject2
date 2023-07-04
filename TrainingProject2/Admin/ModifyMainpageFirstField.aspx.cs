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
            txtGettingStartedMessage.Text = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.GettingStartedLine);
            txtGetLibraries.Text = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.GetLibraries);
            txtWebHosting.Text = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.WebHosting);
            txtStarter.Text = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.Starter);
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            MainPageInfoBusiness.InsertOrUpdateInfoText(txtFirstLinieMessage.Text, MainPageEditableEnum.FirstLineHeader);
            MainPageInfoBusiness.InsertOrUpdateInfoText(txtSecondLinieMessage.Text, MainPageEditableEnum.SecondLineContent);
            MainPageInfoBusiness.InsertOrUpdateInfoText(txtGettingStartedMessage.Text, MainPageEditableEnum.GettingStartedLine);
            MainPageInfoBusiness.InsertOrUpdateInfoText(txtGetLibraries.Text, MainPageEditableEnum.GetLibraries);
            MainPageInfoBusiness.InsertOrUpdateInfoText(txtWebHosting.Text, MainPageEditableEnum.WebHosting);
            MainPageInfoBusiness.InsertOrUpdateInfoText(txtStarter.Text, MainPageEditableEnum.Starter);

            Response.Write(CommonConst.RecordSaveSuccesfully);
        }
    }
}