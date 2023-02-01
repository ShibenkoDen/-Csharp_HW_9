/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(message);
    int data = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return data;
}

int AkkermanFunction (int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return AkkermanFunction(n - 1, 1);
    if (n > 0 && m > 0) return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
    return AkkermanFunction(n,m);
}

int number1 = GetFromUserData ("Введите первое число: ");
int number2 = GetFromUserData ("Введите второе число: ");
int res = AkkermanFunction (number1, number2);
Console.WriteLine(res);