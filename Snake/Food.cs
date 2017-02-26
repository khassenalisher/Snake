using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int Widht;
        int Height;
        char sym;

        Random random = new Random();

        public FoodCreator(int Width, int Height, char sym)
        {
            this.Widht = Width;
            this.Height = Height;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, Widht - 2);
            int y = random.Next(2, Height - 2);
            return new Point(x, y, sym);
        }
    }
}
