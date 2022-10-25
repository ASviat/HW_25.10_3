// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки 1, на оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 1, на оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 1, на оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки 2, на оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2, на оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2, на оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());




double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double n1 = Math.Pow(x2 - x1, 2);
    double n2 = Math.Pow(y2 - y1, 2);
    double n3 = Math.Pow(z2 - z1, 2);
    double sum = Math.Sqrt(n1 + n2 + n3);
    return Math.Round(sum, 2, MidpointRounding.ToZero);
}

Console.WriteLine(Distance(x1, y1, z1, x2, y2, z2));