using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using TwitterAutomation.LoginPage;
using System;

namespace TwitterAutomation.Functions
{
    public  class Actions:Base.Base
    {

        public static void AssertTitleAfterSearchingApplication(IWebDriver driver)
        {
            string title1 = "Spotify";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

        public static void LoginToSpotify(IWebDriver driver)
        {
            Login login = new Login(driver);
            

            login.userName.SendKeys("vivekvk2903@gmail.com");
            System.Threading.Thread.Sleep(2000);

            login.pwd.SendKeys("Vivek@1313");
            System.Threading.Thread.Sleep(1000);

            login.loginButton.Click();
            Screenshot();
            System.Threading.Thread.Sleep(1000);
            

           login.webplayer.Click();
           System.Threading.Thread.Sleep(1000);

            driver.Navigate().GoToUrl("https://open.spotify.com/search/Master%20Theme");
            Screenshot();
            System.Threading.Thread.Sleep(1000);

            login.search.SendKeys(Keys.Control + "v");

            String currentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("CurrentWindow ID is " + currentWindowHandle);


        }

        public static void Sendkeys()
        {
            
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            IWebElement search = driver.FindElement(By.Name("q"));
            search.SendKeys(Keys.Control+"v");
            search.SendKeys(Keys.Enter);

        }

        public static void Screenshot()
        {
            ITakesScreenshot ss = driver as ITakesScreenshot;
            Screenshot screenshot = ss.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\vivek.g\source\repos\TwitterAutomation\TwitterAutomation\Screenshots\.jpg");
            System.Threading.Thread.Sleep(2000);
        }


    }
}
