using System;
using System.Linq;

//Задание 13 Поиск минимального значения LINQ

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 2, 9, 1 };

        int minValue1 = numbers.Min();
        Console.WriteLine($"Минимальное число: {minValue1}");

        // Ожидаемый результат: 1
    }
}