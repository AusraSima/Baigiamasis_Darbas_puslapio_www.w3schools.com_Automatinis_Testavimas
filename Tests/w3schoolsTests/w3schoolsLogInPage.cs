using Framework.Pages.w3schools;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.w3schoolsTests
{
    internal class w3schoolsLogInPage : BaseTest

    {
        [SetUp]
        public void Open()
        {
            LogInVerification.Open();
        }

        [Test]
        public void CheckLogIn()
        {
            LogInVerification.RegistrationWithInvalidData();
            string expectedRegistrationWithInvalidDataResult = "A user with this email does not exist";
            string actualRegistrationWithInvalidDataResult = LogInVerification.RegistrationWithInvalidDataResult();
            Assert.AreEqual(expectedRegistrationWithInvalidDataResult, actualRegistrationWithInvalidDataResult);

            LogInVerification.Open();

            LogInVerification.RegistrationWithoutPassword();
            string expectedRegistrationWithoutPasswordResult = "Make sure you type your email and password correctly. Both your password and email are case-sensitive.";
            string actualRegistrationWithoutPasswordResult = LogInVerification.RegistrationWithoutPasswordResult();
            Assert.AreEqual(expectedRegistrationWithoutPasswordResult, actualRegistrationWithoutPasswordResult);

            LogInVerification.Open();

            LogInVerification.RegistrationWithoutEmail();
            string expectedRegistrationWithoutEmailResult = "Please enter an email";
            string actualRegistrationWithoutEmailResult = LogInVerification.RegistrationWithoutEmailResult();
            Assert.AreEqual(expectedRegistrationWithoutEmailResult, actualRegistrationWithoutEmailResult);

            LogInVerification.Open();

            LogInVerification.RegistrationWithValidData();
            string expectedRegistrationWithValidDataResult = "Welcome!";
            string actualRegistrationWithValidDataResult = LogInVerification.RegistrationWithValidDataResult();
            Assert.AreEqual(expectedRegistrationWithValidDataResult, actualRegistrationWithValidDataResult);
            
            LogInVerification.LogOutVerification();
            string expectedLogOutResult = "Log in";
            string actualLogOutResult = LogInVerification.LogOutVerificationResult();
            Assert.AreEqual(expectedLogOutResult, actualLogOutResult);
        }
    }
}
