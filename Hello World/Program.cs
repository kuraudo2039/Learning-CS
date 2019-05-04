using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        //staticフィールド
        private static int snum = 100;

        //インスタンスフィールド
        private int inum = 200;

        //staticメソッド
        public static void foo()
        {
            Console.WriteLine("foo(static)メソッド");
        }

        public void bar()
        {
            Console.WriteLine("(instans名).bar(インスタンス)メソッド");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1:Hello_World\n2:Calculation\n3:ReadLine\n4:Condition\n5:Repetition\n6:Array\n7:Class\n8:GarbageCorrection\n9:Static/Instans\n10:Collection\n11:Delegate\n12:Exception");
            Console.Write("呼び出すネームスペースの選択：");

            int select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case 1:
                    //ネームスペースHello_Worldメインプログラム呼び出し
                    Hello_World.Program c1 = new Hello_World.Program();
                    c1.main();
                    break;

                case 2:
                    //ネームスペースCalculationメインプログラム呼び出し
                    Calculation.Program c2 = new Calculation.Program();
                    c2.main();
                    break;

                case 3:
                    //ネームスペースReadLineメインプログラム呼び出し
                    ReadLine.Program c3 = new ReadLine.Program();
                    c3.main();
                    break;

                case 4:
                    //ネームスペースConditionsメインプログラム呼び出し
                    Console.Write("Complex?:");
                    bool con = bool.Parse(Console.ReadLine());

                    if (!con)
                    {
                        Conditions.Program c4 = new Conditions.Program();
                        c4.main();
                    }
                    else
                    {
                        //Complexクラスプログラム呼び出し
                        Conditions.Complex c4_1 = new Conditions.Complex();
                        c4_1.main();
                    }
                    break;

                case 5:
                    //ネームスペースRepetitionメインプログラむ呼び出し
                    Repetition.Program c5 = new Repetition.Program();
                    c5.main();
                    break;

                case 6:
                    //ネームスペースArrayメインプログラム呼び出し
                    Array.Program c6 = new Array.Program();
                    c6.main();
                    break;

                case 7:
                    //ネームスペースClassメインプログラム呼び出し
                    Class.Program c7 = new Class.Program();
                    c7.main();
                    break;

                case 8:
                    //ネームスペースGabegeCorrectionメインプログラム呼び出し
                    GarbageCorrection.Program c8 = new GarbageCorrection.Program();
                    c8.main();
                    c8 = null;
                    GC.Collect();
                    break;

                case 9:
                    //このクラス(Program)のstatic/インスタンスのフィールド/メソッドの呼び出し
                    //このクラス(Program)のインスタンス生成
                    Program p = new Program();
                    Console.WriteLine($"pのインスタンスフィールド：p.inum = {p.inum}");
                    Console.WriteLine($"Programのクラスフィールド：snum = {snum}");

                    Console.Write("p.inum：");
                    p.inum = int.Parse(Console.ReadLine());
                    Console.Write("snum：");
                    snum = int.Parse(Console.ReadLine());

                    Console.WriteLine($"pのインスタンスフィールド：p.inum = {p.inum}");
                    Console.WriteLine($"Programのクラスフィールド：snum = {snum}");
                    foo();
                    p.bar();
                    break;

                case 10:
                    Collection.Program LP = new Collection.Program();
                    LP.main();
                    break;

                case 11:
                    Delegate.Program DP = new Delegate.Program();
                    DP.main();
                    break;
                case 12:
                    Exception.Program.main();
                    break;
            }
        }
    }
}