// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m1 = Input("Введите m1: ");
int n1 = Input("Введите n1: ");

int[,] numbers1 = new int[m1, n1];

int m2 = Input("Введите m2: ");
int n2 = Input("Введите n2: ");

int[,] numbers2 = new int[m2, n2];

FillArrayRandomNumbers(numbers2);
FillArrayRandomNumbers(numbers1);

PrintArray(numbers1);
Console.WriteLine();

PrintArray(numbers2);
Console.WriteLine();

MatrixMmultiplication(numbers1,numbers2);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

void MatrixMmultiplication(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        int[,] matrixMmultiplication = new int [array1.GetLength(0),array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            for(int k = 0; k < array2.GetLength(0); k++)
            {
               matrixMmultiplication[i,j] += array1[i,k] * array2[k,j];
            }
            Console.Write(matrixMmultiplication[i, j] + " ");
        }
        Console.WriteLine();
        }
    }    
    else Console.WriteLine("Ошибка! Число столбцов первой матрицы должно быть равно числу строк второй матрицы");
}

