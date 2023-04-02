//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.

Number(Read());

int Read()
{
    Console.WriteLine("Введите число:");
    int N = int.Parse(Console.ReadLine());
    return N;
}

void Number(int N)
{
    int n = 1;
    while (n <= N)
    {
        double d = Math.Pow(n, 3);
        Console.Write(d+" ");
        n++;
    }
}


