using System;
using UserRegistration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationTest
{
    [TestClass]
    public class PasswordStrenghtCheckerTests
    {
        [TestMethod]
        public void GetPassword_7_1point()
        {
            //arrange
            string password = "Ivan00649393!";

            int excpected = 1;
            //act
            int actual = PasswordChecker.GetPasswordStrenght(password);
            //assert
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void GetPassword_7_2point()
        {
            //arrange
            string password = "Ivan00649393!";
            int excpected = 1;
            //act
            int actual = PasswordChecker.GetPasswordLower(password);
            //assert
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void GetPassword_7_3point()
        {
            //arrange
            string password = "Ivan00649393!";
            int excpected = 1;
            //act
            int actual = PasswordChecker.GetPasswordUpper(password);
            //assert
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void GetPassword_7_4point()
        {
            //arrange
            string password = "Ivan00649393!";
            int excpected = 1;
            //act
            int actual = PasswordChecker.GetPasswordNumber(password);
            //assert
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void GetPassword_7_5point()
        {
            //arrange
            string password = "Ivan00649393!";
            int excpected = 1;
            //act
            int actual = PasswordChecker.GetPasswordSpecial(password);
            //assert
            Assert.AreEqual(excpected, actual);
        }
    }
}
