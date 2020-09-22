using System;
using System.Collections.Generic;
using System.Text;

namespace PetternDecorator.DecoratorTest.Decorator
{
    public abstract class DecoratorBase: IObjectTest
    {
        public abstract void GetDecorator();

        public abstract void GetText();
    }
}
