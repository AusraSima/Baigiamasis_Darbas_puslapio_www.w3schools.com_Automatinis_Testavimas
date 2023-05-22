using Framework.Pages.w3schools;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.w3schoolsTests
{
    internal class w3schoolsHTMLTutorialsPage
    {
        [SetUp]

        public void SetUp()
        {
            Driver.InitializeDriver();
            HTMLTutorials.Open();

            HTMLTutorials.AcceptCookies();
        }

        [Test]

        public void CheckHTMLTutorials()
        {
            HTMLTutorials.TryItYourselfField();
        }

        [TearDown]

        public void TearDown()
        {
            //Driver.ShutDownDriver();
        }
    }
}
