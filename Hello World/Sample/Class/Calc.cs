using System;
namespace Class
{
    class Calc
    {
        //オーバーロード：メソッドの名前が同じでも、引数と戻り値の型が異なっていれば定義できる。
        public int ave(int a, int b)
        {
            return (a + b) / 2;
        }

        public int ave(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }

        public double ave(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
    }
}