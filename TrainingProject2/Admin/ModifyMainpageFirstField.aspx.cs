using System;
using System.Web.UI;
using TrainingProject2.Business;
using TrainingProject2.Common;
using TrainingProject2.Entity;

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
            MainPageInfoEntity entity = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.FirstLineHeader);
            txtFirstLinieMessage.Text = entity.Comment;
            txtFirstLinieMessageDescription.Text = entity.Explanation;
            chcFirstLine.Checked = entity.IsActive;
            txtFirstLineInfo.Text = entity.Info;

            MainPageInfoEntity entity2 = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.SecondLineContent);
            txtSecondLinieMessage.Text = entity2.Comment;
            txtSecondLinieMessageDescription.Text = entity2.Explanation;
            chcSeconndLine.Checked = entity2.IsActive;
            txtSecondLineInfo.Text = entity2.Info;

            MainPageInfoEntity entity3 = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.GettingStartedLine);
            txtGettingStartedMessage.Text = entity3.Comment;
            txtStartedMessageDescription.Text = entity3.Explanation;
            chcGettingStartedMessage.Checked = entity3.IsActive;
            txtGettingStartedInfo.Text = entity3.Info;

            MainPageInfoEntity entity4 = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.GetLibraries);
            txtGetLibraries.Text = entity4.Comment;
            txtGetLibrariesDescription.Text = entity4.Explanation;
            chcGetLibraries.Checked = entity4.IsActive;
            txtGetLibrariesInfo.Text = entity4.Info;

            MainPageInfoEntity entity5 = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.WebHosting);
            txtWebHosting.Text = entity5.Comment;
            txtWebhostingDescription.Text = entity5.Explanation;
            chcWebHosting.Checked = entity5.IsActive;
            txtWebhostingInfo.Text = entity5.Info;

            MainPageInfoEntity entity6 = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.Starter);
            txtStarter.Text = entity6.Comment;
            txtStarterDescription.Text = entity6.Explanation;
            chcStarter.Checked = entity6.IsActive;
            txtStarterInfo.Text = entity6.Info;
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            processWithEntity(txtFirstLinieMessage.Text, MainPageEditableEnum.FirstLineHeader, chcFirstLine.Checked,txtFirstLinieMessageDescription.Text,txtFirstLineInfo.Text);
            processWithEntity(txtSecondLinieMessage.Text, MainPageEditableEnum.SecondLineContent, chcSeconndLine.Checked,txtSecondLinieMessageDescription.Text,txtSecondLineInfo.Text);
            processWithEntity(txtGettingStartedMessage.Text, MainPageEditableEnum.GettingStartedLine, chcGettingStartedMessage.Checked,txtStartedMessageDescription.Text,txtGettingStartedInfo.Text);
            processWithEntity(txtGetLibraries.Text, MainPageEditableEnum.GetLibraries, chcGetLibraries.Checked,txtGetLibrariesDescription.Text,txtGetLibrariesInfo.Text);
            processWithEntity(txtWebHosting.Text, MainPageEditableEnum.WebHosting, chcWebHosting.Checked,txtWebhostingDescription.Text,txtWebhostingInfo.Text);
            processWithEntity(txtStarter.Text, MainPageEditableEnum.Starter, chcStarter.Checked,txtStarterDescription.Text,txtStarterInfo.Text);


            Response.Write(CommonConst.RecordSaveSuccesfully);
        }

        private void processWithEntity(string comment, MainPageEditableEnum commentType,bool isActive,string explanation,string info)
        {
            MainPageInfoEntity entity = new MainPageInfoEntity();
            entity.Comment = comment;
            entity.CommentType = commentType;
            entity.IsActive = isActive;
            entity.AddedOn = DateTime.Now;
            entity.UpdatedOn = DateTime.Now;
            entity.Explanation = explanation;
            entity.Info = info;
            MainPageInfoBusiness.InsertOrUpdateInfoTextWithEntity(entity);
        }

    }
}