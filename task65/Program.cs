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