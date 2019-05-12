using System;
using System.Collections;
using System.Collections.Generic;

namespace _143
{
    class Program
    {
        public static int[] ArraySorterOnPivotValue(int[] unsortedArray, int pivot){
            var valuesLessThan = new List<int>();
            var valuesGreaterThan = new List<int>();
            var equalValues = new List<int>();

            foreach (var item in unsortedArray)
            {
                if(item < pivot){
                    valuesLessThan.Add(item);
                } else if(item > pivot) {
                    valuesGreaterThan.Add(item);
                } else {
                    equalValues.Add(item);
                }
            }
            
            var sortedArray = new List<int>(valuesLessThan.Count + equalValues.Count + valuesGreaterThan.Count);
            sortedArray.AddRange(valuesLessThan);
            sortedArray.AddRange(equalValues);
            sortedArray.AddRange(valuesGreaterThan);

            return sortedArray.ToArray();

        }

        static void Main(string[] args)
        {
            var sortedArray = ArraySorterOnPivotValue(new int[] { 9, 12, 3, 5, 14, 10, 10 }, 10 );
            var retrunString = "[";
            for (var item = 0; item < sortedArray.Length; item++)
            {
                retrunString = retrunString + sortedArray[item];
                if (item != sortedArray.Length - 1) retrunString = retrunString + ",";
            }
            retrunString = retrunString + "]";
            Console.WriteLine(retrunString);
        }
    }
}
