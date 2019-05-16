using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace TestowanieProjekt
{
    [TestClass]
    public class AuthorTest
    {
        private AuthorModel author;

        [TestInitialize]
        public void LoadData()
        {
            author = new AuthorModel("Joanne", "Rowling", "02-03-1900");
        }

        [TestMethod]
        [TestCategory("First Name")]
        public void CheckFirstNameOfAuthor()
        {
            var expected = "Joanne";
            var actual = author.FirstName;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Last Name")]
        public void CheckLastNameOfAuthor()
        {
            var expected = "Rowling";
            var actual = author.LastName;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Date Of Birth")]
        public void CheckFormatOfDataBirth()
        {
            var value = author.DateOfBirth;
            var pattern = new Regex("^[0-3]?[0-9].[0-3]?[0-9].(?:[0-9]{2})?[0-9]{2}$");
            StringAssert.Matches(value, pattern);
        }

    }
}
