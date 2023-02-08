/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

string getStrRange(int start, int finish)
{
    if (start == finish)
    {
        return start + ".";
    }
    return finish + "," + getStrRange(start , finish - 1);
}

Console.Clear();
int userNumberStart = 1;
int userNumberFinish = getUserData("Введите число N : ");
string rage = getStrRange(userNumberStart, userNumberFinish);
Console.WriteLine(rage);