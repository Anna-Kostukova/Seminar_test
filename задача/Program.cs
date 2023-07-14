// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Promt(string message) // создаем метод для печати
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Razryd(int a)
{
    int count = 0;
    for (; a > 0; count++) // инициализация переменной
    {
        a = a / 10;
    }
    return count;
}
int num = Promt("Введите число: ");
Console.WriteLine($"Количество цифр в числе = {Razryd(num)}");
