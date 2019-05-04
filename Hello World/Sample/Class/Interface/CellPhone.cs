using System;
namespace Class
{
    //インタフェースはクラスに組み込むことで、プログラム内でその機能を限定しながらクラスを使うことができる
    class CellPhone : IPhone, IEmail
    {
        private string mailAddress;
        private string number;

        //コンストラクタ電話番号とメールアドレスを指定
        public CellPhone(string mailAddress, string number)
        {
            this.mailAddress = mailAddress;
            this.number = number;
        }

        public void Call(string number)
        {
            Console.WriteLine($"{number} に、 {this.number} から電話をかけます");
        }

        public void SendMail(string address)
        {
            Console.WriteLine($"{address}に、{this.mailAddress}からメールを送ります。");
        }
    }
}