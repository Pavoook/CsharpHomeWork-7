// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// (Округление до 2х знаков после запятой - Math.Round(value, 2))

int m = GetSize("Задайте количество строк в массиве:");
int n = GetSize("Задайте количество столбцов в массиве:");
double[,] matrix = new double[m, n];
double maximum = GetBound("Задайте максимальное значение элемента массива:");
double minimum = GetBound("Задайте минимальное значение элемента массива:");
if (ValidateBounds(maximum, minimum)) FillRandomMatrix(matrix, minimum, maximum);
PrintMatrix(matrix);

int GetSize(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    while (number <= 0)
    {
        Console.WriteLine("Неверное значение. Введите целое число больше нуля:");
        number = int.Parse(Console.ReadLine());
    }
    return number;
}

double GetBound(string msg)
{
    Console.WriteLine(msg);
    string value = Console.ReadLine();
    while (double.TryParse(value, out double num) == false)
    {
        Console.WriteLine("Ошибка! Введите вещественное число (для отделения дробной части используйте запятую):");
        value = Console.ReadLine();
    }
    double number = double.Parse(value);
    return number;
}

bool ValidateBounds(double max, double min)
{
    bool valid = false;
    while (valid == false)
    {
        if (max < min)
        {
            Console.WriteLine("Ошибка. Минимум не должен быть больше максимума.");
            maximum = GetBound("Задайте максимальное значение элемента массива:");
            max = maximum;
            minimum = GetBound("Задайте минимальное значение элемента массива:");
            min = minimum;
        }
        else valid = true;
    }
    return valid;
}

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