using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace YahooTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string Email = "SiliconandSynapseTest@Yahoo.com";
            string Password = "Qwerty12345Test";
            string Expected = "Synapse Synapse <siliconandsynapsetest@yahoo.com>";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.yahoo.com/");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            Pages.HomePage homePage = new Pages.HomePage(driver);
            homePage._pressGoToMain();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            Pages.Registration registration = new Pages.Registration(driver);
            registration.SendEmail(Email);
            registration.PressSigninButton();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            registration.SendPassword(Password);
            registration.PressSigninButton();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.PressNewButton();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            mainPage.EnterEmailToSend(Email);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            mainPage.PressSendButton();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            mainPage.PressConfirmButton();

            Thread.Sleep(300000);

            driver.Navigate().Refresh();

            string actual = mainPage.ConfirmEmailCatch();

            Assert.Contains(Expected, actual);

            driver.Quit();
        }
    }
}
