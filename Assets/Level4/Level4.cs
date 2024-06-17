// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using UnityEngine;
//
// //問題
// //判定対象の円 座標(80,310) にある 半径100の円に対して、
// //dataのそれぞれの円が衝突しているかどうかを、TrueまたはFalseで出力してください
// class Program
// {
//     class CircleData
//     {
//         public float X;
//         public float Y;
//         public float Radius;
//     }
//
//     static void Main()
//     {
//         //円1の情報
//         CircleData[] data = new CircleData[]
//         {
//             new CircleData() { X = 100.0f, Y = 100.0f, Radius = 50.0f },
//             new CircleData() { X = 300.0f, Y = 250.0f, Radius = 150.0f },
//             new CircleData() { X = 250.0f, Y = 100.0f, Radius = 50.0f },
//             new CircleData() { X = 400.0f, Y = 50.0f, Radius = 150.0f },
//             new CircleData() { X = 50.0f, Y = 100.0f, Radius = 250.0f },
//             new CircleData() { X = 150.0f, Y = 200.0f, Radius = 150.0f },
//             new CircleData() { X = 300.0f, Y = 300.0f, Radius = 50.0f },
//             new CircleData() { X = 400.0f, Y = 200.0f, Radius = 150.0f },
//             new CircleData() { X = 100.0f, Y = 100.0f, Radius = 350.0f }
//         };
//
//         //円2の情報
//         float x = 80.0f;
//         float y = 310.0f;
//         float r = 100.0f;
//
//         for (int i = 0; i < data.Length; ++i)
//         {
//             //円1の情報を受け取る
//             float targetX = data[i].X;
//             float targetY = data[i].Y;
//             float targetRadius = data[i].Radius;
//
//             //TODO: ここから円判定処理を書く
//             var hitX = targetX - x;
//             var hitY = targetY - y;
//             
//             var hitSqrt = hitX * hitX + hitY * hitY;
//
//             var hitRadius = targetRadius + r;
//             
//             var isHit = hitSqrt <= hitRadius * hitRadius;
//
//             //判定処理ここまで
//             Console.WriteLine(isHit);
//         }
//     }
// }


using System;

class Program
{
    static void Main()
    {
        for (var i = 1; i <= 100; ++i)
        {
            Console.WriteLine(i % 10 == 3 || i % 3 == 0 ? "hoge" : i);
        }
    }
}