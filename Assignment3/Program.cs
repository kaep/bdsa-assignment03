using System;
using System.Linq;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ys = new int[] { 1582, 1600, 2000, 2020, 1900, 5000, 2586100};


            var leapYears = ys.Where(year => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0));
            foreach (var x in leapYears)
            {
                Console.WriteLine(x);
            }
            
            var x1 = new int[] {1,2,3};
            var xs = new int[][] {x1, x1, x1};
            var flat = xs.SelectMany(x => x);          
            
            foreach (var x in flat)
            {
                Console.WriteLine(x);
            }


        }
    }
}
