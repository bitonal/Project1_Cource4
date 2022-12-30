using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumTesting
{
    class Program
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           
            driver.Navigate().GoToUrl("https://pizzaproject.azurewebsites.net");
            
            IWebElement element3 = driver.FindElement(By.TagName("//table[@id='cart']/tbody"));
            IList<IWebElement> Allrow = element3.FindElements(By.TagName("tr"));
            foreach (IWebElement element in Allrow)
            {
                Console.WriteLine(element);
            }
             driver.Quit();
        }
    }
}