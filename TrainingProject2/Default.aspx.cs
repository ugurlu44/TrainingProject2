using System;
using System.Web.UI;
using TrainingProject2.Business;
using TrainingProject2.Common;

namespace TrainingProject2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDefaultFirstLineMessage.Text = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.FirstLineHeader);
            lblDefaultSecondLineMessage.Text = MainPageInfoBusiness.GetMainPageInfoText(MainPageEditableEnum.SecondLineContent);
        }
    }
}