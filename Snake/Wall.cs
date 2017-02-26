using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
        List<Figure> wallList;

        public Wall(int Width, int Height)
        {
            wallList = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, Width - 2, 0, '*');
            HorizontalLine downLine = new HorizontalLine(0, Width - 2, Height - 1, '*');
            VerticalLine leftLine = new VerticalLine(0, Height - 1, 0, '*');
            VerticalLine rightLine = new VerticalLine(0, Height - 1, Width - 2, '*');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}