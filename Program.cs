using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_fibonacci
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++) // Compute Fibonacci sequence iteratively in N steps
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}
