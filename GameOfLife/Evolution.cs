using System.Linq;

namespace GameOfLife
{
    public class Evolution
    {
        private const string Dead = ".";
        private const string Live = "*";

        public string EvolveCell(string cell, string[] neighbors)
        {
            var evolvedCell = Dead;
            var liveNeighbors = neighbors.Count(x => x == Live);
            
            if (cell == Live && liveNeighbors == 2 || liveNeighbors == 3)
            {
                evolvedCell = Live;
            }
            return evolvedCell;
        }

        public Grid EvolveGrid(Grid grid)
        {
            var rows = grid.CurrentGrid.GetLength(0);
            var columns = grid.CurrentGrid.GetLength(1);
            var evolvedGrid = new string[rows,columns];
            for (var y = 0; y < columns; y++)
            {
                for (var x = 0; x < rows; x++)
                {
                    var neighbors = grid.GetNeighborsAtLocation(x, y);
                    evolvedGrid[x,y] = EvolveCell(grid.CurrentGrid[x,y], neighbors);
                }
            }

            return new Grid { CurrentGrid = evolvedGrid };
        }
    }
}