using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace SmoothSentences
{
    class Converters
    {
        internal static List<string> ConvertedToStringList(List<string> fullList)
        {
            var firstPartList = new List<string> { };
            foreach (var item in fullList)
            {
                var result = Regex.Match(item, @"^([\w\-]+)");
                firstPartList.Add(result.Value);
            }
            return firstPartList;
        }
        // Method for spliting List of strings to seperate string and int.
        internal static List<int> ConvertedToIntList(List<string> fullList)
        {
            List<int> nums = new List<int> { };
            int val = 0;
            foreach (var item in fullList)
            {
                item.Split(' ')
                .Select(i =>
                {
                    return int.TryParse(i, out val) ? (int?)val : null;
                })
                .Where(i => i.HasValue)
                .Cast<int>()
                .ToList();
                nums.Add(val);
            }
            return nums;
        }
    }
}
