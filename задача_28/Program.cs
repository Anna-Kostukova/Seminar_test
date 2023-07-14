// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Promt(string message) // создаем метод для печати
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
void Factorial(int b)
{
    int a = 1;
    for (int i = 1; i <= b; i++)
        a = a * i;
    Console.WriteLine($"Произведение чисел от 1 до {b} = {a}");
}
int number = Promt("Введите число: ");
Factorial(number);