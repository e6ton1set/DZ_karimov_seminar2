// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next(0, 1000);

int result = number%10;

    if (number > 100)
{
        Console.WriteLine($"Третьей цифрой числа {number} является {result}");
}

    else
{
        Console.WriteLine($"У числа {number} третьей цифры нет");
}