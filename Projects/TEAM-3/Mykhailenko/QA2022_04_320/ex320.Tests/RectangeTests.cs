using System;
using NUnit.Framework;

namespace ex320.Tests
{
    [TestFixture]
    public class RectangeTests
    {
        [Test]
        public void GetSquare_Return_SquareRectangeW2H3()
        {
            Rectangle r = new Rectangle("Rec3", w_color.silver, new DateTime(2022, 04, 15), 2, 3);
            double tmp = 2 * 3;
            Assert.That(r.GetSquare(), Is.EqualTo(tmp));
        }

        [Test]
        public void GetShape_Return_string_Contain_Square_eq8 ()
        {
            Rectangle r = new Rectangle("Rec3", w_color.silver, new DateTime(2022, 04, 15), 2, 4);
            string tmp = (2 * 4).ToString();
            Assert.That(r.GetShape(), Does.Contain(tmp));
        }
    }
}
