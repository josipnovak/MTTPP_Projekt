using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTTPP_Projekt
{
    [TestFixture]
    public class ExportResult : BaseTest
    {
        [Test]
        public void TheExportResult()
        {
            driver.Navigate().GoToUrl("http://localhost:8000/");
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("novo@novo.com");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("123456");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("//div[@id='quiz_list']/div/ul/a/div/p")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div[1]/a")).Click();
        }
    }
    [TestFixture]
    public class DeleteResult : BaseTest
    {
        [Test]
        public void TheDeleteResult()
        {
            driver.Navigate().GoToUrl("http://localhost:8000/");
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("novo@novo.com");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("123456");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("//div[@id='quiz_list']/div/ul/a/div/p")).Click();
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }
    }
}
