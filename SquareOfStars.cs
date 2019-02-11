using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*',n));
            Console.WriteLine(n);
            for (int i = 0; i < (n-2); i++) ;
            {
                Console.Write('*');
                for (int j = 0; j < n - 2; j++) ;
                Console.Write('*');
                Console.Write('\n');
            }
            Console.WriteLine(new string('*', n));
            Console.WriteLine(n);
            Console.Write('\n');
        }
    }
}
