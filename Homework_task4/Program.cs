/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Clear();

Console.Write("Введите натуральное число:");

string input = Console.ReadLine(); 
int number = Convert.ToInt32(input);

int i = 1;

if (number > 0)
{
while (i <= number)
{
    if ( i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;

}
}
else Console.WriteLine("ОШИБКА! Введено не натуральное число");