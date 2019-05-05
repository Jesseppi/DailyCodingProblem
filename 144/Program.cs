using System;
using System.Collections;
using System.Collections.Generic;

namespace _144
{
    class Program
    {

        public static int? GiveMeYourIntIllDoYouOneBetter(int[] numbers, int index){
            var valueToBeat = numbers[index];
            var biggerIndexsDistance = new SortedList();

            int? closestLargerNumbersIndex = null;

            for(var indx = 0; indx < numbers.Length; indx++)
            {
                if(numbers[indx] > valueToBeat){
                    var indexDiffernce = Math.Abs(Math.Abs((Int32)index) - Math.Abs((Int32)indx));
                    biggerIndexsDistance.Add(indexDiffernce,indexDiffernce);
                };
            }

            if(biggerIndexsDistance.Count > 0) closestLargerNumbersIndex = (int)biggerIndexsDistance.GetByIndex(0);

            return closestLargerNumbersIndex;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GiveMeYourIntIllDoYouOneBetter(new[] { 4, 1, 3, 5, 6 },0));
            Console.WriteLine(GiveMeYourIntIllDoYouOneBetter(new[] { 4, 5, 3, 5, 6 }, 4));
            Console.WriteLine(GiveMeYourIntIllDoYouOneBetter(new[] { 4, 0, 0, 0, 6 }, 1));
        }
    }
}
