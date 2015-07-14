using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    enum Input { Left, Up, Right, Down};


    class GameInput
    {
        public Input GetDirection()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            Console.WriteLine("You pressed " + key.ToString());

            return Input.Down;
        }
    }
}
