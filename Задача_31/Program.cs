﻿// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int sizeArray = GetNum("Введите длину массива: "); // создаем длину (размер)
int min = GetNum("Введите минимальное значение диапазона для элементов массива: ");  // создаем мин значение
int max = GetNum("Введите максимальное значение диапазона для элементов массива: ");// создаем макс значение

int[] array = GetArray(sizeArray, min, max); // новый массив array который вызывает GetArray

PrintArray(array);     // выводит на печать массив
int[] resSum = GetSum(array);
Console.WriteLine($"\nсумма положительных чисел = {resSum[0]} \nсумма отрицательных чисел = {resSum[1]}");
                    // \n - перенос на новую строку

int GetNum(string message) // метод работы с пользователем (на получение какого-то числа), 
{
    Console.Write(message);                   // сообщение выводим на консоль
    int num = int.Parse(Console.ReadLine()); // создаем число, запрашиваем у пользователя
    return num;                             // возвращаем наше число
}

int[] GetArray(int size, int minValue, int maxValue) // будет массив GetArray определенного размера
                                                    // с заданным диапазоном
{
    int[] result = new int[size];   // место хранения result 
    for (int i = 0; i < size; i++) // пока i меньше size
    {
        result[i] = new Random().Next(minValue, maxValue); // заполняем массив рандомными значениями
    }
    return result;                                        // так как метод возвращаемый
}

void PrintArray(int[] arr) // создаем метод печати PrintArray, который получит какой-то массив arr
{
    for (int i = 0; i < arr.Length; i++) //  мы возьмем его длинну
    {
        Console.Write($"{arr[i]} ");    // и все элементы распечатаем
    }
}

int[] GetSum(int[] arr)
{
    int positiveSum = 0;  // одна переменная складывает положительные значения
    int negativeSum = 0; // вторая переменная складывает все отрицательные значения
    int[] res = new int[2];
    foreach (int el in arr) // цикл foreach записывает все элементы в el пока все элементы будут 
                            //идти по очереди по всему массиву - мы находимся в цикле 
    {
        if (el > 0) res[0] += el;
        if (el < 0) res[1] += el;
    }
    return res;
}
