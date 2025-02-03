using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MTTPP_Projekt
{
    [TestFixture]
    public class CreateNewQuiz : BaseTest
    {
        [Test]
        public void CreateNewQuizTest()
        {
            driver.Navigate().GoToUrl("http://localhost:8000/");
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("novo@novo.com");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("123456");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/ul/li[2]/a")).Click();
            driver.FindElement(By.Id("quizName")).Click();
            driver.FindElement(By.Id("quizName")).Clear();
            driver.FindElement(By.Id("quizName")).SendKeys("Novi Kviz");
            driver.FindElement(By.Id("quizDescription")).Clear();
            driver.FindElement(By.Id("quizDescription")).SendKeys("Novi Kviz Opis");
            driver.FindElement(By.Id("addNewQuestion")).Click();
            driver.FindElement(By.Id("quizQuestion0")).Click();
            driver.FindElement(By.Id("quizQuestion0")).Clear();
            driver.FindElement(By.Id("quizQuestion0")).SendKeys("Pitanje 1");
            driver.FindElement(By.Name("quizAnswer10")).Click();
            driver.FindElement(By.Name("quizAnswer10")).Clear();
            driver.FindElement(By.Name("quizAnswer10")).SendKeys("Odgovor1");
            driver.FindElement(By.Name("quizAnswer20")).Click();
            driver.FindElement(By.Name("quizAnswer20")).Clear();
            driver.FindElement(By.Name("quizAnswer20")).SendKeys("Odgovor2");
            driver.FindElement(By.Name("answer2Correct0")).Click();
            driver.FindElement(By.Name("quizAnswer30")).Click();
            driver.FindElement(By.Name("quizAnswer30")).Clear();
            driver.FindElement(By.Name("quizAnswer30")).SendKeys("Odgovor 3");
            driver.FindElement(By.Name("quizAnswer40")).Click();
            driver.FindElement(By.Name("quizAnswer40")).Clear();
            driver.FindElement(By.Name("quizAnswer40")).SendKeys("Odgovor 4");
            driver.FindElement(By.Name("quizAnswer20")).Click();
            driver.FindElement(By.Name("quizAnswer20")).Clear();
            driver.FindElement(By.Name("quizAnswer20")).SendKeys("Odgovor 2");
            driver.FindElement(By.Name("quizAnswer10")).Click();
            driver.FindElement(By.Name("quizAnswer10")).Clear();
            driver.FindElement(By.Name("quizAnswer10")).SendKeys("Odgovor 1");
            driver.FindElement(By.Id("addNewQuestion")).Click();
            driver.FindElement(By.Id("quizQuestion1")).Click();
            driver.FindElement(By.Id("quizQuestion1")).Clear();
            driver.FindElement(By.Id("quizQuestion1")).SendKeys("Pitanje 2");
            driver.FindElement(By.Name("quizAnswer11")).Click();
            driver.FindElement(By.Name("quizAnswer11")).Click();
            driver.FindElement(By.Name("quizAnswer11")).Clear();
            driver.FindElement(By.Name("quizAnswer11")).SendKeys("Odgovor 1");
            driver.FindElement(By.Name("quizAnswer21")).Clear();
            driver.FindElement(By.Name("quizAnswer21")).SendKeys("Odgovor 2");
            driver.FindElement(By.Name("quizAnswer31")).Clear();
            driver.FindElement(By.Name("quizAnswer31")).SendKeys("Odgovor 3");
            driver.FindElement(By.Name("answer4Correct1")).Click();
            driver.FindElement(By.Name("quizAnswer41")).Clear();
            driver.FindElement(By.Name("quizAnswer41")).SendKeys("Odgovor 4");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }
    }
    [TestFixture]
    public class QuizEditTest : BaseTest
    {
        [Test]
        public void TheQuizEditTest()
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
            driver.FindElement(By.XPath("//div[@id='quiz_list']/div/ul/a[6]/div")).Click();
            driver.FindElement(By.XPath("//div[@id='quizContainer']/div/form/button/span")).Click();
            driver.FindElement(By.Id("addNewQuestion")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Answers'])[2]/following::span[1]")).Click();
            driver.FindElement(By.Id("quizQuestion2")).Click();
            driver.FindElement(By.Id("quizQuestion2")).Clear();
            driver.FindElement(By.Id("quizQuestion2")).SendKeys("Pitanje 3");
            driver.FindElement(By.Name("answer1Correct2")).Click();
            driver.FindElement(By.Name("quizAnswer12")).Clear();
            driver.FindElement(By.Name("quizAnswer12")).SendKeys("Odgovor 1");
            driver.FindElement(By.Name("quizAnswer22")).Clear();
            driver.FindElement(By.Name("quizAnswer22")).SendKeys("Odgovor 2");
            driver.FindElement(By.Name("quizAnswer32")).Clear();
            driver.FindElement(By.Name("quizAnswer32")).SendKeys("Odgovor 3");
            driver.FindElement(By.Name("quizAnswer42")).Clear();
            driver.FindElement(By.Name("quizAnswer42")).SendKeys("Odgovor 4");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }
    }
    [TestFixture]
    public class DeleteQuizTest : BaseTest
    {
        [Test]
        public void TheDeleteQuizTest()
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
            driver.FindElement(By.XPath("//div[@id='quiz_list']/div/ul/a[1]/div")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/form[2]/button")).Click();
        }
    }
    [TestFixture]
    public class ChangeQuestionTest : BaseTest
    {
        [Test]
        public void TheChangeQuestionTest()
        {
            driver.Navigate().GoToUrl("http://localhost:8000/");
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("novo@novo.com");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("123456");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            acceptNextAlert = true;
            driver.FindElement(By.XPath("/html/body/div[1]/ul/li[4]/a")).Click();
            driver.FindElement(By.XPath("//div[@id='question_overview0']/form[2]/div/button/span")).Click();
            driver.FindElement(By.Id("answer2Correct0")).Click();
            driver.FindElement(By.Id("answer3Correct0")).Click();
            driver.FindElement(By.Id("answer4Correct0")).Click();
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }
    }
    [TestFixture]
    public class DeleteQuestionTest : BaseTest
    {
        [Test]
        public void TheDeleteQuestionTest()
        {
            driver.Navigate().GoToUrl("http://localhost:8000/");
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("novo@novo.com");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("123456");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            acceptNextAlert = true;
            driver.FindElement(By.XPath("/html/body/div[1]/ul/li[4]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div/form[2]/div/button[2]")).Click();
        }
    }
}
