using NUnit.Framework;
using Framework.Pages.w3schools;
using Tests.BaseTests;

namespace Tests.w3schoolsTests
{
    internal class w3schoolsHomepage : BaseTestSingleSession
    {
        [OneTimeSetUp]
        public void Open()
        {
            Homepage.Open();
            Homepage.AcceptCookies();
        }

        [SetUp]
        public void ReopenPage()
        {
            Homepage.Open();
        }

        [Test]
        public void MenuTutorials()
        {
            string expectedTutorials = "Tutorials";
            string actualTutorials = Homepage.GetTutorialsButtonText();
            Assert.AreEqual(expectedTutorials, actualTutorials);
            Homepage.ClickTutorialsButton();
        }

        [Test]
        public void MenuReferences()
        {
            string expectedReferences = "References";
            string actualReferences = Homepage.GetReferencesButtonText();
            Assert.AreEqual(expectedReferences, actualReferences);
            Homepage.ClickReferencesButton();
        }

        [Test]
        public void MenuExercises()
        {
            string expectedExercises = "Exercises";
            string actualExercises = Homepage.GetExercisesButtonText();
            Assert.AreEqual(expectedExercises, actualExercises);
            Homepage.ClickExercisesButton();
        }

        [Test]
        public void MenuBootcamps()
        {
            string expectedBootcamps = "Bootcamps";
            string actualBootcamps = Homepage.GetBootcampsButtonText();
            Assert.AreEqual(expectedBootcamps, actualBootcamps);
            Homepage.ClickBootcampsButton();
        }

        [Test]
        public void MenuVideos()
        {
            string expectedVideos = "Videos";
            string actualVideos = Homepage.GetVideosButtonText();
            Assert.AreEqual(expectedVideos, actualVideos);
            Homepage.ClickVideosButton();
        }

        [Test]
        public void MenuUpgrade()
        {
            string expectedUpgrade = "Upgrade";
            string actualUpgrade = Homepage.GetUpgradeButtonText();
            Assert.AreEqual(expectedUpgrade, actualUpgrade);
            Homepage.ClickUpgradeButton();
        }

        [Test]
        public void MenuGetCertified()
        {
            string expectedGetCertified = "Get Certified";
            string actualGetCertified = Homepage.GetGetCertifiedButtonText();
            Assert.AreEqual(expectedGetCertified, actualGetCertified);
            Homepage.ClickGetCertifiedButton();
        }

        [Test]
        public void MenuCreateWebsite()
        {
            string expectedCreateWebsite = "Create Website";
            string actualCreateWebsite = Homepage.GetCreateWebsiteButtonText();
            Assert.AreEqual(expectedCreateWebsite, actualCreateWebsite);
            Homepage.ClickCreateWebsiteButton();
        }

        [Test]
        public void MenuSignUp()
        {
            string expectedSignUp = "Sign Up";
            string actualSignUp = Homepage.GetSignUpButtonText();
            Assert.AreEqual(expectedSignUp, actualSignUp);
            Homepage.ClickSignUpButton();
        }

        [Test]
        public void MenuLogIn()
        {
            string expectedLogIn = "Log in";
            string actualLogIn = Homepage.GetLogInButtonText();
            Assert.AreEqual(expectedLogIn, actualLogIn);
            Homepage.ClickLogInButton();
        }

        [Test]
        public void MenuDarkMode()
        {
            string expectedDarkMenu = "Dark mode\r\nDark code";
            string actualDarkMenu = Homepage.GetDarkMenuButtonText();
            Assert.AreEqual(expectedDarkMenu, actualDarkMenu);

            string expectedModeValue = "Dark mode";
            string expectedCodeValue = "Dark code";
            string actualModeValue = Homepage.GetDarkModeButtonText();
            string actualCodeValue = Homepage.GetDarkCodeButtonText();
            Assert.AreEqual(expectedModeValue, actualModeValue);
            Assert.AreEqual(expectedCodeValue, actualCodeValue);
        }

        [Test]
        public void MenuLanguages()
        {
            string expectedGlobeButtnon = "";
            string actualGlobeButton = Homepage.GetGlobeButtonText();
            Assert.AreEqual(expectedGlobeButtnon, actualGlobeButton);
            string expectedLanguageFrame = "";
            string actualLanguageFrame = Homepage.GetLanguages();
            Assert.AreEqual(expectedLanguageFrame, actualLanguageFrame);
        }

        [Test]
        public void MenuSearch()
        {
            string expectedSeachButton = "";
            string actualSearchButton = Homepage.GetSearchButtonText();
            Assert.AreEqual(expectedSeachButton, actualSearchButton);
            Homepage.GetSearchField();
        }

        [Test]
        public void FieldSearch()
        {
            string expectedSearchOurTutorials = "";
            string actualSearchOurTutorials = Homepage.ClickSearchOurTutorialsLink();
            Assert.AreEqual(expectedSearchOurTutorials, actualSearchOurTutorials);
        }

        [Test]
        public void FieldNotSureWhereToBegin()
        {
            string expectedNotSureLink = "Not Sure Where To Begin?";
            string actualNotSureLink = Homepage.GetNotSureLink();
            Assert.AreEqual(expectedNotSureLink, actualNotSureLink);
        }

        [Test]
        public void CodeGame()
        {
            Homepage.CodeGame();
        }        
    }
}