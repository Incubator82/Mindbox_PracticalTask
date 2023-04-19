using GeometricShapes.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes.ShapesList {
    public class Triangle : Shapes {
        private double _perimeter;
        public double Ab { get; }
        public double Bc { get; }
        public double Ac { get; }

        public Triangle(double ab, double bc, double ac)
        {
            // проверка корректности значений
            if (ab <= 0 || bc <= 0 || ac <= 0)
                throw new ArgumentOutOfRangeException("Стороны треугольника должны быть больше нуля.");

            // проверка существования треугольника по трем сторонам. Если хотя бы в одном случае сумма окажется не больше третьей стороны
            if (!(ab + bc > ac && ab + ac > bc && bc + ac > ab))
                throw new ArgumentOutOfRangeException("Треугольник не существует.");

            Ab = ab;
            Bc = bc;
            Ac = ac;

            // вычисляем периметр
            _perimeter = (ab + bc + ac) / 2; 
        }
        public override double GetArea() => Math.Sqrt(_perimeter * (_perimeter - Ab) * (_perimeter - Bc) * (_perimeter - Ac));

        public TriangleType GetTriangleType()
        {
            if (Ab != Bc && Ab != Ac && Bc != Ac)
                return TriangleType.Versatile;
            else if (Ab == Bc && Bc == Ac)
                return TriangleType.Equilateral;
            else
                return TriangleType.Isosceles;
        }
    }
}
