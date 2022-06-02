using System;
using FactoryMethodTask.shapes.bases;

namespace FactoryMethodTask.shapes.factories.bases
{
    public interface ShapeFactory
    {
        public IShape Shape { get; }
    }
}

