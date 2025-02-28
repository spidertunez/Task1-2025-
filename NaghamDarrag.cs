using System;

namespace SelectionSortAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Console.WriteLine("Original array:");
            SelectionSort.PrintArray(arr);

            SelectionSort.SelectionSortAlgorithm(arr);

            Console.WriteLine("\nSorted array:");
            SelectionSort.PrintArray(arr);
        }

        public class SelectionSort
        {
            // Function to perform selection sort
            public static void SelectionSortAlgorithm(int[] arr)
            {
                int n = arr.Length;

                // One by one move boundary of unsorted subarray
                for (int i = 0; i < n - 1; i++)
                {
                    // Find the minimum element in unsorted array
                    int minIndex = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[j] < arr[minIndex])
                        {
                            minIndex = j;
                        }
                    }

                    // Swap the found minimum element with the first element
                    int temp = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = temp;
                }
            }

            // Function to print an array
            public static void PrintArray(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
