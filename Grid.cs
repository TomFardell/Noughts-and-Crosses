namespace NoughtsAndCrosses
{
    using System;

    class Grid
    {
        internal int spaces;
        internal char[,] board;

        internal Grid(int x, int y)
        {
            if (x > 16)
            {
                throw new ArgumentOutOfRangeException("Grid X too large.");
            }
            else if (y > 16)
            {
                throw new ArgumentOutOfRangeException("Grid Y too large.");
            }

            spaces = x * y;
            board = new char[x, y];

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    board[j, i] = ' ';
                }
            }
        }

        internal bool PlayTurn(Player player, Grid grid, GridDisplay gridDisplay)
        {
            gridDisplay.RenderGrid(grid);
            
            while (true)
            {
                int x = player.GetPosition('x');
                int y = player.GetPosition('y');
               
                if (x >= board.GetLength(0) || y >= board.GetLength(1))
                {
                    Console.WriteLine("Position off the board. Enter different position.");
                }
                else if (board[x, y] != ' ')
                {
                    Console.WriteLine("Position full. Enter different position.");
                }
                else
                {
                    grid.UpdateSquare(x, y, player.GetMove());
                    break;
                }
            }
                       
            if (grid.CheckWin())
            {
                return true;
            }

            return false;
        }

        private void UpdateSquare(int xPos, int yPos, char newMove)
        {
            board[xPos, yPos] = newMove;
        }

        private bool CheckWin()
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            // Horizontal checks
            for (int y = 0; y < columns; y++)
            {
                for (int x = 0; x < rows - 2; x++)
                {
                    if (board[x, y] == board[x + 1, y] && board[x, y] == board[x + 2, y] && board[x, y] != ' ')
                    {
                        return true;
                    }
                }
            }

            // Vertical checks
            for (int y = 0; y < columns - 2; y++)
            {
                for (int x = 0; x < rows; x++)
                {
                    if (board[x, y] == board[x, y + 1] && board[x, y] == board[x, y + 2] && board[x, y] != ' ')
                    {
                        return true;
                    }
                }
            }

            // Diagonal checks
            for (int y = 0; y < columns - 2; y++)
            {
                for (int x = 0; x < rows - 2; x++)
                {
                    if (board[x, y] == board[x + 1, y + 1] && board[x, y] == board[x + 2, y + 2] && board[x, y] != ' ')
                    {
                        return true;
                    }
                }
            }

            for (int y = 2; y < columns; y++)
            {
                for (int x = 0; x < rows - 2; x++)
                {
                    if (board[x, y] == board[x + 1, y - 1] && board[x, y] == board[x + 2, y - 2] && board[x, y] != ' ')
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
