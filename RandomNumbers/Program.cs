using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static List<int> SingleInstance(int n)
        {
            Random random = new Random();
            List<int> results = new List<int>();
            for (int i = 0; i < n; ++i)
                results.Add(random.Next(1, 101));
            return results;
        }

        static List<int> MultiInstance(int n)
        {
            List<int> results = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                Random random = new Random();
                results.Add(random.Next(1, 101));
            }
            return results;
        }

        static void Main(string[] args)
        {
            int n = 50;
            var list1 = SingleInstance(n);
            var listN = MultiInstance(n);
            for (int i = 0; i < n; ++i)
                Console.WriteLine($"{list1[i],3}  {listN[i],3}");

            Console.ReadKey();
        }
    }
}
