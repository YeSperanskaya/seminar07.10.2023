// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void NatureNumbers (int num)
{
    if(num == 0) return;

    NatureNumbers(num - 1);
    Console.Write($"{num} ");
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
NatureNumbers(number);


