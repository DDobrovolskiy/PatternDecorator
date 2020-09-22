using System;
using System.Collections.Generic;
using System.Text;

namespace PetternDecorator.DecoratorTest.Decorator
{
    public abstract class DecoratorBase: ObjectTestBase, IObjectTest
    {
        public abstract void GetDecorator();

        //public abstract void GetText();
    }
}
