using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
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
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
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

        internal static void PressKeyMultipleTimes(Actions actions, string key, int times)
        {
            for (int i = 0; i < times; i++)
            {
                actions.SendKeys(key);
            }
        }

        internal static void WriteHeading(string locator, string text)
        {
            IWebElement textbox = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());
            actions.Click(textbox);

            actions.SendKeys(Keys.PageUp);

            PressKeyMultipleTimes(actions, Keys.ArrowDown, 7);

            actions.SendKeys(Keys.End);
            actions.SendKeys(Keys.Control);

            PressKeyMultipleTimes(actions, Keys.ArrowLeft, 5);

            actions.KeyUp(Keys.Control);

            PressKeyMultipleTimes(actions, Keys.Backspace, 17);

            actions.KeyUp(Keys.Shift);
            actions.SendKeys(text);
            actions.Perform();
        }


        internal static void WriteParagraph(string locator, string text)
        {
            IWebElement textbox = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());
            actions.Click(textbox);
            actions.SendKeys(Keys.PageUp);
            PressKeyMultipleTimes(actions, Keys.ArrowDown, 8);
                        
            actions.SendKeys(Keys.End);
            actions.SendKeys(Keys.Control);

            PressKeyMultipleTimes(actions, Keys.ArrowLeft, 4);
                                    
            actions.KeyUp(Keys.Control);

            PressKeyMultipleTimes(actions, Keys.Backspace, 20);
                        
            actions.KeyUp(Keys.Shift);
            actions.SendKeys(text);
            actions.Perform();
        }
        internal static void CloseCurrentTab()
        {
            Driver.GetDriver().Close();
        }
    }    
}
