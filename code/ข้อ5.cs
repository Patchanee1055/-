using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, time;
            day = int.Parse(Console.ReadLine());
            time = int.Parse(Console.ReadLine());
            int breakfastSet=5,weekendSet=2,coffee=3;
            string food = Console.ReadLine();
            if(food == "end") { Console.WriteLine("Bye"); }
            while (breakfastSet != 0 && weekendSet != 0 && coffee != 0)
            {
                food = Console.ReadLine();
                if (food == "breakfastSet")
                {
                    breakfastSet = breakfastSet - 1;
                    if (breakfastSet == 0) { Console.WriteLine("Sorry your order is out of stock"); }
                    if (time > 11) { Console.WriteLine("Sorry your order is not available"); }
                }
                else if (food == "weekendSet")
                {
                    weekendSet = weekendSet - 1;
                    if (weekendSet == 0) { Console.WriteLine("Sorry your order is out of stock"); }
                    if (day != 6 && day != 7) { Console.WriteLine("Sorry your order is not available"); }
                }
                else if (food == "coffee")
                {
                    coffee = coffee - 1;
                    if (breakfastSet == 0) { Console.WriteLine("Sorry your order is out of stock"); }
                }
                else { Console.WriteLine("Please enter a valid menu."); }
            }
        
        }
    }
}
