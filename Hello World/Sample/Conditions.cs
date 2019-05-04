using System;

namespace Conditions
{

    class Program
    {
        public void main()
        {
            Console.Write("整数値を入力:");
            //string型をint型に変換
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"a={a}");

            if (a >= 0)
            {
                Console.WriteLine($"aは正の数です。");
            }
            else
            {
                Console.WriteLine($"aは負の数です。");
            }

        }
    }
}