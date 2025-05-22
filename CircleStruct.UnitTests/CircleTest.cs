using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CircleStruct;

namespace CircleStruct.UnitTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void ConstructorRadiusTest()
        {
            var circle = new Circle(1.5, -2.3, 4.0);
            Assert.That(circle.X, Is.EqualTo(1.5));
            Assert.That(circle.Y, Is.EqualTo(-2.3));
            Assert.That(circle.R, Is.EqualTo(4.0));
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0, 0, -1.0));
        }

        [Test]
        public void LengthTest()
        {
            var circle = new Circle(0, 0, 1.0);
            Assert.That(circle.Length, Is.EqualTo(2 * Math.PI).Within(1e-13));
        }

        [Test]
        public void AreaTest()
        {
            var circle = new Circle(0, 0, 2.0);
            Assert.That(circle.Area, Is.EqualTo(4 * Math.PI).Within(1e-13));
        }

        [Test]
        public void EqualsTest()
        {
            var circle1 = new Circle(1.0, 2.0, 3.0);
            var circle2 = new Circle(1.0, 2.0, 3.0);
            Assert.That(circle1.Equals(circle2), Is.True);
        }

        [Test]
        public void EqualsTest2()
        {
            var circle1 = new Circle(1.0, 2.0, 3.0);
            var circle2 = new Circle(1.0, 2.0, 4.0);
            Assert.That(circle1.Equals(circle2), Is.False);
        }

        [Test]
        public void MultiplicationTest()
        {
            var circle = new Circle(1.0, 1.0, 2.0);
            var scaledCircle = 3.0 * circle;
            Assert.That(scaledCircle.R, Is.EqualTo(6.0));
        }
    }
}
