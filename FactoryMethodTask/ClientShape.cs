using System;
using FactoryMethodTask.shapes;
using FactoryMethodTask.shapes.bases;
using FactoryMethodTask.shapes.factories;
using FactoryMethodTask.shapes.factories.bases;

namespace FactoryMethodTask
{
    public class ClientShape 
    {

        public  IShape GetShape(ShapeFactory factory)
        {
            return factory.Shape;
        }
        
        public IShape GetRandomShape()
        {
            Random random = new Random();
            ShapeFactory  [] types = { CircleFactory.Instance, RectangleFactory.Instance, TriangleFactory.Instance };
            return GetShape(types[random.Next(0,100) % 3]);
        }

        public void CreateShapes()
        {
            
            IShape shape = GetRandomShape();
            
            switch (shape)
            {
                case Triangle triangle:
                    Console.WriteLine("Create Triangle");
                    Console.Write("Enter Name:");
                    triangle.Name = Console.ReadLine();
                    Console.Write("Enter Color:");
                    triangle.Color = Console.ReadLine();
                    Console.Write("Enter Side X:");
                    triangle.X = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side Y:");
                    triangle.Y = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side Z:");
                    triangle.Z = Convert.ToDouble(Console.ReadLine());
                    break;
                case Circle circle:
                    Console.WriteLine("Create Circle");
                    Console.Write("Enter Name:");
                    circle.Name = Console.ReadLine();
                    Console.Write("Enter Color:");
                    circle.Color = Console.ReadLine();
                    Console.Write("Enter Radius:");
                    circle.Radius = Convert.ToInt32(Console.ReadLine());
                    break;
                case Rectangle rectangle:
                    Console.WriteLine("Create Rectangle");
                    Console.Write("Enter Name:");
                    rectangle.Name = Console.ReadLine();
                    Console.Write("Enter Color:");
                    rectangle.Color = Console.ReadLine();
                    Console.Write("Enter Side X:");
                    rectangle.X = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side Y:");
                    rectangle.Y = Convert.ToDouble(Console.ReadLine());
                    break;
            }
            
            Console.WriteLine(shape);
        }
    }
}