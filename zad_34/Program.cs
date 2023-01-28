/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int getUserData(string message)
{
Console.WriteLine(message);
int userData = int.Parse(Console.ReadLine()!);
return userData;
}

int [] getRandomNumber(int length, int start,int end)
{
int[] result = new int[length];
for (int i = 0; i < length; i++)
{
result[i] = new Random().Next(start, end + 1);
}
return result;
}


int getEvenNumbers(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
{
count++;
}

}
return count;
}

void printArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i]);
if (i < array.Length - 1)
{
Console.Write(",");
}
}
Console.WriteLine("]");
}


Console.Clear();
int length = getUserData("Введите длину массива");
int []array = getRandomNumber(length,100,999);
printArray(array);
int arrayCheck = getEvenNumbers(array);
Console.WriteLine();
Console.WriteLine(arrayCheck);