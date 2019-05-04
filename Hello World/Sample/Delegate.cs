using System;
namespace Delegate
{

    delegate void Operation(int a, int b);

    class Calc
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine($"{a}-{b}={a - b}");
        }

        public static void Add(int a, int b)
        {
            Console.WriteLine($"{a}+{b}={a + b}");
        }
    }

    class Program
    {
        delegate void Action(int a);

        static void Func1(int a)
        {
            Console.WriteLine($"a={a}");
        }

        static void Func2(int a)
        {
            Console.WriteLine($"a*a={a * a}");
        }

        static int Func3(int a)
        {
            if (a > 1)
            {
                return a * Func3(a - 1);
            }
            else
            {
                return 1;
            }
        }

        static void Func4(int a)
        {
            Console.WriteLine($"a!={Func3(a)}");
        }


        private void Mul(int a, int b)
        {
            Console.WriteLine($"{a}*{b}={a * b}");
        }

        public void main()
        {
            Console.WriteLine("1:Operation\n2:Action");
            int sw = int.Parse(Console.ReadLine());

            switch (sw)
            {
                case 1:
                    Calc c = new Calc();
                    //delegateを用いて、同じ引数を持つメソッドをOperation(o1~o3)として定義できる
                    //delegate "Operation" の設定
                    Operation o1 = new Operation(Mul);
                    Operation o2 = new Operation(Calc.Add);
                    Operation o3 = new Operation(c.Sub);

                    o1(2, 1);
                    o2(2, 1);
                    o3(2, 1);

                    break;

                //delegateを用いて、異なるメソッドを同じdelegateに定義し、連続して行わせることができる。
                case 2:
                    Action a = new Action(Func1);
                    a += new Action(Func2);
                    a += new Action(Func4);

                    a(3);
                    break;
            }
        }
    }
}