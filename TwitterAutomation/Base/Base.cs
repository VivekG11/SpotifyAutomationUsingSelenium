using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using log4net;
using log4net.Repository;
using System.Reflection;

namespace TwitterAutomation.Base
{
    public class Base
    {
        public static IWebDriver driver;
        public static readonly ILog LogInfo = LogManager.GetLogger(typeof(Tests));

        public static readonly ILoggerRepository loggerRepository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());



        [SetUp]
        public void Setup()
        {
            var file = new FileInfo("log4net.config");

            log4net.Config.XmlConfigurator.Configure(loggerRepository, file);

            try
            {

                LogInfo.Info("Initializing SetUp");

                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--disable-notifications");
                LogInfo.Info("Disabling notifications");
                driver = new ChromeDriver(options);
                LogInfo.Info("navigating control to chrome browser");
                driver.Manage().Window.Maximize();
                driver.Url = "https://accounts.spotify.com/en/login";
                LogInfo.Debug("Navigating to corresponding URL");
            }
            catch(Exception e)
            {
                LogInfo.Error(e.Message);
            }
           
            
        }

      

      

       

       /*   [TearDown]
          public void tearDwon()
          {
              driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
              driver.Quit();
          }*/
    }
}
