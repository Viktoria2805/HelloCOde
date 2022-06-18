// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] number = new int[8];

void SetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(1,100);
    }
}

void OutputArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }      
}

SetArray(number);
OutputArray(number);
