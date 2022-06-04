using System;
using System.Collections.Generic;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Star> stars = new List<Star> {
                new Star(1000, 900),
                new Star(1220, 600),
                new Star(950, 600),
                new Star(1220, 800)
            };

            stars.Sort();
            foreach (Star s in stars)
            {
                Console.WriteLine(s);
            }
        }
    }
}
