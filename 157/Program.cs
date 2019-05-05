using System;
using System.Collections.Generic;
namespace _157
{
    class Program
    {
        public static bool IsSringAPalidrome(string input)
        {
            var numberOfOdds = 0;

            var letterStore = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                try{
                    letterStore[letter]++;
                    numberOfOdds--;
                }catch{
                    letterStore.Add(letter,1);
                    numberOfOdds++;
                }
            }

            return numberOfOdds == 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"is racecar a palindrom? : {Program.IsSringAPalidrome("racecar")}");
            Console.WriteLine($"is Jesse a palindrom? : {Program.IsSringAPalidrome("jesse")}");
            Console.WriteLine($"is Oliver a palindrom? : {Program.IsSringAPalidrome("oliver")}");
            Console.WriteLine($"is Civic a palindrom? : {Program.IsSringAPalidrome("civic")}");
            Console.WriteLine($"is lambda a palindrom? : {Program.IsSringAPalidrome("lambda")}");
        }
    }
}
