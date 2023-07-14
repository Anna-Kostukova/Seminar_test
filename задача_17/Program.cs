﻿// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Promt(string message) // создаем метод для работы с пользователем, даст нам какое-то число
{
    Console.Write(message); // печатаем сообщение
    int num = int.Parse(Console.ReadLine()); // создаем новую переменную,
                                             // конвертируем в число и записываем в переменную num 
    return num; // возвращаем и сначала записываем X, потом Y
}

int x = Promt("Введите точку X: "); // работа с пользователем, вызываем метод Promt
int y = Promt("Введите точку Y: ");
GetResult(x, y);

void GetResult(int X, int Y) // метод невозвращаемого метода
{
    if (X > 0 && Y > 0)
    {
        Console.WriteLine("I четверть");
    }
    if (X < 0 && Y > 0)
    {
        Console.WriteLine("II четверть");
    }
    if (X < 0 && Y < 0)
    {
        Console.WriteLine("III четверть");
    }
    if (X > 0 && Y < 0)
    {
        Console.WriteLine("IV четверть");
    }
}