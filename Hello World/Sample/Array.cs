using System;

namespace Array
{
    class Program
    {
        public void main()
        {
            Console.Write("Dimension?:");
            int D = int.Parse(Console.ReadLine());
            switch (D)
            {
                //一次元配列で平均計算
                case 1:
                    const int N = 5;
                    double[] d = new double[N];
                    double sum = 0;

                    Console.WriteLine($"Please input value {N} times");

                    for (int i = 0; i < N; i++)
                    {
                        Console.Write($"{i + 1}：");
                        d[i] = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }

                    Console.WriteLine("All values");
                    for (int i = 0; i < N; i++)
                    {
                        Console.Write($"{d[i]} ");
                        sum += d[i];
                    }
                    Console.WriteLine();
                    Console.WriteLine($"SUM:{sum} AVE:{sum / N}");
                    break;

                //二次元配列で九九
                case 2:
                    Console.Write("jag?:");
                    bool J = bool.Parse(Console.ReadLine());

                    if (!J)
                    {
                        int[,] a = new int[9, 9];
                        int m, n;
                        int L = a.Length;
                        //二次元配列でのLength;：一番位の高い次元の大きさ

                        for (m = 0; m < L; m++)
                        {
                            for (n = 0; n < L; n++)
                            {
                                a[m, n] = (m + 1) * (n + 1);
                            }
                        }

                        for (m = 0; m < L; m++)
                        {
                            for (n = 0; n < L; n++)
                            {
                                Console.Write($"{a[m, n]}　");
                                if (a[m, n] < 10)
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    /*三次元、四次元も[,,]、[,,,]で表現できる。左から大きな箱にしまわれるイメージ[(三次元分を格納した箱),(二次元分を格納した箱),(一次元分を格納した箱),(値)] */

                    //jag(ギザギザ)配列：全て表示させたとき、長方形にはならず凸凹になる配列
                    else
                    {
                        int[][] a = new int[][] { new int[3], new int[5], new int[1], new int[4] };
                        int m, n;

                        Console.WriteLine("Input Values");

                        //GetLength(次元の値)：次元は左から0から数える{0,1,2,3}
                        Console.WriteLine($"行の数：{a.GetLength(0)} or {a.Length}");
                        for (m = 0; m < a.GetLength(0); m++)
                        {
                            //a[m].Length：aのm番目の行の長さ
                            for (n = 0; n < a[m].Length; n++)
                            {
                                Console.Write($"{m},{n}:");
                                a[m][n] = int.Parse(Console.ReadLine());
                            }
                        }

                        for (m = 0; m < a.GetLength(0); m++)
                        {
                            for (n = 0; n < a[m].Length; n++)
                            {
                                Console.Write($"{{{m},{n}}} = {a[m][n]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
            }
        }
    }
}