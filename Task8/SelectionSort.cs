using System;
using System.Diagnostics;

class Program{
    
    static void SelectionSort(int[] array){ //Сортування простим вибором
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int k = 0;
        int p = 0;
        int len = array.Length;
        for (int i = 0; i < len-1; i++){
            int nmin= i;
            for (int j = i+1; j<len; j++){
                p++;
                if (array[j] < array[nmin]){
                    nmin = j;
                    k++;
                }
            }
                var temp = array[i];
                array[i] = array[nmin];
                array[nmin]= temp;
            
        }
        Console.WriteLine($"Сортування простим вибором робить {p} порівнянь, {k} обмінів за {stopwatch.Elapsed.TotalMilliseconds} ms");
        stopwatch.Stop();

    }
public static void Main()
    {
    int[] array = {7, 10, 4, 3, 9, 8, 6, 5, 2, 1};
    SelectionSort(array);
    }

}
