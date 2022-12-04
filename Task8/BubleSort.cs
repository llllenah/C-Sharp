using System;
using System.Diagnostics;

class Program{
    static void BubbleSort(int[] array){ //Бульбашкове сертування
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int k = 0;
        int p = 0;
        int len = array.Length;
        for (int i = 1; i < len; i++){
            for (int j = 0; j<len-1; j++){
                p++;
                if (array[j] > array[j + 1]){
                    var temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1]= temp;
                    k++;
                }
            }
        }
        
        Console.WriteLine($"Бульбашкове сортування робить {p} порівнянь та {k} обмінів за {stopwatch.Elapsed.TotalMilliseconds} ms");
        stopwatch.Stop();

    }

    public static void Main()
    {
        int[] array = {7, 10, 4, 3, 9, 8, 6, 5, 2, 1};
        BubbleSort(array);
    }

}
