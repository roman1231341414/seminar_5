/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getStrRange(int M, int N)
{
    if (M == 0)
    {
        return N+=1;
    }
    else if (M > 0 && N == 0)
    {
        return N = getStrRange(M - 1, 1);
    }
    else if (M > 0 && N > 0)
    {
        return N = getStrRange(M - 1, getStrRange(M, N - 1));
    }
    return N;
}

Console.Clear();
int userNumberStart = getUserData("Введите число M : ");
int userNumberFinish = getUserData("Введите число N : ");
int rage = getStrRange(userNumberStart, userNumberFinish);
Console.WriteLine(rage);