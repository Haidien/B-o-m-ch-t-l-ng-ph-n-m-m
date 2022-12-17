using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Bảo_đảm_chất_lượng_phần_mềm
{
    [TestClass]
    public class TraCuuKH
    {
        IWebDriver webDriver = new ChromeDriver();

        [TestMethod]
        public void Login()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/admin/adminlogin");
            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/form/div/div/div/div/div/div/div[4]/input");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            webDriver.FindElement(By.Name("UserName")).SendKeys("123");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123");
            Thread.Sleep(waitingTime);
            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);
        }

        [TestMethod]
        public void TCKH_01()
        {
            int waitingTime = 1000;
            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btn = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/input"));
            btn.SendKeys("Hai Dien");
            Thread.Sleep(waitingTime);
            btn.Submit();
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[1]")).Text.Equals("Hai Dien"));
            webDriver.Quit();

        }

        [TestMethod]
        public void TCKH_02()
        {
            int waitingTime = 1000;
            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btn = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/input"));
            btn.SendKeys("Thanh Luyên");
            Thread.Sleep(waitingTime);
            btn.Submit();

            int row = webDriver.FindElements(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr")).Count;
            Assert.IsTrue(row == 0);
            webDriver.Quit();

        }

        [TestMethod]
        public void TCKH_03()
        {
            int waitingTime = 1000;
            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[8]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btn = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/input"));
            btn.SendKeys("Tuan");
            Thread.Sleep(waitingTime);
            btn.Submit();

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr")).Text.Contains("Tuan"));
            webDriver.Quit();

        }
    }
}
