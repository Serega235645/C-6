using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 5, -1, 3, 10, -4, 6 };

            Console.WriteLine("Maximum element" + list.Max());
            Console.WriteLine("Minimum element" + list.Min());
        }
    }
}
