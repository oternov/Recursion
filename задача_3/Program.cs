// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int[] array = new int[6];

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
        Console.Write(array[i] + " ");
    }
}

void ReverseArray(int[] arr, int count)
{
    if (count == arr.Length)
    {
        return;
    }
    Console.Write(arr[arr.Length - 1 - count] + " ");
    ReverseArray(arr, count + 1);
}

PrintArray();
Console.WriteLine();
ReverseArray(array, 0);