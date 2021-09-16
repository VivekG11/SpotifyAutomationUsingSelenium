using NUnit.Framework;
using TwitterAutomation.Functions;
using TwitterAutomation.LoginPage;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;

namespace TwitterAutomation
{
    public class Tests : Base.Base
    {
        

        [Test]
        public void LoginUsingCredentials()
        {
            Actions.LoginToTwitter(driver);
        }

    }
}