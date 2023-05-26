using NUnit.Framework;
using Framework.Pages.w3schools;
using Tests.BaseTests;

namespace Tests.w3schoolsTests
{
    internal class w3schoolsHomepage : BaseTests
    {
        [SetUp]

        public void Open()
        {
            Homepage.Open();
        
            Homepage.AcceptCookies();
        }

        [Test]

        public void CheckHomepage()
        {
            string expectedLogo = "";
            string actualLogo = Homepage.GetLogoButtonText();
            Assert.AreEqual(expectedLogo, actualLogo);

            string expectedTutorials = "Tutorials";
            string actualTutorials = Homepage.GetTutorialsButtonText();
            Assert.AreEqual(expectedTutorials, actualTutorials);

            string expectedReferences = "References";
            string actualReferences = Homepage.GetReferencesButtonText();
            Assert.AreEqual(expectedReferences, actualReferences);

            string expectedExercises = "Exercises";
            string actualExercises = Homepage.GetExercisesButtonText();
            Assert.AreEqual(expectedExercises, actualExercises);

            string expectedBootcamps = "Bootcamps";
            string actualBootcamps = Homepage.GetBootcampsButtonText();
            Assert.AreEqual(expectedBootcamps, actualBootcamps);

            string expectedVideos = "Videos";
            string actualVideos = Homepage.GetVideosButtonText();
            Assert.AreEqual(expectedVideos, actualVideos);

            string expectedUpgrade = "Upgrade";
            string actualUpgrade = Homepage.GetUpgradeButtonText();
            Assert.AreEqual(expectedUpgrade, actualUpgrade);

            string expectedGetCertified = "Get Certified";
            string actualGetCertified = Homepage.GetGetCertifiedButtonText();
            Assert.AreEqual(expectedGetCertified, actualGetCertified);

            string expectedCreateWebsite = "Create Website";
            string actualCreateWebsite = Homepage.GetCreateWebsiteButtonText();
            Assert.AreEqual(expectedCreateWebsite, actualCreateWebsite);

            string expectedSignUp = "Sign Up";
            string actualSignUp = Homepage.GetSignUpButtonText();
            Assert.AreEqual(expectedSignUp, actualSignUp);

            string expectedLogIn = "Log in";
            string actualLogIn = Homepage.GetLogInButtonText();
            Assert.AreEqual(expectedLogIn, actualLogIn);

            string expectedDarkMenu = "Dark mode\r\nDark code";
            string actualDarkMenu = Homepage.GetDarkMenuButtonText();
            Assert.AreEqual(expectedDarkMenu, actualDarkMenu);

            string expectedModeValue = "Dark mode";
            string expectedCodeValue = "Dark code";
            string actualModeValue = Homepage.GetDarkModeButtonText();
            string actualCodeValue = Homepage.GetDarkCodeButtonText();
            Assert.AreEqual(expectedModeValue, actualModeValue);
            Assert.AreEqual(expectedCodeValue, actualCodeValue);

            string expectedGlobeButtnon = "";
            string actualGlobeButton = Homepage.GetGlobeButtonText();
            Assert.AreEqual(expectedGlobeButtnon, actualGlobeButton);
            string expectedLanguageFrame = "";
            string actualLanguageFrame = Homepage.GetLanguages();
            Assert.AreEqual(expectedLanguageFrame, actualLanguageFrame);

            Homepage.Open(); 

            string expectedSeachButton = "";
            string actualSearchButton = Homepage.GetSearchButtonText();
            Assert.AreEqual(expectedSeachButton, actualSearchButton);
            Homepage.GetSearchField();

            string expectedSearchOurTutorials = "";
            string actualSearchOurTutorials = Homepage.ClickSearchOurTutorialsLink();
            Assert.AreEqual(expectedSearchOurTutorials, actualSearchOurTutorials);

            Homepage.Open();

            string expectedNotSureLink = "Not Sure Where To Begin?";
            string actualNotSureLink = Homepage.GetNotSureLink();
            Assert.AreEqual(expectedNotSureLink, actualNotSureLink);

            Homepage.CodeGame();
        }        
    }
}