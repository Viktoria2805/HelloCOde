// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("Введите m: ");
int n = Input("Введите n: ");

double[,] numbers = new double[m, n];

void FillArrayRealRandomNumbers(double[,] array)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Convert.ToDouble(new Random().Next(-10,100)) / new Random().Next(1, 10);;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j],1) + " ");
        }
        Console.WriteLine();
    }
}

FillArrayRealRandomNumbers(numbers);
PrintArray(numbers);