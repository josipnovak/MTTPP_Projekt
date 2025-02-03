using System.Text;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace MTTPP_Projekt
{

    [TestFixture]
    public class RegistrationTest : BaseTest
    {
        [Test]
        public void RegisterNewUserTest()
        {
            driver.Navigate().GoToUrl("http://localhost:8000/");
            driver.FindElement(By.LinkText("Create account")).Click();
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("novi_user_1");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("novi_user_1@gmail.com");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("eB2Esm9e");
            driver.FindElement(By.XPath("//input[@value='Register']")).Click();
        }
    }

    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public void LoginUserTest()
        {
            driver.Navigate().GoToUrl("http://localhost:8000/");
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("novi_user_1@gmail.com");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("eB2Esm9e");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }
    }
}