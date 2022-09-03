// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillArray2D(int verticalLength = 5, int horizontalLength = 4, int minValue = 1, int maxValue = 9)
{
    int[,] array2D = new int[verticalLength, horizontalLength];

    Random rand = new Random();

    for (int i = 0; i < verticalLength; i++)
    {
        for (int j = 0; j < horizontalLength; j++)
        {
            array2D[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($" {array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindMinRow(int[,] array2D)
{
    int[] sumsArray = new int[array2D.GetLength(0)];

    int minPos = 0;

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sumsArray[i] += array2D[i, j];
        }

        if (sumsArray[i] < sumsArray[minPos])
        {
            minPos = i;
        }
    }
    return minPos;
}

int[,] matrix = FillArray2D();

Console.WriteLine("Created array: ");
PrintArray2D(matrix);

Console.WriteLine($"\nThe row with the smallest sum of elements == {FindMinRow(matrix) + 1}");