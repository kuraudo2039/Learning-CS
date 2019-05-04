using System;
namespace Class
{
    class Sparrow : Bird
    {
        public Sparrow() : base("すずめ")
        {
        }

        public override void Sing()
        {
            Console.Write("チュンチュン");
        }
    }
}