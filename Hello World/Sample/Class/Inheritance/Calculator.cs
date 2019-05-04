using System;
namespace Class
{
    class Calculator
    {
        protected int[] num;

        protected int count = 0;

        public Calculator(int count)
        {
            while (count < 1)
            {
                Console.WriteLine("計算する値の数を入力してください(1以上の値)");
                Console.Write("count：");
                count = int.Parse(Console.ReadLine());
            }
            this.count = count;
            num = new int[this.count];
            Console.WriteLine($"{count}回の値を入力");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{i + 1}回目：");
                num[i] = int.Parse(Console.ReadLine());
            }
        }

        public void sum()
        {
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += num[i];
            }
            Console.WriteLine($"合計は {sum} です");
        }
    }
}