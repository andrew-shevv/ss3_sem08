// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

int[,] FillArray2D(int verticalLength = 3, int horizontalLength = 4, int minValue = 0, int maxValue = 9)
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

int minValue(int[,] array2D)
{
    int min = array2D[0, 0];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {

            if (array2D[i, j] < min)
            {
                min = array2D[i, j];
            }
        }
    }
    return min;
}

int maxValue(int[,] array2D)
{
    int max = array2D[0, 0];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {

            if (array2D[i, j] > max)
            {
                max = array2D[i, j];
            }
        }
    }
    return max;
}

void Frequency(int[,] array2D)
{
    int min = minValue(array2D);
    int max = maxValue(array2D);

    for (int l = min; l <= max; l++)
    {
        int getFreq = 0;

        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                if (array2D[i, j] == l)
                {
                    getFreq++;
                }
            }
        }
        if (getFreq > 0) Console.WriteLine($"Number {l} is in this array {getFreq} times");
    }
}

int[,] matrix = FillArray2D();

Console.WriteLine("Created array: ");
PrintArray2D(matrix);

Console.WriteLine();
Frequency(matrix);