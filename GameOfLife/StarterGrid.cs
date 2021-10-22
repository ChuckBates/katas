namespace GameOfLife
{
    public static class StarterGrid
    {

        public static Grid Glider
        {
            get
            {
                var grid = Grid.DefaultDeadGrid(25, 25);
                grid[1, 0] = Grid.Live;
                grid[2, 1] = Grid.Live;
                grid[0, 2] = Grid.Live;
                grid[1, 2] = Grid.Live;
                grid[2, 2] = Grid.Live;
                return new Grid { CurrentGrid = grid };
            }
        }

        public static Grid Diehard
        {
            get
            {
                var grid = Grid.DefaultDeadGrid(40, 40);
                grid[15, 10] = Grid.Live;
                grid[15, 11] = Grid.Live;
                grid[16, 11] = Grid.Live;
                grid[14, 16] = Grid.Live;
                grid[16, 15] = Grid.Live;
                grid[16, 16] = Grid.Live;
                grid[16, 17] = Grid.Live;
                return new Grid {CurrentGrid = grid};
            }
        }

        public static Grid GosperGliderGun
        {
            get
            {
                var grid = Grid.DefaultDeadGrid(30, 50);
                grid[10, 1] = Grid.Live;
                grid[10, 2] = Grid.Live;
                grid[11, 1] = Grid.Live;
                grid[11, 2] = Grid.Live;

                grid[10, 11] = Grid.Live;
                grid[11, 11] = Grid.Live;
                grid[12, 11] = Grid.Live;
                grid[9, 12] = Grid.Live;
                grid[13, 12] = Grid.Live;
                grid[8, 13] = Grid.Live;
                grid[14, 13] = Grid.Live;
                grid[8, 14] = Grid.Live;
                grid[14, 14] = Grid.Live;
                grid[11, 15] = Grid.Live;
                grid[9, 16] = Grid.Live;
                grid[13, 16] = Grid.Live;
                grid[10, 17] = Grid.Live;
                grid[11, 17] = Grid.Live;
                grid[12, 17] = Grid.Live;
                grid[11, 18] = Grid.Live;

                grid[8, 21] = Grid.Live;
                grid[9, 21] = Grid.Live;
                grid[10, 21] = Grid.Live;
                grid[8, 22] = Grid.Live;
                grid[9, 22] = Grid.Live;
                grid[10, 22] = Grid.Live;
                grid[7, 23] = Grid.Live;
                grid[11, 23] = Grid.Live;
                grid[6, 25] = Grid.Live;
                grid[7, 25] = Grid.Live;
                grid[11, 25] = Grid.Live;
                grid[12, 25] = Grid.Live;

                grid[8, 35] = Grid.Live;
                grid[9, 35] = Grid.Live;
                grid[8, 36] = Grid.Live;
                grid[9, 36] = Grid.Live;
                return new Grid {CurrentGrid = grid};
            }
        }
    }
}