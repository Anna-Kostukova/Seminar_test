// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

int Promt(string message) // создаем метод для печати
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Find(int a)
{
    if (a < 1 || a > 4)
        Console.Write("Неверный формат данных");
    if (a == 1)
        Console.Write("X = (0; +n), Y = (0; +n)");
    if (a == 2)
        Console.Write("X = (0; -n), Y = (0; +n)");
    if (a == 3)
        Console.Write("X = (0; -n), Y = (0; -n)");
    if (a == 4)
        Console.Write("X = (0; +n), Y = (0; -n)");
}

int quarter = Promt("Введите номер четверти: ");
Find(quarter);