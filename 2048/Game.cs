using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Game
    {
        static void Main(string[] args)
        {
            Board TheGameBoard = new Board();
            TheGameBoard.PrintBoard();

            GameManager theGame = new GameManager(TheGameBoard);

        }
    }
}
