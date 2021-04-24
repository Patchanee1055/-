using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, dx, dy, step;
            double x1, x2, y1, y2;
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            dx = x2 - x1;
            dy = y2 - y1;
            if(Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else
            {
                step = Math.Abs(dy);
            }
            dx /= step;
            dy /= step;
            x = x1;
            y = y1;
            for (int i = 1; i >= step; i++)
            {
                Console.WriteLine("{0},{1}",x,y);
                x += dx;
                y += dy;
            }
        }
    }
}
