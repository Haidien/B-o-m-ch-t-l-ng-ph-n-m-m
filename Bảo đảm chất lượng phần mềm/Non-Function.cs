using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace Bảo_đảm_chất_lượng_phần_mềm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NF_01()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[1]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("dien");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[3]/div/div/div/p")).Text.Equals("Hai Dien"));
            webDriver.Quit();
        }

        [TestMethod]
        public void NF_02()
        {
            IWebDriver webDriver = new EdgeDriver();
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[1]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("dien");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[3]/div/div/div/p")).Text.Equals("Hai Dien"));
            webDriver.Quit();
        }

        [TestMethod]
        public void NF_03()
        {
            IWebDriver webDriver = new FirefoxDriver();
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[1]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("dien");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[3]/div/div/div/p")).Text.Equals("Hai Dien"));
            webDriver.Quit();
        }
    }
}
