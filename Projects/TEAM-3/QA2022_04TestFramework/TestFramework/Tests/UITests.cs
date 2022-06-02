/*
 Testing local OpenCart Bitnami
*/

using NUnit.Framework;
using TestFramework.Pages;
using TestFramework.Utils;
using System.Threading;

namespace TestFramework.Tests
{
    [TestFixture]
    public class UITests
    {
        [OneTimeSetUp]
        public void Init()
        {
            DataBase db = new DataBase(Values.LOGIN_ROOT, Values.PASS_ROOT);
            if (!db.ExistUser(Values.EMAIL)) 
            {
                Values.log.Info("INSERT User into DB - DataBase.InsertUser");
                db.InsertUser();
            }
            Values.InitWebDriver();
    }

    [Test, Order(1)]
        public void UITest_1_NegativeTest_LoginUserWithIncorrectPass_Expected_ErrorRoute()
        {
            //Arrange
            string expected_route = "account/account";
            string incorrect_pass = Values.PASS + "1";
            Values.log.Info("START TEST UITest_1_NegativeTest_LoginUserWithIncorrectPass_Expected_ErrorRoute");
            LoginPage loginpage = new LoginPage();
            //Act
            string actual_route = loginpage.LoginUser(Values.URL, Values.EMAIL, incorrect_pass);
            Values.log.Info("RESULT TEST EXPECTED (NOT CONTAIN) = " + expected_route + "\t ACTUAL = " + actual_route + "\n");
            //Assert
            Assert.That(actual_route, !Does.Contain(expected_route));
        }

        [Test, Order(2)]
        public void UITest_2_LoginUser_Expected_SuccessRoute()
        {
            //Arrange
            string expected_route = "account/account";
            Values.log.Info("START TEST UITest_2_LoginUser_Expected_SuccessRoute");
            LoginPage loginpage = new LoginPage();
            //Act
            string actual_url = loginpage.LoginUser(Values.URL, Values.EMAIL, Values.PASS);
            Values.log.Info("RESULT TEST EXPECTED (CONTAIN) = " + expected_route + "\t ACTUAL = " + actual_url + "\n");
            //Assert
            Assert.That(actual_url, Does.Contain(expected_route));
        }
        

        [Test, Order(3)]
        public void UITest_3_СhoiceItemCanon5D_Expected_OpenItemDescriptionPage()
        {
            //Arrange
            string expected_route = "product_id=" + Values.ITEM_ID;
            Values.log.Info("START TEST UITest_3_СhoiceItemCanon5D_Expected_OpenItemDescriptionPage");
            HomePage homepage = new HomePage();
            //Act
            string actual_url = homepage.ChoiceCanon5D();
            Values.log.Info("RESULT TEST EXPECTED (CONTAIN) = " + expected_route + "\t ACTUAL = " + actual_url + "\n");
            //Assert
            Assert.That(actual_url, Does.Contain(expected_route));
        }

        [Test, Order(4)]
        public void UITest_4_СhoiceColorCanon5D_Expected_Text_YouHaveAdded()
        {
            //Arrange
            string expected_text = "Success: You have added";
            Values.log.Info("START TEST UITest_4_СhoiceColorCanon5D_Expected_ColorItem");
            ItemPage item = new ItemPage();
            //Act
            string actual_txt = item.ChoiceColorItemAddToCart();
            Values.log.Info("RESULT TEST EXPECTED (CONTAIN) = " + expected_text + "\t ACTUAL = " + actual_txt + "\n");
            //Assert
            Assert.That(actual_txt, Does.Contain(expected_text));
        }

        [Test, Order(5)]
        public void UITest_5_MoveToCart_Expected_OpenCartPage()
        {
            //Arrange
            string expected_route = "checkout/cart";
            Values.log.Info("START TEST UITest_5_MoveToCart_Expected_OpenCartPage");
            ItemPage item = new ItemPage();
            //Act
            string actual_url = item.MoveToCart();
            Values.log.Info("RESULT TEST EXPECTED (CONTAIN) = " + expected_route + "\t ACTUAL = " + actual_url + "\n");
            //Assert
            Assert.That(actual_url, Does.Contain(expected_route));
        }

        [Test, Order(6)]
        public void UITest_6_DeleteItemFromCart_Expected_TextEmptyCart()
        {
            //Arrange
            string expected_text = "0 item(s) - $0.00";
            Values.log.Info("START TEST UITest_6_DeleteItemFromCart_Expected_TextEmptyCart");
            ViewCartPage view_cart = new ViewCartPage();
            //Act
            string actual_text = view_cart.DeleteIntemFromCart();
            Values.log.Info("RESULT TEST EXPECTED (CONTAIN) = " + expected_text + "\t ACTUAL = " + actual_text + "\n");
            //Assert
            Assert.That(actual_text, Does.Contain(expected_text));
        }

        [Test, Order(7)]
        public void UITest_7_Logout_Expected_TextLogout()
        {
            //Arrange
            string expected_text = "Account Logout";
            Values.log.Info("START TEST UITest_7_Logout_Expected_TextLogout");
            HomePage home_page = new HomePage();
            //Act
            string actual_text = home_page.Logout();
            Values.log.Info("RESULT TEST EXPECTED (CONTAIN) = " + expected_text + "\t ACTUAL = " + actual_text + "\n");
            //Assert
            Assert.That(actual_text, Does.Contain(expected_text));
        }
        [OneTimeTearDown]
        public void DeleteUserFromDB()
        {
            DataBase db = new DataBase(Values.LOGIN_ROOT, Values.PASS_ROOT);
            if (db.ExistUser(Values.EMAIL))
            {
                Values.log.Info("DELETE User from DB - DataBase.DeleteUser");
                db.DeleteUser(Values.EMAIL);
            }
            Values.QuitWebDriver();
        }
    }
}
