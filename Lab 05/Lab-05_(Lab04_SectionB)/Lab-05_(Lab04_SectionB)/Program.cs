using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05__Lab04_SectionB_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            canvas.AddShape(new Circle(1, 2, 5));
            canvas.AddShape(new Rectangle(3, 4, 6, 7));
            canvas.AddShape(new Square(8, 9, 10));

            canvas.Draw();
            Console.ReadLine();
        }
    }
}
