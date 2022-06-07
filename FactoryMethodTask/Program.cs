using System;
using FactoryMethodTask.shapes;
using FactoryMethodTask.shapes.bases;

namespace FactoryMethodTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClientShape client = new ClientShape();
            client.CreateShapes();

        }
        
    }
}