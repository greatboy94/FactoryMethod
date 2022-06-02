using System;
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
        
        public  IShape GetRandomShape()
        {
            Random random = new Random();
            ShapeFactory  [] types = { CircleFactory.Instance, RectangleFactory.Instance, TriangleFactory.Instance };
            return GetShape(types[random.Next(0,100) % 3]);
        }
    }
}