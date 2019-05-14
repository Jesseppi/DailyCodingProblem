using System;
using System.Collections;
using System.Collections.Generic;

namespace _138 {
    class Program {
        // private static int GetNumberOfCoinsNeededToPay(int balanceToPay){
        //     var totalCoins = 0;

        //     var coinCounter = new Dictionary<int,int>();
        //     var coinValue = new List<int>{25,10,5,1};

        //     var remainingBalance = balanceToPay;

        //     foreach (var value in coinValue)
        //     {
        //          getNumberOfCoinsForValue(value,ref remainingBalance,ref totalCoins, coinCounter);
        //     }

        //     return totalCoins;

        // }

        // private static void getNumberOfCoinsForValue(int coinValue,ref int remainingBalance,ref int totalCoins, Dictionary<int,int> coinCounter){
        //     if(coinValue > remainingBalance) return;
        //     var number = remainingBalance/coinValue;
        //     var numberOfDenomination = Convert.ToInt32(Math.Truncate(Convert.ToDouble(number)));
        //     coinCounter.Add(coinValue,numberOfDenomination);
        //     totalCoins += numberOfDenomination;
        //     remainingBalance = remainingBalance % coinValue;
        // }

        // static void Main(string[] args)
        // {
        //     var balanceToPay = 1987;
        //     Console.WriteLine($"The minumu coins to pay the bill of {balanceToPay} is {GetNumberOfCoinsNeededToPay(balanceToPay)} ");
        // }

        static int minCoins (int[] coins, int value) {
            int[] calculationTable = new int[value + 1];
            // Base case (If given// value V is 0)
            calculationTable[0] = 0;

            foreach (var denomination in coins)
            {
                if(denomination < calculationTable.Length) calculationTable[denomination] = 1;
            }


            for (int i = 1; i <= value; i++) {
                for (int j = 0; j < coins.Length; j++){
                    if(calculationTable[i] == 1 ) break;
                    if ( i - coins[j] >= 0 )
                    {
                        int smallerValueCount = calculationTable[i - coins[j]];
                        calculationTable[i] = smallerValueCount + 1;
                        break;
                    }
                }
            }
            return calculationTable[value];

        }

        // Driver Code
        static public void Main () {
            int[] availableCoins = { 25, 10, 5, 1 };
            int value = 1987;
            Console.WriteLine ("Minimum coins required is " + minCoins (availableCoins, value));
        }
    }
}