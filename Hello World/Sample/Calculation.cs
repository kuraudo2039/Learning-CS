using System;

namespace Calculation
{
    class Program
    {
        public void main()
        {
            Console.Write("InDec?:");
            bool InDec = bool.Parse(Console.ReadLine());

            if (InDec)
            {
                int a1 = 1, b1 = 1, c1 = 1, d1 = 1;
                int a2, b2, c2, d2;

                a2 = a1++;
                b2 = ++b1;
                c2 = c1--;
                d2 = --d1;

                Console.WriteLine($"a1={a1} b1={b1} c1={c1} d1={d1} a2={a2} b2={b2} c2={c2} d2={d2}");
            }
            else
            {
                Console.WriteLine($"{5}+{4}={5 + 4}");
                Console.WriteLine($"{7}-{2}={7 - 2}");
                Console.WriteLine($"{13}/{4}={13 / 4}余り{13 % 4}");
                Console.WriteLine($"{2}*{5}={2 * 5}");
            }
        }
    }
}