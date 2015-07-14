using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class GameManager
    {
        Board GameBoard;

        public GameManager(Board b)
        {
            GameBoard = b;
            RunGame();
        }

        public void RunGame()
        {
            GameInput inputs = new GameInput();
            inputs.GetDirection();
        }

    }
}
