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
            HTMLTutorials.AcceptCookies();
        }

        [Test]
        public void CheckHTMLTutorials()
        {
            HTMLTutorials.WatchOurVideoField();
            HTMLTutorials.Open();
            HTMLTutorials.TryItYourselfField();
            
            HTMLTutorials.TestYourselfWithExercises();
            string expectedExerciseAnswer = "Correct!";
            string actualExerciseAnswer = HTMLTutorials.GetExerciseAnswer();
            Assert.AreEqual(expectedExerciseAnswer, actualExerciseAnswer);
        }
    }
}
