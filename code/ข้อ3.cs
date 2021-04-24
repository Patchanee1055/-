using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double filmBackWidth = double.Parse(Console.ReadLine());
            while (filmBackWidth <= 0)
            {
                Console.WriteLine("Invalid filmBackWidth.Please input again.");
                filmBackWidth = double.Parse(Console.ReadLine());
            }
            double fLength,fov;
            if (mode == "fLength")
            {
                fLength = double.Parse(Console.ReadLine());
                while (fLength <= 0)
                {
                    Console.WriteLine("Invalid fLength.Please input again.");
                    fLength = double.Parse(Console.ReadLine());
                }
                fov = 2 * Math.Atan(filmBackWidth / 2*fLength);
                Console.WriteLine("fLength={0},fov={1}", fLength,fov);
            }
            else if (mode == "fov")
            {
                fov = double.Parse(Console.ReadLine());
                while (fov > 0.1 && fov < 6.28)
                {
                    Console.WriteLine("Invalid fov.Please input again.");
                    fov = double.Parse(Console.ReadLine());
                }
                fov = filmBackWidth / (2 * Math.Tan(fov / 2));
                Console.WriteLine("fLength={0},fov={1}", fLength, fov);
            }
        }
    }
}
