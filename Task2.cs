using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введіть ціну за 1 зошит");
        double notebookPrice = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введіть кількість зошитів");
        int notebookAmount = int.Parse(Console.ReadLine());

        double priceForAllNotebooks = notebookPrice * notebookAmount;

        Console.WriteLine("Введіть ціну за 1 ручку");
        double penPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть кількість ручок");
        int penAmount = int.Parse(Console.ReadLine());

        double priceForAllPens = penPrice * penAmount;

        double totalPrice = priceForAllNotebooks + priceForAllPens;

        Console.WriteLine("Введіть наявну кількість гривень");
        double userMoney = double.Parse(Console.ReadLine());

        if (totalPrice <= userMoney){
            Console.WriteLine($"Після здійснення покупки залишиться {userMoney - totalPrice} грн.");
        }
        else{
            Console.WriteLine($"Ви не зможете здійснити покупку!\nНе вистачає {totalPrice - userMoney} грн.");
        }
    }

}
