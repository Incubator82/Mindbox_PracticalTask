using System;

namespace GeometricShapes {
    public class Circle : Shapes {
        private double _perimeter;
        public double Radius { get; }

        public Circle(double radius)
        {
            // проверка корректности значений
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Радиус круга должен быть больше нуля.");

            // вычисляем периметр
            _perimeter = 2 * Math.PI * Radius;
            Radius = radius;
        }
        public override double GetArea() => Math.PI * Radius * Radius;
    }
}
