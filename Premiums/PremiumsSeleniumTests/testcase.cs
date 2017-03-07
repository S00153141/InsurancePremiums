using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTests
{
    [TestFixture]
    public class Testcase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:4857/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void MaleTwentyTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Calculate.aspx");
            driver.FindElement(By.Id("tbxGender")).Clear();
            driver.FindElement(By.Id("tbxGender")).SendKeys("Male");
            driver.FindElement(By.Id("tbxAge")).Clear();
            driver.FindElement(By.Id("tbxAge")).SendKeys("20");
            driver.FindElement(By.Id("btnCalculate")).Click();
            Thread.Sleep(200);
            string value = driver.FindElement(By.Id("pOutcome")).Text;
            Assert.AreEqual(6.0, Convert.ToDouble(value));
        }

        [Test]
        public void MaleFifteenTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Calculate.aspx");
            driver.FindElement(By.Id("tbxGender")).Clear();
            driver.FindElement(By.Id("tbxGender")).SendKeys("Male");
            driver.FindElement(By.Id("tbxAge")).Clear();
            driver.FindElement(By.Id("tbxAge")).SendKeys("15");
            driver.FindElement(By.Id("btnCalculate")).Click();
            Thread.Sleep(200);
            string value = driver.FindElement(By.Id("pOutcome")).Text;
            Assert.AreEqual(0, Convert.ToDouble(value));
        }

        [Test]
        public void MaleSixtyText()
        {
            driver.Navigate().GoToUrl(baseURL + "/Calculate.aspx");
            driver.FindElement(By.Id("tbxGender")).Clear();
            driver.FindElement(By.Id("tbxGender")).SendKeys("Male");
            driver.FindElement(By.Id("tbxAge")).Clear();
            driver.FindElement(By.Id("tbxAge")).SendKeys("60");
            driver.FindElement(By.Id("btnCalculate")).Click();
            Thread.Sleep(200);
            string value = driver.FindElement(By.Id("pOutcome")).Text;
            Assert.AreEqual(0.75, Convert.ToDouble(value));
        }

        [Test]
        public void FemaleSixtyText()
        {
            driver.Navigate().GoToUrl(baseURL + "/Calculate.aspx");
            driver.FindElement(By.Id("tbxGender")).Clear();
            driver.FindElement(By.Id("tbxGender")).SendKeys("Female");
            driver.FindElement(By.Id("tbxAge")).Clear();
            driver.FindElement(By.Id("tbxAge")).SendKeys("60");
            driver.FindElement(By.Id("btnCalculate")).Click();
            Thread.Sleep(200);
            string value = driver.FindElement(By.Id("pOutcome")).Text;
            Assert.AreEqual(0.375, Convert.ToDouble(value));
        }
        [Test]
        public void Female10Text()
        {
            driver.Navigate().GoToUrl(baseURL + "/Calculate.aspx");
            driver.FindElement(By.Id("tbxGender")).Clear();
            driver.FindElement(By.Id("tbxGender")).SendKeys("Female");
            driver.FindElement(By.Id("tbxAge")).Clear();
            driver.FindElement(By.Id("tbxAge")).SendKeys("10");
            driver.FindElement(By.Id("btnCalculate")).Click();
            Thread.Sleep(200);
            string value = driver.FindElement(By.Id("pOutcome")).Text;
            Assert.AreEqual(0.0, Convert.ToDouble(value));
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
