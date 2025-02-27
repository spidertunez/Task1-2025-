internal class Program
{
    public static void Main()
    {
        string Name = "Hazem Ibrahim Abdel-Hamed Mohamed Aldriny";
        int Section = 3;
        Console.WriteLine($"Name: {Name} >> Section:{Section}");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Selection Sort Algorithm: Swap the found Min_Number element with the first element");
      
      
        int[] arr = { 15, 10, 25, 20, 30, 40, 35 };

        Console.WriteLine("------------------------------------");
        Console.Write("Orginal array ");
        printArray(arr);

        Console.WriteLine("------------------------------------");
        Console.Write("Sorted array ");
        Selectionsort(arr);
        printArray(arr);
        Console.ReadLine();
    }

    public static void Selectionsort(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length - 1; i++) // Start from i = 0
        {
            int Min_Num = i;
            for (int j = i + 1; j < length; j++)  // Start from j = 1
            {
                if (arr[j] < arr[Min_Num])
                    Min_Num = j;
            }

            int temp = arr[Min_Num];
            arr[Min_Num] = arr[i];
            arr[i] = temp;
        }
    }

    private static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)

            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}