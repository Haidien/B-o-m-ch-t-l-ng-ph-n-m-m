
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Bảo_đạm_chất_lượng_phần_mềm
{
    [TestClass]
    public class DangKy
    {
        IWebDriver webDriver = new ChromeDriver();

        [TestMethod]
        public void DK_01()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Thái");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);
            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[3]/div/div/div/p")).Text.Equals("Thái"));
            webDriver.Quit();
        }

        [TestMethod]
        public void DK_02()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);
           

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[2]/span")).Text.Equals("The TenKH field is required."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_03()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[3]/span")).Text.Equals("The SDT field is required."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_04()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/span")).Text.Equals("The Email field is required."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_05()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[5]/span")).Text.Equals("The DiaChiGiaoHang1 field is required."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_06()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[6]/span")).Text.Equals("The NgaySinh field is required."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_07()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[7]/span")).Text.Equals("The UserName field is required."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_08()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[8]/span")).Text.Equals("The Password field is required."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_09()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Thân");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai1");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai1");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[3]/div/div/div/p")).Text.Equals("Thân"));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_10()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Nguyễn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai2");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/header/div/div[1]/div[3]/div/div/div/p")).Text.Equals("Nguyễn"));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_11()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[8]/span")).Text.Equals("The field Password must be a string or array type with a minimum length of '8'."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_12()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("12345678901234567");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[8]/span")).Text.Equals("The field Password must be a string or array type with a maximum length of '16'."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_13()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("mộthaiba");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[3]/span")).Text.Equals("The SDT field is not a valid phone number."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_14()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/29/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[4]/span")).Text.Equals("The Email field is not a valid e-mail address."));

            webDriver.Quit();
        }

        [TestMethod]
        public void DK_15()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44393/");
            int waitingTime = 1000;

            By registerButton = By.XPath("/html/body/header/div/div[1]/div[3]/div/div/a[2]");
            Thread.Sleep(waitingTime);
            webDriver.Manage().Window.Maximize();
            var btnRegister = webDriver.FindElement(registerButton);
            btnRegister.Click();
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("TenKH")).SendKeys("Tuấn");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("SDT")).SendKeys("123456789");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Email")).SendKeys("tuan@gmail.com");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("DiaChiGiaoHang1")).SendKeys("Lâm Đồng");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("NgaySinh")).SendKeys("09/chín/2001");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("UserName")).SendKeys("tuandeptrai");
            Thread.Sleep(waitingTime);
            webDriver.FindElement(By.Name("Password")).SendKeys("1234567890");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[9]/input")).Click();
            Thread.Sleep(waitingTime);

            Assert.IsTrue(webDriver.FindElement(By.XPath("/html/body/div/form/div/div/div/div/div/div/div[6]/span")).Text.Equals("The value '09/chín/2001' is not valid for NgaySinh."));

            webDriver.Quit();
        }

    }
}
