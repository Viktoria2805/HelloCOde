// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int x = Input("Введите х ");
int y = Input("Введите y: ");
int z = Input("Введите z: ");

int[,,] numbers = new int[x, y, z];

if (x*y*z > 99) { 
    Console.WriteLine("Ошибка! Нет столько неповторяющихся двузначных чисел");   
} else {
    FillArrayRandomNumbers(numbers);
}

void FillArrayRandomNumbers(int[,,] array)
{
    int temp = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] = temp++;
                Console.Write($"{array[i, j, z]} [{i},{j},{z}] ");
            }
        }
        Console.WriteLine("");
    }
}
