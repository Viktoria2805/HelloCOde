// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

int number = Input("Введите трехзначное число: ");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

if ((number > 99) && (number < 1000))
{
    int lastNum = number % 100;
    int SecNum = lastNum / 10;
    Console.WriteLine(SecNum);
}
else Console.WriteLine("Ошибка! Введено не трехзначное числол");


