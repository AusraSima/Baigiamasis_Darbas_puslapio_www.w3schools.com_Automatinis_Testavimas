using System.Collections.Generic;
using System.Linq;

namespace Framework.Pages.w3schools
{
    public class HTMLTutorials
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.w3schools.com/html/default.asp");
        }
        public static void AcceptCookies()
        {
            string buttonAcceptCookies = "//*[@id='accept-choices']";
            Common.Click(buttonAcceptCookies);
            Common.WaitForElementToNotContainText(buttonAcceptCookies, "Accept all &; visit the site");
        }

        public static void WatchOurVideoField()
        {
            Common.Click(Locators.HTMLTutorialsButtons.inputVideoButton);
            Common.Click(Locators.HTMLTutorialsButtons.playVideoButton);
            Common.WaitForElementToBeVisible(Locators.HTMLTutorialsButtons.videoTutorialsPage);            
        }

        public static void TryItYourselfField()
        {
            Common.Click(Locators.HTMLTutorialsButtons.inputTryItYourself);

            List<string> handles = Common.GetWindowHandles();
            Common.SwitchToWindowByHandle(handles.Last());
            Common.WaitForElementToBeVisible(Locators.HTMLTutorialsButtons.inputTextArea);
            
            Common.WriteHeading(Locators.HTMLTutorialsButtons.inputTextArea, "Tai tik pavadinimas");
            Common.GetElementText(Locators.HTMLTutorialsButtons.inputTextArea);
            Common.WriteParagraph(Locators.HTMLTutorialsButtons.inputTextArea, "Tai tik paragrafas");
            Common.GetElementText(Locators.HTMLTutorialsButtons.inputTextArea);
            Common.Click(Locators.HTMLTutorialsButtons.inputRunButton);
            Common.CloseCurrentTab();

            Common.SwitchToWindowByHandle(handles.First());
        }

        public static void TestYourselfWithExercises()
        {
            Common.Click(Locators.HTMLTutorialsButtons.startTheExerciseButton);

            List<string> handles = Common.GetWindowHandles();
            Common.SwitchToWindowByHandle(handles.Last());
            Common.WaitForElementToBeVisible(Locators.HTMLTutorialsButtons.inputExercise);
            Common.SendKeys(Locators.HTMLTutorialsButtons.inputExercise, "title");
            Common.Click(Locators.HTMLTutorialsButtons.submitAnswerButton);
        }
        public static string GetExerciseAnswer()
        {
            return Common.GetElementText(Locators.HTMLTutorialsButtons.answerCorrect);
        }        
    }
}
