using PetternDecorator.DecoratorTest;
using System;
using PetternDecorator.DecoratorTest.Decorator;

namespace PetternDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IObjectTest _objectTest = new DecoratorFirst(new DecoratorTwo(new ObjectTest()));
            _objectTest.GetText();

            ObjectTestBase _objectTestTwo = new DecoratorTwo(new DecoratorFirst(new ObjectTest()));
            _objectTestTwo.GetText();

            Console.WriteLine("--- End ---");
        }
    }
}
