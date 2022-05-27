using System;

namespace FactoryMethodtask
{
    public class ShapeFactory
    {
        public static IShape GetShape(ShapeType type)
        {
            if (type==ShapeType.Circle)
            {
                return new Circle();
            }else if (type == ShapeType.Rectangle)
            {
                return new Rectangle();
            }else if (type==ShapeType.Triangle)
            {
                return new Triangle();
            }else
            {
                return null;
            }
        }
        
        public static IShape GetRandomShape()
        {
            Random random = new Random();
            ShapeType[] types = { ShapeType.Triangle, ShapeType.Rectangle, ShapeType.Circle };
            return GetShape(types[random.Next(0,100) % 3]);
        }
    }
}