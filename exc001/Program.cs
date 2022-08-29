// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] FillArray2D(int verticalLength = 4, int horizontalLength = 5, int minValue = -9, int maxValue = 9)
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

void SwapTopBottomRows(int[,] array2D)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        var temp = array2D[0, j];
        array2D[0, j] = array2D[array2D.GetLength(0) - 1, j];
        array2D[array2D.GetLength(0) - 1, j] = temp;
    }
}

int[,] matrix = FillArray2D();

Console.WriteLine("Created array: ");
PrintArray2D(matrix);

SwapTopBottomRows(matrix);

Console.WriteLine("\nSwapped array: ");
PrintArray2D(matrix);