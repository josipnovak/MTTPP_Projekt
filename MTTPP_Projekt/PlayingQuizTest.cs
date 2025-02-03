using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTTPP_Projekt
{
    [TestFixture]
    public class PlayQuizTest : BaseTest
    {
        [Test]
        public void ThePlayQuizTest()
        {
            driver.Navigate().GoToUrl("http://localhost:8000/");
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("novo@novo.com");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("123456");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/ul/li[3]/a")).Click();
            driver.FindElement(By.XPath("//div[@id='quiz_list']/div/ul/a/div")).Click();
            string questionText = driver.FindElement(By.XPath("/html/body/div[3]/div/div[3]")).Text;
            driver.FindElement(By.LinkText("Start quiz")).Click();
            int questionCount = int.Parse(questionText.Split(' ')[0]);
            for (int i = 0; i < questionCount; i++)
            {
                driver.FindElement(By.XPath("//button[@type='submit']")).Click();
                driver.FindElement(By.Id("next_question_button")).Click();
                driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            }
        }
    }
}
