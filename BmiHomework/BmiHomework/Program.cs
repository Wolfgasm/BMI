using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // 請使用者輸入身高並且自動轉換為公尺單位
            Console.Write("請輸入您的身高(公分)");
            float height = float.Parse(Console.ReadLine()) / 100;
            // 請使用者輸入體重
            Console.Write("請輸入您的體重(公斤)");
            float weight = float.Parse(Console.ReadLine());

            // 計算BMI及顯示結果
            Console.Write("您的BMI為" + weight / Math.Pow(height, 2));

            // 暫停畫面用
            Console.ReadLine();
        }
    }
}
