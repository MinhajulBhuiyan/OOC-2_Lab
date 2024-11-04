using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Lab4_SectionB_Refactor_
{

    public abstract class Shape
    {
        public abstract void Draw();
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }

        public override double CalculateArea()
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

        public Rectangle(int x, int y, int length, int width)
        {
            X = x;
            Y = y;
            Length = length;
            Width = width;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    public class Square : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int SideLength { get; set; }

        public Square(int x, int y, int sideLength)
        {
            X = x;
            Y = y;
            SideLength = sideLength;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }

        public override double CalculateArea()
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

        public double CalculateTotalArea()
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }
            return totalArea;
        }
    }

}
