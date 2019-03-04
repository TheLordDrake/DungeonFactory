using System;
using DungeonFactory.Interfaces;

namespace DungeonFactory
{
    public class Factory : IFactory
    {
        /// <summary>
        /// Generate Dungeon
        /// </summary>
        /// <param name="perimeter">Height x Width, Maximum area of the Dungeon</param>
        /// <returns></returns>
        public Dungeon GenerateDungeon(int[] perimeter)
        {
            if (perimeter.Length != 2)
            {
                throw new ArgumentException("Perimeter array is not 2 int");
            }

            return GenerateDungeon(perimeter[0], perimeter[1]);
        }

        /// <summary>
        /// Generate Dungeon
        /// </summary>
        /// <param name="height">Maximum height of the Dungeon</param>
        /// <param name="width">Maximum width of the Dungeon</param>
        /// <returns></returns>
        public Dungeon GenerateDungeon(int height, int width)
        {
            int[,] layout = GenerateLayout(height, width);

            return new Dungeon(height, width, layout);
        }

        private int[,] GenerateLayout(int height, int width)
        {
            int[,] map = new int[height, width];

            return map;
        }
    }
}
