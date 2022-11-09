Console.WriteLine("Программа, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.");
Console.Write("Введите количество элементов в массиве: ");
int N = int.Parse(Console.ReadLine()!);

int[] GetArray(int N)
{
    int[] Array = new int[N];
    for (int i = 0; i < N; i++)
    {
        Array[i] = int.Parse(Console.ReadLine()!);
    }
    return Array;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}
Console.Write("Введите элементы массива: ");
int[] Array = GetArray(N);
Console.Write("Полученный массив: ");
PrintArray(Array);