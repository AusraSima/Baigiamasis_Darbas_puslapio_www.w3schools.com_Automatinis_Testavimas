using OpenQA.Selenium.DevTools.V110.Input;
using static Framework.Pages.Locators;

namespace Framework.Pages
{
    internal static class Locators
    {
        internal static class HomepageButtons
        {    
            //Menu buttons
            internal static string inputTutorials = "//*[@id='navbtn_tutorials']";
            internal static string inputReferences = "//*[@id='navbtn_references']";
            internal static string inputExercises = "//*[@id='navbtn_exercises']";
            internal static string inputBootcamps = "/html/body/div[3]/a[5]";
            internal static string inputVideos = "/html/body/div[3]/a[6]";
            internal static string inputUpgrade = "/html/body/div[3]/div[2]/a[5]";
            internal static string inputGetCertified = "//*[@id='cert_navbtn']";
            internal static string inputCreateWebsite = "/html/body/div[3]/div[2]/a[3]";
            internal static string inputSignUp = "//*[@id='signupbtn_topnav']";
            internal static string inputLogIn = "//*[@id='w3loginbtn']";

            //Right bar buttons
            internal static string inputDarkFrame = "//*[contains(@id, 'darkmodemenu')]";
            internal static string inputDarkMode = "//*[@id='darkmodemenu']/label[1]";
            internal static string inputDarkCode = "//*[@id='darkmodemenu']/label[2]";

            internal static string inputGlobeButton = "//*[@id='nav_translate_btn']/i";
            internal static string inputIframeLanguages = "/html/body/iframe[4]";
            internal static string inputSelectLanguage = "//*[@id=':1.menuBody']/table/tbody/tr/td[1]/a[1]";

            internal static string inputSearch1 = "//*[@id='nav_search_btn']";
            internal static string inputNotSureLink = "//*[@id='main']/div[2]/div/h4/a";
            internal static string inputSearchOurTutorialsLink = "//*[@id='search2']";
            internal static string backToHomepage = "//*[@id='root']/div/div/div[2]/div/a";
            internal static string selectLanguage = "//*[@id=':0.targetLanguage']/span/a";
            internal static string languageTable = "//*[@id=':1.menuBody']";
            internal static string selectLietuviu = "//*[@id=':1.menuBody']/table/tbody/tr/td[1]/a[2]/div/span[2]";
        }

        internal static class LogInPageButtons
        {
            internal static string inputEmailAddress = "//*[@id='modalusername']";
            internal static string inputPassword = "//*[@id='current-password']";
            internal static string inputLogInButton = "//*[@id='root']/div/div/div[4]/div[1]/div/div[4]/div[1]/button";
            internal static string inputLogOutButton = "//*[@id='navigation']/div[2]/div";
            internal static string inputHomeButton = "//*[@id='root']/div/div/div[2]/div/a/svg";
        }

        internal static class HTMLTutorialsButtons
        {
            internal static string inputTryItYourself = "//*[@id='main']/div[4]/a";
            internal static string inputHeading = "//*[@id='textareawrapper'']/div/div[6]/div[1]/div/div/div/div[5]/pre[8]/span/span[4]";
            internal static string inputParagraph = "//*[@id='textareawrapper']/div/div[6]/div[1]/div/div/div/div[5]/pre[9]/span/span[4]";
            internal static string inputRunButton = "//*[@id='runbtn']";
        }
    }
}
