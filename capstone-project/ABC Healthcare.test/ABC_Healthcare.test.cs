using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Interactions;


namespace ABC_Healthcare.test
{
    [TestFixture]
    public class Test2Test
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void test2()
        {
            driver.Navigate().GoToUrl("https://localhost:5001/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.LinkText("Log in")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("admin");
            driver.FindElement(By.CssSelector(".form-group > .btn")).Click();
            driver.FindElement(By.LinkText("All Products")).Click();
            driver.FindElement(By.LinkText("Homeopathy")).Click();
            driver.FindElement(By.LinkText("Add to Cart")).Click();
            {
                var element = driver.FindElement(By.LinkText("Baby-Care"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.TagName("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
            driver.FindElement(By.LinkText("Personal-Care")).Click();
            driver.FindElement(By.LinkText("Add to Cart")).Click();
            driver.FindElement(By.LinkText("Baby-Care")).Click();
            driver.FindElement(By.CssSelector(".col-4:nth-child(2) .btn")).Click();
            driver.FindElement(By.LinkText("Medicines")).Click();
            driver.FindElement(By.LinkText("Add to Cart")).Click();
            driver.FindElement(By.LinkText("Surgical-Accessories")).Click();
            driver.FindElement(By.LinkText("Add to Cart")).Click();
            driver.FindElement(By.LinkText("View Cart")).Click();
            driver.FindElement(By.LinkText("+")).Click();
            driver.FindElement(By.CssSelector("tr:nth-child(3) .btn-success")).Click();
            driver.FindElement(By.CssSelector("tr:nth-child(3) .btn-primary")).Click();
            driver.FindElement(By.CssSelector("tr:nth-child(4) .btn-danger")).Click();
            driver.FindElement(By.LinkText("Hi,admin, Log out")).Click();
            driver.FindElement(By.LinkText("About Us")).Click();
            driver.FindElement(By.LinkText("Contact")).Click();
            driver.Close();
        }
    }
}
