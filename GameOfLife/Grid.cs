using System;
using System.Collections.Generic;

namespace GameOfLife
{
    public class Grid
    {
        public const string Dead = ".";
        public const string Live = "*";
        public string[,] CurrentGrid { get; set; }

        public string[] GetNeighborsAtLocation(int x, int y)
        {
            var rows = CurrentGrid.GetLength(0);
            var columns = CurrentGrid.GetLength(1);
            var neighbors = new List<string>{};
            for (int i = x - 1; i <= x + 1; i++)
            {
                if (i < 0 || i >= rows)
                {
                    continue;
                }
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (j < 0 || j >= columns)
                    {
                        continue;
                    }
                    if (i == x && j == y)
                    {
                        continue;
                    }
                    neighbors.Add(CurrentGrid[i,j]);
                }
            }

            return neighbors.ToArray();
        }

        public static string[,] DefaultDeadGrid(int width, int height)
        {
            var grid = new string[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    grid[i, j] = Dead;
                }
            }

            return grid;
        }

        public static bool Equal(string[,] first, string[,] second)
        {
            for (int i = 0; i < first.GetLength(0); i++)
            {
                for (int j = 0; j < first.GetLength(1); j++)
                {
                    if (first[i, j] != second[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void Print(string[,] grid, int generations)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Generations: {generations}");
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i,j] + " ");   
                }
                Console.WriteLine();
            }
        }
    }
}