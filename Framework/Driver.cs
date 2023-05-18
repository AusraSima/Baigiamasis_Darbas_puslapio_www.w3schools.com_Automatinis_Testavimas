using Framework.Pages.w3schools;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver(); 
        }
        
        internal static IWebDriver GetDriver() 
        {
            return driver;
        }
        
        internal static void OpenPage(string url)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();
        }
        
        public static void NavigateToHomepage() 
        {
            driver.Navigate().GoToUrl("https://www.w3schools.com/");
        }        

        public static void ClosePage()
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
        public static void ShutDownDriver() 
        {
            driver.Quit();
        }
    }
}
