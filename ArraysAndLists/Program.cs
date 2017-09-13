using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // It's easy to understand what kind of information you are 
            // looking at because an int is an int, a string is a string, ect ect
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //numbers[5] = 42;

            Console.WriteLine(numbers.Length);

            /* .
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
            
            string[] names = new string[] { "Eddie", "Alex", "Micheal", "David Lee" };

            foreach (string name in names) //Much easier than looping through the array with Array.length();
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            
            string zig = "You can get what you want out of life " + 
                "if you help enough other people get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach(char zigChar in charArray)
                Console.Write(zigChar);
            */

            Console.ReadLine();

        }
    }
}
