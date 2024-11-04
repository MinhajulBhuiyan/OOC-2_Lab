using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_05__Lab04_SectionB_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_05__Lab04_SectionB_.Tests
{
    [TestClass()]
    public class CanvasTests
    {
        public void Draw_ShouldDrawAllShapes() 
        {
            // Arrange
            var canvas = new Canvas();
            var circle = new Circle(1, 2, 5);
            var rectangle = new Rectangle(3, 4, 6, 7);
            var square = new Square(8, 9, 10);

            // Redirect Console output to capture it
            var stringBuilder = new StringBuilder();
            var stringWriter = new StringWriter(stringBuilder);
            Console.SetOut(stringWriter);

            // Act
            canvas.AddShape(circle);
            canvas.AddShape(rectangle);
            canvas.AddShape(square);
            canvas.Draw();

            // Restore the original Console output
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

            // Assert
            var expectedOutput = "Drawing a Circle" + Environment.NewLine +
                                 "Drawing a Rectangle" + Environment.NewLine +
                                 "Drawing a Square" + Environment.NewLine;

            Assert.AreEqual(expectedOutput, stringBuilder.ToString());
        }

}
}