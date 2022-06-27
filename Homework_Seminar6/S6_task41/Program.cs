// Задача 41: Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите элементы(через зяпятую): ");
string input = Console.ReadLine();

int countAll = 1;
int countNegative = 0;
int countPositive = 0;
int i = 0;
int length = input.Length;

if (input[0] == 44)
{
    i++;
}

if (input[length - 1] == 44)
{
    length--;
}

for (; i < length; i++)
{
    char item = input[i];
    if (item == 44) // ,
    {
        countAll++;
        continue;
    }

    if (item == 45) // -
    {
        countNegative++;
        continue;
    }

    if (item == 48) // 0
    {
        countNegative++;
    }
}

countPositive = countAll - countNegative;
Console.Write($"Кол-во элементов > 0: {countPositive}");


