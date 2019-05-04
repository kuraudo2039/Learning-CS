using System;

namespace Class
{
    class Person
    {
        //　名前（フィールド）
        public string name = "";

        //　年齢（フィールド）
        public int age = 0;

        //情報の表示（メソッド）
        public void ShowInformation()
        {
            Console.WriteLine($"名前：{name} 年齢：{age}");
        }

        //情報の設定（メソッド)
        public void SetInformation(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //入力情報の設定（メソッド）
        public void SetInformation2()
        {
            Console.WriteLine("Please Input Information as {name_age}");
            string text = Console.ReadLine();
            if (text != "")
            {
                var words = text.Split(new string[] { " ", "　" }, StringSplitOptions.RemoveEmptyEntries);
                this.name = words[0];
                this.age = int.Parse(words[1]);
            }
        }
    }
}