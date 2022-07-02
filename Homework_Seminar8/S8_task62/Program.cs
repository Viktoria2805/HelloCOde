// Задача 62: Заполните спирально массив 4 на 4.

int n = Input("Введите n: ");

int[,] numbers = new int[n,n];

// 1[0,0]   2[0,1]   3[0,2]   4[0,3]
// 12[1,0]  13[1,1]  14[1,2]  5[1,3]
// 11[2,0]  16[2,1]  15[2,2]  6[2,3]
// 10[3,0]  9[3,1]   8[3,2]   7[3,3]

int counter = 1;
int i = 0;
int j = 0;
int maxCounter = numbers.GetLength(0) * numbers.GetLength(1) + 1;

while (true) {
    if (MoveRight(numbers)) break;
    if (MoveBottom(numbers)) break;
    if (MoveLeft(numbers)) break;
    if (MoveTop(numbers)) break;
}

for (int k = 0; k < numbers.GetLength(0); k++)
{
    for (int m = 0; m < numbers.GetLength(1); m++)
    {
        Console.Write(numbers[k,m] + " ");
    }
    Console.WriteLine("");
}

bool MoveRight(int[,] numbers)
{
    if (j + 1 == numbers.GetLength(0)) {
        i++;
        return false;
    }
    if (numbers[i,j] != 0) {
        i++;
        return false;
    }
    while (j < numbers.GetLength(0) && numbers[i,j] == 0) {
        numbers[i,j] = counter++;
        j++;
    }
    i++;
    j--;
    return counter == maxCounter;
}

bool MoveLeft(int[,] numbers)
{
    if (numbers[i,j] != 0) {
        i--;
        return false;
    }
    while (j >= 0 && numbers[i,j] == 0) {
        numbers[i,j] = counter++;
        j--;
    }
    i--;
    j++;
    return counter == maxCounter;
}

bool MoveTop(int[,] numbers)
{
    if (numbers[i,j] != 0) {
        j--;
        return false;
    }
    while (i >= 0 && numbers[i,j] == 0) {
        numbers[i,j] = counter++;
        i--;
    }
    i++;
    j++;
    return counter == maxCounter;
}

bool MoveBottom(int[,] numbers)
{
    if (i == 0) {
        j--;
        return false;
    }
    if (numbers[i,j] != 0) {
        j--;
        return false;
    }
    while (i < numbers.GetLength(0) && numbers[i,j] == 0) {
        numbers[i,j] = counter++;
        i++;
    }
    i--;
    j--;
    return counter == maxCounter;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}