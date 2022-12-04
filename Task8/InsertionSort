using System;
using System.Diagnostics;

class Program{
    static void InsertionSort(int[] array){
        int i, j;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int p = 0;
        int k = 0;
        for (i = 1; i < array.Length; i++){
            int c = array[i];
            for (j = i - 1; j >= 0 && array[j] > c; j--){
                p++;
                array[j+1] = array[j];
            }
            if (array[j + 1] != c){
                k++;
            }
            array[j + 1] = c;
        }
        Console.WriteLine($"Сортування простою вставкою робить {p} порівнянь, {k} обмінів за {stopwatch.Elapsed.TotalMilliseconds} ms");
        stopwatch.Stop();
    }

    public static void Main()
    {
        int[] array = {7, 10, 4, 3, 9, 8, 6, 5, 2, 1};
    
        InsertionSort(array);
    }

}
