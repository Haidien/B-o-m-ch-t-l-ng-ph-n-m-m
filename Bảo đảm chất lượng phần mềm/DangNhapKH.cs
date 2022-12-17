using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class DangNhapKH
    {
        IWebDriver webDriver = new ChromeDriver();

        [TestMethod]
        public void DNKH_01()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[1]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[2]/span")).Text.Equals("The UserName field is required."));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[3]/span")).Text.Equals("The Password field is required."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DNKH_02()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[1]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[2]/span")).Text.Equals("The UserName field is required."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DNKH_03()
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
            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[3]/span")).Text.Equals("The Password field is required."));
           
            webDriver.Quit();
        }

        [TestMethod]
        public void DNKH_04()
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
            webDriver.FindElement(By.Name("Password")).SendKeys("123456789dd");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/p[1]")).Text.Equals("Sai thông tin tài khoản"));
           
            webDriver.Quit();
        }

        [TestMethod]
        public void DNKH_05()
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

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[3]/div/div/div/p")).Text.Equals("Hai Dien"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[2]/nav/ul/li[1]/a")).Text.Equals("TRANG CHỦ"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[2]/nav/ul/li[2]/a")).Text.Equals("CÁC SẢN PHẨM"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[2]/nav/ul/li[3]/a")).Text.Equals("GIỎ HÀNG"));
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[2]/nav/ul/li[4]/a")).Text.Equals("CÁC ĐƠN HÀNG"));
            webDriver.Quit();
        }

    }

}
