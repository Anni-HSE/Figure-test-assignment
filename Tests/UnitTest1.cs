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
            Assert.That(triangle.getPerimeter(), Is.EqualTo(12));
        }

        [Test]
        public void TestTriangleAreaEqual()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.getArea(), Is.EqualTo(6));
        }

        [Test]
        public void TestTriangleShapeName()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.getName(), Is.EqualTo("Прямоугольный разносторонний треугольник"));
        }

        [Test]
        public void TestTriangleType1()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            Assert.That(triangle.getTriangleType(), Is.EqualTo("Равносторонний"));
        }

        [Test]
        public void TestTriangleType2()
        {
            Triangle triangle = new Triangle(20, 20, 37);
            Assert.That(triangle.getTriangleType(), Is.EqualTo("Равнобедренный"));
        }

        [Test]
        public void TestTriangleType3()
        {
            Triangle triangle = new Triangle(6, 5, 4);
            Assert.That(triangle.getTriangleType(), Is.EqualTo("Разносторонний"));
        }

        [Test]
        public void TestgetSigCosSelectSide()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.getSigCosSelectSide(triangle.SideC), Is.EqualTo(0));
        }

        [Test]
        public void TestgetTriangleAngleType1()
        {
            Triangle triangle = new Triangle(2, 2, 1);
            Assert.That(triangle.getTriangleAngleType(), Is.EqualTo("Остроугольный"));
        }

        [Test]
        public void TestgetTriangleAngleType2()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.getTriangleAngleType(), Is.EqualTo("Прямоугольный"));
        }

        [Test]
        public void TestgetTriangleAngleType3()
        {
            Triangle triangle = new Triangle(20, 20, 37);
            Assert.That(triangle.getTriangleAngleType(), Is.EqualTo("Тупоугольный"));
        }
    }
}