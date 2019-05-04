using System;
namespace Class
{
    class Static
    {
        //Dataオブジェクトの数
        private static int num = 0;

        //データの値
        private int id;

        //コンストラクタ
        public Static(int id)
        {
            this.id = id;
            num++;
            Console.WriteLine($"オブジェクトの数：{num} データの値：{this.id}");
        }

        //静的メソッドでオブジェクトの数を取得
        public static void ShowNumber()
        {
            Console.WriteLine($"オブジェクトの数：{num}");
        }

    }
}