// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int N = Input("Введите натурльаное число: ");

int count = 0;
int result = 0;

while (count < N)
{
    result = Cube(count);
    count = count + 1;
    Console.Write($"{result}, ");
}

Console.WriteLine(Cube(N));

int Cube(int a)
{
    return a * a * a;
}

int Input (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}