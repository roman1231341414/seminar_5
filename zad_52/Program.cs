/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int m = 3;
int n = 3;
int[,] arr = new int[m, n];

void FillArray(int[,] arrayToFill)
{
    for (int i = 0; i < arrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFill.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    
}

void PrintArray(int [,] array)
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
void printColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();

}
void Average(int [,] arr)
{
    double sum =0;
    for (int j = 0; j < arr.GetLength(1);j++ )
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i,j];
        }
        Console.WriteLine($"Cреднееарифметическое столбца №{j} = {sum/arr.GetLength(1)}");
        sum = 0;
    }
}


FillArray(arr);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Average(arr);
