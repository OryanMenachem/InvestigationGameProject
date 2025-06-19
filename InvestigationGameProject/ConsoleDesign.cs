using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGameProject
{
    internal class ConsoleDesign
    {
        /// <summary>
        ///  Console.ReadLine().Trim() with sign '>'
        /// </summary>
        /// <returns></returns>
        public static string Input()
        {
            Console.Write("\n> ");

            string input = Console.ReadLine().Trim();

            Console.Clear();
            Console.WriteLine();

            return input;
        }

        public static void ErrorColor(string text, bool newLine = true)
        {
            if (newLine)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{text}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{text}");
                Console.ResetColor();
            }


        }

        public static void SuccessfullColor(string text, bool newLine = true)
        {
            if (newLine)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{text}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{text}");
                Console.ResetColor();

            }



        }

        public static void CyanColor(string text, bool newLine = true)
        {
            if (newLine)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{text} ");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{text} ");
                Console.ResetColor();

            }

        }

        public static void RedColor(string text, bool newLine = true)
        {
            if (newLine)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{text} ");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{text} ");
                Console.ResetColor();
            }

        }
    }
}
