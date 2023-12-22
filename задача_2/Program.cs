// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

int m = new Random().Next(0,4);
int n = new Random().Next(0,4);
Console.WriteLine($"Число m = {m}. Число n = {n}.");

int Ackerman(int M, int N)
{
    int Ack = 0;
    if (M == 0)
    {
        Ack = N + 1;
    }
    if (M > 0 && N == 0)
    {
        Ack = Ackerman(M-1, 1);
    }
    if (M > 0 && N > 0)
    {
        Ack = Ackerman(M-1, Ackerman(M, N-1));
    }
    return Ack;
}

Console.WriteLine(Ackerman(m, n));
