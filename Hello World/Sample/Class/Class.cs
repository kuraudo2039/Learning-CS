using System;

namespace Class
{
    class Program
    {
        public void main()
        {
            Console.Write("OverLoad?:");
            bool OL = bool.Parse(Console.ReadLine());

            if (!OL)
            {
                Console.WriteLine("Normal:1\nPrivate:2\nNoField:3\nConstruct:4\nDestruct:5\nStatic:6\nInheritance:7\nAbstruct:8\nInterface:9");
                int sw = int.Parse(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        Person p1, p2, p3;
                        p1 = new Person();
                        p2 = new Person();
                        p3 = new Person();

                        p1.name = "モリモリ武蔵";
                        p1.age = 353;

                        p2.SetInformation("コリコリ羽子田", 13);

                        p3.SetInformation2();

                        p1.ShowInformation();
                        p2.ShowInformation();
                        p3.ShowInformation();
                        break;

                    case 2:
                        PersonPrivate pp1, pp2;
                        pp1 = new PersonPrivate();
                        pp2 = new PersonPrivate();

                        pp1.SetInformation("室町幕府", 1699);

                        Console.WriteLine("Please Input 2 times that{Name → Age}");
                        pp2.Name = Console.ReadLine();
                        pp2.Age = int.Parse(Console.ReadLine());

                        pp1.ShowInformation();
                        Console.WriteLine($"名前：{pp2.Name} 年齢：{pp2.Age}");
                        break;

                    case 3:
                        PersonNoFields pn;
                        pn = new PersonNoFields();

                        pn.SetInformation("轟京子", 15);
                        pn.ShowInformation();

                        Console.Write($"Please True Age:");
                        pn.Age = int.Parse(Console.ReadLine());
                        //Nameへの代入はできない

                        pn.ShowInformation();

                        break;

                    case 4:
                        PersonConstruct pc1, pc2;
                        pc1 = new PersonConstruct();
                        pc2 = new PersonConstruct("よろしくお願いしまｽｴｿﾞｰ", 21);

                        Console.Write("名前：");
                        pc1.Name = Console.ReadLine();
                        Console.Write("年齢：");
                        pc1.Age = int.Parse(Console.ReadLine());

                        Console.WriteLine($"名前：{pc1.Name} 年齢：{pc1.Age}");
                        pc2.ShowInformation();
                        break;

                    case 5:
                        Destruct d = new Destruct();
                        Console.ReadLine();
                        break;

                    case 6:
                        //Staticクラス(インスタンスを入れる箱)を5つ作る
                        Static[] S = new Static[5];
                        //Staticのインスタンスの数を表示
                        Static.ShowNumber();
                        //Staticクラスのインスタンスを生成
                        for (int i = 0; i < S.Length; i++)
                        {
                            //Dataのインスタンスを生成
                            S[i] = new Static(i * 64);
                            //Dataのインスタンスの数を表示
                            Static.ShowNumber();
                        }

                        break;

                    case 7:
                        Console.Write("計算する数を入力してください：");
                        int count = int.Parse(Console.ReadLine());
                        //親クラスCalculatorのインスタンスを生成
                        Calculator C = new Calculator(count);
                        //親クラスの足し算の合計を表示
                        C.sum();

                        //継承クラスExCalculatorのインスタンスを生成
                        ExCalculator EC = new ExCalculator(count);
                        //継承クラスの掛け算の合計を表示
                        EC.mul();

                        Console.WriteLine("階乗を計算する値を入力してください");
                        EC.SetInformation(1);
                        //継承クラスの階乗を表示
                        EC.mul();

                        break;

                    case 8:
                        //抽象クラスはインスタンスを生成できない→サブクラスのインスタンスを生成する
                        //抽象クラスを配列に複製することは出来る
                        Bird[] b = new Bird[2];
                        b[0] = new Crow();
                        b[1] = new Sparrow();
                        for (int i = 0; i < b.Length; i++)
                        {
                            Console.Write($"{b[i].Name}「");
                            b[i].Sing();
                            Console.WriteLine("」");
                        }

                        //抽象クラスには抽象メソッドだけでなく抽象プロパティも設定できる
                        VectorNormal VN = new VectorNormal();
                        Console.WriteLine("x,y 座標を入力してください");
                        Console.Write("X:");
                        VN.X = double.Parse(Console.ReadLine());
                        Console.Write("Y:");
                        VN.Y = double.Parse(Console.ReadLine());
                        Console.WriteLine($"座標({VN.X},{VN.Y})が入力されました");
                        VN.Polar();
                        break;

                    case 9:
                        CellPhone CP = new CellPhone("test@email.com", "012-3456-7890");
                        //CellPhoneクラスから直接メソッドを使用
                        CP.Call("098-7654-3210");
                        CP.SendMail("send@email.com");

                        //CellPhoneインスタンスを各インタフェース変数にキャスト
                        //→インタフェースの機能のみ使用できるように制限できる
                        IEmail mail = (IEmail)CP;
                        IPhone phone = (IPhone)CP;

                        //mailインタフェースでCellPhoneインスタンスにアクセス
                        mail.SendMail("wao@email.com");
                        //phoneインタフェースでCellPhoneインスタンスにアクセス
                        phone.Call("019-2938-4756");

                        break;
                }
            }
            else
            {
                Calc calc = new Calc();
                Split split = new Split();
                int[] num = new int[3];

                Console.WriteLine($"Input {num.Length} values ad {{a_b_c}}");
                num = split.main(Console.ReadLine());

                int a = num[0], b = num[1], c = num[2];
                int ans1 = calc.ave(a, b);
                int ans2 = calc.ave(a, b, c);
                double ans3 = calc.ave((double)a, (double)b, (double)c);

                Console.WriteLine($"(a+b)/2 = {ans1}");
                Console.WriteLine($"(a+b+c)/3 = {ans2}");
                Console.WriteLine($"(double) (a+b+c)/3 = {ans3}");
            }
        }
    }
}