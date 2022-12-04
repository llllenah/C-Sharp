using System;
using System.Diagnostics;

class Program{
public static void ShellSort(int[] array, int size)
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    int k = 0;
    int p = 0;
    for (int interval = size / 2; interval > 0; interval /= 2)
    {
        for (int i = interval; i < size; i++)
        {
            p++;
            var currentKey = array[i];
            var d = i;
            while (d >= interval && array[d - interval] > currentKey)
            {
                k++;
                array[d] = array[d - interval];
                d -= interval;
            }
            array[d] = currentKey;
            
        }
    }
    stopwatch.Stop();
    Console.WriteLine($"Сортування алгоритмом Шелла робить {p} порівнянь, {k} обмінів за {stopwatch.Elapsed.TotalMilliseconds} ms");
}
public static void Main()
    {
    int[] array = {7, 10, 4, 3, 9, 8, 6, 5, 2, 1};
    
    ShellSort(array, array.Length);
    }

}
