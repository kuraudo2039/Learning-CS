using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        public void main()
        {
            Console.WriteLine("1:List\n2:Dictionary\n3:HashSet");
            int sw = int.Parse(Console.ReadLine());

            switch (sw)
            {
                case 1:
                    List<string> a = new List<string>();
                    a.Add("真");
                    a.Add("間");
                    a.Add("魔");
                    list(a);

                    //1番目に摩を挿入
                    a.Insert(1, "摩");
                    list(a);

                    a.RemoveAt(1);
                    a.Remove("真");
                    list(a);
                    /*
                        Reverse()	全体の要素の順序を反転させます。
                        Find()	指定されたデータを探し、最も小さいインデックスを返します。
                        Exists()	指定されたデータと同じものが存在するかどうかを調べます。
                        Clear()	全てのデータを削除します。
                        Sort()	オブジェクトを並べ替えます。             */

                    break;

                case 2:
                    //ハッシュテーブルをDictionaryで作成。ハッシュで中身を関連付ける
                    //配列の様に順番ごとになっているわけではないため、foreachとcapital.Keysを用いて中身を表示する必要がある
                    Dictionary<string, string> capital = new Dictionary<string, string>();
                    capital["日本"] = "東京";
                    capital["イギリス"] = "ロンドン";
                    capital["フランス"] = "パリ";
                    capital["中国"] = "北京";
                    Console.WriteLine("世界の首都");
                    foreach (string s in capital.Keys)
                    {
                        Console.WriteLine($"{s}の首都は{capital[s]}です。");
                    }
                    break;

                case 3:
                    //HachSetを用いるとデータを重複なく管理することができる
                    HashSet<int> t = new HashSet<int>();
                    for (int i = 0; i < 3; i++)
                    {
                        t.Add(i);
                    }
                    foreach (int num in t)
                    {
                        Console.WriteLine($"{num}");
                    }

                    t.Add(1);
                    foreach (int num in t)
                    {
                        Console.WriteLine($"{num}");
                    }

                    break;
            }
        }

        public void list(List<string> wholeText)
        {
            int count = 0;
            foreach (string text in wholeText)
            {
                count++;
                Console.WriteLine($"{count}：{text}");
            }
            count = 0;
        }
    }
}