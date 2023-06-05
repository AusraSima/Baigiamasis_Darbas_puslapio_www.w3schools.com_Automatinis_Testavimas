using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        
        internal static IWebDriver GetDriver() 
        {
            return driver;
        }
        
        internal static void OpenPage(string url)
        {
            driver.Url = url;
        }        
        
        public static void ShutDownDriver() 
        {
            driver.Quit();
        }

        public static string TakeScreenshot(string methodName)
        {
            string screenshotDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}-{methodName}.png";
            string screenshotFilePath = $"{screenshotDirectoryPath}\\{screenshotName}";
            
            Directory.CreateDirectory(screenshotDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"{screenshotFilePath}", ScreenshotImageFormat.Png);

            return screenshotFilePath;
        }
    }
}
