// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int[] array = new int[6];

void PrintArray(int[] arr, int count)
{
    if (count == arr.Length)
    {
        return;
    }
    array[count] = new Random().Next(1,10);
    Console.Write(arr[count] + " ");
    PrintArray(arr, count + 1);
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

PrintArray(array, 0);
Console.WriteLine();
ReverseArray(array, 0);