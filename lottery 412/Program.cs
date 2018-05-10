using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            // 產生亂數
            Random rand = new Random();

            // 設定計數
            int n = 1;

            while (n <= 10)
            {
                // 產生6個random亂數

                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);
              
                Console.ForegroundColor = ConsoleColor.Yellow;

                // 用if判斷每個數字是否有重複

                if (r1 != r2 && r1 != r3 && r1 != r4 && r1 != r5 && r1 != r6 && r2 != r3 && r2 != r4 && r2 != r5 && r2 != r6 && r3 != r4 && r3 != r5 && r3 != r6 && r4 != r5 && r4 != r6 && r5 != r6)
                {
                    Console.WriteLine("第{0:00}組:  {1:00}  {2:00}  {3:00}  {4:00}  {5:00}  {6:00}", n, r1, r2, r3, r4, r5, r6);

                    n++;
                }             
            }

            Console.ReadLine();

        }
    }
}