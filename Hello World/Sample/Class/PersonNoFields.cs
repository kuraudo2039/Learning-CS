using System;
namespace Class
{
    class PersonNoFields
    {
        public void SetInformation(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"名前：{Name} 年齢：{Age}");
        }

        //set/getにprivateをつけることで、他クラスからのアクセスができなくなる
        public string Name
        {
            private set; get;
        }

        public int Age
        {
            set; get;
        }
    }
}