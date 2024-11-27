using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hpattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n=int.Parse(Console.ReadLine());
            int middle = n / 2;
            if (n < 3 || n % 2 == 0)
            {
                Console.WriteLine("it is not possible because it is not Prime");
                return;
            }

            for(int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (c == 0 || c == n - 1 || r == middle)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                
                    Console.WriteLine();
                
            }
        }
    }
}
