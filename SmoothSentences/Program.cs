﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;


// Program for adventofCode.com

namespace SmoothSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> positions = new List<string> { };
            foreach (string line in System.IO.File.ReadLines("Positions.txt"))
            {
                positions.Add(line);
            }
            var pos = positions.Select(int.Parse).ToList();
            int x = CalcNumberOfIncreases(pos);
            Console.WriteLine(x);
            int threeWindowMeasurment = ThreeMeasurementWindows(pos);
            Console.WriteLine(threeWindowMeasurment);

        }
        private static int CalcNumberOfIncreases(List<int> input)
        {
            int count = 0;
            int i = 1;
            while(i < input.Count())
            {
                if (input[i] > input[i - 1]) count++;
                i++;
            }
            return count;
        }
        private static int ThreeMeasurementWindows(List<int> input)
        {
            int count = 0;
            for (int i = 3; i < input.Count; i++)
            {
                int first = input[i - 1];
                int second = input[i - 2];
                int third = input[i - 3];
                int current = first + second + third;
                int _first = input[i];
                int _second = input[i - 1];
                int _third = input[i - 2];
                int next = _first + _second + _third;
                if (next > current) count++;
            }
            return count;
        }
    }
}
