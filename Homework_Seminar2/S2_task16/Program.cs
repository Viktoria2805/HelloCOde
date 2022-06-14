// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();

int number1 = Input("Введите первое число: ");
int number2 = Input("Введите второе число: ");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int square (int a)
{
    return a*a;
}

if ((number1 == square(number2)) || (number2 == square(number1)))
{
    Console.WriteLine("Да");
}
else  Console.WriteLine("Нет");