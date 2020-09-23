using PetternDecorator.DecoratorTest;
using System;
using PetternDecorator.DecoratorTest.Decorator;
using PetternDecorator.DecoratorTesRunTime;
using PetternDecorator.DecoratorTesRunTime.Decorators;

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

            IDec dec = new Dec();
            const string addDec1 = "add x";
            bool addDec1Bool = true;
            const string addDec2 = "add z";
            bool addDec2Bool = true;

            Console.WriteLine("Please press 'help' or press Enter to exite programm");
            while (true)
            {
                string preessKey = Console.ReadLine();
                
                switch(preessKey)
                {
                    case "": return;
                    case "help": 
                        dec.GetCommand();
                        if (addDec1Bool) Console.WriteLine(addDec1);
                        if (addDec2Bool) Console.WriteLine(addDec2);
                        break;
                    case addDec1:
                        if (addDec1Bool)
                        {
                            dec = new DecDecoratorFirst(dec);
                            addDec1Bool = false;
                            Console.WriteLine("Decorator First is done!");
                        }
                        else
                        {
                            Console.WriteLine("Operation didn`t complite");
                        }
                        break;
                    case addDec2:
                        if (addDec2Bool)
                        {
                            dec = new DecDecoratorTwo(dec);
                            addDec2Bool = false;
                            Console.WriteLine("Decorator Two is done!");
                        }
                        else
                        {
                            Console.WriteLine("Operation didn`t complite");
                        }
                        break;
                    default: dec.SetCommandConsole(preessKey); break;
                }

                Console.WriteLine("---");
            }
        }
    }
}
