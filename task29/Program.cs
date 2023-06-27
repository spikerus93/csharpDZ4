// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.

int[] GetRandomArray()
{    int[] Array = new int[8];
    for(int i=0; i<Array.Length;i++)
    {
        Array[i] = Random.Shared.Next(-999, 1000);
    }
    return Array;
}

int[] MyArray = GetRandomArray();
Console.WriteLine($"[{String.Join(", " , MyArray)}]");