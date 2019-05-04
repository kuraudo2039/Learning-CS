using System;

namespace Repetition
{
    class Program
    {
        public void main()
        {
            Console.WriteLine("for=0,while=1,dowhile=2,infinity=3");
            int sw = int.Parse(Console.ReadLine());

            switch (sw)
            {
                case 0:

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine();

                    //x_y座標をAに変換
                    Console.WriteLine("(x,y)座標をAに変換\n[x_y]で入力");
                    Console.Write("x_y=");
                    var x_y = Split1(Console.ReadLine());
                    int x = x_y[0], y = x_y[1];


                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (j == x && i == y)
                            {
                                Console.Write($"A　");
                            }
                            else { Console.Write($"{j}　"); }
                        }
                        Console.Write("\n");
                    }
                    break;

                case 1:
                    Console.Write("値を入力:");
                    int valueW = int.Parse(Console.ReadLine());
                    while (valueW > 0)
                    {
                        Console.Write($"{valueW} ");
                        valueW--;
                    }
                    Console.WriteLine();
                    break;

                //dowhileは条件によらず少なくとも一回実行される。
                case 2:
                    Console.Write("値を入力:");
                    int valueD = int.Parse(Console.ReadLine());
                    do
                    {
                        Console.Write($"{valueD} ");
                        valueD--;
                    } while (valueD > 0);
                    Console.WriteLine();
                    break;

                case 3:
                    //乱数の初期設定
                    Random rand = new Random();
                    Console.WriteLine("ぞろ目が出たら終了");
                    while (true)
                    {
                        int dice1 = rand.Next(1, 7);
                        int dice2 = rand.Next(1, 7);
                        Console.WriteLine($"{dice1} {dice2}");

                        if (dice1 == dice2)
                        {
                            Console.WriteLine("終了");
                            break;
                        }
                    }
                    break;
            }
        }

        //スペースで文字列を分けて値に変換
        static int[] Split1(string text)
        {
            var words = text.Split(new string[] { " ", "　" }, StringSplitOptions.RemoveEmptyEntries);

            var SplitNum = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                SplitNum[i] = int.Parse(words[i]);
            }

            return SplitNum;

        }
    }
}