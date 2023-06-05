namespace Framework.Pages
{
    internal static class Locators
    {
        internal static class HomepageButtons
        {
            //Menu buttons
            internal static string inputHome = "/html/body/div[3]/a[1]";
            internal static string backToHomepage = "/html/body/div[4]/a[1]";
            internal static string inputTutorials = "//*[@id='navbtn_tutorials']";
            internal static string inputReferences = "//*[@id='navbtn_references']";
            internal static string inputExercises = "//*[@id='navbtn_exercises']";
            internal static string inputBootcamps = "/html/body/div[3]/a[5]";
            internal static string inputVideos = "/html/body/div[3]/a[6]"; 
            internal static string inputUpgrade = "/html/body/div[3]/div[2]/a[5]";
            internal static string inputGetCertified = "//*[@id='cert_navbtn']";
            internal static string outputGetCertified = "//*[@id='site-header-nav']/nav/ul/li[1]/a";
            internal static string inputCreateWebsite = "/html/body/div[3]/div[2]/a[3]";
            internal static string inputSignUp = "//*[@id='signupbtn_topnav']";
            internal static string inputLogIn = "//*[@id='w3loginbtn']";
            internal static string inputClose = "//*[@id='navigation']/div/div/button";

            //Right bar buttons
            internal static string inputDarkFrame = "//*[contains(@id, 'darkmodemenu')]";
            internal static string inputDarkMode = "//*[@id='darkmodemenu']/label[1]";
            internal static string inputDarkCode = "//*[@id='darkmodemenu']/label[2]";

            internal static string inputGlobeButton = "//*[@id='nav_translate_btn']";
            internal static string inputLanguageButton = "//*[@id=':0.targetLanguage']";
            internal static string inputIframe = "//*[@title='Kalbos Vertėjo valdiklis']";
            internal static string inputLanguageLietuviu = "//*[@id=':1.menuBody']/table/tbody/tr/td[1]/a[2]/div";

            internal static string inputSearch = "//*[@id='nav_search_btn']/i";
            internal static string inputSearchField = "(//*[@class= 'gsc-input'])[2]";
            internal static string inputSearchIcon = "//*[@id='learntocode_searchicon']";
            internal static string searchdResultField = "//*[@id='___gcse_0']/div/div/div[1]";
            internal static string resultFieldOff = "//*[@id='___gcse_0']/div/div/div[1]/div[1]";

            //Other Homepage buttons and links
            internal static string inputSearchOurTutorialsLink = "//*[@id='search2']";
            internal static string inputNotSureLink = "//*[@id='main']/div[2]/div/h4/a";

            internal static string inputPlayGame = "//*[@id='main']/div[15]/div/p/a";
            internal static string inputGoForward = "//*[@id='codeGame-button-forward']";
            internal static string inputPlayCode = "//*[@id='codeGame-button-runsequence']";
            internal static string inputPlayNextLevel = "//*[@id='codeGame-nextLevel']";
        }

        internal static class LogInPageButtons
        {
            internal static string inputEmailAddress = "//*[@id='modalusername']";
            internal static string inputPassword = "//*[@id='current-password']";
            internal static string inputLogInButton = "//*[@id='root']/div/div/div[4]/div[1]/div/div[4]/div[1]/button";
            internal static string inputLogOutButton = "//*[@id='navigation']/div[2]/div";
            internal static string inputHomeButton = "//*[@id='root']/div/div/div[2]/div/a/svg";
            internal static string elementToBeVisibleWhenInvalidData = "//*[@id='root']/div/div/div[4]/div[1]/div/div[3]/div";
            internal static string outputInvalidData = "//div[contains(@class, 'Alert_danger__Wsdhv')]";            
            internal static string outputPasswordNotEntered = "//*[@id='root']/div/div/div[4]/div[1]/div/div[3]/div";
            internal static string outputEmailNotEntered = "//*[@id='root']/div/div/div[4]/div[1]/div/div[2]/form/div[1]/span";
            internal static string outputValidData = "//*[@id='scoreCardMLW3S']/div[1]";
            internal static string outputLogOutResult = "//*[@id='root']/div/div/div[4]/div[1]/div/div[1]/h1";
        }

        internal static class HTMLTutorialsButtons
        {
            internal static string videoTutorialsPage = "/html/body/div[6]/div[1]/div/h1";
            internal static string inputVideoButton = "//*[@id='main']/div[3]/a[2]";
            internal static string playVideoButton = "//*[@id='my-video']/button";
            internal static string stopVideo = "//*[@id='my-video']/div[5]/button[1]";
            
            internal static string backToHTMLTutorials = "//*[@id='pagetop']/a[1]";
            internal static string inputTryItYourself = "//*[@id='main']/div[4]/a";
            internal static string inputTextArea = "//*[@id='textareawrapper']/div/div[6]";
            internal static string inputRunButton = "//*[@id='runbtn']";

            internal static string startTheExerciseButton = "//*[@id='w3-exerciseform']/div/p[2]/a";
            internal static string inputExercise = "//*[@id='assignmentcontainer']/input";
            internal static string submitAnswerButton = "//*[@id='answerbutton']";
            internal static string answerCorrect = "//*[@id='assignmentCorrect']/h2";
        }
    }
}
