using Microsoft.VisualStudio.TestTools.UnitTesting;
using Passsword;
using System;

namespace PasswordTests
{
    [TestClass]
    public class PasswordTests
    {
        Pass passTest = new Pass();
        [TestMethod]
        public void CheckPassword_true1_return1()
        {
            string a = "fhdjf";
            Assert.AreEqual(1, passTest.CheckPassword(a));
        }
        [TestMethod]
        public void CheckPassword_true2_return2()
        {
            string a = "fhdjf5";
            Assert.AreEqual(2, passTest.CheckPassword(a));
        }
        [TestMethod]
        public void CheckPassword_true3_return3()
        {
            string a = "Fhjff5";
            Assert.AreEqual(3, passTest.CheckPassword(a));
        }
        [TestMethod]
        public void CheckPassword_true4_return4()
        {
            string a = "Fhdjggf5";
            Assert.AreEqual(4, passTest.CheckPassword(a));
        }
        [TestMethod]
        public void TCheckPassword_true5_return5()
        {
            string a = "Fhdjf55%";
            Assert.AreEqual(5, passTest.CheckPassword(a));
        }
        [TestMethod]
        public void CheckPassword_true0_return0()
        {
            string a = "😂";
            Assert.AreEqual(0, passTest.CheckPassword(a));
        }
    }
}
