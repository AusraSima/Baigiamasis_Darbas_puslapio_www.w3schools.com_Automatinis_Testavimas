using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Framework.Pages.w3schools
{
    public class LogIn
    {
        public static void Open()
        {
            Driver.OpenPage("https://profile.w3schools.com/");
        }
        
        public static void AcceptCookies()
        {
            string buttonAcceptCookies = "//*[@id='accept-choices']";
            Common.Click(buttonAcceptCookies);
            Common.WaitForElementToNotContainText(buttonAcceptCookies, "Accept all &; visit the site");
        }
    }
}
