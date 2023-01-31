/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int[] getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return array;
}

int getCountNumber(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        {
            count++;
        }
    }
    return count;
}

int[] array = getUserData("Введите числа ЧЕРЕЗ пробел");
int count = getCountNumber(array);
Console.WriteLine($"Количество чисел больше 0 = {count}");