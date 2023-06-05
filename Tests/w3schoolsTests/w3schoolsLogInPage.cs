using Framework.Pages.w3schools;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.w3schoolsTests
{
    internal class w3schoolsLogInPage : BaseTestSingleSession

    {
        [SetUp]
        public void Open()
        {
            LogInVerification.Open();
        }

        [Test]
        public void LoginWithInvalidData()
        {
            LogInVerification.LoginWithInvalidData();
            string expectedLoginWithInvalidDataResult = "A user with this email does not exist";
            string actualLoginWithInvalidDataResult = LogInVerification.LoginWithInvalidDataResult();
            Assert.AreEqual(expectedLoginWithInvalidDataResult, actualLoginWithInvalidDataResult);
        }

        [Test]
        public void LoginWithoutPassword()
        {
            LogInVerification.LoginWithoutPassword();
            string expectedLoginWithoutPasswordResult = "Make sure you type your email and password correctly. Both your password and email are case-sensitive.";
            string actualLoginWithoutPasswordResult = LogInVerification.LoginWithoutPasswordResult();
            Assert.AreEqual(expectedLoginWithoutPasswordResult, actualLoginWithoutPasswordResult);
        }

        [Test]
        public void LoginWithoutEmail()
        {
            LogInVerification.LoginWithoutEmail();
            string expectedLoginWithoutEmailResult = "Please enter an email";
            string actualLoginWithoutEmailResult = LogInVerification.LoginWithoutEmailResult();
            Assert.AreEqual(expectedLoginWithoutEmailResult, actualLoginWithoutEmailResult);
        }

        [Test]
        public void LoginWithValidData()
        {
            LogInVerification.LoginWithValidData();
            string expectedLoginWithValidDataResult = "Welcome!";
            string actualLoginWithValidDataResult = LogInVerification.LoginWithValidDataResult();
            Assert.AreEqual(expectedLoginWithValidDataResult, actualLoginWithValidDataResult);

            LogInVerification.LogOutVerification();
            string expectedLogOutResult = "Log in";
            string actualLogOutResult = LogInVerification.LogOutVerificationResult();
            Assert.AreEqual(expectedLogOutResult, actualLogOutResult);
        }
    }
}
