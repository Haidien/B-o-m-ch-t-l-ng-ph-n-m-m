using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Bảo_đảm_chất_lượng_phần_mềm
{
    [TestClass]
    public class TimKiemSanPham
    {
        IWebDriver webDriver = new ChromeDriver();

        [TestMethod]
        public void Login()
        {
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
        }


        [TestMethod]
        public void TKSP_01()
        {
            int waitingTime = 1000;
            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[2]/nav/ul/li[2]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btn = webDriver.FindElement(By.XPath("/html/body/div[4]/form/input"));
            btn.SendKeys("abcc");
            Thread.Sleep(waitingTime);
            btn.Submit();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.FindElement(By.XPath("//h6")).Text.Equals("abcc"));
            Thread.Sleep(waitingTime);
            webDriver.Quit();

        }

        [TestMethod]
        public void TCSP_02()
        {
            int waitingTime = 1000;
            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[2]/nav/ul/li[2]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btn = webDriver.FindElement(By.XPath("/html/body/div[4]/form/input"));
            btn.SendKeys("wwwwwww");
            Thread.Sleep(waitingTime);
            btn.Submit();
            Thread.Sleep(waitingTime);

            int row = webDriver.FindElements(By.XPath("/html/body/section/div/div/div[2]/div")).Count;
            Assert.IsTrue(row == 0);
            webDriver.Quit();

        }

        [TestMethod]
        public void TCSP_03()
        {
            int waitingTime = 1000;
            Login();
            var sideBar = webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[2]/nav/ul/li[2]/a"));
            sideBar.Click();
            Thread.Sleep(waitingTime);
            var btn = webDriver.FindElement(By.XPath("/html/body/div[4]/form/input"));
            btn.SendKeys("abc");
            Thread.Sleep(waitingTime);
            btn.Submit();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.FindElement(By.XPath("//h6")).Text.Contains("abc"));
            Thread.Sleep(waitingTime);
            webDriver.Quit();

        }
    }
}
