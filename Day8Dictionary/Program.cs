using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, string> bookDirectory = new Dictionary<string, string>();

            for (int i = 0; i < time; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                bookDirectory.Add(temp[0], temp[1]);

            }

            for (int i = 0; i < time; i++)
            {

                var s = Console.ReadLine();
                if (bookDirectory.ContainsKey(s))
                {
                    Console.WriteLine(s + "=" + bookDirectory[s]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

        }
    }
}
