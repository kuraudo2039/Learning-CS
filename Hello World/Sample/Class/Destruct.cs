using System;
namespace Class
{
    class Destruct
    {
        public Destruct()
        {
            Console.WriteLine("コンストラクタ");
        }

        ~Destruct()
        {
            Console.WriteLine("デストラクタ");
        }
    }
}