using static Framework.Pages.Locators;

namespace Framework.Pages
{
    internal static class Locators
    {
        internal static class HomepageButtons
        {            
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
            internal static string inputDarkMode = "//*[@id='main']/div[1]/div/a[3]/i";
            internal static string inputGlobe = "//*[@id='nav_translate_btn']";
            internal static string inputSearch1 = "//*[@id='nav_search_btn']";
            internal static string inputNotSureLink = "//*[@id='main']/div[2]/div/h4/a";
            internal static string inputSearchOurTutorialsLink = "//*[@id='search2']";
            internal static string backToHomepage = "//*[@id='root']/div/div/div[2]/div/a";
        }
    }
}
