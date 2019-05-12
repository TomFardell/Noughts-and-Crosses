namespace NoughtsAndCrosses
{
    using System;

    class Grid
    {
        public int spaces;

        private int x;
        private int y;
        private string[] board;

        internal Grid(int xLength, int yLength)
        {
            x = xLength;
            y = yLength;
            spaces = xLength * yLength;
            board = new string[spaces];

            for (int i = 0; i < spaces; i++)
            {
                board[i] = (i + 1).ToString();
            }
        }

        internal void PrintGrid()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
            Console.WriteLine("   |   |   ");
        }

        internal void UpdateSquare(int position, string newMove)
        {
            board[position - 1] = newMove;
        }
    }
}
