using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05__Lab04_SectionB_
{
    public enum ShapeType
    {
        Circle,
        Rectangle,
        Square
    }

    public class Shape
    {
        public ShapeType Type { get; set; }

        public Shape(ShapeType type)
        {
            Type = type;
        }

        public void Draw()
        {
            switch (Type)
            {
                case ShapeType.Circle:
                    Console.WriteLine("Drawing a Circle");
                    break;
                case ShapeType.Rectangle:
                    Console.WriteLine("Drawing a Rectangle");
                    break;
                case ShapeType.Square:
                    Console.WriteLine("Drawing a Square");
                    break;
                default:
                    Console.WriteLine("Unknown shape");
                    break;
            }
        }
    }

    public class Circle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Circle(int x, int y, int radius) : base(ShapeType.Circle)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int x, int y, int length, int width) : base(ShapeType.Rectangle)
        {
            X = x;
            Y = y;
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            return Length * Width;
        }
    }

    public class Square : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int SideLength { get; set; }

        public Square(int x, int y, int sideLength) : base(ShapeType.Square)
        {
            X = x;
            Y = y;
            SideLength = sideLength;
        }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

    public class Canvas
    {
        private List<Shape> shapes;

        public Canvas()
        {
            shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void Draw()
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}