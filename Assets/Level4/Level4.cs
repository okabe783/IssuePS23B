using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        for (var i = 1; i <= 100; ++i)
        {
            //判定処理をここに書いてください
            var n = i.ToString();

            if (n.Contains("3"))
            {
                Console.WriteLine("hoge");
            }

            Console.WriteLine(i);
            //コメントもあわせて書いてください
            //出力はConsole.WriteLine(i);やConsole.WriteLine("hoge");などと書く
        }
    }
}