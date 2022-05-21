using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserManagerTests.Tests
{
    [TestClass]
    public class UserManagerTests
    {
        public TestContext TestContext { get; set; }
        private USERManager.USERManager manager = new USERManager.USERManager();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "testUser.xml",
            "User",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void UserManager_Test()
        {
            string login = Convert.ToString(TestContext.DataRow["login"]);
            string phone = Convert.ToString(TestContext.DataRow["phone"]);
            string email = Convert.ToString(TestContext.DataRow["email"]);
            string password = Convert.ToString(TestContext.DataRow["password"]);
            string number = Convert.ToString(TestContext.DataRow["number"]);
            string seria = Convert.ToString(TestContext.DataRow["seria"]);

            bool result = manager.Add(login, phone, email, password, number, seria);

            Assert.IsTrue(result, "Пользователь не может быть создан!");
        }
    }
}
