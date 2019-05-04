using System;

namespace ReadLine
{
    class Program
    {
        public void main()
        {
            string str1, str2;
            Console.Write("str1=");
            str1 = Console.ReadLine();
            Console.Write("str2=");
            str2 = Console.ReadLine();
            Console.WriteLine($"str1 + str2 = {str1 + str2}");
        }
    }
}