using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;

namespace Framework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void WaitForElementToNotContainText(string locator, string text)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(5));
            wait.Until(driver => !driver.FindElement(By.XPath(locator)).Text.Contains(text));
        }

        internal static void WaitForElementToContainText(string locator, string text)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).Text.Contains(text));
        }

        internal static void MeniuMygtukai(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }        
    }    
}
