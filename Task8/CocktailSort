using System;
using System.Diagnostics;

class Program{
    private static void Swap(ref int a, ref int b)
    {
    	a ^= b;
    	b ^= a;
    	a ^= b;
    }
    
    public static void CocktailSort(ref int[] array)
    {    
        int k = 0;
        int p = 0;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
    	while (true){
    		bool flag;
    		int[] start = { 1, array.Length - 1 };
    		int[] end = { array.Length, 0 };
    		int[] inc = { 1, -1 };
    
    		for (int it = 0; it < 2; ++it)
    		{
    			flag = true;
    
    			for (int i = start[it]; i != end[it]; i += inc[it])
    			{
    			    p++;
    				if (array[i - 1] > array[i])
    				{
    				    k++;
    					Swap(ref array[i - 1], ref array[i]);
    					flag = false;
    				}
    			}
    
    			if (flag){
                    stopwatch.Stop();
                    Console.WriteLine($"Шейкерне сортування робить {p} порівнянь, {k} обмінів за {stopwatch.Elapsed.TotalMilliseconds} ms");
    				return;
                }
    		}
    	}
    }

    public static void Main(){
        
        int[] array = {7, 10, 4, 3, 9, 8, 6, 5, 2, 1};
        
        CocktailSort(ref array);
    }

}

