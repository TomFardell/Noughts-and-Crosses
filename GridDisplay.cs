namespace NoughtsAndCrosses
{
    using System;

    class GridDisplay
    {
        internal void RenderGrid(Grid grid)
        {
            Char[,] board = grid.board;
            int x = board.GetLength(0);
            int y = board.GetLength(1);

            Console.Clear();

            Console.Write("   ");
            for (int j = 0; j < x; j++)
            {
                Console.Write("|   ");
            }
            Console.WriteLine("|");

            Console.Write("   ");
            for (int j = 0; j < x; j++)
            {
                if (j < 10)
                {
                    Console.Write("| {0} ", j.ToString());
                }
                else
                {
                    Console.Write("| {0}", j.ToString());
                }
            }
            Console.WriteLine("|");

            Console.Write("___");
            for (int j = 0; j < x; j++)
            {
                Console.Write("|___");
            }
            Console.WriteLine("|");

            for (int i = 0; i < y; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < x; j++)
                {
                    Console.Write("|   ");
                }
                Console.WriteLine("|");

                if (i < 10)
                {
                    Console.Write(" {0} ", i.ToString());
                }
                else
                {
                    Console.Write(" {0}", i.ToString());
                }

                    for (int j = 0; j < x; j++)
                {
                    Console.Write("| {0} ", board[j, i]);
                }
                Console.WriteLine("|");

                Console.Write("___");
                for (int j = 0; j < x; j++)
                {
                    Console.Write("|___");
                }
                Console.WriteLine("|");
            }
        }
    }
}
