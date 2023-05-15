using OpenQA.Selenium;

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
            string locator = "//*[@id='myAccordion']/div/a[1]";
            Common.Click(locator);
            //Common.WaitForElementToContainText(locator, "open_xs_menu(tutorials);");
            //Common.Click(locator);
        }

        public static void ClickReferencesButton()
        {
            string locator = "//*[@id='myAccordion']/div/a[2]";
            Common.Click(locator);
        }

        public static void ClickExercicesButton()
        {
            string locator = "//*[@id='myAccordion']/div/a[3]";
            Common.Click(locator);
        }

        public static void ClickBootcampsButton()
        {
            string locator = "//*[@id='myAccordion']/div/a[8]";
            Common.Click(locator);
        }

        public static void ClickVideosButton()
        {
            string locator = "//*[@id='myAccordion']/div/a[9]";
            Common.Click(locator);
        }

        //Linkai
        public static void ClickLink()
        {

        }

        //Paieska
        public static void Search()
        {

        }
    }
}
