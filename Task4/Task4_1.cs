using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введіть кількість елементів масиву");
        int numberAmount = int.Parse(Console.ReadLine());
        int[] mas = new int[numberAmount];
        
        Console.WriteLine("Введіть числа");
        for (int i = 0; i < numberAmount; i++){
            mas[i] = int.Parse(Console.ReadLine());
        }
        
        int pairedElementsNumber = 0;
        int positiveElementsSum = 0 ;
        foreach(int number in mas){
            if (number > 0){
                positiveElementsSum+=number;
            }
            if (number % 2 == 0){
                pairedElementsNumber+=1;
            }
        }
        Console.WriteLine($"Сума додатних елементів одновимірного масиву чисел = {positiveElementsSum}");
        Console.WriteLine($"Кількість парних елементів одновимірного масиву чисел = {pairedElementsNumber}");
    }
}
