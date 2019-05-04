using System;
namespace Class
{
    //Calculatorクラスを継承
    class ExCalculator : Calculator
    {
        /*
        //継承元(スーパークラス)にコンストラクタ(引数なし)があるパターン
        public ExCalculator() : base(){}

        //継承元の引数がないパターン
        public ExCalculator() : base(10){}

        //継承元の引数が多いパターン
        public ExCalculator(int count, string text) : base(count){} 
        */

        //継承元にコンストラクタ(引数あり)がある場合に必要な処理
        public ExCalculator(int count) : base(count) { }
        public void mul()
        {
            double mul = 1;
            Console.WriteLine("値が一つでかつ自然数の場合は階乗が計算されます");

            if (count == 1 && num[0] > 0)
            {
                for (int i = 1; i <= num[0]; i++)
                {
                    mul *= i;
                }
                Console.WriteLine($"{num[0]} の階乗は {mul} です。");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    mul *= num[i];
                }

                Console.WriteLine($"全てかけた値は {mul} です");
            }
        }

        public void SetInformation(int count)
        {
            num = null;
            GC.Collect();

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
    }
}