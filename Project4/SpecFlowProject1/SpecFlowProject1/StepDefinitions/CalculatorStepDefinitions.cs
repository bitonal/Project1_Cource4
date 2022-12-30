using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PizzahubStepDefinitions
    {
        public ChromeDriver driver;

        [Given(@"i have to navigate to home page")]
        public void GivenIHaveToNavigateToPizzahubPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:1007/");

        }

        [Then(@"click on list pizza and add pizza to cart")]
        public void GivenClickOnAllPizzaButtonAndAddPizzaToCart()
        {
          
            driver.FindElement(By.LinkText("Add to cart")).Click();
            driver.FindElement(By.LinkText("101")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Add to cart")).Click();
            driver.FindElement(By.LinkText("100")).Click();
            driver.FindElement(By.LinkText("Add to cart")).Click();
        }

        [Then(@"click order button and add pizza to cart")]
        public void ThenClickOnVegPizzaButtonAndAddPizzaToCart()
        {
            driver.FindElement(By.LinkText("Veg")).Click();
            driver.FindElement(By.CssSelector(".col-4:nth-child(2) .btn")).Click();
            driver.FindElement(By.LinkText("Non_Veg")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".col-4:nth-child(2) .btn")).Click();
        }

        [Then(@"click on order  butoon to check order list")]
        public void ThenClickOnViewCartButoonToCheckOrderList()
        {
            driver.FindElement(By.LinkText("View Cart")).Click();
        }

        [Then(@"add  pizzas and payment")]
        public void ThenAddPizzas()
        {
            driver.FindElement(By.LinkText("+")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("tr:nth-child(4) .btn-info")).Click();
        }

        [When(@"click on checkout button order should be placed")]
        public void WhenClickOnCheckoutButtonOrderShouldBePlaced()
        {
            driver.FindElement(By.LinkText("Checkout")).Click();
            driver.Close();
        }
    }
}
