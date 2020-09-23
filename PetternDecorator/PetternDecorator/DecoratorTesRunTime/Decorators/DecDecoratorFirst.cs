using System;
using System.Collections.Generic;
using System.Text;

namespace PetternDecorator.DecoratorTesRunTime.Decorators
{
    public class DecDecoratorFirst : IDec
    {
        IDec _dec;

        public DecDecoratorFirst(IDec dec)
        {
            _dec = dec;
        }

        string commandX = "- x";

        public void GetCommand()
        {
            Console.WriteLine(commandX);
            _dec.GetCommand();
        }

        public void SetCommandConsole(string command)
        {
            if(command == commandX)
            {
                Console.WriteLine("-> Cut");
            }
            else
            {
                _dec.SetCommandConsole(command);
            }
        }
    }
}
