using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Pages.w3schools
{
    public class Homepage
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.w3schools.com/");
        }

        
        //Cookies
        public static void AcceptCookies()
        {
            string buttonAcceptCookies = "//*[@id='accept-choices']";
            Common.Click(buttonAcceptCookies);
            Common.WaitForElementToNotContainText(buttonAcceptCookies, "Accept all &; visit the site");
        }

        //Meniu mygtukai
        public static void ClickLogoButton()
        {
            string locator = "/html/body/div[3]/a[1]";
            Common.Click(locator);
        }

        public static void ClickTutorialsButton()
        {
            Common.Click(Locators.HomepageButtons.inputTutorials);
        }

        public static string GetTutorialsButtonText()
        {
            return Common.GetElementValue(Locators.HomepageButtons.inputTutorials, "Tutorials");
        }

        public static void ClickReferencesButton()
        {
            Common.Click(Locators.HomepageButtons.inputReferences);
        }

        public static string GetReferencesButtonText()
        {
            return Common.GetElementValue(Locators.HomepageButtons.inputReferences, "References");
        }

        public static void ClickExercicesButton()
        {
            Common.Click(Locators.HomepageButtons.inputExercises);
        }

        public static void ClickBootcampsButton()
        { 
            Common.Click(Locators.HomepageButtons.inputBootcamps);
            Driver.NavigateToHomepage();

        }

        public static void ClickVideosButton()
        {
            Common.Click(Locators.HomepageButtons.inputVideos);
            Driver.NavigateToHomepage();
        }

        public static void ClickUpgradeButton()
        {
            Common.Click(Locators.HomepageButtons.inputUpgrade);
            Driver.NavigateToHomepage();
        }

        public static void ClickGetCertifiedButton()
        {
            Common.Click(Locators.HomepageButtons.inputGetCertified);
            Driver.ClosePage();
            Driver.NavigateToHomepage();
        }

        public static void ClickCreateWebsiteButton()
        {
            Common.Click(Locators.HomepageButtons.inputCreateWebsite);
        }

        public static void ClickSignUpButton()
        {
            Common.Click(Locators.HomepageButtons.inputSignUp);
            Driver.NavigateToHomepage();
        }

        public static void ClickLogInButton()
        {            
            Common.Click(Locators.HomepageButtons.inputLogIn);
            Common.Click(Locators.HomepageButtons.backToHomepage);
        }

        public static void ClickDarkModeButton()
        {
            Common.Click(Locators.HomepageButtons.inputDarkMode);
        }

        public static void ClickGlobeButton()
        {
            Common.Click(Locators.HomepageButtons.inputGlobe);
        }

        public static void ClickSearchButton()
        {
            Common.Click(Locators.HomepageButtons.inputSearch1);
            Common.GetElementText(Locators.HomepageButtons.inputSearch1);
        }


        //Linkai
        public static void ClickNotSureLink()
        {
            Common.Click(Locators.HomepageButtons.inputNotSureLink);
            Driver.NavigateToHomepage();
        }

        public static void ClickSearchOurTutorialsLink()
        {
            Common.SendKeys(Locators.HomepageButtons.inputSearchOurTutorialsLink, "HTML");
            Common.Click(Locators.HomepageButtons.inputSearchOurTutorialsLink);
            Common.GetElementText(Locators.HomepageButtons.inputSearchOurTutorialsLink);
            //Driver.NavigateToHomepage();
        }

        //Paieska
        public static void Search()
        {

        }
    }
}
