// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] numbers = new int[m, n];

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

FillArrayRandomNumbers(numbers);

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

Console.Write("Введите позицию элемента: ");
string input = Console.ReadLine();

int positionI = Convert.ToInt32(input[0]) - '0';
int positionJ = Convert.ToInt32(input[1]) - '0';

PrintArray(numbers);
Console.WriteLine();
Console.Write(positionI);
Console.Write(positionJ + " -> ");

void FindValueArray(int[,] array)
{
    if (positionI >= 0  && positionI < m && positionJ >=0 && positionJ < n)
    {
        Console.Write(numbers[positionI,positionJ]);
    }
    else  Console.Write("Такой позиции в массиве нет");

}

FindValueArray(numbers);