using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"input.txt"))
                {
                    String line = sr.ReadToEnd();
                    int number = 0;
                    int counter = 0;
                    foreach(char c in line)
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
                    Console.WriteLine(number);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
