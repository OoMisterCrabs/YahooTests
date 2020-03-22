using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace YahooTest.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;
        By _actual = By.XPath("/html/body/header/div[1]/div/div/div[1]/div/div[1]");
        By _goToMainLocator = By.Id("header-mail-button");
        By _confirmButton = By.LinkText("Войти");

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void _pressGoToMain()
        {
            if (_driver.FindElement(_goToMainLocator).Displayed == true)
            {
                _driver.FindElement(_goToMainLocator).Click();
            }
            _driver.FindElement(_confirmButton).Click();
        }
    }
}
