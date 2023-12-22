// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

int M = 5;
int N = 10;

void NaturalNumber(int FirstNumber, int SecondNumber)
{
    Console.WriteLine(FirstNumber);
    if (FirstNumber == SecondNumber)
    {
        return;
    }
    NaturalNumber(FirstNumber+1, SecondNumber);
}

NaturalNumber(M, N);