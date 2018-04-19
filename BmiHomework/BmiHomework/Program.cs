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
            string[] state = new string[] {"過輕", "正常", "過重", "輕度肥胖", "中度肥胖", "跟你媽一樣胖" };
            int n = 0;

            string ifSoldier = "";
            

            // 請使用者輸入身高並且自動轉換為公尺單位
            Console.Write("請輸入您的身高(公分)");
            float height = float.Parse(Console.ReadLine()) / 100;

            // 請使用者輸入體重
            Console.Write("請輸入您的體重(公斤)");
            float weight = float.Parse(Console.ReadLine());

            // 計算BMI
            double bmi_ = weight / Math.Pow(height, 2);

            //判斷過輕過重
            if (bmi_ < 18.5)
                n = 0;
            else if (bmi_ >= 18.5 && bmi_ < 24)
                n = 1;
            else if (bmi_ >= 24 && bmi_ < 27)
                n = 2;
            else if (bmi_ >= 27 && bmi_ < 30)
                n = 3;
            else if (bmi_ >= 30 && bmi_ < 35)
                n = 4;
            else
                n = 5;

            //判斷是否需當兵

            if (bmi_ > 31.5 || bmi_ < 16.5)
                ifSoldier = "您不須當兵";
            else if ((bmi_ >= 16.5 && bmi_ < 17) || (bmi_ > 31 && bmi_ <= 31.5))
                ifSoldier = "您須服替代役";
            else
                ifSoldier = "您需常備兵役";



            // 計算BMI及顯示結果
            Console.Write("您的BMI為" + bmi_+"_屬於:"+state[n]+"，"+ifSoldier);

            // 暫停畫面用
            Console.ReadLine();
        }
    }
}
