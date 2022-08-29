// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] FillArray2D(int verticalLength = 4, int horizontalLength = 5, int minValue = 1, int maxValue = 9)
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

int[,] FlipArray(int[,] array2D)
{
    int[,] arrayFlip = new int[array2D.GetLength(1), array2D.GetLength(0)];

    for (int i = 0; i < arrayFlip.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFlip.GetLength(1); j++)
        {
            arrayFlip[i, j] = array2D[j, i];
        }
    }
    return arrayFlip;
}

int[,] matrix = FillArray2D();

Console.WriteLine("Created array: ");
PrintArray2D(matrix);

int[,] flippedArr = FlipArray(matrix);

Console.WriteLine("\nFlipped array: ");
PrintArray2D(flippedArr);