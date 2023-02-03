/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

int GetDataUser(string message)
{
    Console.WriteLine(message);
    int dataUser = int.Parse(Console.ReadLine()!);
    return dataUser;
}

void printColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}


double[,] RandomDoubleNumbers(int colLength, int rowLength, int start, int end)
{
    double[,] array = new double[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, end + 1) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int i = GetDataUser("Введите количество строк");
int b = GetDataUser("Введите количество столбцов");
double[,] array = RandomDoubleNumbers(i, b, 0, 10);
PrintArray(array);