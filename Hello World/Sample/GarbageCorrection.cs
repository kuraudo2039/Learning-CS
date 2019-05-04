using System;
namespace GarbageCorrection
{
    class Program
    {
        public void main()
        {
            string[] a = new string[10000];
            for (int i = 0; i < 10000; i++)
            {
                a[i] = new string('M', 10000);
            }
            Console.WriteLine("メモリ使用量（GC発動前）：" + GC.GetTotalMemory(false));//trueならGC後のメモリ使用量
            //使っていた配列の参照を解除
            a = null;
            Console.WriteLine("メモリ使用量（参照解除後）；" + GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("メモリ使用量（GC発動後）；" + GC.GetTotalMemory(false));


        }
    }
}