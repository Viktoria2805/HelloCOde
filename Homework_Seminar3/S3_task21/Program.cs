// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int x1 = Input("Введите координату X1: ");
int y1 = Input("Введите координату Y1: ");
int z1 = Input("Введите координату Z1: ");
int x2 = Input("Введите координату X2: ");
int y2 = Input("Введите координату Y2: ");
int z2 = Input("Введите координату Z2: ");

int distanceX = CalculateDistance(x1, x2);
int distanceY = CalculateDistance(y1, y2);
int distanceZ = CalculateDistance(z1, z2);

double distance = Math.Sqrt(Quadro(distanceX) + Quadro(distanceY) + Quadro(distanceZ));

Console.WriteLine("Расстояние между точками в 3D пространстве " + distance);

int Quadro(int a)
{
    return a * a;
}

int CalculateDistance(int a, int b)
{
    return a - b;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
