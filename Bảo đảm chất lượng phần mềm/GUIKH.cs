using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Bảo_đảm_chất_lượng_phần_mềm
{
    [TestClass]
    public class GUIKH
    {
        IWebDriver webDriver = new ChromeDriver();

        [TestMethod]
        public void Login()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/Login");
            int waitingTime = 1000;

            By loginButton = By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            webDriver.FindElement(By.Name("UserName")).SendKeys("dien");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("123456789");
            Thread.Sleep(waitingTime);

            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
        }

        [TestMethod]
        public void GUIKH_01()
        {

            int waitingTime = 1000;
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            Thread.Sleep(waitingTime);
            By loginButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[1]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnLogin = webDriver.FindElement(loginButton);
            btnLogin.Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.Title.Equals("Đăng nhập"));
            Thread.Sleep(waitingTime);
            webDriver.Quit();
        }

        [TestMethod]
        public void GUIKH_02()
        {

            int waitingTime = 1000;
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            Thread.Sleep(waitingTime);
            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.Title.Equals("Đăng ký"));
            Thread.Sleep(waitingTime);
            webDriver.Quit();
        }

        [TestMethod]
        public void GUIKH_03()
        {

            int waitingTime = 1000;
            Login();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.Title.Equals("Trang chủ"));
            Thread.Sleep(waitingTime);
            webDriver.Quit();
        }

        [TestMethod]
        public void GUIKH_04()
        {

            int waitingTime = 1000;
            Login();
            Thread.Sleep(waitingTime);
            By CacSP = By.XPath("/html/body/header/div/div[1]/div[2]/nav/ul/li[2]/a");
            var btnSP = webDriver.FindElement(CacSP);
            btnSP.Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.Title.Equals("Các sản phẩm"));
            Thread.Sleep(waitingTime);
            webDriver.Quit();
        }

        [TestMethod]
        public void GUIKH_05()
        {

            int waitingTime = 1000;
            Login();
            Thread.Sleep(waitingTime);
            By GioHang = By.XPath("/html/body/header/div/div[1]/div[2]/nav/ul/li[3]/a");
            var btnGH = webDriver.FindElement(GioHang);
            btnGH.Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.Title.Equals("Giỏ hàng"));
            Thread.Sleep(waitingTime);
            webDriver.Quit();
        }
    }
}
