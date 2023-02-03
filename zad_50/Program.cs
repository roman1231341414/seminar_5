/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
int GetDataUser(string message)
{
    Console.WriteLine(message);
    int dataUser = int.Parse(Console.ReadLine()!);
    return dataUser;
}

int m = 3;
int n = 3;
int[,] arr = new int[m, n];

void FillArray(int[,] arrayToFill)
{
    for (int i = 0; i < arrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFill.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void FindElementArray(int[,] findElement, int userNumber)
{
    bool find = false;
    for (int i = 0; i < findElement.GetLength(0); i++)
    {
        for (int j = 0; j < findElement.GetLength(1); j++)
        {
            if (findElement[i, j] == userNumber)
            {
                Console.WriteLine("ваше число находиться по координатам: " + i + " " + j);
                find = true;
            }
        }
    }
    if (!find)
    {
        Console.WriteLine("Такого значения в массиве нет");
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

FillArray(arr);
PrintArray(arr);
int number = GetDataUser("Введите значение: ");
Console.WriteLine();
FindElementArray(arr,number);
