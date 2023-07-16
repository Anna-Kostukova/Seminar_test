// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Promt(string message) // создаем метод для печати
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void GetSum(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;  // sum = sum + 1;
    }

    Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");
}
int A = Promt("Введите число ");
GetSum(A);

