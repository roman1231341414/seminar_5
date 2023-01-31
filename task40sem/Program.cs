int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine());
    return userData;
}

bool IsTriangleExist(int a,int b,int c)
{
    bool isExist = false;
    if (a < b+c && b<a+c && c<b+c )
    {
        isExist = true;
    }
    return isExist;
}

int a = getUserData("Введите длину стороны А");
int b = getUserData("Введите длину стороны B");
int c = getUserData("Введите длину стороны C");

bool isExist = IsTriangleExist(a,b,c);
Console.WriteLine($"Треугольник со сторонами [{a},{b},{c}] {((isExist)?"cуществует":"не существует")}");