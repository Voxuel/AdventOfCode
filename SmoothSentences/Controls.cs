using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace SmoothSentences
{
    class Controls
    {
        internal static int Controller(List<string> dir)
        {
            int val = 0;
            int depth = 0;
            int hori = 0;

            foreach (var item in dir)
            {
                if (item.Contains("up"))
                {
                    val = int.Parse(Regex.Match(item, @"\d+").Value);
                    depth -= val;
                }
                if (item.Contains("down"))
                {
                    val = int.Parse(Regex.Match(item, @"\d+").Value);
                    depth += val;
                }
                if (item.Contains("forward"))
                {
                    val = int.Parse(Regex.Match(item, @"\d+").Value);
                    hori += val;
                }
            }
            int sum = depth * hori;
            return sum;
        }
    }
}
