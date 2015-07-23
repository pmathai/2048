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

            var input = inputs.GetDirection();

            while (input != Input.Quit)
            {
                Console.WriteLine("What is input " + input);

                //move board around
                if (input == Input.Left)
                {
                    //move board left
                    GameBoard.MoveBoardLeft();

                }
                else if(input == Input.Up)
                {
                    //move board up.
                }
                else if(input == Input.Right)
                {

                    //move board right
                    GameBoard.MoveBoardRight();
                }
                else if(input == Input.Down)
                {
                    //move board down
                }


                //check if game over or insert new random number
                GameBoard.InsertNewNumber();

                //print board
                GameBoard.PrintBoard();
                input = inputs.GetDirection();

            }
            



        }

    }
}
