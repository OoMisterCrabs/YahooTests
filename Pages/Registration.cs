using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace YahooTest.Pages
{
    class Registration
    {
        private IWebDriver _driver;
        By _actual = By.XPath("/html/body/div[2]/div[1]/div[1]/div[2]/strong");
        By _mailInput = By.Id("login-username");
        By _signinButton = By.Id("login-signin");
        By _passwordInput = By.Id("login-passwd");


        public Registration(IWebDriver driver)
        {
            _driver = driver;
            
        }

        public void SendEmail(string Email)
        {
            Thread.Sleep(3000);
            _driver.FindElement(_mailInput).Click();
            _driver.FindElement(_mailInput).SendKeys(Email);
        }

        public void SendPassword(string Password)
        {
            Thread.Sleep(3000);
            _driver.FindElement(_passwordInput).Click();
            _driver.FindElement(_passwordInput).SendKeys(Password);
        }

        public void PressSigninButton()
        {
            _driver.FindElement(_signinButton).Click();
        }
    }
}
