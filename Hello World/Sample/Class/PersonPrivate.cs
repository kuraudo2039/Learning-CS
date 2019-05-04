using System;
namespace Class
{
    class PersonPrivate
    {
        private string name = "";
        private int age = 0;

        public void SetInformation(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"名前：{name} 年齢：{age}");
        }

        //情報の設定
        //string型のNameという名前のプロパティを定義
        public string Name
        {
            //set：このクラスのNameにアクセスし、代入した時の処理
            //value：外部から与えられた値
            set { name = value; }

            //get:このクラスのNameにアクセスし、中身の表示をした時の処理
            get { return name; }
        }

        //情報の設定
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        //書き込みまたは読み込みのみの機能を付けたプロパティも定義可能
    }
}