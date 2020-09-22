using System;
using System.Collections.Generic;
using System.Text;
using PetternDecorator.DecoratorTest;

namespace PetternDecorator.DecoratorTest.Decorator
{
    public class DecoratorFirst : DecoratorBase
    {
        private IObjectTest _object;

        public DecoratorFirst(IObjectTest objectTest)
        {
            _object = objectTest;
        }

        public override void GetDecorator()
        {
            Console.WriteLine("DecoratorFirst");
        }

        public override void GetText()
        {
            _object.GetText();
            Console.WriteLine("add Decorator First");
        }
    }
}
