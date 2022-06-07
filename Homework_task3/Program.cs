/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите число:");

string input = Console.ReadLine(); 
double number = Convert.ToInt32(input);

if (number % 2 == 0)
{
  Console.WriteLine("Введенное число " + number + " четное");
}

else 
{
 Console.WriteLine("Введенное число " + number + " нечетное");
}