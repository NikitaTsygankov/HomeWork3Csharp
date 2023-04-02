// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

int Read(string argument)
{
    int number;
    System.Console.WriteLine($"Введите{argument}:");
    while((!int.TryParse(Console.ReadLine(), out number)))
    {
        System.Console.WriteLine("Это не число");
    }
    return number;
}

double length()
{
    int x1 = Read(" x1");
    int y1 = Read(" y1");
    int x2 = Read(" x2");
    int y2 = Read(" y2");
    int x3 = Read(" x3");
    int y3 = Read(" y3");
    double length = Math.Sqrt(Math.Pow(x1-x2-x3, 2) + Math.Pow(y1-y2-y3, 2));
    return length;
}

void Answer()
{
    double l = length();
    System.Console.WriteLine($"Segment length = {l}");
}
Answer();