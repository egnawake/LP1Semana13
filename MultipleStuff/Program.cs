using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList superList = new SuperList { 4, 10, 2, 29, 17, 13 };
            (double min, double max) = superList.GetMinMax4();
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
        }
    }
}
