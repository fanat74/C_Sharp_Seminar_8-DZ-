// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int raws, int columns, int min, int max)
{
    int[,] matrix = new int[raws, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine("|");
    }
}


void FindMinRaws(int[,] matrix)
{
    int sumMin = 0;
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        if (sum < sumMin)
        {
            sumMin = sum;
            count = i;
        }

    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов это {count} строка");

}


int[,] array2D = CreateMatrixRndInt(3, 3, -10, 10);
PrintMatrix(array2D);
FindMinRaws(array2D);
