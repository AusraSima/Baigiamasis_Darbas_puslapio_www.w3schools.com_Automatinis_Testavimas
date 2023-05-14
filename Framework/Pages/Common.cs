using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using static System.Net.Mime.MediaTypeNames;

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
            IWebElement button = (IWebElement)Driver.GetDriver().FindElement(By.XPath(locator));
            button.Click();

            //here you do something like update or save 

            //then you define the button element again before you use it
            IWebElement button1 = Driver.GetDriver().FindElement(By.XPath(locator));
            //that new element will point to the same element in the new DOM
            button1.Click();
        }
        



        //internal static void SendKeys(string locator, string keys)
        //{
        //    GetElement(locator).SendKeys(keys);
        //}

        //internal static string GetElementText(string locator)
        //{
        //    return GetElement(locator).Text;
        //}

        //internal static void ScrollUntilElementIsClickable(string locator)
        //{
        //    IWebElement element = GetElement(locator);

        //    bool isClickable = false;
        //    int maxTries = 20;
        //    int currentTry = 0;

        //    while (!isClickable)
        //    {
        //        try
        //        {
        //            element.Click();
        //            isClickable = true;
        //        }
        //        catch (Exception exception)
        //        {
        //            if (exception is ElementClickInterceptedException && currentTry < maxTries)
        //            {
        //                Driver.GetDriver().ExecuteJavaScript("window.scrollBy(0, 200)");
        //                currentTry++;
        //            }
        //            else
        //            {
        //                throw exception;
        //            }
        //        }
        //    }
        //}

        //internal static string GetElementCssAttributeValue(string locator, string attribute)
        //{
        //    return GetElement(locator).GetCssValue(attribute);
        //}

        //internal static void WaitForElementCssAttributeValueToBe(string locator, string attributeName, string expectedAttributeValue)
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(2));
        //    wait.PollingInterval = TimeSpan.FromMilliseconds(50);
        //    wait.Until(driver => driver.FindElement(By.XPath(locator)).GetCssValue(attributeName).Equals(expectedAttributeValue));
        //}

        //internal static void WaitForElementIsVisible(string locator)
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
        //    //wait.PollingInterval = TimeSpan.FromMilliseconds(50);            
        //    //wait.Until(driver => driver.PageSource.Contains(locator));

        //    IWebElement button = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button")));

        //    // Click the button
        //    button.Click();

        //}
    }
}
