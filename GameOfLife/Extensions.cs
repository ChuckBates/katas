namespace GameOfLife
{
    public static class Extensions
    {
        public static bool Equals(this string[,] self, string[,] other)
        {
            for (int i = 0; i < self.GetLength(0); i++)
            {
                for (int j = 0; j < self.GetLength(1); j++)
                {
                    if (self[i, j] != other[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}