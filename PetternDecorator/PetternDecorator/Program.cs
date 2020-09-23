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

            Console.WriteLine("--- End --- offline");

            //RunTimeTest

            while(true)
            {
                string preessKey;
                Console.WriteLine("Please press 'help' or press Enter to exite programm");
                preessKey = Console.ReadLine();
                
                switch(preessKey)
                {
                    case "": return; break;
                    case "help": Console.WriteLine("not command"); break;
                    default: Console.WriteLine("Unknow command, please repeat command"); break;
                }    
            }
        }
    }
}
