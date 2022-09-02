// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("Input number of rows: ");
int rows = int.Parse(Console.ReadLine()!);
int columns = rows * 2 + 1;


int[,] triangle = new int[rows, columns];

triangle[0, columns / 2] = 1;
triangle[1, columns / 2 - 1] = 1;
triangle[1, columns / 2 + 1] = 1;

for (int i = 2; i < rows; i++)
{
    for (int j = columns / 2 - i; j <= columns / 2 + i; j += 2)
    {
        triangle[i, j] = triangle [i - 1, j - 1] + triangle [i - 1, j + 1];
    }
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] == 0)
            {
                Console.Write("  ");
            }
            else if (array2D[i, j] >= 10) { Console.Write($"{array2D[i, j]}"); }
            else Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray2D(triangle);