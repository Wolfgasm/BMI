using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 樂透
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int j = 9;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("還剩下" + j + "次");
                Console.WriteLine("請按Enter開下一次獎");

                int ran1 = r.Next(1, 49);
                int ran2 = r.Next(1, 49);
                int ran3 = r.Next(1, 49);
                int ran4 = r.Next(1, 49);
                int ran5 = r.Next(1, 49);
                int ran6 = r.Next(1, 49);

                Console.WriteLine("┌──── 大樂透開獎時間────┐");
                Console.WriteLine("│                       │");
                Console.WriteLine("│                       │");
                Console.WriteLine("│    {0:00} {1:00} {2:00} {3:00} {4:00} {5:00}  │", ran1, ran2, ran3, ran4, ran5, ran6);
                Console.WriteLine("│                       │");
                Console.WriteLine("│                       │");
                Console.WriteLine("└───────────────────────┘");
                Console.ReadLine();
                j = j - 1;
                Console.Clear();
            }
        }
    }
}