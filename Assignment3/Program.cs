using System;
using System.Linq;

namespace BDSA2020.Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            var ys = new int[] { 1582, 1600, 2000, 2020, 1900, 5000, 2586100};


            var leapYears = ys.Where(year => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0));

            
            var x1 = new int[] {1,2,3};
            var xs = new int[][] {x1, x1, x1};
            var flat = xs.SelectMany(x => x);          
            
            
            Console.WriteLine("this is a 1341234test1341 world".WordCount());
        }
    }
}
