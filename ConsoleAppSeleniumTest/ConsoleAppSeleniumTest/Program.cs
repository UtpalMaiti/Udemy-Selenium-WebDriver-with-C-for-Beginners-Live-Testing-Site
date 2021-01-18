using System;
using System.Threading;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleAppSeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://testing.todorvachev.com");
            //Thread.Sleep(3000);
            //driver.Quit();

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://testing.todorvachev.com/selectors/name/");
            //IWebElement webElement = driver.FindElement(By.Name("myName"));
            //if (webElement.Displayed)
            //{
            //    GreenMessage("YES,I can see the element");
            //}
            //else
            //{
            //    RedMessage("Well ,something went wrong,I couldn't see the element");
            //}
            //Thread.Sleep(3000);
            //driver.Quit();

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://testing.todorvachev.com/selectors/id/");
            //IWebElement webElement = driver.FindElement(By.Id("testImage"));
            //if (webElement.Displayed)
            //{
            //    GreenMessage("YES,I can see the element");
            //}
            //else
            //{
            //    RedMessage("Well ,something went wrong,I couldn't see the element");
            //}
            //Thread.Sleep(3000);
            //driver.Quit();


            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://testing.todorvachev.com/selectors/class-name/");
            //IWebElement webElement = driver.FindElement(By.ClassName("testClass"));
            //if (webElement.Displayed)
            //{
            //    GreenMessage("YES,I can see the element");
            //}
            //else
            //{
            //    RedMessage("Well ,something went wrong,I couldn't see the element");
            //}
            //Thread.Sleep(3000);
            //driver.Quit();

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://testing.todorvachev.com/selectors/css-path/");
            //IWebElement cssSelector = driver.FindElement(By.CssSelector("#post-108 > div > figure > img"));
            //if (cssSelector.Displayed)
            //{
            //    GreenMessage("YES,I can see the element");
            //}
            //else
            //{
            //    RedMessage("Well ,something went wrong,I couldn't see the element");
            //}
            //IWebElement xPath = driver.FindElement(By.XPath("//*[@id=\"post-108\"]/div/figure/img"));
            //if (xPath.Displayed)
            //{
            //    GreenMessage("YES,I can see the element");
            //}
            //else
            //{
            //    RedMessage("Well ,something went wrong,I couldn't see the element");
            //}
            //Thread.Sleep(3000);
            //driver.Quit();

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://testing.todorvachev.com/selectors/css-path/");
            //IWebElement cssSelector = driver.FindElement(By.CssSelector("#post-108 > div > figure > img"));
            //if (cssSelector.Displayed)
            //{
            //    GreenMessage("YES,I can see the element");
            //}
            //else
            //{
            //    RedMessage("Well ,something went wrong,I couldn't see the element");
            //}
            //IWebElement xPath = driver.FindElement(By.XPath("//*[@id=\"post-108\"]/div/figure/img"));
            //if (xPath.Displayed)
            //{
            //    GreenMessage("YES,I can see the element");
            //}
            //else
            //{
            //    RedMessage("Well ,something went wrong,I couldn't see the element");
            //}
            //Thread.Sleep(3000);
            //driver.Quit();

            //IWebDriver driver = new ChromeDriver();
            //IWebElement textBox;
            //string url = "http://testing.todorvachev.com/special-elements/text-input-field/";
            //driver.Navigate().GoToUrl(url);
            //textBox = driver.FindElement(By.Name("username"));
            //textBox.SendKeys("Test text");
            //Thread.Sleep(3000);
            //textBox.Clear();
            //Console.WriteLine(textBox.GetAttribute("maxlength"));
            //Thread.Sleep(3000);
            //driver.Quit();

            IWebDriver driver = new ChromeDriver();
            IWebElement element;
            string url = "http://testing.todorvachev.com/special-elements/check-button-test-3/";
            string option = "1";
            driver.Navigate().GoToUrl(url);
            element = driver.FindElement(By.XPath("//*[@id=\"post-33\"]/div/p[7]/input[" + option + "]"));
            bool.TryParse(element.GetAttribute("checked"), out bool isChecked);
            if (isChecked)
            {
                Console.WriteLine("This checkbox is already checked!");
            }
            else
            {
                Console.WriteLine("Huh, someone left the checkbox unchecked, lets check it!");
                element.Click();
            }
            driver.Quit();



        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
