// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

int number = Input("Введите число: ");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

if (number > 99)
{
    int thirdNum = 0;
    while (number > 99)
    {
        thirdNum = number % 10;
        number = number / 10;
    }
    Console.WriteLine(thirdNum);
}
else Console.WriteLine("Третьей цифры в числе нет");

