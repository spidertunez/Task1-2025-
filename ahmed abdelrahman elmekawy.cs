using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ahmed_Abdelrahman_Elmekawy
{

    class Program
    {
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                // البحث عن العنصر الأصغر في الجزء غير المرتب من المصفوفة
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // تبديل العنصر الأصغر مع العنصر الحالي
                if (minIndex != i)
                {
                    int temp = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            Console.WriteLine("befor:");
            PrintArray(arr);

            SelectionSort(arr);

            Console.WriteLine("After:");
            PrintArray(arr);
        }
    }
}
