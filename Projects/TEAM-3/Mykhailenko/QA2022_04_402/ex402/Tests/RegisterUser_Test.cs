/*
 Testing local OpenCart Bitnami
*/

using NUnit.Framework;
using ex402.Pages;
using ex402.Utils;

namespace ex402.Tests
{
    [TestFixture]
    internal class RegisterUser_Test : Values
    {
        [OneTimeSetUp]
        public void Init()
        {
            DataBase db = new DataBase(LOGIN_ROOT, PASS_ROOT);
            if (db.ExistUser(EMAIL)) { db.DeleteUser(EMAIL); }
        }

        [Test]
        public void RegistrUser_SuccessRoute_Test()
        {
            //Arrange
            string expected_route = "account/success";
            RegisterPage registerpage = new RegisterPage();
            //Act
            string actual_url = registerpage.RegisterUser(URL, F_NAME, L_NAME, EMAIL, PHONE, PASS);
            //Assert
            Assert.That(actual_url, Does.Contain(expected_route));
        }
    }
}
