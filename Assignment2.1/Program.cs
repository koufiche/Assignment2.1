using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));
            Console.ReadKey(true);

            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(a);
            Console.ReadKey(true);
        }
        static void displayArray(int[] r)
        {
            for (int i = 0; i < r.Length; i++)
            {
                Console.Write(r[i] + " ");
            }
            Console.WriteLine();
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int temp; // temporary variable holds the first value in the array
            for (int i = 0; i < d; i++) //goes through the number of shifts it asks for
            {
                temp = a[0]; // set first value in array to temp
                for (int j = 0; j < a.Length - 1; j++) //goes through loop
                {
                    a[j] = a[j + 1]; //moves value left and replaces

                }
                a[a.Length - 1] = temp; // sets last value to first value
            }
            return a;
        }
        static int maximumToys(int[] prices, int k)
        {
            int price = 0;
            int count = 0;
            int maxcount = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > k) //skip prices bigger than k
                {
                    continue;
                }
                for (int j = i; j < prices.Length; j++) //run through loop when you find an item less than k
                {
                    if (prices[j] < k && prices[j] + price < k)  //check to see if the item can be added to the total
                    {
                        price += prices[j]; // add to running total
                        count++; // increment count
                    }
                }
                if (count > maxcount) //if the new count is bigger than the old one replace it
                {
                    maxcount = count;
                }
                count = 0; //reset values
                price = 0;
            }
            return maxcount;
        }
    }
}

