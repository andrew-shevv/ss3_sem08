// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] FillArray2D(int verticalLength = 4, int horizontalLength = 4, int minValue = 0, int maxValue = 9)
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

int[] minValueCoords(int[,] array2D)
{
    int min = array2D[0, 0];
    int[] minCoords = new int[2];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {

            if (array2D[i, j] < min)
            {
                min = array2D[i, j];
                minCoords[0] = i;
                minCoords[1] = j;
            }
        }
    }
    return minCoords;
}

int[,] DeleteMinElementCrossSection(int[,] array2D)
{
    int[,] alteredArray = new int[array2D.GetLength(0) - 1, array2D.GetLength(1) - 1];

    int[] coords = minValueCoords(array2D);

    int rowOffset = 0;
    int columnOffset = 0;

    for (int i = 0; i < alteredArray.GetLength(0); i++)
    {
        

        if (i == coords[0]) rowOffset++;
        for (int j = 0; j < alteredArray.GetLength(1); j++)
        {
            if (j == coords[1]) columnOffset++;
            alteredArray[i, j] = array2D[i + rowOffset, j + columnOffset];
        }
        columnOffset = 0;
    }
    return alteredArray;
}

int[,] matrix = FillArray2D();

Console.WriteLine("Created array: ");
PrintArray2D(matrix);

int[,] alteredArray = DeleteMinElementCrossSection(matrix);

Console.WriteLine("\nAltered array: ");
PrintArray2D(alteredArray);