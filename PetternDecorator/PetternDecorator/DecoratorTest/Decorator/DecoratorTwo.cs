using System;
using System.Collections.Generic;
using System.Text;

namespace PetternDecorator.DecoratorTest.Decorator
{
    class DecoratorTwo: DecoratorBase
    {
        private IObjectTest _object;

        public DecoratorTwo(IObjectTest objectTest)
        {
            _object = objectTest;
        }

        public override void GetDecorator()
        {
            Console.WriteLine("DecoratorTwo");
        }

        public override void GetText()
        {
            _object.GetText();
            Console.WriteLine("add Decorator Two");
        }
    }
}
