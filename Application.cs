namespace NoughtsAndCrosses
{
    using System;

    class Application
    {
        internal void Start()
        {
            Grid grid = new Grid(3, 3);
            Player player = new Player();

            grid.PrintGrid();

            for (int i = 0; i < grid.spaces; i++)
            {
                grid.UpdateSquare(player.GetPosition(), player.GetMove());
                Console.Clear();
                grid.PrintGrid();
            }

            Console.Write("Press any key to exit > ");
            Console.ReadKey();
        }
    }
}
