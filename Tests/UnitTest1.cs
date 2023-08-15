using Figure;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTriangleConstructorArgumentException()
        {
            Assert.Throws<ArgumentException>(() => { Triangle triangle = new Triangle(1, 1, 2); });
        }

        [Test]
        public void TestTriangleConstructorArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { Triangle triangle = new Triangle(-1, 1, 2); });
        }

        [Test]
        public void TestTriangleChangeSideArgumentException()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            Assert.Throws<ArgumentException>(() => { triangle.SideA = 2; });
        }

        [Test]
        public void TestTriangleChangeSideArgumentOutOfRangeException()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            Assert.Throws<ArgumentOutOfRangeException>(() => { triangle.SideB = -5; });
        }

        [Test]
        public void TestTriangleSideEqual()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.SideC, Is.EqualTo(5));
        }

        [Test]
        public void TestTrianglePerimetrEqual()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.Perimeter(), Is.EqualTo(12));
        }

        [Test]
        public void TestTriangleAreaEqual()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.Area(), Is.EqualTo(6));
        }

        [Test]
        public void TestTriangleShapeName1()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.ShapeName(), Is.EqualTo("Прямоугольный треугольник"));
        }

        [Test]
        public void TestTriangleShapeName2()
        {
            Triangle triangle = new Triangle(2, 2, Math.Sqrt(8));
            Assert.That(triangle.ShapeName(), Is.EqualTo("Равнобедренный прямоугольный треугольник"));
        }

        [Test]
        public void TestTriangleShapeName3()
        {
            Triangle triangle = new Triangle(20, 19, 37);
            Assert.That(triangle.ShapeName(), Is.EqualTo("Тупоугольный треугольник"));
        }

        [Test]
        public void TestTriangleShapeName4()
        {
            Triangle triangle = new Triangle(20, 20, 37);
            Assert.That(triangle.ShapeName(), Is.EqualTo("Равнобедренный тупоугольный треугольник"));
        }

        [Test]
        public void TestTriangleShapeName5()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            Assert.That(triangle.ShapeName(), Is.EqualTo("Равносторонний треугольник"));
        }

        [Test]
        public void TestTriangleShapeName6()
        {
            Triangle triangle = new Triangle(2, 2, 1);
            Assert.That(triangle.ShapeName(), Is.EqualTo("Равнобедренный остроугольный треугольник"));
        }

        [Test]
        public void TestTriangleShapeName7()
        {
            Triangle triangle = new Triangle(6, 5, 4);
            Assert.That(triangle.ShapeName(), Is.EqualTo("Остроугольный треугольник"));
        }
    }
}