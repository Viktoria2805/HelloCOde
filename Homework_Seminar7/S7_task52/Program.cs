// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");

double[,] numbers = new double[m, n];

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
        }
    }
}

FillArrayRandomNumbers(numbers);

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintArray(numbers);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");

void FindColumnArithmeticMmean(double[,] array)
{
    double sum;
    double columnArithmeticMmean;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        columnArithmeticMmean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        columnArithmeticMmean = sum / m;
        Console.Write(Math.Round(columnArithmeticMmean, 1) + " ");
    }

}

FindColumnArithmeticMmean(numbers);