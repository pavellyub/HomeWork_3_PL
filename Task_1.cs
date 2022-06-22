// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int n = Input("Введите пятизначное число: ");

if (n < -100000 || n > 100000)
{
    Console.WriteLine("Ошибка. Введено не пятизначное число.");
}

int copy_n = n;
int result = 0;

while (n != 0)
{
    int digit = n%10;
    result = result * 10 + digit;
    n = n/10;
}

if (copy_n == result)
{
    Console.WriteLine("Это палиндром!");
}
else
{
    Console.WriteLine("Это не палиндром!");
}

int Input (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
