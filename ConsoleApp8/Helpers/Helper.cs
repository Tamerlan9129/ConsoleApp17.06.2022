using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Helpers
{
    class Helper
    {
        public static void Printer(string text, ConsoleColor color) 
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        
        }
        public static void ErrorAndSucces(string text, ConsoleColor color) 
        {
            Console.ForegroundColor = color;
            foreach (char item in text)
            {
                Console.Write(item);
                System.Threading.Thread.Sleep(35);
            }
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.ResetColor();
            
        }
    }
}
