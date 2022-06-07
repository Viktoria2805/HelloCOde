/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Clear();

Console.Write("Введите первое число:");

string input1 = Console.ReadLine(); 
int number1 = Convert.ToInt32(input1);

Console.Write("Введите второе число:");

string input2 = Console.ReadLine(); 
int number2 = Convert.ToInt32(input2);

Console.Write("Введите третье число:");

string input3 = Console.ReadLine(); 
int number3 = Convert.ToInt32(input3);

int max = number1;

if (number2 >= max)
{
    max = number2;
}
if (number3 >= max)
{
    max = number3;
}

Console.WriteLine("Максимальное число: " + max);
