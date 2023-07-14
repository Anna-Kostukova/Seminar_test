// Задача 30: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int Promt(string message) // создаем метод для печати
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] Fill(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 2);
    }
    return a;
}
void PrintMass(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]} ");
    }
}

int N = Promt("Введите длину массива: ");
int[] array = new int[N];

for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
PrintMass(Fill(array));