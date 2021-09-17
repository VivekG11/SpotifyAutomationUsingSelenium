using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace TwitterAutomation.LoginPage
{
    public  class Login
    {
       


        public Login(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

      

        [FindsBy(How = How.Name, Using = "username")]
        [CacheLookup]
        public  IWebElement userName;

        [FindsBy(How = How.Id, Using = "login-password")]
        [CacheLookup]
        public IWebElement pwd;

        [FindsBy(How = How.Id, Using = "login-button")]
        [CacheLookup]
        public IWebElement loginButton;

        [FindsBy(How = How.ClassName, Using = "col-xs-12")]
        [CacheLookup]
        public IWebElement webplayer;

         [FindsBy(How = How.ClassName, Using = "CPgTPk9wPOVigmNI6xWP")]
        [CacheLookup]
        public IWebElement search;

        // public IWebElement search = driver.FindElement(By.XPath("//*[@id=\"main\"]/div/div[2]/div[1]/header/div[3]/div/div/form/input"));
       
    }
}
