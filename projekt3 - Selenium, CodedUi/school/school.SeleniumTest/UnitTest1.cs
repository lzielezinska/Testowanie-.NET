using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace school.SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {

        IWebDriver driver;
        INavigation navigation;
        String url;

        [TestInitialize]
        public void SetUp()
        {
            url = "http://localhost:16370/";
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url); 
            driver.Manage().Window.Maximize();
            LoginAsAdmin();

        }

        [TestMethod]
        public void CheckListOfStudents()
        {
          
            var expected = "List Of Students";
            var actual = driver.FindElement(By.Id("GoToStudentsMenu")).Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckListOfMarks()
        {

            var expected = "List of Marks";
            var actual = driver.FindElement(By.Id("GoToMarksMenu")).Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckListOfClasses()
        {

            var expected = "List of Classes";
            var actual = driver.FindElement(By.Id("GoToClassesMenu")).Text;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void TestMethod1()
        {

            //var listOfStudents = driver.FindElement(By.Id("GoToStudentsMenu"));
            //listOfStudents.Click();

            //var editStudent = driver.FindElement(By.Id("7"));
            //editStudent.Click();
            CreateTheExampleStudent();


        }

        private void LoginAsAdmin()
        {
            var loginTab = driver.FindElement(By.Id("loginLink"));
            loginTab.Click();

            var emailField = driver.FindElement(By.Id("Email"));
            emailField.Click();
            emailField.SendKeys("zielezinska.lucyna@gmail.com");

            var passwordField = driver.FindElement(By.Id("Password"));
            passwordField.Click();
            passwordField.SendKeys("a@DMIN1");

            var loginButton = driver.FindElement(By.Name ("Log in"));
            loginButton.Click();
        }

        private void CreateTheExampleStudent()
        {
            var listOfStudents = driver.FindElement(By.Id("GoToStudentsMenu"));
            listOfStudents.Click();

            var createStudent = driver.FindElement(By.Id("CreateStudentID"));
            createStudent.Click();

            var firstnameField = driver.FindElement(By.Id("Firstname"));
            firstnameField.Click();
            firstnameField.SendKeys("Harry");

            var lastnameField = driver.FindElement(By.Id("Lastname"));
            lastnameField.Click();
            lastnameField.SendKeys("Potter");

            var peselField = driver.FindElement(By.Id("Pesel"));
            peselField.Click();
            peselField.SendKeys("97070808360");

            var dateOfBirthField = driver.FindElement(By.Id("DateOfBirth"));
            dateOfBirthField.Click();
            dateOfBirthField.SendKeys("30/07/1991");

          //  SelectElement select = driver.FindElement(By.Id("ClassId")));
            //var classField = driver.FindElement(By.Id("ClassId"));
            //classField.

            var createButton = driver.FindElement(By.Id("CreateButton"));
            createButton.Click();
        }
    }
}
