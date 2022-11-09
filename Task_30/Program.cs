Console.WriteLine("Программа, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. Далее считает количество нулей и единиц, если единиц больше чем нулей то выводит TRUE на экран, иначе выводит False.");

Console.Write("Введите количество элементов в массиве: ");
int N = int.Parse(Console.ReadLine()!);

int[] GetArray(int N)
{
    int[] Array = new int[N];
    Random random = new Random();
    for (int i = 0; i < N; i++)
    {
        Array[i] = random.Next(0, 2);
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
int[] Array = GetArray(N);
Console.Write("Полученный массив: ");
PrintArray(Array);
Console.WriteLine();

int countZero = 0;
int countOne = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] == 0)
    {
        countZero++;
    }
    else
    {
        countOne++;
    }
}
Console.WriteLine(countOne > countZero);