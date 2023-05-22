using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Framework.Pages.w3schools
{
    public class Homepage
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.w3schools.com/");
        }               
        
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
            return Common.GetElementText(Locators.HomepageButtons.inputTutorials);
        }
        
        public static string GetReferencesButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputReferences);
        }

        public static string GetExercisesButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputExercises);
        }

        public static string GetBootcampsButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputBootcamps);
        }
        
        public static string GetVideosButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputVideos);
        }

        public static string GetUpgradeButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputUpgrade);
        }

        public static string GetGetCertifiedButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputGetCertified);
        }

        public static string GetCreateWebsiteButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputCreateWebsite);
        }

        public static string GetSignUpButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputSignUp);
        }

        public static string GetLogInButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputLogIn);
        }

        public static string GetDarkMenuButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputDarkFrame);
        }

        public static string GetDarkModeButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputDarkMode);
        }

        public static string GetDarkCodeButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputDarkCode);
        }

        public static string GetGlobeButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputGlobeButton);
        }

        public static string GetLanguages()
        {
            string globeButton = "//*[@id='nav_translate_btn']";
            Common.Click(globeButton);
            string languageButton = "//*[@class='VIpgJd-yAWNEb-L7lbkb skiptranslate']";
            Common.JustWait();
            Common.Click(languageButton);

            string iframe = "//*[@id=':1.menuBody']/table/tbody/tr/td[1]/a[1]/div/span[2]";
            //string iframe = "//*[@name='cnftComm']";
            
            //string iframeLocator = "cnftComm";
            Common.SwitchToIframeByLocator(iframe);

            string headinglocator = "//*[@id=':1.menuBody']/table/tbody/tr/td[1]/a[1]/div/span[2]";

            return Common.GetElementText(headinglocator);


            //Common.Click(Locators.HomepageButtons.inputGlobeButton);
            ////Common.WaitForElementToBeVisible(Locators.HomepageButtons.inputSelectLanguage, "Pasirinkti kalbą");
            //Common.Click(Locators.HomepageButtons.inputSelectLanguage);
            ////Common.WaitForElementToBeVisible(Locators.HomepageButtons.inputIframeLanguages, "Pasirinkti kalbą");
            //Common.SwitchToIframeByLocator(Locators.HomepageButtons.inputIframeLanguages);

            //string languages = Common.GetElementText(Locators.HomepageButtons.inputIframeLanguages);

            //Common.SwitchToDefaultContent();

            //return languages;
        }


        public static void WaitForFrameToBeVisible()
        {
            Common.WaitForElementToBeVisible(Locators.HomepageButtons.inputDarkFrame, "darkmodemenu");
        }

        public static void ClickGlobeButton()
        {
            Common.Click(Locators.HomepageButtons.inputGlobeButton);
            Common.Click(Locators.HomepageButtons.selectLanguage);
            Common.WaitForElementToBeVisible(Locators.HomepageButtons.languageTable, "lietuvių");
            Common.Click(Locators.HomepageButtons.selectLietuviu);            
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

        //Paieska
        public static void ClickSearchOurTutorialsLink()
        {
            Common.SendKeys(Locators.HomepageButtons.inputSearchOurTutorialsLink, "HTML");
            Common.Click(Locators.HomepageButtons.inputSearchOurTutorialsLink);
            Common.GetElementText(Locators.HomepageButtons.inputSearchOurTutorialsLink);
            Driver.NavigateToHomepage();
        }        
    }
}
