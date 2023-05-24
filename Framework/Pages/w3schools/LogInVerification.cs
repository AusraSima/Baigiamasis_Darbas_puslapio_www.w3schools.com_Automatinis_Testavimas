using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Framework.Pages.w3schools
{
    public class LogInVerification
    {
        public static void Open()
        {
            Driver.OpenPage("https://profile.w3schools.com/");
        }

        public static void EnterValidEmail()
        {
            Common.SendKeys(Locators.LogInPageButtons.inputEmailAddress, "avasims@handleride.com");
            Common.SendKeys(Locators.LogInPageButtons.inputPassword, "QijHRYEc15#");
            Common.Click(Locators.LogInPageButtons.inputLogInButton);
        }

        public static void ExitValidEmail()
        {
            Common.WaitForElementToBeVisible(Locators.LogInPageButtons.inputLogOutButton);
            Common.Click(Locators.LogInPageButtons.inputLogOutButton);
        }               
    }
}
