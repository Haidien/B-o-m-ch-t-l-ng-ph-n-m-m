using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class DangNhapAdmin
    {
        IWebDriver webDriver = new ChromeDriver();

        [TestMethod]
        public void DNAD_01()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/admin/adminlogin");
            int waitingTime = 1000;
            webDriver.Manage().Window.Maximize();

            webDriver.FindElement(By.XPath("/html/body/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/form/div/div/div/div/div/div/div[2]/span")).Text.Equals("The UserName field is required."));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/form/div/div/div/div/div/div/div[3]/span")).Text.Equals("The Password field is required."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DNAD_02()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/admin/adminlogin");
            int waitingTime = 1000;
            webDriver.Manage().Window.Maximize();
            webDriver.FindElement(By.Name("Password")).SendKeys("123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/form/div/div/div/div/div/div/div[2]/span")).Text.Equals("The UserName field is required."));
            webDriver.Quit();
        }

        [TestMethod]
        public void DNAD_03()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/admin/adminlogin");
            int waitingTime = 1000;
            webDriver.Manage().Window.Maximize();
            webDriver.FindElement(By.Name("UserName")).SendKeys("123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/form/div/div/div/div/div/div/div[3]/span")).Text.Equals("The Password field is required."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DNAD_04()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/admin/adminlogin");
            int waitingTime = 1000;
            webDriver.Manage().Window.Maximize();
            webDriver.FindElement(By.Name("UserName")).SendKeys("123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("12345");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/form/div/div/div/div/div/div/p")).Text.Equals("Sai thông tin tài khoản"));

            webDriver.Quit();
        }

        [TestMethod]
        public void DNAD_05()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/admin/adminlogin");
            int waitingTime = 1000;
            webDriver.Manage().Window.Maximize();
            webDriver.FindElement(By.Name("UserName")).SendKeys("123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/nav/div[2]/ul/li[2]/a/div/p")).Text.Equals("Thanh Luyen"));
            webDriver.Quit();
        }
    }
}
