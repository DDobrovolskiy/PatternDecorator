using System;
using System.Collections.Generic;
using System.Text;

namespace PetternDecorator.DecoratorTesRunTime.Decorators
{
    class DecDecoratorTwo : IDec
    {
        IDec _dec;

        public DecDecoratorTwo(IDec dec)
        {
            _dec = dec;
        }

        string commandX = "- z";

        public void GetCommand()
        {
            Console.WriteLine(commandX);
            _dec.GetCommand();
        }

        public void SetCommandConsole(string command)
        {
            if (command == commandX)
            {
                Console.WriteLine("-> Zero");
            }
            else
            {
                _dec.SetCommandConsole(command);
            }
        }

    }
}
