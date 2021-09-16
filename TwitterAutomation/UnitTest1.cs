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

        [Test]
        public void loginUsingExcelData()
        {
            Login login = new Login(driver);

            AccessData.ExcelData.PopulateInCollection(@"C:\Users\vivek.g\source\repos\TwitterAutomation\TwitterAutomation\DataResouce\loginDeatils.xlsx");

            login.userName.SendKeys(AccessData.ExcelData.ReadData(1, "username"));
            System.Threading.Thread.Sleep(1000);

            login.pwd.SendKeys(AccessData.ExcelData.ReadData(1, "password"));
            System.Threading.Thread.Sleep(1000);

            login.loginButton.Click();

            login.settingsButton.Click();
            
        }
    }
}