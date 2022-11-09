Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");

Console.Write("Введите число: ");
int input = int.Parse(Console.ReadLine()!);

int GetSumOfDigits(int input)
{
    int result = 0;
    while (input > 0)
    {
        result += input % 10;
        input /= 10;
    }
    return result;
}

if (input >= 0)
{
    GetSumOfDigits(input);

} else {
    input *= -1;
    GetSumOfDigits(input);
    
}
Console.Write("Сумма цифр введенного числа = " + GetSumOfDigits(input));