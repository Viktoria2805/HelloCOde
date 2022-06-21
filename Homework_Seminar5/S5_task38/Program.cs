//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int size = Input("Введите размер массива: ");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[size];

FillArrayNumbers(array);

void FillArrayNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Input($"Введите элменент массива {i}: ");
    }
}

int DiffMaxMin(int[] array)
{
    int min = array[0];
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return max-min;
}

Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {DiffMaxMin(array)}");