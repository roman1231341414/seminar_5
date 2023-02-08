/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

string getStrRange(int M, int N,int saveM)
{
    if (N == saveM )
    {
        return M + "";
    }
    return getStrRange(M + N, N - 1,saveM);
}

Console.Clear();
int userNumberStart = getUserData("Введите число M : ");
int userNumberFinish = getUserData("Введите число N : ");
int saveMM = userNumberStart;
string rage = getStrRange(userNumberStart, userNumberFinish,saveMM);
Console.WriteLine(rage);