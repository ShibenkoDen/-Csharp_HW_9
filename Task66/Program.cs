/*
Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(message);
    int data = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return data;
}

int GetSumOfRange(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return start + GetSumOfRange(start + 1, end);
}

int M = GetFromUserData("Введите начало ряда: ");
int N = GetFromUserData("Введите конец ряда: ");
int res = GetSumOfRange(M, N);
Console.WriteLine($"Сумма элементов от {M} до {N} равна {res}");