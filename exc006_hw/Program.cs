// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillArray2D(int verticalLength = 4, int horizontalLength = 5, int minValue = 0, int maxValue = 9)
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

void DescendingSortArrayRows(int[,] array2D)
{
    for (int k = 0; k < array2D.GetLength(0); k++)
    {
        for (int i = 0; i < array2D.GetLength(1) - 1; i++)
        {
            int maxPos = i;
    
            for (int j = i + 1; j < array2D.GetLength(1); j++)
            {
                if (array2D[k, j] > array2D[k, maxPos])
                {
                    maxPos = j;
                }
            }

            int temp = array2D[k, i];
            array2D[k, i] = array2D[k, maxPos];
            array2D[k, maxPos] = temp;
        }
    }
}

int[,] matrix = FillArray2D();

Console.WriteLine("Created array: ");
PrintArray2D(matrix);

DescendingSortArrayRows(matrix);

Console.WriteLine("\nArray with rows sorted in descending order: ");
PrintArray2D(matrix);
