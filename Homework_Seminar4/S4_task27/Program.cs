// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int number = Input("Введите число: ");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int i = 0;
int ostatok = 1;
int sum = 0;

while (number != 0)
{
    ostatok = number % 10;
    number = number / 10;
    i++;
    sum = sum + ostatok;
}

Console.Write(sum);
