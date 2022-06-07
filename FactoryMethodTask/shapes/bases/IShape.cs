using System;

namespace FactoryMethodTask.shapes.bases
{
    public interface IShape
    {
        string ShapeName();
        string ShapeColor();
        double ShapeArea();
        double ShapePerimeter();
    }
}

