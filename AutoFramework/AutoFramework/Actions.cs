﻿namespace AutoFramework
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    using Pages;

    public static class Actions
    {
        public static void InitializeDriver()
        {
            //Driver.driver = new ChromeDriver();
            //Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            //Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost loginScenario = new LoginScenarioPost();

            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys(username);
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys(password);
            loginScenario.RepeatPasswordField.Clear();
            loginScenario.RepeatPasswordField.SendKeys(repeatPassword);
            loginScenario.LoginButton.Click();
        }
    }
}
