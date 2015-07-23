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

        public void InsertNewNumber()
        {
            int attempt = 0;
            bool success = false;
            Random rnd = new Random();

            while(success == false  && attempt < 15)
            {
                //do this stupid thing while you don't have a method to check for an open spot on the board
                attempt++;

                int x = rnd.Next(0, 3);
                int y = rnd.Next(0, 3);

                //if random spot is empty insert into map and turn success true
                //else pick again
                if(map[x,y] == 0)
                {
                    map[x, y] = 2;
                    success = true;

                }
                

            }
        }

        public void MoveBoardLeft()
        {
            int columnStart = 1;
            int rowStart = 0;

            //loop through columns 2 to 4
            for(int y = columnStart; y < 4; y++)
            {
                //loop through rows 1 to 4
                for(int x = rowStart; x < 4; x++)
                {
                    //slide left if spot to the left is empty
                    if(map[x,y-1] == 0)
                    {
                        map[x, y - 1] = map[x, y];
                        map[x, y] = 0;
                    }
                    //slide left and combine if position to the left is equal
                    else if(map[x,y-1] == map[x,y])
                    {
                        map[x, y - 1] = map[x, y - 1] + map[x, y - 1];
                        map[x, y] = 0;
                    }
                    //don't slide
                    else
                    {
                        
                    }
                    
                }
                
            }


        }

        public void MoveBoardRight()
        {
            int columnStart = 2;
            int rowStart = 0;

            //loop through columns 2 to 0
            for (int y = columnStart; y >= 0; y--)
            {
                //loop through rows 1 to 4
                for (int x = rowStart; x < 4; x++)
                {
                    //slide right if spot to the right is empty
                    if (map[x, y + 1] == 0)
                    {
                        map[x, y + 1] = map[x, y];
                        map[x, y] = 0;
                    }
                    //slide right and combine if position to the right is equal
                    else if (map[x, y + 1] == map[x, y])
                    {
                        map[x, y + 1] = map[x, y + 1] + map[x, y + 1];
                        map[x, y] = 0;
                    }
                    //don't slide
                    else
                    {

                    }

                }

            }
        }

        public void MoveBoardUp()
        {

        }

        public void MoveBoardDown()
        {

        }

    }
}
