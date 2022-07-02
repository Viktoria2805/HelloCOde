// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] numbers = new int[m, n];

FillArrayRandomNumbers(numbers);

PrintArray(numbers);
Console.WriteLine();

FindRowWithMinSumElements(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
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

void FindRowWithMinSumElements(int[,] array)
{
    int[] tempArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            tempArray[i] += array[i,j];
        }
    }

    int min = tempArray[0];
    int minI = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] < min)
        {
            min = tempArray[i];
            minI = i;
        }
         Console.WriteLine($"Сумма элементов {i} строки = {tempArray[i]}");
    }
    Console.WriteLine();
    Console.Write($"Минимальная сумма элементов = {min} ");
    Console.Write($" и расположена на {minI} строке");

}
