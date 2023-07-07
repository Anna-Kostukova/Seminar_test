// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int NewRandom(){
    int number = new Random().Next(100, 1000);
    return number;
}
int RemoveSecondDigit(int random)
    {
        int firstDigit = random / 100;     
        int thirdDigit = random % 10;       

        int mNumber = firstDigit * 10 + thirdDigit;    
        return mNumber;
    }
int random = NewRandom();
Console.WriteLine($"число: {random}");
int mNumber = RemoveSecondDigit(random);
Console.WriteLine($"Новое число: {mNumber}");
