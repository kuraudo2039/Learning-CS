using System;

namespace Conditions
{
    class Complex
    {
        public void main()
        {
            Console.Write("Fall Through?:");
            bool FT = bool.Parse(Console.ReadLine());

            Console.Write("さいころの目を入力:");
            int dice = int.Parse(Console.ReadLine());

            if (dice > 0 && dice <= 6)
            {
                if (!FT)
                {
                    //余りを条件として指定
                    if (dice % 2 == 0)
                    {
                        Console.WriteLine("丁（ﾁｮｳ）です");
                    }
                    else
                    {
                        Console.WriteLine("半（ﾊﾝ）です");
                    }
                }

                else
                {
                    //特定の値(文字)を条件として使用
                    //複数の値(文字)を使用したいときのみフォールスルーが許される。
                    switch (dice)
                    {
                        case 1:
                        case 3:
                        case 5:
                            Console.WriteLine("半（ﾊﾝ）です");
                            break;

                        case 2:
                        case 4:
                        case 6:
                            Console.WriteLine("丁（ﾁｮｳ）です");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("不適切な値です");
            }
        }
    }
}