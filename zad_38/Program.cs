/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int [] generatArray(int length,int start,int end)
{
int [] result = new int[length];
for (int i = 0; i < length; i++)
{
result[i] = new Random().Next(start,end + 1);
}
return result;
}


int getDeltaNumbers(int[] array)
{
int max = array[0];
int min = array[0];
int delta = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] > max)
{
max = array[i];
}
else if(min > array[i])
{
min = array[i];
}
}
delta = max - min;
return delta;
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


int [] array = generatArray(5,1,8);
printArray(array);
Console.WriteLine();
int delta = getDeltaNumbers(array);
Console.WriteLine(delta);