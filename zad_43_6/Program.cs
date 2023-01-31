double getUserData(string message)
{
    Console.Write(message);
    var userData = Convert.ToDouble(Console.ReadLine());
    return userData;
}

double intersectionPointX(double k1,double b1,double k2,double b2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    return x;
}

double intersectionPointY(double k1,double b1,double k2,double b2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    return y;
}
double k1 = getUserData("Введите k1 = ");
double b1 = getUserData("Введите b1 = ");
double k2 = getUserData("Введите k2 = ");
double b2 = getUserData("Введите b2 = ");

double getIntersectionPointX = intersectionPointX( k1, b1, k2, b2);
double getIntersectionPointY = intersectionPointY( k1, b1, k2, b2);
Console.WriteLine($"{getIntersectionPointX},{getIntersectionPointY}");




