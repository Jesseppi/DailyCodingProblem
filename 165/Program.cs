using System;
using System.Collections.Generic;

namespace _165
{
    class Program
    {
        public static int[] GetManyNumbersAreBiggerOnTheRight(int[] numbers){
            var arrayLength = numbers.Length;

            var biggerNumbersArray = new int[arrayLength];

            var tallyDictionary = new Dictionary<int,int>();

            for(var index = 0; index < arrayLength; index++){
                tallyDictionary.Add(index,0);
                var indexValue = numbers[index];
                for(var compareIndex = 0; compareIndex < index; compareIndex ++)
                {
                    var compareValue = numbers[compareIndex];
                    if(compareValue - indexValue > 0) tallyDictionary[compareIndex]++;
                }
            }

            tallyDictionary.Values.CopyTo(biggerNumbersArray,0);
            return biggerNumbersArray;
        }
        static void Main(string[] args)
        {
            var biggerArray = GetManyNumbersAreBiggerOnTheRight(new int[] { 3, 4, 9, 6, 1 });
            var retrunString = "[";
            for(var item = 0; item < biggerArray.Length; item++)
            {
                retrunString = retrunString + biggerArray[item];
                if(item != biggerArray.Length-1) retrunString = retrunString + ",";
            }
            retrunString = retrunString + "]";
            Console.WriteLine(retrunString);

        }
    }
}
