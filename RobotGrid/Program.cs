using System;

namespace RobotGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] grid = new char[10, 10];
            var rowIndex = 5;
            var colIndex = 5;
            RedrawGrid(grid, rowIndex, colIndex);
            while (true)
            {
                var input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case 'a':
                        //move left
                        if (colIndex > 0) colIndex--;
                        break;

                    case 'd':
                        //move right
                        if (colIndex < 9) colIndex++;
                        break;

                    case 'w':
                        //move up
                        if (rowIndex > 0) rowIndex--;
                        break;

                    case 's':
                        //move down
                        if (rowIndex < 9) rowIndex++;
                        break;

                    default:
                        break;
                }
                RedrawGrid(grid, rowIndex, colIndex);
            }
        }

        static void RedrawGrid(char[,] grid, int row, int col)
        {            
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    grid[i, j] = ' ';

            grid[row, col] = '_';
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }                
        }
    }
}
