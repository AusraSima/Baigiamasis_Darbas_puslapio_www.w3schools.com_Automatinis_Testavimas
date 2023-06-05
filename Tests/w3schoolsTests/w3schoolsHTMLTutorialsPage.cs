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

        // Šį testą reikėtų suskaidyti į tris atskirus testus
        [Test]
        public void CheckHTMLTutorials()
        {
            HTMLTutorials.WatchOurVideoField();
            HTMLTutorials.Open();

            // Šis metodas turėtų būti kaip atskiras testas
            HTMLTutorials.TryItYourselfField();
            
            // Ši dalis taip pat turėtų būti kaip atskiras testas
            HTMLTutorials.TestYourselfWithExercises();
            string expectedExerciseAnswer = "Correct!";
            string actualExerciseAnswer = HTMLTutorials.GetExerciseAnswer();
            Assert.AreEqual(expectedExerciseAnswer, actualExerciseAnswer);
        }
    }
}
