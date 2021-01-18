using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{

    static void Main()
    {

        IWebDriver driver = new ChromeDriver();
        IWebElement textBox;

        string url = "http://testing.todorvachev.com/special-elements/text-input-field/";
        driver.Navigate().GoToUrl(url);
        textBox = driver.FindElement(By.Name("username"));
        textBox.SendKeys("Test text");
        Thread.Sleep(3000);
        Console.WriteLine(textBox.GetAttribute("maxlength"));
        Thread.Sleep(3000);
        driver.Quit();
    }

}