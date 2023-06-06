using Framework.Pages.w3schools;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.w3schoolsTests
{
    internal class w3schoolsHTMLTutorialsPage : BaseTest
    {
        [SetUp]
        public void Open()
        {
            HTMLTutorials.Open();
            Homepage.AcceptCookies();
        }

        [Test]
        public void CheckWatchOurVideoField()
        {
            string expectedWatchOurVideoButton = "Watch our Video Tutorial »\r\nNEW";
            string actualWatchOurVideoButton = HTMLTutorials.GetWatchOurVideoButtonText();
            Assert.AreEqual(expectedWatchOurVideoButton, actualWatchOurVideoButton);

            HTMLTutorials.GoToVideoPage();

            string expectedVideoTurorialTitle = "Play Video";
            string actualVideoTurorialTitle = HTMLTutorials.GetPlayVideoButtonText();
            Assert.AreEqual(expectedVideoTurorialTitle, actualVideoTurorialTitle);
        }

        [Test]
        public void CheckTryItYourselfField()
        {
            HTMLTutorials.TryItYourselfField();
        }
        
        [Test]
        public void CheckTestYourselfWithExercises()
        {
            HTMLTutorials.TestYourselfWithExercises();
            string expectedExerciseAnswer = "Correct!";
            string actualExerciseAnswer = HTMLTutorials.GetExerciseAnswer();
            Assert.AreEqual(expectedExerciseAnswer, actualExerciseAnswer);
        }
    }
}
