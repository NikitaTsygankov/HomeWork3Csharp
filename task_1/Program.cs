//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
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


