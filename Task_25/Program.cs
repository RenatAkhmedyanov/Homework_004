Console.WriteLine("Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

double GetDegree(int A, int B)
{
    double result = Math.Pow(A, B);
    return result;
}

Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
if (B < 0)
{
    Console.WriteLine("Некорректный ввод! Второе число должно быть натуральным!");
}
else
{
    Console.Write(A + "^" + B + " = " + GetDegree(A, B));
}
