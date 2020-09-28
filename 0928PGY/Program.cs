using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0928PGY
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int d = 0;
            int f = rnd.Next(0, 999);
            do
            {
                d++;
                Console.WriteLine($"Hello World! {d}");
                
            } while (d!=f);
            Console.ReadKey(true);

        }
    }
}
