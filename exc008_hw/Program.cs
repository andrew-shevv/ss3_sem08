// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray2D(int verticalLength, int horizontalLength, int minValue = 0, int maxValue = 9)
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

int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < newMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < newMatrix.GetLength(1); j++)
            {
                for (int l = 0; l < matrix1.GetLength(1); l++)
                {
                    newMatrix[i, j] += matrix1[i, l] * matrix2[l, j];
                }
            }
        }
    }
    else Console.WriteLine("\nThese matrices cannot be multiplied");

    return newMatrix;
}

int[,] matrix1 = FillArray2D(verticalLength: 3, horizontalLength: 2);

int[,] matrix2 = FillArray2D(verticalLength: 2, horizontalLength: 3);

Console.WriteLine("First matrix: ");
PrintArray2D(matrix1);

Console.WriteLine("\nSecond matrix: ");
PrintArray2D(matrix2);

int[,] multMatrix = MatrixMult(matrix1, matrix2);

Console.WriteLine("\nResulting matrix: ");
PrintArray2D(multMatrix);