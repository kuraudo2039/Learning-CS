using System;
namespace Class
{
    class VectorNormal : VectorBase
    {
        private double x = 0.0, y = 0.0;
        private double r = 0.0, θr = 0.0, θ = 0.0;

        public override double X
        {
            set { x = value; }
            get { return x; }
        }

        public override double Y
        {
            set { y = value; }
            get { return y; }
        }

        public void Polar()
        {
            r = Math.Sqrt((x * x + y * y));
            θr = Math.Atan((x / y));
            θ = (180f / Math.PI) * θr;
            //{0:0000}や{0:D4}{0:F4}、{0:-4}/{0:4}などで0埋めや左/右詰めができる
            //補完文字列($)の場合は、{x:0000}や{x:D4}、{x,-4}/{x,4}、また、{x,-4:F3}で小数第三位まで指定などもできる
            Console.WriteLine($"({x},{y})は極座標で({r,-4:F3},{θr,-4:F3}({θ,-4:F3}°)です");
        }
    }
}