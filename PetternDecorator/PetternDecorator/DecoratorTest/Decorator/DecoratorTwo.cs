using System;
using System.Collections.Generic;
using System.Text;

namespace PetternDecorator.DecoratorTest.Decorator
{
    class DecoratorTwo: IDecorator
    {
        private IObjectTest _object;

        public DecoratorTwo(IObjectTest objectTest)
        {
            _object = objectTest;
        }

        public void GetDecorator()
        {
            Console.WriteLine("DecoratorTwo");
        }

        public void GetText()
        {
            _object.GetText();
            Console.WriteLine("add Decorator Two");
        }
    }
}
