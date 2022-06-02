using System;
using FactoryMethodTask.shapes;
using FactoryMethodTask.shapes.bases;

namespace FactoryMethodTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClientShape client = new ClientShape();
            
            IShape shape = client.GetRandomShape();
       
            switch (shape)
            {
                case Triangle triangle:
                    triangle.Name = "Triangle";
                    triangle.Color = "Red";
                    triangle.X = 3;
                    triangle.Y = 5;
                    triangle.Z = 2;
                    break;
                case Circle circle:
                    circle.Name = "Circle";
                    circle.Color = "Green";
                    circle.Radius = 5;
                    break;
                case Rectangle rectangle:
                    rectangle.Name = "Rectangle";
                    rectangle.Color = "Black";
                    rectangle.X = 5;
                    rectangle.Y = 3;
                    break;
            }

            Console.WriteLine(shape);
        }
    }
}