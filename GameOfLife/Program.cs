using System;
using System.Threading;

namespace GameOfLife
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var grid = StarterGrid.GosperGliderGun;
            
            var generation = new Evolution();
            var evolve = true;
            var generations = 0;
            
            Grid.Print(grid.CurrentGrid, generations);
            
            while (evolve)
            {
                var evolvedGrid = generation.EvolveGrid(grid);
                generations++;
                Grid.Print(evolvedGrid.CurrentGrid, generations);
                if (Grid.Equal(evolvedGrid.CurrentGrid, grid.CurrentGrid))
                {
                    evolve = false;
                }
                grid = evolvedGrid;
                Thread.Sleep(100);
            }

            Console.WriteLine("Evolution Complete");
        }
    }
}