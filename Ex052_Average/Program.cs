// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// (Округление до 2х знаков - Math.Round(value, 2))

int[,] matrix = new int[3, 4];
FillRandomMatrix(matrix);
Console.WriteLine("Дан двумерный массив случайных чисел:");
PrintMatrix(matrix);
Console.Write("Среднее арифметическое каждого столбца:  ");
PrintAverageOfColumns(matrix);

void FillRandomMatrix(int[,] table)
{
    Random r = new Random();
    for (int row = 0; row < table.GetLength(0); row++)
    {
        for (int col = 0; col < table.GetLength(1); col++)
        {
            table[row, col] = r.Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] table)
{
    for (int row = 0; row < table.GetLength(0); row++)
    {
        for (int col = 0; col < table.GetLength(1); col++)
        {
            Console.Write($"{table[row, col]}  ");
        }
        Console.WriteLine();
    }
}

void PrintAverageOfColumns(int[,] table)
{
    double average = 0;
    for (int col = 0; col < table.GetLength(1); col++)
    {
        for (int row = 0; row < table.GetLength(0); row++)
        {
            average += table[row, col];
        }
        average = Math.Round(average / table.GetLength(0), 2);
        Console.Write($"{average}  ");
        average = 0;
    }
}