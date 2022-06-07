using System;
using FactoryMethodTask.shapes.bases;
using FactoryMethodTask.shapes.factories.bases;

namespace FactoryMethodTask.shapes.factories
{
    public class RectangleFactory: SingletonShapeFactory<RectangleFactory>
    {
        public override IShape Shape=> new Rectangle();
    }
}

