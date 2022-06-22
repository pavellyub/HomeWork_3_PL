// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int xa = Input("Введите координату Х точки А: ");
int ya = Input("Введите координату Y точки А: ");
int za = Input("Введите координату Z точки А: ");
int xb = Input("Введите координату X точки B: ");
int yb = Input("Введите координату Y точки B: ");
int zb = Input("Введите координату Z точки B: ");

int lenghtX = (xa - xb);
int lenghtY = (ya - yb);
int lenghtZ = (za - zb);

double result = (Quadro(lenghtX) + Quadro(lenghtY) + Quadro(lenghtZ));
double Cube = Math.Sqrt(result);
Console.WriteLine($"Расстояние между точками составляет: {Cube}");

int Quadro (int a)
{
    return a * a;
}

int Input (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}