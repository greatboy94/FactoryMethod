using System;

namespace FactoryMethodtask
{
    public class Circle: IShape
    {
        private string name;
        private string color;
        private int radius;
        
        public Circle()
        {
            
        }
        public Circle(string name, string color, int radius)
        {
            this.name = name;
            this.color = color;
            this.radius = radius;
        }

        public string Name
        {
            set { name = value; }
        }
        public string Color
        {
            set { color = value; }
        }
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        
        public string ShapeName()
        {
            return name;
        }

        public string ShapeColor()
        {
            return color;
        }

        public double ShapeArea()
        {
            return Math.PI * (radius * radius);
        }

        public double ShapePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return $"Name:{ShapeName()}, Color:{ShapeColor()}, Area:{ShapeArea()}, Perimeter:{ShapePerimeter()}";
        }

    }
}