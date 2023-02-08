int[,] generate2DArray(int colLength, int rowLength, int start, int end)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
void printHeadOfArray(int length)
{
    Console.Write("\t");
for (int i = 0; i < length; i++)
{
    printInColor(i + "\t",ConsoleColor.DarkGreen);
}
Console.WriteLine();
}


void printArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t",ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-------------");
}



int[,] swapRows(int [,] array,int row1,int row2)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[row1,i];
        array[row1,i] = array [row2,i];
        array[row2,i] = tmp;
    }
    return array;
}

int[,] array = generate2DArray(10,7,-5,10);
printArray(array);
int [,] swapedArray = swapRows(array,0,array.GetLength(0) - 1);
printArray(swapedArray);