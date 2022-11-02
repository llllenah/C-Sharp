using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введіть число");
        int number = int.Parse(Console.ReadLine());
        int number2 = number;
        
        int sum = 0;
        do{
            sum+=number%10;
            number=number/10;
        }
        while (number!=0);

        Console.WriteLine($"Сума цифр числа '{number2}' = {sum}");
    }

}
