using System;
using FactoryMethodTask.shapes.bases;

namespace FactoryMethodTask.shapes
{
    public class Rectangle: IShape
    {

        private string name;
        private string color;
        private double x, y;

        public Rectangle()
        {
            
        }

        public Rectangle(string name, string color, double x, double y)
        {
            this.name = name;
            this.color = color;
            this.x = x;
            this.y = y;
        }
        
        public string Name 
        {
            set { name = value; } 
        }
        public string Color 
        {
            set { color = value; } 
        }
        public double X 
        {
            get { return x; } 
            set { x = value; } 
        }
        public double Y 
        {
            get { return y; } 
            set { y = value; } 
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
            return x * y;
        }

        public double ShapePerimeter()
        {
            return 2 * (x * y);
        }

        public override string ToString()
        {
            return $"Name:{ShapeName()}, Color:{ShapeColor()}, Area:{ShapeArea()}, Perimeter:{ShapePerimeter()}";
        }
    }
}

