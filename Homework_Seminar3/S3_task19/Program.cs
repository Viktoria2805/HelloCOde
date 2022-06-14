// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();

int number = Input("Введите число: ");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

if ((number > 9999) && (number < 100000))
{
    int firstNum = number / 10000;
    int lastNum = number % 10;
    int secNum = (number / 1000) % 10;
    int preLastnum = (number % 100) / 10;
    if ((firstNum == lastNum) && (secNum == preLastnum))
    Console.WriteLine("Да - палиндром");
    else  Console.WriteLine("Нет - не палиндром");
}
else Console.WriteLine("Ошибка! Введено не пятизначное число");

