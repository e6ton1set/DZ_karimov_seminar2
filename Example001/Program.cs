//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите целое трёхзначное число");

int number = int.Parse(Console.ReadLine());

    if (number > 0)
{
string str = number.ToString();
Console.WriteLine($"Вторая цифра числа {number} это {str[1]}");
}
    else
{
        Console.WriteLine("Вы ввели отрицательное число");
}