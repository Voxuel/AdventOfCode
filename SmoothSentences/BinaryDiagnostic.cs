using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace SmoothSentences
{
    internal class BinaryDiagnostic
    {
        internal static void BinData()
        {
            var input = File.ReadAllLines("BinaryDiagnostic.txt");

            string[] gamma = new string[12];
            string[] epsilon = new string[12];

            for (int i = 0; i < input[0].Count(); i++)
            {
                gamma[i] = input.Where(x => x[i] == '1').Count() > (input.Count() / 2) ? "1" : "0";
            }
            for (int i = 0; i < input[0].Count(); i++)
            {
                epsilon[i] = input.Where(x => x[i] == '1').Count() < (input.Count() / 2) ? "1" : "0";
            }

            var gammaVal = ConvertToDecimal(string.Join("", gamma));
            var epsilonVal = ConvertToDecimal(string.Join("", epsilon));

            Console.WriteLine(gammaVal);
            Console.WriteLine(epsilonVal);
            double result = gammaVal * epsilonVal;
            Console.WriteLine(result);
        }
        private static double ConvertToDecimal(string bin)
        {
            var reversedBinary = bin.Reverse().ToArray();
            double amt = 0;

            for (int i = 0; i < reversedBinary.Count(); i++)
            {
                amt += reversedBinary[i].ToString() == "1" ? Math.Pow(2, i) : 0;
            }
            return amt;
        }

    }
}
