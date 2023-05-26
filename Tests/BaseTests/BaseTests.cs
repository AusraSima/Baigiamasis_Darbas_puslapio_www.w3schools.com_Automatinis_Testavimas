using Framework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.BaseTests
{
    internal class BaseTests
    {
        [SetUp]

        public void SetUp()
        {
            Driver.InitializeDriver();
        }

        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshotFilePath);
            }
            Driver.ShutDownDriver();
        }
    }
}
