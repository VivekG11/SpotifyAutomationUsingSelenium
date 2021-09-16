using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using TwitterAutomation.LoginPage;

namespace TwitterAutomation.Functions
{
    public  class Actions
    {
        public static void LoginToTwitter(IWebDriver driver)
        {
            Login login = new Login(driver);
            //login.userNameField.Click();

            login.userName.SendKeys("vivekvk2903@gmail.com");
            System.Threading.Thread.Sleep(6000);

            login.pwd.SendKeys("Vivek@1313");

            login.loginButton.Click();
            System.Threading.Thread.Sleep(1000);

            login.settingsButton.Click();

        }

        
    }
}
