// See https://aka.ms/new-console-template for more information
Console.WriteLine($"{GetCountDistinctSubstrings("aabab",3)}");
Console.WriteLine($"{GetCountDistinctSubstrings("abcc", 2)}");




static int GetCountDistinctSubstrings(string inputString, int k)
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
                if(!HasRepeatingCharacters(substring))
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


