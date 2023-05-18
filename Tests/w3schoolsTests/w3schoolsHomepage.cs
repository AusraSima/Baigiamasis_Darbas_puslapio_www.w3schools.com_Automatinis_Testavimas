using NUnit.Framework;
using Framework.Pages.w3schools;
using Framework;

namespace Tests.w3schoolsTests
{
    internal class w3schoolsHomepage
    {
        [SetUp]

        public void SetUp()
        {
            Driver.InitializeDriver();
            Homepage.Open();
        
            Homepage.AcceptCookies();
        }

        [Test]

        public void CheckMenuButtons()
        {
            Homepage.ClickTutorialsButton();
            Homepage.ClickReferencesButton();
            Homepage.ClickExercicesButton();
            Homepage.ClickBootcampsButton();
            Homepage.ClickVideosButton();
            Homepage.ClickUpgradeButton();
            Homepage.ClickGetCertifiedButton();
            Homepage.ClickSignUpButton();
            //Homepage.ClickLogInButton();
            //Homepage.ClickDarkModeButton();
            Homepage.ClickGlobeButton();
            Homepage.ClickSearchButton();

            //Paieskos laukas
            Homepage.ClickNotSureLink();
            Homepage.ClickSearchOurTutorialsLink();
        }

        [TearDown]

        public void TearDown()
        {
            //Driver.ShutDownDriver();
        }
    }
}
