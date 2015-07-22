using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    enum Input { Left, Up, Right, Down, Quit};


    class GameInput
    {
        public Input GetDirection()
        {
            ConsoleKeyInfo keyPress= Console.ReadKey();

            //Console.WriteLine("You pressed " + keyPress.Key.ToString());

            if (keyPress.Key.ToString() == "W")
            {
                return Input.Up;
            }
            else if (keyPress.Key.ToString() == "A")
            {
                return Input.Left;
            }
            else if (keyPress.Key.ToString() == "S")
            {
                return Input.Down;
            }
            else if (keyPress.Key.ToString() == "D")
            {
                return Input.Right;
            }



            return Input.Quit;
        }
    }
}
