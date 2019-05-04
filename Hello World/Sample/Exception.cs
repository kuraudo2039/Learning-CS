using System;
namespace Exception
{
    class Program
    {
        public static void main()
        {
            Console.WriteLine("Please Input Value(1~5)");
            int b = int.Parse(Console.ReadLine());
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    int a = getNum(i);
                    b--;
                    Console.WriteLine($"{a}/{b}={calc(a, b)}");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("0による割り算が発生");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("配列の範囲外にアクセスしました");
            }
            finally
            {
                Console.WriteLine("終了");
            }
        }

        private static int calc(int a, int b)
        {
            return a / b;
        }

        public static int getNum(int index)
        {
            int[] num = { 0, 1, 2, 3 };
            return num[index];
        }
    }
}