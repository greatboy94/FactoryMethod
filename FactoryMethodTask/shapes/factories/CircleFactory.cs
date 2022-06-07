using System;
using FactoryMethodTask.shapes.bases;
using FactoryMethodTask.shapes.factories.bases;

namespace FactoryMethodTask.shapes.factories
{
    public class CircleFactory : SingletonShapeFactory<CircleFactory>
    {
        public override IShape Shape=> new Circle();
    }
}

