using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{



    class Board
    {

        int[,] map;

        public Board()
        {
            map = new int[4,4];
            Array.Clear(map, 0, 4);
            //insert random values to start with
            PopulateBoard();
        }

        public void PrintBoard()
        {
            int max = map.Cast<int>().Max();
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(map[x, y] + "    ");
                }
                Console.WriteLine();
            }
        }

        /**
         * 
         * insert two random 2s into board to start.
         * */
        public void PopulateBoard()
        {
            Random rnd = new Random();
            int x1 = rnd.Next(0, 3);
            int y1 = rnd.Next(0, 3);
            map[x1, y1] = 2;

            int x2 = rnd.Next(0, 3);
            int y2 = rnd.Next(0, 3);
            map[x2, y2] = 2;
        }
    }
}
