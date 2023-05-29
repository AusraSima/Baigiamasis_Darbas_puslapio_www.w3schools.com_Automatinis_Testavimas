namespace Framework.Pages.w3schools
{
    public class LogInVerification
    {
        public static void Open()
        {
            Driver.OpenPage("https://profile.w3schools.com/");
        }

        public static void RegistrationWithInvalidData()
        {
            Common.SendKeys(Locators.LogInPageButtons.inputEmailAddress, "rob@handleride.com");
            Common.SendKeys(Locators.LogInPageButtons.inputPassword, "159AbCd");
            Common.Click(Locators.LogInPageButtons.inputLogInButton);
        }

        public static string RegistrationWithInvalidDataResult()
        {
            Common.WaitForElementToBeVisible(Locators.LogInPageButtons.elementToBeVisibleWhenInvalidData);
            return Common.GetElementText(Locators.LogInPageButtons.outputInvalidData);
        }

        public static void RegistrationWithoutPassword()
        {
            Common.SendKeys(Locators.LogInPageButtons.inputEmailAddress, "avasims@handleride.com");
            Common.Click(Locators.LogInPageButtons.inputLogInButton);
        }

        public static string RegistrationWithoutPasswordResult()
        {
            Common.WaitForElementToBeVisible(Locators.LogInPageButtons.elementToBeVisibleWhenInvalidData);
            return Common.GetElementText(Locators.LogInPageButtons.outputPasswordNotEntered);
        }

        public static void RegistrationWithoutEmail()
        {
            Common.SendKeys(Locators.LogInPageButtons.inputPassword, "QijHRYEc15#");
            Common.Click(Locators.LogInPageButtons.inputLogInButton);
        }
        
        public static string RegistrationWithoutEmailResult()
        {
            return Common.GetElementText(Locators.LogInPageButtons.outputEmailNotEntered);
        }      

        public static void RegistrationWithValidData()
        {
            Common.SendKeys(Locators.LogInPageButtons.inputEmailAddress, "avasims@handleride.com");
            Common.SendKeys(Locators.LogInPageButtons.inputPassword, "QijHRYEc15#");
            Common.Click(Locators.LogInPageButtons.inputLogInButton);
        }

        public static string RegistrationWithValidDataResult()
        {
            Common.WaitForElementToBeVisible(Locators.LogInPageButtons.outputValidData);
            return Common.GetElementText(Locators.LogInPageButtons.outputValidData);
        }

        public static void LogOutVerification()
        {
            Common.WaitForElementToBeVisible(Locators.LogInPageButtons.inputLogOutButton);
            Common.Click(Locators.LogInPageButtons.inputLogOutButton);
        }

        public static string LogOutVerificationResult()
        {
            Common.WaitForElementToBeVisible(Locators.LogInPageButtons.outputLogOutResult);
            return Common.GetElementText(Locators.LogInPageButtons.outputLogOutResult);
        }
    }
}
