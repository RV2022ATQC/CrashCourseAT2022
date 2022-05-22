/*
 Testing local OpenCart Bitnami
*/

using NUnit.Framework;
using ex402.Pages;
using ex402.Utils;

namespace ex402
{
    internal class RegisterOrLoginUser_Test
    {
        const string URL = "http://127.0.0.1/opencart/";
        const string F_NAME = "user";
        const string L_NAME = "user";
        const string EMAIL = "user@user.com";
        const string PHONE = "+380931234567";
        const string PASS = "user";

        [Test, Order(1)]
        public void RegisterUser_SuccessRoute_Test()
        {
            //Arrange
            string expected_route = "account/success";
            if (DataBase.ExistUser(EMAIL)) { DataBase.DeleteUser(EMAIL); }
            RegisterPage rp = new RegisterPage();
            //Act
            rp.RegisterUser(URL, F_NAME, L_NAME, EMAIL, PHONE, PASS);
            //Assert
            rp.CheckThatRoute(expected_route);
        }

        [Test, Order(2)]
        public void LoginUser_SuccessRoute_Test()
        {
            //Arrange
            string expected_route = "account/account";
            LoginPage lp = new LoginPage();
            //Act
            lp.LoginUser(URL, EMAIL, PASS);
            //Assert
            lp.CheckThatRoute(expected_route);
        }

        [Test, Order(2)]
        public void RegisterOrLoginUser_SuccessRoute_Test()
        {
            if (DataBase.ExistUser(EMAIL))
            {
                LoginUser_SuccessRoute_Test();
            }
            else
            {
                RegisterUser_SuccessRoute_Test();
            }
        }
    }
}
