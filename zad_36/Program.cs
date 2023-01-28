/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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


int getSumNumbers(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if (i % 2 != 0)
{
sum = sum + array[i];
}

}
return sum;
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

int [] array = generatArray(4,0,20);
printArray(array);
Console.WriteLine();
int sum = getSumNumbers(array);
Console.WriteLine($"cумма нечетных позиций в массиве = {sum}");