using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace final
{
    [TestFixture]
    class My_test
    {
[Test]
public void TestComparison3()
        {
            CompInv3 f1 = new CompInv3();
           Transport x = new Transport("land ", "car", "renault", "kadjar", 2022);
            Transport y = new Transport("land ", "car", "fiat", "tipo", 2009);
            int ExpectedValue = string.Compare(x.brend, y.brend, StringComparison.Ordinal);
            Console.WriteLine("TestComparison() execution");
            Assert.IsTrue(f1.Compare(x,y) == ExpectedValue);

        }
        [Test]
        public void TestComparison4()
        {
            CompInv4 f1 = new CompInv4();
            Transport x = new Transport("land ", "car", "renault", "kadjar", 2022);
            Transport y = new Transport("land ", "car", "renault", "duster", 2009);
            int ExpectedValue = string.Compare(x.model, y.model, StringComparison.Ordinal);
            Console.WriteLine("TestComparison() execution");
            Assert.IsTrue(f1.Compare(x, y) == ExpectedValue);

        }
        [Test]
        public void TestComparison2()
        {
            CompInv2 f1 = new CompInv2();
            Transport x = new Transport("land ", "car", "renault", "kadjar", 2022);
            Transport y = new Transport("air ", "airplane", "airbus", "A300", 2009);
            int ExpectedValue = string.Compare(x.vehicle, y.vehicle, StringComparison.Ordinal);
            Console.WriteLine("TestComparison() execution");
            Assert.IsTrue(f1.Compare(x, y) == ExpectedValue);

        }
        [Test]
        public void TestComparison1()
        {
            CompInv1 f1 = new CompInv1();
            Transport x = new Transport("land ", "car", "renault", "kadjar", 2022);
            Transport y = new Transport("air ", "airbus", "airbus", "A300", 2009);
            int ExpectedValue = string.Compare(x.kind, y.kind, StringComparison.Ordinal);
            Console.WriteLine("TestComparison() execution");
            Assert.IsTrue(f1.Compare(x, y) == ExpectedValue);

        }
        [Test]
        public void TestToString()
        {
            //Given
            var x = new Transport("land ", "car", "renault", "kadjar", 2022);
            string ExpectedValue = "Kind: land  Vehicle : car Brand: renault Model: kadjar Year: 2022 ";

            //When
            var ActualValue = x.ToString();

            //Then
            Assert.AreEqual(ActualValue, ExpectedValue);
            //Assert.AreEqual(ActualValue, ExpectedValue);
            }
        [Test]
        public void TestSerialization()
        {//Given
            string curFile = "e:\\tCollection.xml";
            bool ExpectedValue = true;
            //When
            var ActualValue= File.Exists(curFile);
            //Then
            Assert.AreEqual(ActualValue, ExpectedValue);
        }
    }
}
