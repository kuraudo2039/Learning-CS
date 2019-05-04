using System;

namespace Hello_World
{
    class Program
    {
        public void main()
        {
            //MyClassクラスをc1に生成
            MyClass c1 = new MyClass();

            //c1(Myclass)にある関数ReturnMessage(引数無し)の呼び出し
            //$(文字列補完)は、WriteLineの｛｝の中に直接変数を置いて呼び出せる。
            //Console.WriteLine($"Hello World! {c1.ReturnMessage()}");

            //$がない場合
            Console.WriteLine("Hello World! {0}", c1.ReturnMessage());
        }
    }
}