// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int arrSize = GetNum("Задайте длину массива: ");
int arrMin = GetNum("Введите минимальное значение массива: ");
int arrMax = GetNum("Введите максимальное значение массива: ");

int[] arr = GetArray(arrSize, arrMin, arrMax);
PrintArray(arr);
NegativeArray(arr);

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void NegativeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    Console.Write("Искомый массив: ");
    PrintArray(array);
}

