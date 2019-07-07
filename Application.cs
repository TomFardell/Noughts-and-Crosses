namespace NoughtsAndCrosses
{
    using System;

    class Application
    {
        internal void Start()
        {
            Grid grid = new Grid(3, 3);
            GridDisplay gridDisplay = new GridDisplay();
            Player playerOne = new Player('O');
            Player playerTwo = new Player('X');
            string winner = "None";

            int i = 0;
            while (true)
            {
                if (grid.PlayTurn(playerOne, grid, gridDisplay))
                {
                    winner = "Player One";
                    break;
                }

                i++;

                if (i >= grid.spaces)
                {
                    break;
                }

                if (grid.PlayTurn(playerTwo, grid, gridDisplay))
                {
                    winner = "Player Two";
                    break;
                }

                i++;

                if (i >= grid.spaces)
                {
                    break;
                }
            }

            gridDisplay.RenderGrid(grid);

            Console.WriteLine("Winner: {0}", winner);
            Console.Write("Press any key to exit > ");
            Console.ReadKey();
        }
    }
}
