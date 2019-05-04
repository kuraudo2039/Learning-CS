using System;
namespace Class
{
    class Split
    {
        //string型を入力し、int[]型を戻す
        public int[] main(string text)
        {
            var words = text.Split(new string[] { " ", "　" }, StringSplitOptions.RemoveEmptyEntries);
            int[] figures = new int[words.Length];
            for (int i = 0; i < figures.Length; i++)
            {
                figures[i] = int.Parse(words[i]);
            }
            return figures;
        }
    }
}