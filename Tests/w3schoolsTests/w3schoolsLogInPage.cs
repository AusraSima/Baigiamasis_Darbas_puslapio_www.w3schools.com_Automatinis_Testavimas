using Framework.Pages.w3schools;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.w3schoolsTests
{
    internal class w3schoolsLogInPage : BaseTests

    {
        [SetUp]

        public void Open()
        {
            LogInVerification.Open();
        }

        [Test]

        public void CheckLogIn()
        {
            LogInVerification.EnterValidEmail();
            LogInVerification.ExitValidEmail();
        }
    }
}
