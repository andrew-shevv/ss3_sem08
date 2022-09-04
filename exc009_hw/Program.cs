// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Fill3DArray(
    int yAxis = 2, int xAxis = 2, int zAxis = 2, 
    int minValue = 10, int maxValue = 99
)
{
    int[,,] array3D = new int[yAxis, xAxis, zAxis];

    List<int> container = new List<int>();

    Random rand = new Random();

    for (int k = 0; k < array3D.GetLength(2); k++)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                int number;

                do
                {
                    number = rand.Next(minValue, maxValue + 1);
                } while (container.Contains(number));

                array3D[i, j, k] = number;

                container.Add(number);
            }
        }
    }

    return array3D;
}

void Print3DArray(int[,,] array3D)
{
    for (int k = 0; k < array3D.GetLength(2); k++)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                Console.Write($" {array3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        
    }
}

int[,,] matrix = Fill3DArray();

Print3DArray(matrix);