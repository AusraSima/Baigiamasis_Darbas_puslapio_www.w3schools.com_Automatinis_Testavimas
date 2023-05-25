using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;
using Framework.Pages.w3schools;
using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;

namespace Framework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static IWebElement GetElementByTagName(string name)
        {
            return Driver.GetDriver().FindElement(By.TagName(name));
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

        internal static void WaitForElementTextToBeVisible(string locator, string text)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).Text.Contains(text));
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).Displayed);
        }

        internal static void JustWait()
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(5));
        }
        
        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void SwitchToIframeByLocator(string locator)
        {
            IWebElement element = GetElement(locator);
            Driver.GetDriver().SwitchTo().Frame(element);
        }

        internal static void SwitchToDefaultContent()
        {
            Driver.GetDriver().SwitchTo().DefaultContent();
        }

        internal static List<string> GetWindowHandles()
        {
            return Driver.GetDriver().WindowHandles.ToList();
        }
        
        internal static void SwitchToWindowByHandle(string handle)
        {
            Driver.GetDriver().SwitchTo().Window(handle);
        }

        internal static void Write1(string locator, string text)
        {            
            IWebElement textbox = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());
            actions.Click(textbox);            
            actions.SendKeys(Keys.PageUp);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.End);
            actions.SendKeys(Keys.Control);
            actions.SendKeys(Keys.ArrowLeft);
            actions.SendKeys(Keys.ArrowLeft);
            actions.SendKeys(Keys.ArrowLeft);
            actions.SendKeys(Keys.ArrowLeft);
            actions.SendKeys(Keys.ArrowLeft);
            actions.KeyUp(Keys.Control);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace); // tiek daug backspace, nes kitaip tinkamai neveike
            actions.KeyUp(Keys.Shift);
            actions.SendKeys(text);
            actions.Perform();
        }

        internal static void Write2(string locator, string text)
        {
            IWebElement textbox = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());
            actions.Click(textbox);
            actions.SendKeys(Keys.PageUp);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.ArrowDown);
            actions.SendKeys(Keys.End);
            actions.SendKeys(Keys.Control);
            actions.SendKeys(Keys.ArrowLeft);
            actions.SendKeys(Keys.ArrowLeft);
            actions.SendKeys(Keys.ArrowLeft);
            actions.SendKeys(Keys.ArrowLeft);
            actions.SendKeys(Keys.ArrowLeft);
            actions.KeyUp(Keys.Control);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.SendKeys(Keys.Backspace);
            actions.KeyUp(Keys.Shift);
            actions.SendKeys(text);
            actions.Perform();
        }
    }    
}
