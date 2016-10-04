using System;
using System.IO;

namespace Advent_of_code
{
    class Day2
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(PartOne());

            Console.WriteLine(PartTwo());

            Console.ReadKey();

        }

        //Part One
        static int PartOne()
        {
            StreamReader file = new StreamReader("input.txt");
            int totalPaper = 0;
            string line;
            while((line = file.ReadLine()) != null)
            {
                string[] size = line.Split('x');
                totalPaper = totalPaper + Calculator(Int32.Parse(size[0]), Int32.Parse(size[1]), Int32.Parse(size[2])); 
            }
            return totalPaper;

        }

        static int Calculator(int l,int w, int h)
        {
            int slack = 0;

            int bigNumber = Math.Max(Math.Max(l, w), h);
            if (bigNumber == l)
                slack = w * h;
            else if (bigNumber == w)
                slack = l * h;
            else
                slack = l * w;

            int total = (2 * l * w) + (2 * w * h) + (2 * h * l) + slack;
            return total;
        }

        //Part Two
        static int PartTwo()
        {
            StreamReader file = new StreamReader("input.txt");
            int totalRibbon = 0;
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] size = line.Split('x');
                totalRibbon = totalRibbon + CalculatorTwo(Int32.Parse(size[0]), Int32.Parse(size[1]), Int32.Parse(size[2]));
            }
            return totalRibbon;
        }

        static int CalculatorTwo(int l, int w, int h)
        {
            int ribbon = 0;
            int bigNumber = Math.Max(Math.Max(l, w), h);
            if (bigNumber == l)
                ribbon = w + w + h + h;
            else if (bigNumber == w)
                ribbon = l + l + h + h;
            else
                ribbon = l + l + w + w;

            int total = (l * w * h) + ribbon;
            return total;
        }
    }
}
