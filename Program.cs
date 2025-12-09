using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 2, 9, 1 };

        int minValue1 = numbers.Min();
        Console.WriteLine($"Минимальное число (способ 1): {minValue1}");

        // Ожидаемый результат: 1
    }
}