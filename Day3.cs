using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Advent_Of_Code
{
    class Day3
    {
        static void Main(string[] args)
        {
            PartOne();
            PartTwo();
            Console.ReadKey();
        }

        static void PartOne()
        {
            string text = File.ReadAllText("input.txt");

            List<Coordinate> storage = new List<Coordinate>();
            int x = 0;
            int y = 0;
            storage.Add(new Coordinate
            {
                X = x,
                Y = y
            });

            foreach (char c in text)
            {
                if (c == '^')
                    y++;
                else if (c == 'v')
                    y--;
                else if (c == '<')
                    x--;
                else if (c == '>')
                    x++;


                storage.Add(new Coordinate
                {
                    X = x,
                    Y = y
                });

            }

            var uniqueItems = from s in storage
                              group s by new
                              {
                                  s.X,
                                  s.Y,
                              } into unique
                              select new Coordinate()
                              {
                                  X = unique.Key.X,
                                  Y = unique.Key.Y,
                              };

            List<Coordinate> newList = uniqueItems.ToList();
            Console.WriteLine(newList.Count);

        }



        static void PartTwo()
        {
            string text = File.ReadAllText("input.txt");

            List<Coordinate> storage = new List<Coordinate>();
            int x = 0;
            int y = 0;
            int a = 0;
            int b = 0;
            storage.Add(new Coordinate
            {
                X = x,
                Y = y
            });

            storage.Add(new Coordinate
            {
                X = a,
                Y = b
            });

            bool turn = false;
            foreach (char c in text)
            {
                if (turn == false)
                {
                    if (c == '^')
                        y++;
                    else if (c == 'v')
                        y--;
                    else if (c == '<')
                        x--;
                    else if (c == '>')
                        x++;
                    turn = true;

                    storage.Add(new Coordinate
                    {
                        X = x,
                        Y = y
                    });
                }
                else
                {
                    if (c == '^')
                        b++;
                    else if (c == 'v')
                        b--;
                    else if (c == '<')
                        a--;
                    else if (c == '>')
                        a++;
                    turn = false;
                    storage.Add(new Coordinate
                    {
                        X = a,
                        Y = b
                    });
                }
            }

            var uniqueItems = from s in storage
                              group s by new
                              {
                                  s.X,
                                  s.Y,
                              } into unique
                              select new Coordinate()
                              {
                                  X = unique.Key.X,
                                  Y = unique.Key.Y,
                              };

            List<Coordinate> newList = uniqueItems.ToList();
            Console.WriteLine(newList.Count);
        }
    }

    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
