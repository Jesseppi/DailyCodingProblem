using System;
using System.Collections;
using System.Collections.Generic;

namespace _138
{
    class Program
    {
        private static int GetNumberOfCoinsNeededToPay(int balanceToPay){
            var totalCoins = 0;

            var coinCounter = new Dictionary<int,int>();
            var coinValue = new List<int>{25,10,5,1};

            var remaindingBalance = balanceToPay;

            foreach (var value in coinValue)
            {
                 getNumberOfCoinsForValue(value,ref remaindingBalance,ref totalCoins, coinCounter);
            }

            return totalCoins;

        }

        private static void getNumberOfCoinsForValue(int coinValue,ref int remainingBalance,ref int totalCoins, Dictionary<int,int> coinCounter){
            if(coinValue > remainingBalance) return;
            var number = remainingBalance/coinValue;
            var numberOfDenomination = Convert.ToInt32(Math.Truncate(Convert.ToDouble(number)));
            coinCounter.Add(coinValue,numberOfDenomination);
            totalCoins += numberOfDenomination;
            remainingBalance = remainingBalance % coinValue;
        }

        static void Main(string[] args)
        {
            var balanceToPay = 1987;
            Console.WriteLine($"The minumu coins to pay the bill of {balanceToPay} is {GetNumberOfCoinsNeededToPay(balanceToPay)} ");
        }

    //     static int minCoins(int[] coins,
    //                 int m, int V)
    //     {
    //         // table[i] will be storing  
    //         // the minimum number of coins 
    //         // required for i value. So  
    //         // table[V] will have result 
    //         int[] table = new int[V + 1];

    //         // Base case (If given 
    //         // value V is 0) 
    //         table[0] = 0;

    //         // Initialize all table 
    //         // values as Infinite 
    //         for (int i = 1; i <= V; i++)
    //             table[i] = int.MaxValue;

    //         // Compute minimum coins  
    //         // required for all 
    //         // values from 1 to V 
    //         for (int i = 1; i <= V; i++)
    //         {
    //             // Go through all coins 
    //             // smaller than i 
    //             for (int j = 0; j < m; j++)
    //                 if (coins[j] <= i)
    //                 {
    //                     int sub_res = table[i - coins[j]];
    //                     if (sub_res != int.MaxValue &&
    //                         sub_res + 1 < table[i])
    //                         table[i] = sub_res + 1;
    //                 }
    //         }
    //         return table[V];

    //     }

    //     // Driver Code  
    //     static public void Main()
    //     {
    //         int[] coins = { 25, 10, 5, 1 };
    //         int m = coins.Length;
    //         int V = 1987;
    //         Console.WriteLine("Minimum coins required is " +
    //                                  minCoins(coins, m, V));
    //     }
    // }
}
