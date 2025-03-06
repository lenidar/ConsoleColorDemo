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
            int cnt = 0;

            // just for more color possiblities
            color[0] = ConsoleColor.Red;
            color[1] = ConsoleColor.Green;
            color[2] = ConsoleColor.Blue;
            color[3] = ConsoleColor.Magenta;
            color[4] = ConsoleColor.Cyan;
            color[5] = ConsoleColor.Yellow;
            color[6] = ConsoleColor.Gray;
            color[7] = ConsoleColor.White;

            // for loop that initializes a 100 number array
            // with random numbers from 1 - 100
            for (int x = 0; x < nums.Length;x++)
                nums[x] = rnd.Next(0, 100) + 1;

            // for loop that displays the array
            for (int x = 0; x < nums.Length; x++)
            {
                // a check that will color the foreground or background
                // depending on the x value of the loop. 
                // the color will also depend on the x value of the loop
                if (x % 2 == 0)
                    Console.ForegroundColor = color[x % 8];
                else
                    Console.BackgroundColor = color[x % 8];

                // this displays
                Console.Write($"{nums[x]}\t");
                cnt++;

                Console.ResetColor();

                // this will format the display ensuring that only 10 things
                // are displayed per row
                if (cnt % 10 == 0)
                    Console.WriteLine();
            }
        }
    }
}
