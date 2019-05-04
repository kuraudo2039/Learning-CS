using System;
namespace Class
{
    abstract class Bird
    {
        //名前フィールド
        private string name;
        //引数付きコンストラクタ
        public Bird(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        //サブクラスがオーバーライドするための箱（抽象メソッド）
        public abstract void Sing();
    }
}