// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// var m = int.Parse(Console.ReadLine());
//             Console.WriteLine(string.Format("Число в 10-й системе = {0} ", m));
 
//             string tmp = "";
//             while (m>0)
//             {
//                 tmp += m & 1;
//                 m /= 2;
//             }
 
//             for (int i = tmp.Length - 1; i >= 0; i--)
//             {
//                 Console.Write(tmp[i]);
//             }
 
//             Console.WriteLine();

 int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num1 = Prompt("Введите десятичное число: ");

string collect = "";
int result = num1;

while (result > 0)
{
    
    collect = result % 2 + collect;

    result = result / 2;
}


Console.WriteLine(collect);
