using System;
namespace Class
{
    class Crow : Bird
    {
        public Crow() : base("カラス") { }

        public override void Sing()
        {
            Console.Write("カーカー");
        }
    }
}