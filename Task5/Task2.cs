using System;

public class Program
{
    static int MaxNumberOfArray(int[] mas){
       int maxNumberOfArray = mas[0];
       foreach(int number in mas){
           if (number>maxNumberOfArray){
               maxNumberOfArray = number;
           }
       }
       return maxNumberOfArray;
    }
    
    public static void Main()
    {
        Console.WriteLine("Введіть кількість елементів масиву");
        int numberAmount = int.Parse(Console.ReadLine());
        int[] mas = new int[numberAmount];
        
        Console.WriteLine("Введіть числа");
        for (int i = 0; i < numberAmount; i++){
            mas[i] = int.Parse(Console.ReadLine());
        }
        int maxNumberOfArray = MaxNumberOfArray(mas);
        Console.WriteLine($"Максимальне значення серед елементів масиву = {maxNumberOfArray}");
    }
}
