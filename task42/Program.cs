// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int DecimalToBinary(int num)
{
    int result = 0;
    int mult = 10;
    while(num > 0)
    {
        result += num % 2*mult;
        num /= 2;
        mult *= 10;
    }
    return result;
}

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DecimalToBinary(number));



// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

// Console.Write("Can you enter number:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DecimalToBinary(number));
// Console.WriteLine(DecimalToBinaryStr(number));

// int DecimalToBinary(int num)
// {
//     int result = 0;
//     int mult = 1;
//     while (num > 0)
//     {
//         result += num % 2 * mult;
//         num = num / 2;// num /= 2 //
//         mult *= 10;
//     }
//     return result;
// }

// string DecimalToBinaryStr(int num)
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num % 2 + result;
//         num = num / 2;// num /= 2 //
//     }
//     return result;
// }