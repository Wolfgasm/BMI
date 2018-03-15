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
            
            Console.Write("請輸入您的身高(公分)");
            float height = float.Parse(Console.ReadLine())/100;
            Console.Write("請輸入您的體重(公斤)");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("您的BMI為"+weight/Math.Pow(height,2));

            Console.ReadLine();
        }
    }
}
