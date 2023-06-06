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
            string expectedTutorialsClickResult = "HTML and CSS";
            string actualTutorialsClickResult = Homepage.GetTutorialsDropdownMenuText();
            Assert.AreEqual(expectedTutorialsClickResult, actualTutorialsClickResult);
        }

        [Test]
        public void MenuReferences()
        {
            string expectedReferences = "References";
            string actualReferences = Homepage.GetReferencesButtonText();
            Assert.AreEqual(expectedReferences, actualReferences);

            Homepage.ClickReferencesButton();
            string expectedReferencesClickResult = "HTML Tag Reference";
            string actualReferencesClickResult = Homepage.GetReferencesDropdownMenuText();
            Assert.AreEqual(expectedReferencesClickResult, actualReferencesClickResult); ; ;
        }

        [Test]
        public void MenuExercises()
        {
            string expectedExercises = "Exercises";
            string actualExercises = Homepage.GetExercisesButtonText();
            Assert.AreEqual(expectedExercises, actualExercises);

            Homepage.ClickExercisesButton();
            string expectedExercisesClickResult = "HTML Exercises";
            string actualExercisesClickResult = Homepage.GetExercisesDropdownMenuText();
            Assert.AreEqual(expectedExercisesClickResult, actualExercisesClickResult);
        }

        [Test]
        public void MenuBootcamps()
        {
            string expectedBootcamps = "Bootcamps";
            string actualBootcamps = Homepage.GetBootcampsButtonText();
            Assert.AreEqual(expectedBootcamps, actualBootcamps);

            Homepage.ClickBootcampsButton();
            string expectedBootcampsClickResult = "Coding Bootcamps";
            string actualBootcampsClickResult = Homepage.GetBootcampsPageText();
            Assert.AreEqual(expectedBootcampsClickResult, actualBootcampsClickResult);
        }

        [Test]
        public void MenuVideos()
        {
            string expectedVideos = "Videos";
            string actualVideos = Homepage.GetVideosButtonText();
            Assert.AreEqual(expectedVideos, actualVideos);

            Homepage.ClickVideosButton();
            string expectedVideosClickResult = "HTML Video Tutorial";
            string actualVideosClickResult = Homepage.GetVideosPageText();
            Assert.AreEqual(expectedVideosClickResult, actualVideosClickResult);
        }

        [Test]
        public void MenuUpgrade()
        {
            string expectedUpgrade = "Upgrade";
            string actualUpgrade = Homepage.GetUpgradeButtonText();
            Assert.AreEqual(expectedUpgrade, actualUpgrade);

            Homepage.ClickUpgradeButton();
            string expectedUpgradeClickResult = "To Unlock Powerful Features:";
            string actualUpgradeClickResult = Homepage.GetUpgradePageText();
            Assert.AreEqual(expectedUpgradeClickResult, actualUpgradeClickResult);
        }

        [Test]
        public void MenuGetCertified()
        {
            string expectedGetCertified = "Get Certified";
            string actualGetCertified = Homepage.GetGetCertifiedButtonText();
            Assert.AreEqual(expectedGetCertified, actualGetCertified);

            Homepage.ClickGetCertifiedButton();
            string expectedGetCertifiedClickResult = "Certificate Courses";
            string actualGetCertifiedClickResult = Homepage.GetGetCertifiedPageText();
            Assert.AreEqual(expectedGetCertifiedClickResult, actualGetCertifiedClickResult);
        }

        [Test]
        public void MenuCreateWebsite()
        {
            string expectedCreateWebsite = "Create Website";
            string actualCreateWebsite = Homepage.GetCreateWebsiteButtonText();
            Assert.AreEqual(expectedCreateWebsite, actualCreateWebsite);

            Homepage.ClickCreateWebsiteButton();
            string expectedCreateWebsiteClickResult = "Create a Free Website";
            string actualCreateWebsiteClickResult = Homepage.GetCreateWebsitePageText();
            Assert.AreEqual(expectedCreateWebsiteClickResult, actualCreateWebsiteClickResult);
        }

        [Test]
        public void MenuSignUp()
        {
            string expectedSignUp = "Sign Up";
            string actualSignUp = Homepage.GetSignUpButtonText();
            Assert.AreEqual(expectedSignUp, actualSignUp);

            Homepage.ClickSignUpButton();
            string expectedSignUpClickResult = "For Free";
            string actualSignUpClickResult = Homepage.GetSignUpPageText();
            Assert.AreEqual(expectedSignUpClickResult, actualSignUpClickResult);
        }

        [Test]
        public void MenuLogIn()
        {
            string expectedLogIn = "Log in";
            string actualLogIn = Homepage.GetLogInButtonText();
            Assert.AreEqual(expectedLogIn, actualLogIn);

            Homepage.ClickLogInButton();
            string expectedLogInClickResult = "Log in";
            string actualLogInClickResult = Homepage.GetLogInPageText();
            Assert.AreEqual(expectedLogInClickResult, actualLogInClickResult);
        }

        [Test]
        public void MenuDarkMode()
        {
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
            string expectedLanguageChangeResult = "Išmokite koduoti";
            string actualLanguageChangeResult = Homepage.GetLanguages();
            Assert.AreEqual(expectedLanguageChangeResult, actualLanguageChangeResult);
        }

        [Test]
        public void MenuSearch()
        {
            string expectedText = "Tutorials";

            Homepage.ClickMenuSearchButton();
            Homepage.EnterSearchPhrase(expectedText);
            Homepage.ClickButtonToSearchForPhrase();
            string result = Homepage.GetSearchField();

            StringAssert.Contains(expectedText, result);
        }

        [Test]
        public void FieldSearch()
        {
            string expectedResult = "HTML Tutorial";

            Homepage.EnterSearchPhraseToSearchField("html");
            Homepage.ClickSearchButton();
            string actualResult = Homepage.GetSearchResultHeading();

            Assert.AreEqual(expectedResult, actualResult);
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