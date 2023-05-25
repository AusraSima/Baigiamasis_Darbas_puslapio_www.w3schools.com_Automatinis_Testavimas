using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.w3schools
{
    public class HTMLTutorials
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.w3schools.com/html/default.asp");
        }
        //Cookies
        public static void AcceptCookies()
        {
            string buttonAcceptCookies = "//*[@id='accept-choices']";
            Common.Click(buttonAcceptCookies);
            Common.WaitForElementToNotContainText(buttonAcceptCookies, "Accept all &; visit the site");
        }

        public static void TryItYourselfField()
        {
            Common.Click(Locators.HTMLTutorialsButtons.inputTryItYourself);

            List<string> handles = Common.GetWindowHandles();
            Common.SwitchToWindowByHandle(handles.Last());
            Common.WaitForElementTextToBeVisible(Locators.HTMLTutorialsButtons.inputTextArea, "This is a Heading");
            
            Common.Write1(Locators.HTMLTutorialsButtons.inputTextArea, "Tai tik pavadinimas");
            Common.GetElementText(Locators.HTMLTutorialsButtons.inputTextArea);
            Common.Write2(Locators.HTMLTutorialsButtons.inputTextArea, "Tai tik paragrafas");
            Common.GetElementText(Locators.HTMLTutorialsButtons.inputTextArea);
            Common.Click(Locators.HTMLTutorialsButtons.inputRunButton);

            //Common.Write(Locators.HTMLTutorialsButtons.inputParagraph, "Tiesiog paragrafas");





            //Common.SendKeys(Locators.HTMLTutorialsButtons.inputHeading, "Pavadinimas");
            //    Common.SendKeys(Locators.HTMLTutorialsButtons.inputParagraph, "Paragrafas");
            //    Common.Click(Locators.HTMLTutorialsButtons.inputRunButton);
            //    Common.GetElementText(Locators.HTMLTutorialsButtons.inputHeading);
            //    Common.GetElementText(Locators.HTMLTutorialsButtons.inputParagraph);

            //    Common.SwitchToWindowByHandle(handles.First());            
        }
    }
}
