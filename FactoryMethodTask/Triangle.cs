using System;

namespace FactoryMethodtask
{
    public class Triangle: IShape
    {
        private string name;
        private string color;
        private double x, y, z;

        public Triangle()
        {
            
        }
        public Triangle(string name, string color, double x, double y, double z)
        {
            this.name = name;
            this.color = color;
            this.x = x;
            this.y = y;
            this.z = z;
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
        public double Z 
        {
            get { return z; } 
            set { z = value; } 
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
            return x * y / 2;
        }

        public double ShapePerimeter()
        {
            return x + y + z;
        }

        public override string ToString()
        {
            return $"Name:{ShapeName()}, Color:{ShapeColor()}, Area:{ShapeArea()}, Perimeter:{ShapePerimeter()}";
        }

        
    }
}

