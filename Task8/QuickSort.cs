using System;
using System.Diagnostics;

class Program
{
    //метод для обміну елементів масиву
    static void Swap(ref int x, ref int y)
    {
        var t = x;
        x = y;
        y = t;
    }

    //метод повертає індекс опорного елемента
    static int Partition(int[] array, int minIndex, int maxIndex, ref int k, ref int p)
    {
        p++;
        var pivot = minIndex - 1;
        for (var i = minIndex; i < maxIndex; i++)
        {
            p++;
            if (array[i] < array[maxIndex])
            {
                pivot++;
                k++;
                Swap(ref array[pivot], ref array[i]);
            }
        }
        pivot++;
        Swap(ref array[pivot], ref array[maxIndex]);
        return pivot;
    }

    //швидке сортування
    static int[] QuickSort(int[] array, int minIndex, int maxIndex, ref int k, ref int p)
    {

        if (minIndex >= maxIndex)
        {
            return array;
        }

        var pivotIndex = Partition(array, minIndex, maxIndex, ref k, ref p);
        QuickSort(array, minIndex, pivotIndex - 1, ref k, ref p);
        QuickSort(array, pivotIndex + 1, maxIndex, ref k, ref p);
        return array;
    }


    static void Main(string[] args)
    {
        int k = 0;
        int p = 0;
        int[] array = {7, 10, 4, 3, 9, 8, 6, 5, 2, 1};
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        QuickSort(array, 0, array.Length - 1, ref k, ref p);
        Console.WriteLine($"Алгоритм швидкого сортування робить {p} порівнянь та {k} обмінів за {stopwatch.Elapsed.TotalMilliseconds} ms");
        stopwatch.Stop();
    }
}
