using System;
using GeometricShapes.Enums;
using GeometricShapes.ShapesList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricShapes.Tests.ClassTests {
    [TestClass]
    public class TriangleTests {
        [TestMethod]
        public void GetTriangleType_7and8and9_VersatileReturned()
        {
            TriangleType expected = TriangleType.Versatile;
            var result = new Triangle(7, 8, 9).GetTriangleType();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetArea_145and145and140_Returned8889()
        {
            double expected = 8889;
            var result = Convert.ToDouble(new Triangle(145, 145, 140).GetArea().ToString("0"));
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Треугольник не существует.")]
        public void TriangleConstructor_ExistenceTriangleNotValid()
        {
            var result = new Triangle(1, 2, 3);
        }
    }
}
