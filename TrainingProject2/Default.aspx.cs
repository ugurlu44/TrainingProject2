using System;
using System.Web.UI;
using TrainingProject2.Business;
using TrainingProject2.Common;
using TrainingProject2.Entity;

namespace TrainingProject2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MainPageInfoEntity entity = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.FirstLineHeader);
            lblDefaultFirstLineMessage.Text = entity.Comment;

            MainPageInfoEntity entity2 = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.SecondLineContent);
            lblDefaultSecondLineMessage.Text = entity2.Comment;

            MainPageInfoEntity entity3 = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.GettingStartedLine);
            lblGettingStartedMessage.Text = entity3.Comment;

            MainPageInfoEntity entity4 = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.GetLibraries);
            lblGetLibraries.Text = entity4.Comment;

            MainPageInfoEntity entity5 = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.WebHosting);
            lblWebHosting.Text = entity5.Comment;

            MainPageInfoEntity entity6 = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.Starter);
            lblStarter.Text = entity6.Comment;
        }
    }
}