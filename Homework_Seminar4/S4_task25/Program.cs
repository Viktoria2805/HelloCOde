// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int numberA = Input("Введите число A: ");
int numberB = Input("Введите число B: ");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

if (numberB > 0)
{
    int degree = 1;
    for (int i = 1; i <= numberB; i++)
    {
        degree = degree*numberA;
    }
Console.Write(degree);
}
else Console.Write("Вы ввели не натуральное число B ");

