/*
Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(message);
    int data = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return data;
}

void PrintRange (int number)
{
    if (number == 0)
    {
        return;
    }
    Console.Write (number+ ",");
    PrintRange (number-1);
}

int N = GetFromUserData ("Введите число N: ");
PrintRange (N);
Console.WriteLine();