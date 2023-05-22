using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.w3schools
{
    public class HTMLTutorials
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.w3schools.com/html/default.asp");
        }
        //Cookies
        public static void AcceptCookies()
        {
            string buttonAcceptCookies = "//*[@id='accept-choices']";
            Common.Click(buttonAcceptCookies);
            Common.WaitForElementToNotContainText(buttonAcceptCookies, "Accept all &; visit the site");
        }
    }
}
