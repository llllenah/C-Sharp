using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введіть кількість рядків");
    int rowsAmount = int.Parse(Console.ReadLine());
    Console.WriteLine("Введіть кількість стовбчиків");
    int columnsAmount = int.Parse(Console.ReadLine());
    
    int[,] mas = new int[rowsAmount, columnsAmount];
    Console.WriteLine($"Введіть {rowsAmount*columnsAmount} елементів");
    for (int i = 0; i < rowsAmount; i++){
        for (int j = 0; j <columnsAmount; j++){
            mas[i, j] = int.Parse(Console.ReadLine());
        }
    }
    
    int min = mas[0, 0];
    int max = mas[0, 0];
    foreach (int number in mas){
        if (min > number){
            min = number;
        }
        if (max < number){
            max = number;
        }
    }
    int sum = min + max;
    Console.WriteLine($"Мінімальний елемент = {min}");
    Console.WriteLine($"Максимальний елемент = {max}");
    Console.WriteLine($"Сума максимального та мінімального елементів = {sum}");
  }
}
