namespace NoughtsAndCrosses
{
    using System;

    class Player
    {
        internal string GetMove()
        {
            Console.Write("Please enter a move > ");
            return Console.ReadLine();
        }

        internal int GetPosition()
        {
            Console.Write("Please enter a grid position > ");
            return int.Parse(Console.ReadLine());
        }
    }
}
