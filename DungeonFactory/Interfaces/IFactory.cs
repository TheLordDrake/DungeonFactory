using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonFactory.Interfaces
{
    interface IFactory
    {
        /// <summary>
        /// Generate Dungeon
        /// </summary>
        /// <param name="height">Maximum height of the Dungeon</param>
        /// <param name="width">Maximum width of the Dungeon</param>
        /// <returns></returns>
        Dungeon GenerateDungeon(int height, int width);

        /// <summary>
        /// Generate Dungeon
        /// </summary>
        /// <param name="perimeter">Height x Width, Maximum area of the Dungeon</param>
        /// <returns></returns>
        Dungeon GenerateDungeon(int[] perimeter);
    }
}
