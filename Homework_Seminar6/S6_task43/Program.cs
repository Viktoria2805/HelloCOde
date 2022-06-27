// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.Clear();

double b1 = Input("Введите b1: ");
double k1 = Input("Введите k1: ");
double b2 = Input("Введите b2: ");
double k2 = Input("Введите k2: ");

double Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

double x = (b2 - b1) / (k1-k2);
double y = k2 * x + b2;

Console.WriteLine($"x=: {x}");
Console.WriteLine($"y=: {y}");