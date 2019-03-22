using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace TestowanieProjekt
{
    [TestClass]
    class AuthorControllerTest
    {
        public TestContext TestContext { get; set; }
        
        [TestMethod]
        [DataSource
         ("Microsoft.VisualStudio.TestTools.DataSource.CSV",
             @"Lists.csv",
             "Lists#csv",
             DataAccessMethod.Sequential),
         DeploymentItem("Lists.csv")]
        [TestCategory("AddFromCsv")]
        public void TheNumberOfAuthorsShouldIncrease()
        {
            var expected = AuthorController.CountAuthors();
            String firstName = TestContext.DataRow["FirstName"].ToString();
            String lastName = TestContext.DataRow["LastName"].ToString();
            String dateOfBirth = TestContext.DataRow["DateOfBirth"].ToString();
            AuthorController.AddAuthor(firstName, lastName, dateOfBirth);
            expected = expected + 1;
            var actual = AuthorController.CountAuthors();
            Assert.AreEqual(expected, actual);
        }



    }
}
