using System;
using FactoryMethodTask.shapes.bases;
using FactoryMethodTask.shapes.factories.bases;

namespace FactoryMethodTask.shapes.factories
{
    public class TriangleFactory: SingletonShapeFactory<TriangleFactory>
    {
        public override  IShape Shape=> new Triangle();
    }
}

