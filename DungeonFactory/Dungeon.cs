using System;
using System.Collections.Generic;
using System.Text;
using DungeonFactory.Interfaces;

namespace DungeonFactory
{
    public class Dungeon : IDungeon
    {
        private readonly int height;
        private readonly int width;

        private int[,] layout;

        public int Height
        {
            get { return height; }
        }

        public int Width
        {
            get { return width; }
        }

        public int[,] Layout
        {
            get { return layout; }
        }

        public Dungeon(int h, int w, int[,] map)
        {
            height = h;
            width = w;
            layout = map;
        }
    }
}
