using System;
using System.IO;

namespace Advent_of_code
{
    class Day1
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"input.txt"))
                {
                    String line = sr.ReadToEnd();

                    PartOne(line);
                    PartTwo(line);
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        //Part One
        static void PartOne(String line)
        {
            int number = 0;
            foreach (char c in line)
            {
                if (c == '(')
                    number++;
                else
                    number--;
            }
            Console.WriteLine(number);
        }

        //Part Two
        static void PartTwo(String line)
        {
            int number = 0;
            int counter = 0;
            foreach (char c in line)
            {
                counter++;
                if (c == '(')
                    number++;
                else
                    number--;

                if (number == -1)
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
