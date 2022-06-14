// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

int number = Input("Введите число: ");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

bool checkHoliday(int a)
{
    if ((a == 6) || (a == 7))
    {
        return true;
    }
    else if ((a == 1) || (a == 2) || (a == 3) || (a == 4) || (a == 5))
            {
                Console.WriteLine("Нет");
                return false;
            }         
        else 
            { 
                Console.WriteLine("Вы ввели число,не обозначающее день недели");
                return false;
            }
}

if (checkHoliday(number) == true)
{
    Console.WriteLine("Да");
}

