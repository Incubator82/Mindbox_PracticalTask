
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometricShapes.Tests.ClassTests {
    [TestClass]
    public class CircleTests {

        [TestMethod]
        public void GetArea_35_Returned3848()
        {
            double expected = 3848;
            var result = Convert.ToDouble(new Circle(35).GetArea().ToString("0"));
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Радиус круга должен быть больше нуля.")]
        public void CircleConstructor_CheckingCorrectnessValue()
        {
            var result = new Circle(-35);
        }
    }
}
