// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int a = Prompt("Введите первое число: ");
int b = Prompt("Введите второе число: ");
int c = Prompt("Введите третее число: ");
Triangle(a, b, c);

void Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        Console.Write("Треугольник существует");
    }
    else
    {
        Console.Write("Треугольник не существует");
    }
}
