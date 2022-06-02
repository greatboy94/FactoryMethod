using System;
using FactoryMethodTask.shapes.bases;

namespace FactoryMethodTask.shapes.factories.bases
{
    public abstract class SingletonShapeFactory<T> : ShapeFactory where T : class, new()
    {
        private static T _instance;

        public static T Instance => _instance ??= new T();
   
        public virtual IShape Shape { get; }
    }
}

