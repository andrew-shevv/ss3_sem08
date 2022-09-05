// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillSpiral2D(int verticalLength = 4, int horizontalLength = 4)
{
    int[,] array2D = new int[verticalLength, horizontalLength];

    int count = 1;
    int i = 0;
    int k = 0;
    int j;

    while (i < verticalLength * horizontalLength)
    {
        k++;

        for (j = k - 1; j < horizontalLength - k + 1; j++)
        {
            array2D[k - 1, j] = count++;
            i++;
        }

        for (j = k; j < verticalLength - k + 1; j++)
        {
            array2D[j, horizontalLength - k] = count++;
            i++;
        }

        for (j = horizontalLength - k - 1; j >= k - 1; j--)
        {
            array2D[verticalLength - k, j] = count++;
            i++;
        }

        for (j = verticalLength - k - 1; j >= k; j--)
        {
            array2D[j, k - 1] = count++;
            i++;
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
            Console.Write(array2D[i, j].ToString("D2") + " ");
        }
        Console.WriteLine();
    }
}

int[,] spiral = FillSpiral2D();

PrintArray2D(spiral);