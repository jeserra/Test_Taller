using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KStringLibrary;

public static class KStringClass
{


    public  static int GetCountDistinctSubstrings(string inputString, int k)
    {
        List<string> distinctSubstrings = new List<string>();

        // Check for invalid input
        if (k <= 0 || k > inputString.Length)
        {
            return distinctSubstrings.Count;
        }

        for (int i = 0; i <= inputString.Length - k; i++)
        {
            string substring = inputString.Substring(i, k);
            if (!distinctSubstrings.Contains(substring))
            {
                if (!HasRepeatingCharacters(substring))
                    distinctSubstrings.Add(substring);
            }
        }

        return distinctSubstrings.Count;
    }

    static bool HasRepeatingCharacters(string inputString)
    {
        // Use LINQ to group characters and count occurrences
        var characterCounts = inputString.GroupBy(c => c).Select(group => new { Char = group.Key, Count = group.Count() });

        // Check if any character occurs more than once
        return characterCounts.Any(item => item.Count > 1);
    }



}
