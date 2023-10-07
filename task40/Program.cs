// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первую сторону ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую сторону ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третью сторону ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle(int a, int b, int c)
{
    if(a< b + c && b < a + c && c < b + a) return true;
    return false;
}

bool result = IsExistTriangle(firstNumber, secondNumber, thirdNumber);
Console.WriteLine(result ? "Треугольник существует": "Треугольник не существует");

