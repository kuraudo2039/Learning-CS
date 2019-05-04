using System;
namespace Class
{
    class PersonConstruct
    {
        private string name = "";

        private int age = 0;

        //クラスと同じ名前のメソッドは、インスタンスが生成されるときの引数を用いて、初めに一度だけ実行される
        //引数無しコンストラクタ
        public PersonConstruct() : this("名無し", 0)
        {
            Console.WriteLine($"引数無しコンストラクタ name:{name} age:{age}");
        }
        public PersonConstruct(string name, int age)
        {
            this.name = name;
            this.age = age;
            if (name != "名無し" && age != 0)
            {
                Console.WriteLine($"引数ありコンストラクタ name:{name} age:{age}");
            }
        }

        public void ShowInformation()
        {
            Console.WriteLine($"名前：{name} 年齢:{age}");
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}