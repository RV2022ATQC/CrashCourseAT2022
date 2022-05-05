using System;
using NUnit.Framework;

namespace ex320.Tests
{
    [TestFixture]
    public class FigureTests
    {
        /*
        Directly methods of class Figure, I can only create objects of classes of heirs.
        Because class Figure is abstract. I can't create an object of class Figure
        */
        [Test]
        public void GetCreateDate_Returs0 ()
        {
            Circle c = new Circle();
            int result = c.GetCreateDate();
            Assert.That(result, Is.EqualTo(0)); 
        }

        [Test]
        public void GetSape_Rerutnd_string_SrartWith_Name ()
        {
            Circle c = new Circle();
            string result = c.GetShape();
            Assert.That(result, Does.StartWith("Name"));
        }
    }
}
