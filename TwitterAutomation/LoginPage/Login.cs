using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace TwitterAutomation.LoginPage
{
    public class Login
    {
        
        
        public Login(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

      

        [FindsBy(How = How.Name, Using = "username")]
        [CacheLookup]
        public IWebElement userName;

        [FindsBy(How = How.Id, Using = "login-password")]
        [CacheLookup]
        public IWebElement pwd;

        [FindsBy(How = How.Id, Using = "login-button")]
        [CacheLookup]
        public IWebElement loginButton;

        [FindsBy(How = How.Id, Using = "account-settings-link")]
        [CacheLookup]
        public IWebElement settingsButton;
    }
}
