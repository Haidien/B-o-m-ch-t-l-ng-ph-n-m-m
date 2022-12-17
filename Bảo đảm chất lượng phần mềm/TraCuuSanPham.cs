using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class TraCuuSanPham
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
        public void TCSP_01()
        {
            int waitingTime = 1000;
            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);           
            var btn = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/input"));
            btn.SendKeys("Dell XPS");
            Thread.Sleep(waitingTime);
            btn.Submit();
        
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr[1]/td[1]")).Text.Equals("Dell XPS"));
            webDriver.Quit();

        }

        [TestMethod]
        public void TCSP_02()
        {
            int waitingTime = 1000;
            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btn = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/input"));
            btn.SendKeys("xyz");
            Thread.Sleep(waitingTime);
            btn.Submit();

            int row = webDriver.FindElements(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr")).Count;
            Assert.IsTrue(row == 0);
            webDriver.Quit();

        }

        [TestMethod]
        public void TCSP_03()
        {
            int waitingTime = 1000;
            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/div/nav/ul/li[6]/a/span[2]"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btn = webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/input"));
            btn.SendKeys("Dell");
            Thread.Sleep(waitingTime);
            btn.Submit();
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/table/tbody/tr")).Text.Contains("Dell"));
            webDriver.Quit();

        }
    }
}
