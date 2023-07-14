// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int Promt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double Distance(int a, int b, int c, int d)
{
    double dist = Math.Sqrt((a - c) * (a - c) + (b - d) * (b - d));
    return dist;
}

int x1 = Promt("ВВедите x координату точки А : ");
int y1 = Promt("ВВедите y координату точки А : ");
int x2 = Promt("ВВедите x координату точки B : ");
int y2 = Promt("ВВедите y координату точки B : ");


Console.WriteLine("Расстояние между точками А и В " + Distance(x1, y1, x2, y2));
