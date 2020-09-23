using System;
using System.Collections.Generic;
using System.Text;

namespace PetternDecorator.DecoratorTesRunTime
{
    public class Dec : IDec
    {
        private List<string> _command = new List<string>();
        private string commandP = "- p";
        private string commandC = "- c";

        public Dec()
        {
            _command.Add(commandP);
            _command.Add(commandC);
        }

        public void GetCommand()
        {
            foreach(string c in _command)
            {
                Console.WriteLine(c);
            }
        }

        public void SetCommandConsole(string command)
        {
            if(_command.Contains(command))
            {
                if (command == commandP) Console.WriteLine("-> Paste");
                if (command == commandC) Console.WriteLine("-> Copy");
            }
            else
            {
                Console.WriteLine("Unknow command!");
            }
        }

        

    }
}
