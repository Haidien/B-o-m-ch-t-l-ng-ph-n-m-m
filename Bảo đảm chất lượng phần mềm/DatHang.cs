using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class DatHang
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
        public void DH_01()
        {
            Login();
            int waitingTime = 1000;
            webDriver.FindElement(By.XPath("/html/body/section[2]/div/div[2]/div[1]/div/a/div/img")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/section/div/div/div[2]/div/div[2]/a")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/section/div/div/div/div/div[2]/div/div/form/input")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiNhanHang")).SendKeys("Nhà Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TrangThaiThanhToan")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("IDPT")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/form/section/div/div/div[1]/div/div/div[6]/div/div/div/select/option[2]"));
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/form/section/div/div/div[2]/div/button")).Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.FindElement(By.XPath("//h2")).Text.Equals("Chúc mừng bạn đã đặt hàng thành công"));          
            webDriver.Quit();
        }

        [TestMethod]
        public void DH_02()
        {
            Login();
            int waitingTime = 1000;
            webDriver.FindElement(By.XPath("/html/body/section[2]/div/div[2]/div[1]/div/a/div/img")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/section/div/div/div[2]/div/div[2]/a")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("quantity")).SendKeys("1000");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/section/div/div/div/div/table/tbody/tr/td[4]/input")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/section/div/div/div/div/div[2]/div/div/form/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body")).Text.Equals("Số lượng mặt hàng bna không đủ!"));

            webDriver.Quit();
        }
    }
}
