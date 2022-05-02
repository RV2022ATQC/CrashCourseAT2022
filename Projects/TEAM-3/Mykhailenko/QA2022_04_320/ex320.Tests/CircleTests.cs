using System;
using NUnit.Framework;

namespace ex320.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void GetSquare_Return_SquareCircleRadius_2 ()
        {
            Circle c = new Circle("C1",w_color.white, new DateTime(2022, 04, 15), 2);
            double res_temp = Math.PI * 2 * 2;
            double result = c.GetSquare();
            Assert.That(result, Is.EqualTo(res_temp));
        }

        [Test]
        public void GetSape_Rerutnd_string_Contain_Radius()
        {
            Circle c = new ex320.Circle();
            string result = c.GetShape();
            Assert.That(result, Does.Contain("Radius"));
        }
    }
}
