using System;
using System.Collections.Generic;


namespace _157
{
    class Program
    {
        public static string returnLongestPalindrom(string input)
        {
            var palindrome = "no Palindrome Present";
            var letterOccuranceCountStore = new Dictionary<char, int>();

            var runTracker = new Dictionary<int, int>();
            var lastLetterWasdouble = false;
            var runCount = 0;

            for (var letter = 0; letter < input.Length; letter++)
            {
                try
                {
                    letterOccuranceCountStore[input[letter]]++;
                    runCount++;
                    lastLetterWasdouble = true;
                    if(letterOccuranceCountStore[input[letter]] > 2) runCount--;
                    if (letter == input.Length - 1)
                    {
                        runTracker.Add(runCount, letter);
                    }
                }
                catch
                {
                    letterOccuranceCountStore.Add(input[letter], 1);
                    if (lastLetterWasdouble == true)
                    {
                        if(!runTracker.ContainsKey(runCount))runTracker.Add(runCount, letter);
                        runCount = 0;
                        lastLetterWasdouble = false;
                    }
                }
            }

            if (runTracker.Count > 0)
            {
                var biggestPalindrome = (0, 0);
                foreach (var item in runTracker)
                {
                    if (item.Key > biggestPalindrome.Item1)
                    {
                        biggestPalindrome = (item.Key, item.Value);
                    }
                };

                var startingIndex = (biggestPalindrome.Item2 + 1) - (biggestPalindrome.Item1 * 2 + 1);
                var endingIndex = biggestPalindrome.Item2 - startingIndex + 1;
                palindrome = input.Substring(startingIndex, endingIndex);
            }

            return palindrome;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($" The Palindrome in racecar is : {Program.returnLongestPalindrom("racecar")}");
            Console.WriteLine($"  The Palindrome in banana is : {Program.returnLongestPalindrom("banana")}");
            Console.WriteLine($" The Palindrome in aabcdcb is : {Program.returnLongestPalindrom("aabcdcb")}");
        }
    }
}
