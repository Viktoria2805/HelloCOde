// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
int number = Input("Введите число: ");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int i = 1;

while (i <= number)
{
    if (i<number) Console.Write(i*i*i + ", ");
    else Console.Write(i*i*i);
    i++;
}
