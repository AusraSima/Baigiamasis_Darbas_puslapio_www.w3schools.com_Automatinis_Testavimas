using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Common.Click(Locators.HomepageButtons.inputGlobeButton);
            Common.WaitForElementTextToBeVisible(Locators.HomepageButtons.inputLanguageButton, "Pasirinkti kalbą");
            Common.Click(Locators.HomepageButtons.inputLanguageButton);
            Common.SwitchToIframeByLocator(Locators.HomepageButtons.inputIframe);
            Common.Click(Locators.HomepageButtons.inputLanguageLietuviu);

            return Common.GetElementText(Locators.HomepageButtons.inputLanguageLietuviu);
        }
       
        public static string GetSearchButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputSearch);
        }

        public static string ClickSearchOurTutorialsLink()
        {
            Common.SendKeys(Locators.HomepageButtons.inputSearchOurTutorialsLink, "HTML");
            Common.Click(Locators.HomepageButtons.inputSearchOurTutorialsLink);
            return Common.GetElementText(Locators.HomepageButtons.inputSearchOurTutorialsLink);
        }

        public static string GetNotSureLink()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputNotSureLink);
        }

        public static void CodeGame()
        {
            Common.Click(Locators.HomepageButtons.inputPlayGame);
            
            List<string> handles = Common.GetWindowHandles();
            Common.SwitchToWindowByHandle(handles.Last());
            Common.WaitForElementToBeVisible(Locators.HomepageButtons.inputGoForward);
            Common.Click(Locators.HomepageButtons.inputGoForward);
            Common.Click(Locators.HomepageButtons.inputGoForward);
            Common.Click(Locators.HomepageButtons.inputPlayCode);

            Common.SwitchToWindowByHandle(handles.First());
        }





        

        
        public static void ClickSearchButton()
        {
            Common.Click(Locators.HomepageButtons.inputSearch);
            Common.GetElementText(Locators.HomepageButtons.inputSearch);
        }


          
    }
}
