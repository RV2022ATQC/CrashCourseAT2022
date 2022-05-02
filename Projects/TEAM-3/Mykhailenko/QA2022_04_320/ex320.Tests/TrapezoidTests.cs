using System;
using NUnit.Framework;

namespace ex320.Tests
{
    [TestFixture]
    public class TrapezoidTests
    {
        [Test]
        public void GetSquare_Return_SquareTrapezoidB7S52H3()
        {
            Trapezoid t = new Trapezoid("Trapezoid1", w_color.white, new DateTime(2022, 04, 18), 7, 5, 3);
            double tmp = (7+5)*3/2;
            Assert.That(t.GetSquare(), Is.EqualTo(tmp));
        }

        [Test]
        public void GetShape_Return_string_Contain_string_Base_small()
        {
            Trapezoid t = new Trapezoid("Trapezoid1", w_color.white, new DateTime(2022, 04, 18), 7, 5, 3);
            Assert.That(t.GetShape(), Does.Contain("Base small"));
        }

    }
}
