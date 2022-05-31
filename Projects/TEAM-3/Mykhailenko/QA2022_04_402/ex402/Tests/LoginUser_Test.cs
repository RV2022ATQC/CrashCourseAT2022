/*
 Testing local OpenCart Bitnami
*/

using NUnit.Framework;
using ex402.Pages;
using ex402.Utils;


namespace ex402.Tests
{
    [TestFixture]
    internal class LoginUser_Test : Values
    {
        [OneTimeSetUp]
        public void Init()
        {
            DataBase db = new DataBase(LOGIN_ROOT, PASS_ROOT);
            if (!db.ExistUser(EMAIL)) { db.InsertUser(); }
        }

        [Test]
        public void LoginUser_SuccessRoute_Test()
        {
            //Arrange
            string expected_route = "account/account";
            LoginPage loginpage = new LoginPage();
            //Act
            string actual_url = loginpage.LoginUser(URL, EMAIL, PASS);
            //Assert
            Assert.That(actual_url, Does.Contain(expected_route));
        }
    }
}
