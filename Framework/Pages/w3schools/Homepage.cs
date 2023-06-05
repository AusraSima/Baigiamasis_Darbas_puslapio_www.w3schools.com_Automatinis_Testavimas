using System.Collections.Generic;
using System.Linq;

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
        
        public static string GetTutorialsButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputTutorials);
        }

        public static void ClickTutorialsButton()
        {
            Common.Click(Locators.HomepageButtons.inputTutorials);
        }

        public static string GetReferencesButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputReferences);
        }

        public static void ClickReferencesButton()
        {
            Common.Click(Locators.HomepageButtons.inputReferences);
        }

        public static string GetExercisesButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputExercises);
        }

        public static void ClickExercisesButton()
        {
            Common.Click(Locators.HomepageButtons.inputExercises);
        }


        public static string GetBootcampsButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputBootcamps);
        }

        public static void ClickBootcampsButton()
        {
            Common.Click(Locators.HomepageButtons.inputBootcamps);
        }

        public static string GetVideosButtonText()
        {
            Common.WaitForElementToBeVisible(Locators.HomepageButtons.inputVideos);
            return Common.GetElementText(Locators.HomepageButtons.inputVideos);
        }

        public static void ClickVideosButton()
        {
            Common.Click(Locators.HomepageButtons.inputVideos);
        }

        public static string GetUpgradeButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputUpgrade);
        }

        public static void ClickUpgradeButton()
        {
            Common.Click(Locators.HomepageButtons.inputUpgrade);
        }

        public static string GetGetCertifiedButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputGetCertified);
        }

        public static void ClickGetCertifiedButton()
        {
            Common.Click(Locators.HomepageButtons.inputGetCertified);

            List<string> handles = Common.GetWindowHandles();
            Common.SwitchToWindowByHandle(handles.Last());
            Common.WaitForElementToBeVisible(Locators.HomepageButtons.outputGetCertified);
            
            Common.SwitchToWindowByHandle(handles.First());
        }

        public static string GetCreateWebsiteButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputCreateWebsite);
        }

        public static void ClickCreateWebsiteButton()
        {
            Common.Click(Locators.HomepageButtons.inputCreateWebsite);
        }

        public static string GetSignUpButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputSignUp);
        }

        public static void ClickSignUpButton()
        {
            Common.Click(Locators.HomepageButtons.inputSignUp);
        }

        public static string GetLogInButtonText()
        {
            return Common.GetElementText(Locators.HomepageButtons.inputLogIn);
        }

        public static void ClickLogInButton()
        {
            Common.Click(Locators.HomepageButtons.inputLogIn);
            Common.WaitForElementToBeVisible(Locators.HomepageButtons.inputClose);
            Common.Click(Locators.HomepageButtons.inputClose);
        }

        public static string GetDarkMenuButtonText()
        {
            Common.WaitForElementToBeVisible(Locators.HomepageButtons.inputDarkFrame);
            return Common.GetElementText(Locators.HomepageButtons.inputDarkFrame);
        }

        public static string GetDarkModeButtonText()
        {
            Common.WaitForElementToBeVisible(Locators.HomepageButtons.inputDarkMode);
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


        public static void ClickMenuSearchButton()
        {
            Common.Click(Locators.HomepageButtons.inputSearch);
        }

        public static void EnterSearchPhrase(string phrase)
        {
            Common.WaitForElementToBeVisible(Locators.HomepageButtons.inputSearchField);
            Common.SendKeys(Locators.HomepageButtons.inputSearchField, phrase);
        }

        public static void ClickButtonToSearchForPhrase()
        {
            Common.Click(Locators.HomepageButtons.inputSearchIcon);
        }

        public static string GetSearchField()
        {
            Common.WaitForElementToBeVisible("//*[contains(@class,'gsc-results-wrapper-visible')]");
            return Common.GetElementText(Locators.HomepageButtons.searchdResultField);
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
            Common.WaitForElementTextToBeVisible(Locators.HomepageButtons.inputPlayNextLevel, "Play next level");
            Common.Click(Locators.HomepageButtons.inputPlayNextLevel);
            Common.Click(Locators.HomepageButtons.inputGoForward);
            Common.Click(Locators.HomepageButtons.inputGoForward);
            Common.Click(Locators.HomepageButtons.inputGoForward);
            Common.Click(Locators.HomepageButtons.inputGoForward);
            Common.Click(Locators.HomepageButtons.inputPlayCode);

            Common.SwitchToWindowByHandle(handles.First());
        }   
    }
}
