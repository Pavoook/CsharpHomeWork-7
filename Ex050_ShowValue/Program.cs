// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// (row, colum - входные данные)

double[,] matrix = new double[3, 4];
FillRandomMatrix(matrix, 0, 10);
Console.WriteLine("Дан двумерный массив случайных чисел:");
PrintMatrix(matrix);
ShowValue(matrix, AskAndGetNumber("Введите номер строки (нумерация с 0):"), AskAndGetNumber("Введите номер столбца (нумерация с 0):"));

void FillRandomMatrix(double[,] table, double min, double max)
{
    Random r = new Random();
    for (int row = 0; row < table.GetLength(0); row++)
    {
        for (int col = 0; col < table.GetLength(1); col++)
        {
            table[row, col] = Math.Round(r.NextDouble() * (max + - min) + min, 2);
        }
    }
}

void PrintMatrix(double[,] table)
{
    for (int row = 0; row < table.GetLength(0); row++)
    {
        for (int col = 0; col < table.GetLength(1); col++)
        {
            Console.Write($"{table[row, col]}   ");
        }
        Console.WriteLine();
    }
}

int AskAndGetNumber(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    while (number < 0)
    {
        Console.WriteLine("Неверное значение. Введите целое неотрицательное число:");
        number = int.Parse(Console.ReadLine());
    }
    return number;
}

void ShowValue(double[,] table, int row, int col)
{
    if (row < table.GetLength(0) && col < table.GetLength(1)) Console.WriteLine("Искомый элемент равен " + table[row, col]);
    else Console.WriteLine("Такого элемента в массиве нет.");
}