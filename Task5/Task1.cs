using System;

public class Program
{
    static void Average(int firstNumber, int secondNumber){
       double average = (firstNumber+secondNumber)/2.0;
       Console.WriteLine($"Середнє арифметичне значення = {average}");
    }
    public static void Main()
    {
        Console.WriteLine("Введіть перше число");
        int firstNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введіть друге число");
        int secondNumber = int.Parse(Console.ReadLine());
        
        Average(firstNumber, secondNumber);
    }
}
