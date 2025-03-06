using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleColorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100];
            Random rnd = new Random();
            ConsoleColor[] color = new ConsoleColor[8];

            color[0] = ConsoleColor.Red;
            color[1] = ConsoleColor.Green;
            color[2] = ConsoleColor.Blue;
            color[3] = ConsoleColor.Magenta;
            color[4] = ConsoleColor.Cyan;
            color[5] = ConsoleColor.Yellow;
            color[6] = ConsoleColor.Gray;
            color[7] = ConsoleColor.White;
            int cnt = 0;

            for (int x = 0; x < nums.Length;x++)
                nums[x] = rnd.Next(0, 100) + 1;

            for (int x = 0; x < nums.Length; x++)
            {
                if (x % 2 == 0)
                    Console.ForegroundColor = color[x % 8];
                else
                    Console.BackgroundColor = color[x % 8];

                Console.Write($"{nums[x]}\t");
                cnt++;

                Console.ResetColor();

                if (cnt % 10 == 0)
                    Console.WriteLine();
            }
        }
    }
}
